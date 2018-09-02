using log4net;
using MetroFramework.Forms;
using Summer.CompetitiveTender.Model;
using Summer.CompetitiveTender.Model.Response;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTemplate;
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
                LoginRes loginRes = CacheData.GetInstance().GetValue<LoginRes>("login");

                GpTemplateWebServiceClient client = new GpTemplateWebServiceClient();
                resultDO result = client.add(this.txtName.Text.Trim(),
                    (int)this.cboType.SelectedValue,
                    (int)this.cboProjectType.SelectedValue,
                    this.txtRemark.Text.Trim(),
                    loginRes.bcId ,
                    loginRes.bctId,
                    DateTime.Now);

                if (result.success)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    log.Error(result.message);
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
