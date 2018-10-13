using log4net;
using MetroFramework.Forms;
using Summer.CompetitiveTender.Model;
using Summer.CompetitiveTender.Service;
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
using Summer.CompetitiveTender.Service.ServiceReferenceGpTemplate;

namespace Summer.CompetitiveTender.View.InviteTender
{
    public partial class CreateTemplateForm : FormBase
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(CreateTemplateForm));

        /// <summary>
        /// gpTemplateService
        /// </summary>
        private IGpTemplateService gpTemplateService = new GpTemplateService();

        #endregion

        #region 方法

        public CreateTemplateForm()
        {
            InitializeComponent();
        }

        private void CreateTemplateForm_Shown(object sender, EventArgs e)
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
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                baseUserWebDO user = Cache.GetInstance().GetValue<baseUserWebDO>("login");
               
                gpTemplateWebDO gpTemplate = new gpTemplateWebDO();
                gpTemplate.gtName = this.txtName.Text.Trim();
                gpTemplate.gtType = (int)this.cboType.SelectedValue;
                gpTemplate.gtTypeSpecified = true;
                gpTemplate.gtGroup = (int)this.cboProjectType.SelectedValue;
                gpTemplate.gtGroupSpecified = true;
                gpTemplate.remark = this.txtRemark.Text.Trim();
                gpTemplate.adtId = user.auID;
                gpTemplate.adtCoId = user.acId;
                gpTemplate.adtTime = DateTime.Now;

                if (gpTemplateService.Add(gpTemplate))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "新建模板失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroFramework.MetroMessageBox.Show(this, "新建模板失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
