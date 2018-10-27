using log4net;
using MetroFramework;
using MetroFramework.Forms;
using Summer.Common.Utility;
using Summer.CompetitiveTender.Model;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTemplate;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTemplateNode;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTenderProject;
using Summer.CompetitiveTender.Service.ServiceReferenceLogin;
using Summer.CompetitiveTender.View.BidEvaluaMethod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xceed.Words.NET;
using System.Runtime;
using Ionic.Zip;

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
                    try
                    {
                        List<string> paths = new List<string>();

                        GenerateDocument gd = new GenerateDocument();

                        //模板文件
                        string pathBid = gd.GenerateBidDocument(this.gptp, this.bidEvalTemplatePage.GetTemplate());
                        paths.Add(pathBid);

                        //评标条款
                        string pathBidEvalClause = gd.GenerateBidEvalClauseDocument(this.gptp);
                        paths.Add(pathBidEvalClause);

                        //评分点
                        string pathBidEvalScoringPoint = gd.GenerateBidEvalScoringPointDocument(this.gptp);
                        paths.Add(pathBidEvalScoringPoint);

                        //评分因素
                        string pathBidEvalFactor = gd.GenerateBidEvalFactorDocument(this.gptp);
                        paths.Add(pathBidEvalFactor);

                        //问题澄清
                        //string pathBidQuestion = gd.GenerateBidQuestionDocument(this.gptp);

                        //if (!string.IsNullOrWhiteSpace(pathBidQuestion))
                        //{
                        //    paths.Add(pathBidQuestion);
                        //}

                        GenerateBidFile generateBidFile = new GenerateBidFile(paths.ToArray());
                        generateBidFile.Dock = DockStyle.Fill;
                        this.pnelFrame.Controls.Add(generateBidFile);
                    }
                    catch (Exception ex)
                    {
                        log.Error(ex);
                        MetroMessageBox.Show(this, "生成失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "上传招标文件":
                    try
                    {
                        string srcPath = AppDirectory.Temp_Dir(this.gptp.gpId);
                        string destPath = Path.Combine(AppDirectory.Temp(), this.gptp.gpId + ".zip");

                        using (ZipFile zip = new ZipFile(Encoding.UTF8))
                        {
                            zip.AddDirectory(srcPath); 
                            zip.Save(destPath);
                        }

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
                    break;
                case "打印招标文件":
                    MetroMessageBox.Show(this, "疯狂开发中...", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "下载":
                    try
                    {
                        FolderBrowserDialog fbdl = new FolderBrowserDialog();
                        if (fbdl.ShowDialog() == DialogResult.OK)
                        {
                            baseUserWebDO loginResponse = Cache.GetInstance().GetValue<baseUserWebDO>("login");
                            //bool result = gpTenderFileService.DownloadFile(fbdl.SelectedPath, this.gptp.gtpId, this.gptp.gpId, loginResponse.auID);
                            bool result = gpTenderFileService.DownloadFile(fbdl.SelectedPath, "1d485a24-0f17-41f9-8d48-e2601f667835", "2f345345-a8b0-4257-a4ca-302476b66193", loginResponse.auID);

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

        #endregion
    }
}
