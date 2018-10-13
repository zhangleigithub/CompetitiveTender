using log4net;
using MetroFramework;
using Summer.CompetitiveTender.Model;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.Service.ServiceReferenceGpEvalwayItemGtf;
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
    public partial class BidEvalClauseForm : FormBase
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(BidEvalClauseForm));

        /// <summary>
        /// gpEvalwayItemGtfService
        /// </summary>
        private IGpEvalwayItemGtfService gpEvalwayItemGtfService;

        /// <summary>
        /// projectId
        /// </summary>
        private string projectId;

        /// <summary>
        /// sectionId
        /// </summary>
        private string sectionId;

        /// <summary>
        /// gpEvalWayItemGtf
        /// </summary>
        private gpEvalWayItemGtfWebDO gpEvalWayItemGtf;

        #endregion

        #region 事件

        private void btnSummit_Click(object sender, EventArgs e)
        {
            try
            {
                baseUserWebDO user = Cache.GetInstance().GetValue<baseUserWebDO>("login");

                gpEvalWayItemGtfWebDO obj = null;

                //修改
                if (this.gpEvalWayItemGtf != null)
                {
                    obj = this.gpEvalWayItemGtf;
                    obj.optId = user.auID;
                    obj.optCoId = user.acId;
                    obj.optTime = DateTime.Now;
                }
                else //新增
                {
                    obj = new gpEvalWayItemGtfWebDO();
                    obj.gsId = this.sectionId;
                    obj.adtId = user.auID;
                    obj.adtCoId = user.acId;
                    obj.adtTime = DateTime.Now;
                }

                obj.gewigName = this.txtName.Text.Trim();
                obj.gewigType = (int)this.cboType.SelectedValue;
                obj.gewigTypeSpecified = true;
                obj.maxScore = decimal.Parse(this.txtMaxScore.Text);
                obj.maxScoreSpecified = true;
                obj.minScore = decimal.Parse(this.txtMinScore.Text);
                obj.minScoreSpecified = true;
                obj.isNeedFirstPara = (int)this.cboIsNeedFirstPara.SelectedValue;
                obj.isNeedFirstParaSpecified = true;
                obj.firstParaDesc = this.txtFirstParaDesc.Text;
                obj.isNeeSecondPara = (int)this.cboIsNeeSecondPara.SelectedValue;
                obj.isNeeSecondParaSpecified = true;
                obj.secondParaDesc = this.txtSecondParaDesc.Text;
                obj.algoName = this.txtAlgoName.Text;
                obj.sort = int.Parse(this.txtSort.Text);
                obj.sortSpecified = true;
                obj.remark = this.txtRemark.Text;

                //修改
                if (this.gpEvalWayItemGtf != null)
                {
                    if (this.gpEvalwayItemGtfService.Update(obj))
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
                    if (this.gpEvalwayItemGtfService.Add(obj))
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

        public BidEvalClauseForm(IGpEvalwayItemGtfService gpEvalwayItemGtfService, string projectId, string sectionId, gpEvalWayItemGtfWebDO gpEvalWayItemGtf)
        {
            InitializeComponent();

            List<ComboBoxDataSource> lstType = new List<ComboBoxDataSource>();
            lstType.Add(new ComboBoxDataSource() { Text = "符合性", Value = 0 });
            lstType.Add(new ComboBoxDataSource() { Text = "评分", Value = 1 });
            this.cboType.DataSource = lstType;
            this.cboType.DisplayMember = "Text";
            this.cboType.ValueMember = "Value";

            List<ComboBoxDataSource> lstIsNeed = new List<ComboBoxDataSource>();
            lstIsNeed.Add(new ComboBoxDataSource() { Text = "不需要", Value = 0 });
            lstIsNeed.Add(new ComboBoxDataSource() { Text = "需要", Value = 1 });
            this.cboIsNeedFirstPara.DataSource = lstIsNeed;
            this.cboIsNeedFirstPara.DisplayMember = "Text";
            this.cboIsNeedFirstPara.ValueMember = "Value";

            this.cboIsNeeSecondPara.DataSource = new List<ComboBoxDataSource>(lstIsNeed);
            this.cboIsNeeSecondPara.DisplayMember = "Text";
            this.cboIsNeeSecondPara.ValueMember = "Value";

            this.gpEvalwayItemGtfService = gpEvalwayItemGtfService;
            this.projectId = projectId;
            this.sectionId = sectionId;
            this.gpEvalWayItemGtf = gpEvalWayItemGtf;

            if (gpEvalWayItemGtf != null)
            {
                this.txtName.Text = gpEvalWayItemGtf.gewigName;
                this.cboType.SelectedValue = gpEvalWayItemGtf.gewigType;
                this.txtMaxScore.Text = gpEvalWayItemGtf.maxScore.ToString();
                this.txtMinScore.Text = gpEvalWayItemGtf.minScore.ToString();
                this.cboIsNeedFirstPara.SelectedValue = gpEvalWayItemGtf.isNeedFirstPara;
                this.txtFirstParaDesc.Text = gpEvalWayItemGtf.firstParaDesc;
                this.cboIsNeeSecondPara.SelectedValue = gpEvalWayItemGtf.isNeeSecondPara;
                this.txtSecondParaDesc.Text = gpEvalWayItemGtf.secondParaDesc;
                this.txtAlgoName.Text = gpEvalWayItemGtf.algoName;
                this.txtSort.Text = gpEvalWayItemGtf.sort.ToString();
                this.txtRemark.Text = gpEvalWayItemGtf.remark;
            }
        }

        #endregion
    }
}
