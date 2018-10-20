using log4net;
using MetroFramework;
using MetroFramework.Forms;
using Summer.CompetitiveTender.Model;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.Service.ServiceReferenceGpBidFileOrg;
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
    public partial class BidEvalFactorForm : FormBase
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(BidEvalFactorForm));

        /// <summary>
        /// gpBidFileOrgService
        /// </summary>
        private IGpBidFileOrgService gpBidFileOrgService;

        /// <summary>
        /// projectId
        /// </summary>
        private string projectId;

        /// <summary>
        /// sectionId
        /// </summary>
        private string sectionId;

        /// <summary>
        /// gpBidFileOrg
        /// </summary>
        private gpBidFileOrgWebDO gpBidFileOrg;

        #endregion

        #region 事件

        private void btnSummit_Click(object sender, EventArgs e)
        {
            try
            {
                baseUserWebDO user = Cache.GetInstance().GetValue<baseUserWebDO>("login");

                gpBidFileOrgWebDO obj = null;

                //修改
                if (this.gpBidFileOrg != null)
                {
                    obj = this.gpBidFileOrg;
                    obj.optId = user.auID;
                    obj.optCoId = user.acId;
                    obj.optTime = DateTime.Now;
                }
                else //新增
                {
                    obj = new gpBidFileOrgWebDO();
                    obj.projectId = this.projectId;
                    obj.sectionId = this.sectionId;
                    obj.adtId = user.auID;
                    obj.adtCoId = user.acId;
                    obj.adtTime = DateTime.Now;
                }

                obj.bbfoName = this.txtName.Text.Trim();
                obj.isMust = (int)this.cboIsMust.SelectedValue;
                obj.isMustSpecified = true;
                obj.sort = int.Parse(this.txtSort.Text);
                obj.sortSpecified = true;

                //修改
                if (this.gpBidFileOrg != null)
                {
                    if (this.gpBidFileOrgService.Update(obj))
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
                    if (this.gpBidFileOrgService.Add(obj))
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

        public BidEvalFactorForm(IGpBidFileOrgService gpBidFileOrgService, string projectId, string sectionId, gpBidFileOrgWebDO gpBidFileOrg)
        {
            InitializeComponent();

            List<ComboBoxDataSource> lstIsNeed = new List<ComboBoxDataSource>();
            lstIsNeed.Add(new ComboBoxDataSource() { Text = "否", Value = 0 });
            lstIsNeed.Add(new ComboBoxDataSource() { Text = "是", Value = 1 });
            this.cboIsMust.DataSource = lstIsNeed;
            this.cboIsMust.DisplayMember = "Text";
            this.cboIsMust.ValueMember = "Value";

            this.gpBidFileOrgService = gpBidFileOrgService;
            this.projectId = projectId;
            this.sectionId = sectionId;
            this.gpBidFileOrg = gpBidFileOrg;

            if (gpBidFileOrg != null)
            {
                this.txtName.Text = gpBidFileOrg.bbfoName;
                this.txtSort.Text = gpBidFileOrg.sort.ToString();
                this.cboIsMust.SelectedValue = gpBidFileOrg.isMust;
            }
        }

        #endregion
    }
}
