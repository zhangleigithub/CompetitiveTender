using log4net;
using MetroFramework.Forms;
using Summer.CompetitiveTender.Model;
using Summer.CompetitiveTender.Model.Request;
using Summer.CompetitiveTender.Model.Response;
using Summer.CompetitiveTender.Service;
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
            lstType.Add(new ComboBoxDataSource() { Text = "招标", Value = 0 });
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
                LoginResponse loginResponse = Cache.GetInstance().GetValue<LoginResponse>("login");

                GpTemplateAddRequest gpTemplateAddRequest = new GpTemplateAddRequest();
                gpTemplateAddRequest.Name = this.txtName.Text.Trim();
                gpTemplateAddRequest.Type = (int)this.cboType.SelectedValue;
                gpTemplateAddRequest.Group = (int)this.cboProjectType.SelectedValue;
                gpTemplateAddRequest.Remark = this.txtRemark.Text.Trim();
                gpTemplateAddRequest.AdtId = loginResponse.bcId;
                gpTemplateAddRequest.AdtCoId = loginResponse.bctId;
                gpTemplateAddRequest.AdtTime = DateTime.Now;

                if (gpTemplateService.Add(gpTemplateAddRequest))
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
