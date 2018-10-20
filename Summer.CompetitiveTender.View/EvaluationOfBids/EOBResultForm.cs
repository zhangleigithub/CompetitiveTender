using log4net;
using MetroFramework;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.Service.ServiceReferenceBidEvaluation;
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
    public partial class EOBResultForm : FormBase
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(EOBResultForm));

        /// <summary>
        /// bidEvaluationService
        /// </summary>
        private IBidEvaluationService bidEvaluationService = new BidEvaluationService();

        /// <summary>
        /// projectId
        /// </summary>
        private string projectId;

        /// <summary>
        /// sectionId
        /// </summary>
        private string sectionId;

        #endregion

        #region 事件

        private void EOBResultForm_Shown(object sender, EventArgs e)
        {
            this.LoadData();
        }

        #endregion

        #region 方法

        public EOBResultForm(string projectId, string sectionId)
        {
            InitializeComponent();

            this.projectId = projectId;
            this.sectionId = sectionId;
        }

        public void LoadData()
        {
            try
            {
                this.grdBidEvalResult.Rows.Clear();
                var result = this.bidEvaluationService.FindBidEvaluationResultByProjectIdAndSectionId(this.projectId,this.sectionId);
                this.SetGridData(result);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "加载失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetGridData(gpEvalResultWebDO[] values)
        {
            this.grdBidEvalResult.Rows.Clear();

            foreach (var item in values)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.grdBidEvalResult);
                row.Cells[this.colTbrCompanyName.Index].Value = item.gadBidCompanyName;
                row.Cells[this.colGerResult.Index].Value = item.gerResult;
                row.Cells[this.colGerScores.Index].Value = item.gerScores;
                row.Cells[this.colRemark.Index].Value = item.remark;
                row.Cells[this.colDateTime.Index].Value = item.gerTime;
                row.Tag = item;

                this.grdBidEvalResult.Rows.Add(row);
            }
        }

        #endregion
    }
}
