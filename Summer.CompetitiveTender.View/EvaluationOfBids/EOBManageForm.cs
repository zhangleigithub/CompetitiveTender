using log4net;
using MetroFramework;
using Summer.CompetitiveTender.Model;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTenderProject;
using Summer.CompetitiveTender.Service.ServiceReferenceLogin;
using Summer.CompetitiveTender.View.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            if (this.grdProject.CurrentRow != null)
            {
                gpTenderProjectWebDO gptp = this.grdProject.CurrentRow.Tag as gpTenderProjectWebDO;

                SetRecJudgesForm setRecJudgesForm = new SetRecJudgesForm();
                setRecJudgesForm.ShowDialog(this);
                setRecJudgesForm.Dispose();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "请选择招标项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBidEval_Click(object sender, EventArgs e)
        {
            if (this.grdProject.CurrentRow != null)
            {
                gpTenderProjectWebDO gptp = this.grdProject.CurrentRow.Tag as gpTenderProjectWebDO;

                EOBForm eOBForm = new EOBForm(gptp.gtpId, gptp.gsId);
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
            if (this.grdProject.CurrentRow != null)
            {
                gpTenderProjectWebDO gptp = this.grdProject.CurrentRow.Tag as gpTenderProjectWebDO;

                OpenFileDialog ofdl = new OpenFileDialog();
                ofdl.Filter = "word(*.doc)|*.doc";

                if (ofdl.ShowDialog() == DialogResult.OK)
                {
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "请选择招标项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (this.grdProject.CurrentRow != null)
            {
                gpTenderProjectWebDO gptp = this.grdProject.CurrentRow.Tag as gpTenderProjectWebDO;

                SaveFileDialog sfdl = new SaveFileDialog();
                sfdl.Filter = "word(*.doc)|*.doc|所有文件|*.*";
                sfdl.FileName = "xxxx";
                sfdl.DefaultExt = "doc";
                sfdl.AddExtension = true;

                if (sfdl.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "请选择招标项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            var result = gpTenderProjectService.FindListByCondition(string.Empty, string.Empty, this.txtProjectName.Text.Trim(), this.txtProjectCode.Text.Trim());
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
