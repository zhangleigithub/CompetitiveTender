using log4net;
using MetroFramework.Forms;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.View.Common;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTemplate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Summer.CompetitiveTender.Service.ServiceReferenceLogin;
using Summer.CompetitiveTender.Model;
using MetroFramework;

namespace Summer.CompetitiveTender.View.InviteTender
{
    public partial class EditTemplateForm : FormBase
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(EditTemplateForm));

        /// <summary>
        /// gpTemplateService
        /// </summary>
        private IGpTemplateService gpTemplateService;

        /// <summary>
        /// gptId
        /// </summary>
        private string gptId;

        /// <summary>
        /// gpTemplate
        /// </summary>
        private gpTemplateWebDO gpTemplate = null;

        #endregion

        #region 方法

        public EditTemplateForm(IGpTemplateService gpTemplateService, string gptId)
        {
            InitializeComponent();
            this.gpTemplateService = gpTemplateService;
            this.gptId = gptId;
        }

        private void EditTemplateForm_Shown(object sender, EventArgs e)
        {
            List<ComboBoxDataSource> lstType = new List<ComboBoxDataSource>();
            lstType.Add(new ComboBoxDataSource() { Text = "招标", Value = 1 });
            this.cboType.DataSource = lstType;
            this.cboType.DisplayMember = "Text";
            this.cboType.ValueMember = "Value";

            List<ComboBoxDataSource> lstProjectType = new List<ComboBoxDataSource>();
            lstProjectType.Add(new ComboBoxDataSource() { Text = "货物", Value = 1 });
            lstProjectType.Add(new ComboBoxDataSource() { Text = "服务", Value = 2 });
            lstProjectType.Add(new ComboBoxDataSource() { Text = "工程", Value = 3 });
            this.cboProjectType.DataSource = lstProjectType;
            this.cboProjectType.DisplayMember = "Text";
            this.cboProjectType.ValueMember = "Value";

            try
            {
                this.gpTemplate = this.gpTemplateService.FindById(this.gptId);
                this.txtName.Text = this.gpTemplate.gtName;
                this.cboType.SelectedValue = this.gpTemplate.gtType;
                this.cboProjectType.SelectedValue = this.gpTemplate.gtGroup;
                this.txtRemark.Text = this.gpTemplate.remark;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "获取失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnOKClick(object sender, EventArgs e)
        {
            try
            {
                baseUserWebDO user = Cache.GetInstance().GetValue<baseUserWebDO>("login");

                this.gpTemplate.gtName = this.txtName.Text.Trim();
                this.gpTemplate.gtType = (int)this.cboType.SelectedValue;
                this.gpTemplate.gtTypeSpecified = true;
                this.gpTemplate.gtGroup = (int)this.cboProjectType.SelectedValue;
                this.gpTemplate.gtGroupSpecified = true;
                this.gpTemplate.remark = this.txtRemark.Text.Trim();
                this.gpTemplate.optId = user.auID;
                this.gpTemplate.optCoId = user.acId;
                this.gpTemplate.optTime = DateTime.Now;

                if (gpTemplateService.Update(gpTemplate))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "修改模板失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroFramework.MetroMessageBox.Show(this, "修改模板失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
