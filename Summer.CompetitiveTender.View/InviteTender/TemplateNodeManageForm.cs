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
    public partial class TemplateNodeManageForm : MetroForm
    {
        public TemplateNodeManageForm()
        {
            InitializeComponent();

            TreeNode node0 = new TreeNode("开标一览表");
            TreeNode node1 = new TreeNode("第一章");
            node1.Nodes.Add("测试");
            TreeNode node2 = new TreeNode("第二章");
            node2.Nodes.Add("测试");
            trvTemplateNode.Nodes.Add(node0);
            trvTemplateNode.Nodes.Add(node1);
            trvTemplateNode.Nodes.Add(node2);
        }

        private void TemplateNodeManageForm_Shown(object sender, EventArgs e)
        {
            List<ComboBoxDataSource> lstProjectType = new List<ComboBoxDataSource>();
            lstProjectType.Add(new ComboBoxDataSource() { Text = "商务", Value = 1 });
            lstProjectType.Add(new ComboBoxDataSource() { Text = "技术", Value = 2 });
            lstProjectType.Add(new ComboBoxDataSource() { Text = "价格", Value = 3 });
            this.cboProjectType.DataSource = lstProjectType;
            this.cboProjectType.DisplayMember = "Text";
            this.cboProjectType.ValueMember = "Value";

            List<ComboBoxDataSource> lstCanModify = new List<ComboBoxDataSource>();
            lstCanModify.Add(new ComboBoxDataSource() { Text = "否", Value = 0 });
            lstCanModify.Add(new ComboBoxDataSource() { Text = "是", Value = 1 });
            this.cboCanModify.DataSource = lstCanModify;
            this.cboCanModify.DisplayMember = "Text";
            this.cboCanModify.ValueMember = "Value";

            this.cboCanDelete.DataSource = lstCanModify;
            this.cboCanDelete.DisplayMember = "Text";
            this.cboCanDelete.ValueMember = "Value";

            List<ComboBoxDataSource> lstProperty = new List<ComboBoxDataSource>();
            lstProperty.Add(new ComboBoxDataSource() { Text = "普通文档", Value = 1 });
            lstProperty.Add(new ComboBoxDataSource() { Text = "文件夹", Value = 2 });
            lstProperty.Add(new ComboBoxDataSource() { Text = "专用文档", Value = 3 });
            this.cboProperty.DataSource = lstProperty;
            this.cboProperty.DisplayMember = "Text";
            this.cboProperty.ValueMember = "Value";

            this.cboCanModifyManage.DataSource = lstCanModify;
            this.cboCanModifyManage.DisplayMember = "Text";
            this.cboCanModifyManage.ValueMember = "Value";

            this.cboDRBid.DataSource = lstCanModify;
            this.cboDRBid.DisplayMember = "Text";
            this.cboDRBid.ValueMember = "Value";

            this.cboClient.DataSource = lstCanModify;
            this.cboClient.DisplayMember = "Text";
            this.cboClient.ValueMember = "Value";

            this.cboCanModifyITender.DataSource = lstCanModify;
            this.cboCanModifyITender.DisplayMember = "Text";
            this.cboCanModifyITender.ValueMember = "Value";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnSummit_Click(object sender, EventArgs e)
        {

        }
    }
}
