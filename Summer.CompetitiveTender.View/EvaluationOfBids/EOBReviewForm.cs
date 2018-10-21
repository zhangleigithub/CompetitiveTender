using log4net;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.Service.ServiceReferenceGpApplyDetail;
using Summer.CompetitiveTender.Service.ServiceReferenceLogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Summer.CompetitiveTender.Model;
using Summer.CompetitiveTender.Service.ServiceReferenceGpEvalResult;

namespace Summer.CompetitiveTender.View.EvaluationOfBids
{
    public partial class EOBReviewForm : FormBase
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(EOBReviewForm));

        /// <summary>
        /// gpEvalResultService
        /// </summary>
        private IGpEvalResultService gpEvalResultService = new GpEvalResultService();

        /// <summary>
        /// gpApplyDetail
        /// </summary>
        private gpApplyDetailWebDO gpApplyDetail;

        #endregion

        public EOBReviewForm(gpApplyDetailWebDO gpApplyDetail)
        {
            InitializeComponent();

            this.gpApplyDetail = gpApplyDetail;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                baseUserWebDO user = Cache.GetInstance().GetValue<baseUserWebDO>("login");

                gpEvalResultWebDO gpEvalResult = new gpEvalResultWebDO();
                gpEvalResult.gtpId = gpApplyDetail.gtpId;
                gpEvalResult.gsId = gpApplyDetail.gsId;
                gpEvalResult.gadBidPersonId = gpApplyDetail.gadBidPersonId;
                gpEvalResult.gadBidCompanyId = gpApplyDetail.gadBidCompanyId;
                gpEvalResult.gsewiName = this.txtGsewiName.Text.Trim();
                gpEvalResult.gerResult = int.Parse(this.txtGerResult.Text.Trim());
                gpEvalResult.gerResultSpecified = true;
                gpEvalResult.gerScores = double.Parse(this.txtGerScores.Text.Trim());
                gpEvalResult.gerScoresSpecified = true;
                gpEvalResult.remark = this.txtRemark.Text.Trim();
                gpEvalResult.gerPersonId = user.auID;
                gpEvalResult.gerCompanyId = user.acId;
                gpEvalResult.gerTime = DateTime.Now;
                gpEvalResult.gerTimeSpecified = true;
                gpEvalResult.optId = user.auID;
                gpEvalResult.optCoId = user.acId;
                gpEvalResult.optTime = DateTime.Now;
                gpEvalResult.optTimeSpecified = true;

                if (this.gpEvalResultService.Add(gpEvalResult))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "评分失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroFramework.MetroMessageBox.Show(this, "评分失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
