using MetroFramework;
using MetroFramework.Forms;
using Summer.CompetitiveTender.View.BidEvaluaMethod;
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
    public partial class EditITenderForm : FormBase
    {
        public EditITenderForm()
        {
            InitializeComponent();
        }

        private void EditITenderForm_Shown(object sender, EventArgs e)
        {
            this.trvMenu.SelectedNode = this.trvMenu.Nodes[0];
        }

        private void trvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.pnelFrame.Controls.Clear();

            switch (e.Node.Text)
            {
                case "招标正文":
                    BidEvalBodyPage bidEvalBodyPage = new BidEvalBodyPage();
                    bidEvalBodyPage.Dock = DockStyle.Fill;
                    this.pnelFrame.Controls.Add(bidEvalBodyPage);
                    break;
                case "评标条款":
                    BidEvalClausePage bidEvalClausePage = new BidEvalClausePage();
                    bidEvalClausePage.Dock = DockStyle.Fill;
                    this.pnelFrame.Controls.Add(bidEvalClausePage);
                    break;
                case "评 分 点":
                    BidEvalScoringPointPage bidEvalScoringPointPage = new BidEvalScoringPointPage();
                    bidEvalScoringPointPage.Dock = DockStyle.Fill;
                    this.pnelFrame.Controls.Add(bidEvalScoringPointPage);
                    break;
                case "评分因素":
                    BidEvalFactorPage bidEvalFactorPage = new BidEvalFactorPage();
                    bidEvalFactorPage.Dock = DockStyle.Fill;
                    this.pnelFrame.Controls.Add(bidEvalFactorPage);
                    break;
                case "生成招标文件":
                    MetroMessageBox.Show(this, "疯狂开发中...", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "打印招标文件":
                    MetroMessageBox.Show(this, "疯狂开发中...", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }
        }
    }
}
