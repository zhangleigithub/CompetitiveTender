using log4net;
using MetroFramework;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.Service.ServiceReferenceGpApplyDetail;
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
    public partial class EOBBidFileForm : FormBase
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(EOBBidFileForm));

        /// <summary>
        /// gpApplyDetailService
        /// </summary>
        private IGpApplyDetailService gpApplyDetailService = new GpApplyDetailService();

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

        private void EOBForm_Shown(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void grdBids_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == this.colReview.Index)
                {
                    gpApplyDetailWebDO obj = this.grdBids.CurrentRow.Tag as gpApplyDetailWebDO;

                    //object obj1 = bidEvaluationService.AuxiliaryAnalysis(this.sectionId);
                    //object obj2 = bidEvaluationService.PriceAnalysis(this.sectionId);
                    //object obj3 = bidEvaluationService.ConformanceContrastResult(this.sectionId);
                    //object obj4 = bidEvaluationService.EvaluationFactorsAnalysis(this.sectionId);
                    //object obj5 = bidEvaluationService.FileDifferenceResult(this.sectionId);
                    //object obj6 = bidEvaluationService.FileExceptionResult(this.sectionId);
                    //object obj7 = bidEvaluationService.AutomaticScoreResult(this.sectionId);

                    EOBReviewForm eOBReviewForm = new EOBReviewForm(obj);
                    eOBReviewForm.ShowDialog(this);
                    eOBReviewForm.Dispose();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "操作失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 方法

        public EOBBidFileForm(string projectId, string sectionId)
        {
            InitializeComponent();

            this.projectId = projectId;
            this.sectionId = sectionId;
        }

        public void LoadData()
        {
            try
            {
                this.grdBids.Rows.Clear();
                var result = this.gpApplyDetailService.FindApplyFileBySectionId(this.sectionId);
                this.SetGridData(result);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "加载失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetGridData(gpApplyDetailWebDO[] values)
        {
            this.grdBids.Rows.Clear();

            foreach (var item in values)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.grdBids);
                row.Cells[this.colTbrCompanyName.Index].Value = item.gadBidCompanyName;
                row.Cells[this.colTbrName.Index].Value = item.gadBidPersonName;
                row.Cells[this.colTbrCode.Index].Value = item.gadBidCode;
                row.Cells[this.colBidTime.Index].Value = item.gadBidTime;
                row.Cells[this.colReview.Index].Value = "评分";
                row.Tag = item;

                this.grdBids.Rows.Add(row);
            }
        }

        #endregion
    }
}
