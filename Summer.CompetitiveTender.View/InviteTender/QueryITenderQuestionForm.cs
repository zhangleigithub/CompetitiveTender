using log4net;
using MetroFramework;
using MetroFramework.Forms;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTenderProject;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTfOperation;
using Summer.CompetitiveTender.View.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Summer.CompetitiveTender.View.InviteTender
{
    public partial class QueryITenderQuestionForm : FormBase
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(QueryITenderQuestionForm));

        /// <summary>
        /// IGpTfOperationService
        /// </summary>
        private IGpTfOperationService gpTfOperationService = new GpTfOperationService();

        /// <summary>
        /// gptp
        /// </summary>
        private gpTenderProjectWebDO gptp;

        #endregion

        #region 事件

        private void QueryITenderQuestionForm_Shown(object sender, EventArgs e)
        {
            List<ComboBoxDataSource> lstType = new List<ComboBoxDataSource>();
            lstType.Add(new ComboBoxDataSource() { Text = "澄清", Value = 1 });
            lstType.Add(new ComboBoxDataSource() { Text = "修改", Value = 2 });
            this.cboType.DataSource = lstType;
            this.cboType.DisplayMember = "Text";
            this.cboType.ValueMember = "Value";
            this.cboType.SelectedValue = 1;

            this.colType.DataSource = lstType;
            this.colType.DisplayMember = "Text";
            this.colType.ValueMember = "Value";
        }

        private void btnQuestQuery_Click(object sender, EventArgs e)
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

        private void grdITQuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            gpTfOperationWebDO gptfo = this.grdITQuest.Rows[e.RowIndex].Tag as gpTfOperationWebDO;

            if (e.ColumnIndex == this.colDetail.Index)
            {
                ITenderQuestionDetailForm iTenderQuestionDetailForm = new ITenderQuestionDetailForm(gptfo);
                iTenderQuestionDetailForm.ShowDialog(this);
                iTenderQuestionDetailForm.Dispose();
            }
            else if (e.ColumnIndex == this.colReplayQuestion.Index)
            {
                ReplayQuestionForm replayQuestionForm = new ReplayQuestionForm(gpTfOperationService, gptfo.gtoId);
                replayQuestionForm.ShowDialog(this);
                replayQuestionForm.Dispose();
            }
        }

        #endregion

        #region 方法

        public QueryITenderQuestionForm(gpTenderProjectWebDO gptp)
        {
            InitializeComponent();
            this.gptp = gptp;
        }

        public void LoadData()
        {
            this.grdITQuest.Rows.Clear();
            var result = gpTfOperationService.FindQuestions(this.gptp.gtpId, this.gptp.gpId, this.txtTitle.Text.Trim(), (int)this.cboType.SelectedValue);
            this.SetGridData(result);
        }

        public void SetGridData(gpTfOperationWebDO[] values)
        {
            this.grdITQuest.Rows.Clear();

            foreach (var item in values)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.grdITQuest);
                row.Cells[this.colOperationId.Index].Value = item.gtoCode;
                row.Cells[this.colProjectCode.Index].Value = item.gtpId;
                row.Cells[this.colSectionCode.Index].Value = item.gsId;
                row.Cells[this.colFileId.Index].Value = item.gtfId;
                row.Cells[this.colCaption.Index].Value = item.gtoTitle;
                row.Cells[this.colType.Index].Value = item.gtoType;
                row.Cells[this.colContent.Index].Value = item.gtoContent;
                row.Cells[this.colCreateDate.Index].Value = item.optTime;
                row.Cells[this.colState.Index].Value = item.state;
                row.Cells[this.colDetail.Index].Value = "详情";
                row.Cells[this.colReplayQuestion.Index].Value = "回复";
                row.Tag = item;

                this.grdITQuest.Rows.Add(row);
            }
        }

        #endregion
    }
}
