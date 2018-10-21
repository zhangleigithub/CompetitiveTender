using log4net;
using MetroFramework;
using Summer.CompetitiveTender.Model;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.Service.ServiceReferenceBidEvaluation;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTenderProject;
using Summer.CompetitiveTender.Service.ServiceReferenceLogin;
using Summer.CompetitiveTender.View.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Summer.CompetitiveTender.View.EvaluationOfBids
{
    public partial class EOBManageForm : FormBase
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(EOBManageForm));

        /// <summary>
        /// gpTenderProjectService
        /// </summary>
        private IGpTenderProjectService gpTenderProjectService = new GpTenderProjectService();

        /// <summary>
        /// bidEvaluationService
        /// </summary>
        private IBidEvaluationService bidEvaluationService = new BidEvaluationService();

        /// <summary>
        /// gpBidQuestionsService
        /// </summary>
        private IGpBidQuestionsService gpBidQuestionsService = new GpBidQuestionsService();

        #endregion

        #region 事件

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadData();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "加载失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRecJudges_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.grdProject.CurrentRow != null)
                {
                    gpTenderProjectWebDO gptp = this.grdProject.CurrentRow.Tag as gpTenderProjectWebDO;

                    baseUserWebDO loginResponse = Cache.GetInstance().GetValue<baseUserWebDO>("login");
                    //////
                    Service.ServiceReferenceGpBidQuestions.gpBidQuestionsWebDO obj = new Service.ServiceReferenceGpBidQuestions.gpBidQuestionsWebDO();
                    obj.gtpId = gptp.gtpId;
                    obj.gsId = gptp.gsId;
                    obj.gbqEndTime = DateTime.Now;
                    obj.gbqEndTimeSpecified = true;
                    obj.gbqConTent = "测试";
                    obj.gbqAgainstCoName = "123";
                    obj.gbqProposerId = loginResponse.auID;
                    obj.gbqProposerName = loginResponse.auName;
                    obj.gbqProposedTime = DateTime.Now;
                    obj.gbqProposedTimeSpecified = true;
                    obj.isEnd = 0;
                    obj.isEndSpecified = true;
                    obj.evalState = gptp.evalState;
                    obj.evalStateSpecified = true;

                    bool b = gpBidQuestionsService.Add(obj);

                    Service.ServiceReferenceGpBidQuestions.gpBidQuestionsWebDO[] result = gpBidQuestionsService.FindList(gptp.gtpId, gptp.gsId, string.Empty);

                    Service.ServiceReferenceGpBidQuestions.gpBidQuestionsWebDO r = result[0];
                    r.gbqConTent = "测试1";

                    bool b1 = gpBidQuestionsService.Update(r);

                    result = gpBidQuestionsService.FindList(gptp.gtpId, gptp.gsId, string.Empty);

                    bool b2 = gpBidQuestionsService.Remove(result[0].gbqId);

                    result = gpBidQuestionsService.FindList(gptp.gtpId, gptp.gsId, string.Empty);

                    SetRecJudgesForm setRecJudgesForm = new SetRecJudgesForm();
                    setRecJudgesForm.ShowDialog(this);
                    setRecJudgesForm.Dispose();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "请选择招标项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "操作失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBidEval_Click(object sender, EventArgs e)
        {
            if (this.grdProject.CurrentRow != null)
            {
                gpTenderProjectWebDO gptp = this.grdProject.CurrentRow.Tag as gpTenderProjectWebDO;

                EOBBidFileForm eOBForm = new EOBBidFileForm(gptp.gtpId, gptp.gsId);
                eOBForm.ShowDialog(this);
                eOBForm.Dispose();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "请选择招标项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBidEvalReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.grdProject.CurrentRow != null)
                {
                    gpTenderProjectWebDO gptp = this.grdProject.CurrentRow.Tag as gpTenderProjectWebDO;

                    OpenFileDialog ofdl = new OpenFileDialog();
                    ofdl.Filter = "pdf(*.pdf)|*.pdf";

                    if (ofdl.ShowDialog() == DialogResult.OK)
                    {
                        gpSectionWebDO obj = new gpSectionWebDO();
                        obj.gtpId = gptp.gtpId;
                        obj.gsId = gptp.gsId;
                        obj.evalReportUploadTime = DateTime.Now;
                        obj.evalReportFileName = Path.GetFileName(ofdl.FileName);

                        using (Stream stream = ofdl.OpenFile())
                        {
                            byte[] bytes = new byte[stream.Length];
                            stream.Read(bytes, 0, bytes.Length);

                            bool result = bidEvaluationService.BidFileResave(obj, bytes);

                            if (result)
                            {
                                MetroMessageBox.Show(this, "上传成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "上传失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "请选择招标项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "上传失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (this.grdProject.CurrentRow != null)
            {
                gpTenderProjectWebDO gptp = this.grdProject.CurrentRow.Tag as gpTenderProjectWebDO;

                EOBResultForm eOBResultForm = new EOBResultForm(gptp.gtpId, gptp.gsId);
                eOBResultForm.ShowDialog(this);
                eOBResultForm.Dispose();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "请选择招标项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDownloadITenderFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.grdProject.CurrentRow != null)
                {
                    gpTenderProjectWebDO gptp = this.grdProject.CurrentRow.Tag as gpTenderProjectWebDO;

                    Service.ServiceReferenceBidEvaluation.resultDO result = bidEvaluationService.GetBidEvaluationReportFile(gptp.gsId);

                    Service.ServiceReferenceBidEvaluation.reslultInfoDO obj = result.obj as Service.ServiceReferenceBidEvaluation.reslultInfoDO;

                    SaveFileDialog sfdl = new SaveFileDialog();
                    sfdl.Filter = string.Format("{0}(*.{0})|*.{0}", obj.suffix);
                    sfdl.FileName = obj.fileName;
                    sfdl.DefaultExt = obj.suffix;
                    sfdl.AddExtension = true;

                    if (sfdl.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream fs = File.Create(sfdl.FileName))
                        {
                            fs.Write(result.fileContent, 0, result.fileContent.Length);
                        }
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "请选择招标项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "下载失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 方法

        public EOBManageForm()
        {
            InitializeComponent();

            List<ComboBoxDataSource> lstEvalState = new List<ComboBoxDataSource>();
            lstEvalState.Add(new ComboBoxDataSource() { Text = "评标失败", Value = -1 });
            lstEvalState.Add(new ComboBoxDataSource() { Text = "未启动", Value = 0 });
            lstEvalState.Add(new ComboBoxDataSource() { Text = "评标成功", Value = 1 });
            lstEvalState.Add(new ComboBoxDataSource() { Text = "启动评标", Value = 2 });
            lstEvalState.Add(new ComboBoxDataSource() { Text = "启动评标变动", Value = 3 });
            lstEvalState.Add(new ComboBoxDataSource() { Text = "启动二次报价", Value = 4 });
            lstEvalState.Add(new ComboBoxDataSource() { Text = "结束二次报价", Value = 5 });

            this.colProjectEvalState.DataSource = lstEvalState;
            this.colProjectEvalState.DisplayMember = "Text";
            this.colProjectEvalState.ValueMember = "Value";
        }

        public void LoadData()
        {
            this.grdProject.Rows.Clear();
            //baseUserWebDO loginResponse = Cache.GetInstance().GetValue<baseUserWebDO>("login");
            //var result = gpTenderProjectService.FindListByAuId(loginResponse.auID);
            var result = gpTenderProjectService.FindBidProjecList(string.Empty, string.Empty, this.txtProjectName.Text.Trim(), this.txtProjectCode.Text.Trim());
            this.SetGridData(result);
        }

        public void SetGridData(gpTenderProjectWebDO[] values)
        {
            this.grdProject.Rows.Clear();

            foreach (var item in values)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.grdProject);
                row.Cells[this.colProjectCode.Index].Value = item.gtpCode;
                row.Cells[this.colProjectName.Index].Value = item.gtpName;
                row.Cells[this.colSectionCode.Index].Value = item.gsCode;
                row.Cells[this.colSectionName.Index].Value = item.gsName;
                row.Cells[this.colProjectEvalState.Index].Value = item.evalState;
                row.Tag = item;

                this.grdProject.Rows.Add(row);
            }
        }

        #endregion
    }
}
