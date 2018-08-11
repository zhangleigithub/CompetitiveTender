using MetroFramework.Forms;
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
    public partial class ITenderTemplateNodeForm : MetroForm
    {
        public ITenderTemplateNodeForm()
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
    }
}
