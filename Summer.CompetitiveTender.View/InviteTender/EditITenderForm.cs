﻿using log4net;
using MetroFramework;
using MetroFramework.Forms;
using Summer.Common.Utility;
using Summer.CompetitiveTender.Model;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTemplate;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTemplateNode;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTenderProject;
using Summer.CompetitiveTender.Service.ServiceReferenceLogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace Summer.CompetitiveTender.View.InviteTender
{
    public partial class EditITenderForm : FormBase
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(EditITenderForm));

        /// <summary>
        /// bidEvalTemplatePage
        /// </summary>
        private BidEvalTemplatePage bidEvalTemplatePage = new BidEvalTemplatePage();

        /// <summary>
        /// gpTemplateNodeService
        /// </summary>
        private IGpTemplateNodeService gpTemplateNodeService = new GpTemplateNodeService();

        /// <summary>
        /// gpTenderFileService
        /// </summary>
        private IGpTenderFileService gpTenderFileService = new GpTenderFileService();

        /// <summary>
        /// gpEvalwayItemGtfService
        /// </summary>
        private IGpEvalwayItemGtfService gpEvalwayItemGtfService = new GpEvalwayItemGtfService();

        /// <summary>
        /// IGpTenderEvalEleService
        /// </summary>
        private IGpTenderEvalEleService gpTenderEvalEleService = new GpTenderEvalEleService();

        /// <summary>
        /// IGpBidFileOrgService
        /// </summary>
        private IGpBidFileOrgService gpBidFileOrgService = new GpBidFileOrgService();

        /// <summary>
        /// gptp
        /// </summary>
        private gpTenderProjectWebDO gptp;

        #endregion

        #region 事件

        private void EditITenderForm_Shown(object sender, EventArgs e)
        {
            this.trvMenu.SelectedNode = this.trvMenu.Nodes[0];
        }

        private void trvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.pnelFrame.Controls.Clear();

            switch (e.Node.Text)
            {
                case "招标模板":
                    bidEvalTemplatePage.Dock = DockStyle.Fill;
                    this.pnelFrame.Controls.Add(bidEvalTemplatePage);
                    break;
                case "评标条款":
                    BidEvalClausePage bidEvalClausePage = new BidEvalClausePage(this.gpEvalwayItemGtfService, this.gptp.gtpId, this.gptp.gpId);
                    bidEvalClausePage.Dock = DockStyle.Fill;
                    this.pnelFrame.Controls.Add(bidEvalClausePage);
                    break;
                case "评 分 点":
                    BidEvalScoringPointPage bidEvalScoringPointPage = new BidEvalScoringPointPage(this.gpTenderEvalEleService, this.gptp.gtpId, this.gptp.gpId);
                    bidEvalScoringPointPage.Dock = DockStyle.Fill;
                    this.pnelFrame.Controls.Add(bidEvalScoringPointPage);
                    break;
                case "评分因素":
                    BidEvalFactorPage bidEvalFactorPage = new BidEvalFactorPage(this.gpBidFileOrgService, this.gptp.gtpId, this.gptp.gpId);
                    bidEvalFactorPage.Dock = DockStyle.Fill;
                    this.pnelFrame.Controls.Add(bidEvalFactorPage);
                    break;
                case "生成招标文件":
                    if (MetroMessageBox.Show(this, "确定要生成招标文件吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.GenerateBidDocument();
                    }
                    break;
                case "上传招标文件":
                    this.UploadBidFile();
                    break;
                case "打印招标文件":
                    this.PrintBidFile();
                    break;
                case "下载招标文件":
                    this.DownloadBidFile();
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region 方法

        public EditITenderForm(gpTenderProjectWebDO gptp)
        {
            InitializeComponent();
            this.gptp = gptp;
        }

        private void GenerateBidDocument()
        {
            try
            {
                List<string> paths = new List<string>();

                GenerateDocument gd = new GenerateDocument();

                //模板文件
                string pathBid = gd.GenerateBidDocument(this.gptp, this.bidEvalTemplatePage.GetTemplate());
                string pathBidPdf = Office.WordToPdf(pathBid);
                File.Delete(pathBid);
                paths.Add(pathBidPdf);

                //评标条款
                string pathBidEvalClause = gd.GenerateBidEvalClauseDocument(this.gptp);
                string pathBidEvalClausePdf = Office.WordToPdf(pathBidEvalClause);
                File.Delete(pathBidEvalClause);
                paths.Add(pathBidEvalClausePdf);

                //评分点
                string pathBidEvalScoringPoint = gd.GenerateBidEvalScoringPointDocument(this.gptp);
                string pathBidEvalScoringPointPdf = Office.WordToPdf(pathBidEvalScoringPoint);
                File.Delete(pathBidEvalScoringPoint);
                paths.Add(pathBidEvalScoringPointPdf);

                //评分因素
                //string pathBidEvalFactor = gd.GenerateBidEvalFactorDocument(this.gptp);
                //string pathBidEvalFactorPdf = Office.WordToPdf(pathBidEvalFactor);
                //File.Delete(pathBidEvalFactor);
                //paths.Add(pathBidEvalFactorPdf);

                //问题澄清
                string pathBidQuestion = gd.GenerateBidQuestionDocument(this.gptp);

                if (!string.IsNullOrWhiteSpace(pathBidQuestion))
                {
                    string pathBidQuestionPdf = Office.WordToPdf(pathBidQuestion);
                    File.Delete(pathBidQuestion);
                    paths.Add(pathBidQuestionPdf);
                }

                GenerateBidFile generateBidFile = new GenerateBidFile(paths.ToArray());
                generateBidFile.Dock = DockStyle.Fill;
                this.pnelFrame.Controls.Add(generateBidFile);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "生成失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UploadBidFile()
        {
            try
            {
                string sourcePath = AppDirectory.Temp_Dir(this.gptp.gpId);
                string destPath = Path.Combine(AppDirectory.Temp(), this.gptp.gpId + ".zip");

                Compress.CreateZipFile(sourcePath, destPath);

                baseUserWebDO loginResponse = Cache.GetInstance().GetValue<baseUserWebDO>("login");
                bool result = gpTenderFileService.UploadFile(destPath, loginResponse.auID, this.gptp.gtpId, this.gptp.gpId);

                if (result)
                {
                    MetroMessageBox.Show(this, "上传成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "上传失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "上传失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DownloadBidFile()
        {
            try
            {
                FolderBrowserDialog fbdl = new FolderBrowserDialog();
                if (fbdl.ShowDialog() == DialogResult.OK)
                {
                    baseUserWebDO loginResponse = Cache.GetInstance().GetValue<baseUserWebDO>("login");
                    bool result = gpTenderFileService.DownloadFile(fbdl.SelectedPath, this.gptp.gtpId, this.gptp.gpId, loginResponse.auID);

                    if (result)
                    {
                        MetroMessageBox.Show(this, "下载成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "下载失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "下载失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintBidFile()
        {
            try
            {
                string path = Path.Combine(AppDirectory.Temp_Dir(gptp.gpId), "招标文件.docx");

                MetroMessageBox.Show(this, "疯狂开发中......", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "打印失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
