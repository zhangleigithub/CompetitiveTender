using log4net;
using MetroFramework;
using MetroFramework.Forms;
using Summer.CompetitiveTender.Service;
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
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(EditITenderForm));

        /// <summary>
        /// gpEvalwayItemGtfService
        /// </summary>
        private IGpEvalwayItemGtfService gpEvalwayItemGtfService = new GpEvalwayItemGtfService();

        /// <summary>
        /// IGpTenderEvalEleService
        /// </summary>
        private IGpTenderEvalEleService gpTenderEvalEleService = new GpTenderEvalEleService();

        /// <summary>
        /// IGpBidFileOrgService
        /// </summary>
        private IGpBidFileOrgService gpBidFileOrgService = new GpBidFileOrgService();

        /// <summary>
        /// projectId
        /// </summary>
        private string projectId;

        /// <summary>
        /// sectionId
        /// </summary>
        private string sectionId;

        /// <summary>
        /// bidEvalBodyPage
        /// </summary>
        private BidEvalBodyPage bidEvalBodyPage = new BidEvalBodyPage();

        #endregion

        #region 事件

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
                    bidEvalBodyPage.Dock = DockStyle.Fill;
                    this.pnelFrame.Controls.Add(bidEvalBodyPage);
                    break;
                case "评标条款":
                    BidEvalClausePage bidEvalClausePage = new BidEvalClausePage(this.gpEvalwayItemGtfService, this.projectId, this.sectionId);
                    bidEvalClausePage.Dock = DockStyle.Fill;
                    this.pnelFrame.Controls.Add(bidEvalClausePage);
                    break;
                case "评 分 点":
                    BidEvalScoringPointPage bidEvalScoringPointPage = new BidEvalScoringPointPage(this.gpTenderEvalEleService, this.projectId, this.sectionId);
                    bidEvalScoringPointPage.Dock = DockStyle.Fill;
                    this.pnelFrame.Controls.Add(bidEvalScoringPointPage);
                    break;
                case "评分因素":
                    BidEvalFactorPage bidEvalFactorPage = new BidEvalFactorPage(this.gpBidFileOrgService,this.projectId,this.sectionId);
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

        #endregion

        #region 方法

        public EditITenderForm(string projectId,string sectionId)
        {
            InitializeComponent();
            this.projectId = projectId;
            this.sectionId = sectionId;
        }

        #endregion
    }
}
