using log4net;
using MetroFramework;
using Summer.CompetitiveTender.Model;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTenderEvalEle;
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

namespace Summer.CompetitiveTender.View.InviteTender
{
    public partial class BidEvalScoringPointForm : FormBase
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(BidEvalScoringPointForm));

        /// <summary>
        /// gpTenderEvalEleService
        /// </summary>
        private IGpTenderEvalEleService gpTenderEvalEleService;

        /// <summary>
        /// projectId
        /// </summary>
        private string projectId;

        /// <summary>
        /// sectionId
        /// </summary>
        private string sectionId;

        /// <summary>
        /// gpTenderEvalEle
        /// </summary>
        private gpTenderEvalEleWebDO gpTenderEvalEle;

        #endregion

        #region 事件

        private void btnSummit_Click(object sender, EventArgs e)
        {
            try
            {
                baseUserWebDO user = Cache.GetInstance().GetValue<baseUserWebDO>("login");

                gpTenderEvalEleWebDO obj = null;

                //修改
                if (this.gpTenderEvalEle != null)
                {
                    obj = this.gpTenderEvalEle;
                    obj.optId = user.auID;
                    obj.optCoId = user.acId;
                    obj.optTime = DateTime.Now;
                }
                else //新增
                {
                    obj = new gpTenderEvalEleWebDO();
                    obj.gtpId = this.projectId;
                    obj.gsId = this.sectionId;
                    obj.adtId = user.auID;
                    obj.adtCoId = user.acId;
                    obj.adtTime = DateTime.Now;
                }

                obj.gteeName = this.txtName.Text.Trim();
                obj.evalUnit = this.txtUnit.Text.Trim();
                obj.evalNum = decimal.Parse(this.txtNum.Text);
                obj.evalNumSpecified = true;
                obj.evalGrads = decimal.Parse(this.txtGrads.Text);
                obj.evalGradsSpecified = true;
                obj.maxScore = decimal.Parse(this.txtMaxScore.Text);
                obj.maxScoreSpecified = true;
                obj.minScore = decimal.Parse(this.txtMinScore.Text);
                obj.minScoreSpecified = true;
                obj.standard = decimal.Parse(this.txtStandard.Text);
                obj.standardSpecified = true;
                obj.greatWay = int.Parse(this.txtGreatWay.Text);
                obj.greatWaySpecified = true;
                obj.greatNum = int.Parse(this.txtGreatNum.Text);
                obj.greatNumSpecified = true;
                obj.littleWay = int.Parse(this.txtLittleWay.Text);
                obj.littleWaySpecified = true;
                obj.littleNum = int.Parse(this.txtLittleNum.Text);
                obj.littleNumSpecified = true;
                obj.canDel = (int)this.cboCanDelete.SelectedValue;
                obj.canDelSpecified = true;

                //修改
                if (this.gpTenderEvalEle != null)
                {
                    if (this.gpTenderEvalEleService.Update(obj))
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "保存失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //新增
                {
                    if (this.gpTenderEvalEleService.Add(obj))
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "保存失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "保存失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 方法

        public BidEvalScoringPointForm(IGpTenderEvalEleService gpTenderEvalEleService, string projectId, string sectionId, gpTenderEvalEleWebDO gpTenderEvalEle)
        {
            InitializeComponent();

            List<ComboBoxDataSource> lstIsNeed = new List<ComboBoxDataSource>();
            lstIsNeed.Add(new ComboBoxDataSource() { Text = "不可以", Value = 0 });
            lstIsNeed.Add(new ComboBoxDataSource() { Text = "可以", Value = 1 });
            this.cboCanDelete.DataSource = lstIsNeed;
            this.cboCanDelete.DisplayMember = "Text";
            this.cboCanDelete.ValueMember = "Value";

            this.gpTenderEvalEleService = gpTenderEvalEleService;
            this.projectId = projectId;
            this.sectionId = sectionId;
            this.gpTenderEvalEle = gpTenderEvalEle;

            if (gpTenderEvalEle != null)
            {
                this.txtName.Text = gpTenderEvalEle.gteeName;
                this.txtUnit.Text = gpTenderEvalEle.evalUnit;
                this.txtNum.Text = gpTenderEvalEle.evalNum.ToString();
                this.txtGrads.Text = gpTenderEvalEle.evalGrads.ToString();
                this.txtMaxScore.Text = gpTenderEvalEle.maxScore.ToString();
                this.txtMinScore.Text = gpTenderEvalEle.minScore.ToString();
                this.txtStandard.Text = gpTenderEvalEle.standard.ToString();
                this.txtGreatWay.Text = gpTenderEvalEle.greatWay.ToString();
                this.txtGreatNum.Text = gpTenderEvalEle.greatNum.ToString();
                this.txtLittleWay.Text = gpTenderEvalEle.littleWay.ToString();
                this.txtLittleNum.Text = gpTenderEvalEle.littleNum.ToString();
                this.cboCanDelete.SelectedValue = gpTenderEvalEle.canDel;
            }
        }

        #endregion
    }
}
