using MetroFramework;
using MetroFramework.Forms;
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
    public partial class TemplateManageForm : MetroForm
    {
        public TemplateManageForm()
        {
            InitializeComponent();
        }

        private void QueryITenderTemplateForm_Shown(object sender, EventArgs e)
        {
            List<ComboBoxDataSource> lstType = new List<ComboBoxDataSource>();
            lstType.Add(new ComboBoxDataSource() { Text = "招标", Value = 0 });
            this.colTemplateType.DataSource = lstType;
            this.colTemplateType.DisplayMember = "Text";
            this.colTemplateType.ValueMember = "Value";

            List<ComboBoxDataSource> lstProjectType = new List<ComboBoxDataSource>();
            lstProjectType.Add(new ComboBoxDataSource() { Text = "货物", Value = 1 });
            lstProjectType.Add(new ComboBoxDataSource() { Text = "服务", Value = 2 });
            lstProjectType.Add(new ComboBoxDataSource() { Text = "工程", Value = 3 });
            this.colTemplateProjectType.DataSource = lstProjectType;
            this.colTemplateProjectType.DisplayMember = "Text";
            this.colTemplateProjectType.ValueMember = "Value";

            List<ComboBoxDataSource> lstState = new List<ComboBoxDataSource>();
            lstState.Add(new ComboBoxDataSource() { Text = "未生成", Value = 0 });
            lstState.Add(new ComboBoxDataSource() { Text = "已生成", Value = 1 });
            this.colTemplateState.DataSource = lstState;
            this.colTemplateState.DisplayMember = "Text";
            this.colTemplateState.ValueMember = "Value";

            for (int i = 0; i < 30; i++)
            {
                this.grdTemplate.Rows.Add(i, i, "测试", 0, (i % 4 == 0) ? 1 : i % 4, "测试", DateTime.Now.ToLocalTime(), i % 2);
            }
        }

        private void btnNewTemplate_Click(object sender, EventArgs e)
        {
            CreateTemplateForm createTemplateForm = new CreateTemplateForm();
            createTemplateForm.ShowDialog(this);
            createTemplateForm.Dispose();
        }

        private void btnEditTemplate_Click(object sender, EventArgs e)
        {
            EditTemplateForm editTemplateForm = new EditTemplateForm();
            editTemplateForm.ShowDialog(this);
            editTemplateForm.Dispose();
        }

        private void btnTemplateNode_Click(object sender, EventArgs e)
        {
            TemplateNodeManageForm templateNodeManageForm = new TemplateNodeManageForm();
            templateNodeManageForm.ShowDialog(this);
            templateNodeManageForm.Dispose();
        }

        private void btnDeleteTemplate_Click(object sender, EventArgs e)
        {
            if (this.grdTemplate.CurrentRow != null)
            {
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, "确定要删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    this.grdTemplate.Rows.Remove(this.grdTemplate.CurrentRow);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "请选择要删除的模板！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDownloadTemplate_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdl = new SaveFileDialog();
            sfdl.Filter = "word(*.doc)|*.doc|所有文件|*.*";
            sfdl.FileName = "xxxx";
            sfdl.DefaultExt = "doc";
            sfdl.AddExtension = true;

            if (sfdl.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
