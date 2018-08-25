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
    public partial class EditTemplateForm : MetroForm
    {
        public EditTemplateForm()
        {
            InitializeComponent();
        }

        private void EditTemplateForm_Shown(object sender, EventArgs e)
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
    }
}
