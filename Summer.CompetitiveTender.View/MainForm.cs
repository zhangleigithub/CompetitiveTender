using MetroFramework.Forms;
using Summer.CompetitiveTender.View.InviteTender;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Summer.CompetitiveTender.View
{
    public partial class MainForm : MetroForm
    {
        #region 方法

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(UserType userType) : this()
        {
            switch (userType)
            {
                case UserType.Unkown:
                    break;
                case UserType.InviteTender:
                    this.tsmiFile.Visible = true;
                    this.tsmiNewITenderTemplate.Visible = true;
                    this.tsmiNewITenderFile.Visible = true;
                    this.tsmiNewBidTemplate.Visible = false;
                    this.tsmiNewBidFile.Visible = false;
                    this.tsmiNewOpenOfBidsTemplate.Visible = true;
                    this.tsmiNewEvaluationOfBidsTemplate.Visible = true;
                    this.toolStripSeparator5.Visible = true;
                    this.tsmiExit.Visible = true;

                    this.tsmiQuery.Visible = true;
                    this.tsmiQueryITenderTemplate.Visible = true;
                    this.tsmiQueryITenderFile.Visible = true;
                    this.tsmiQueryBidTemplate.Visible = false;
                    this.tsmiQueryBidFile.Visible = false;
                    this.tsmiQueryOpenOfBidsTemplate.Visible = true;
                    this.tsmiQueryEvaluationOfBidsTemplate.Visible = true;

                    this.tsmiOpenOfBids.Visible = true;
                    this.tsmiCheckIn.Visible = true;
                    this.tsmiDecryptBidFile.Visible = true;

                    this.tsmiEvaluationOfBids.Visible = true;
                    this.tsmiEOBPrepare.Visible = true;
                    this.tsmiEOBClean.Visible = true;
                    this.tsmiEOBQualificationReview.Visible = true;
                    this.tsmiEOBTechnologyReview.Visible = true;
                    this.tsmiEOBCommerceReview.Visible = true;
                    this.tsmiReviewResult.Visible = true;
                    break;
                case UserType.Agency:
                    this.tsmiFile.Visible = true;
                    this.tsmiNewITenderTemplate.Visible = true;
                    this.tsmiNewITenderFile.Visible = true;
                    this.tsmiNewBidTemplate.Visible = true;
                    this.tsmiNewBidFile.Visible = true;
                    this.tsmiNewOpenOfBidsTemplate.Visible = true;
                    this.tsmiNewEvaluationOfBidsTemplate.Visible = false;
                    this.toolStripSeparator5.Visible = true;
                    this.tsmiExit.Visible = true;

                    this.tsmiQuery.Visible = true;
                    this.tsmiQueryITenderTemplate.Visible = true;
                    this.tsmiQueryITenderFile.Visible = true;
                    this.tsmiQueryBidTemplate.Visible = true;
                    this.tsmiQueryBidFile.Visible = true;
                    this.tsmiQueryOpenOfBidsTemplate.Visible = true;
                    this.tsmiQueryEvaluationOfBidsTemplate.Visible = false;

                    this.tsmiOpenOfBids.Visible = true;
                    this.tsmiCheckIn.Visible = true;
                    this.tsmiDecryptBidFile.Visible = true;

                    this.tsmiEvaluationOfBids.Visible = false;
                    this.tsmiEOBPrepare.Visible = false;
                    this.tsmiEOBClean.Visible = false;
                    this.tsmiEOBQualificationReview.Visible = false;
                    this.tsmiEOBTechnologyReview.Visible = false;
                    this.tsmiEOBCommerceReview.Visible = false;
                    this.tsmiReviewResult.Visible = false;
                    break;
                case UserType.Tender:
                    this.tsmiFile.Visible = true;
                    this.tsmiNewITenderTemplate.Visible = false;
                    this.tsmiNewITenderFile.Visible = false;
                    this.tsmiNewBidTemplate.Visible = true;
                    this.tsmiNewBidFile.Visible = true;
                    this.tsmiNewOpenOfBidsTemplate.Visible = false;
                    this.tsmiNewEvaluationOfBidsTemplate.Visible = false;
                    this.toolStripSeparator5.Visible = true;
                    this.tsmiExit.Visible = true;

                    this.tsmiQuery.Visible = true;
                    this.tsmiQueryITenderTemplate.Visible = false;
                    this.tsmiQueryITenderFile.Visible = true;
                    this.tsmiQueryBidTemplate.Visible = true;
                    this.tsmiQueryBidFile.Visible = true;
                    this.tsmiQueryOpenOfBidsTemplate.Visible = false;
                    this.tsmiQueryEvaluationOfBidsTemplate.Visible = false;

                    this.tsmiOpenOfBids.Visible = true;
                    this.tsmiCheckIn.Visible = true;
                    this.tsmiDecryptBidFile.Visible = true;

                    this.tsmiEvaluationOfBids.Visible = false;
                    this.tsmiEOBPrepare.Visible = false;
                    this.tsmiEOBClean.Visible = false;
                    this.tsmiEOBQualificationReview.Visible = false;
                    this.tsmiEOBTechnologyReview.Visible = false;
                    this.tsmiEOBCommerceReview.Visible = false;
                    this.tsmiReviewResult.Visible = false;
                    break;
                case UserType.Expert:
                    this.tsmiFile.Visible = false;
                    this.tsmiNewITenderTemplate.Visible = false;
                    this.tsmiNewITenderFile.Visible = false;
                    this.tsmiNewBidTemplate.Visible = false;
                    this.tsmiNewBidFile.Visible = false;
                    this.tsmiNewOpenOfBidsTemplate.Visible = false;
                    this.tsmiNewEvaluationOfBidsTemplate.Visible = false;
                    this.toolStripSeparator5.Visible = false;
                    this.tsmiExit.Visible = false;

                    this.tsmiQuery.Visible = false;
                    this.tsmiQueryITenderTemplate.Visible = false;
                    this.tsmiQueryITenderFile.Visible = false;
                    this.tsmiQueryBidTemplate.Visible = false;
                    this.tsmiQueryBidFile.Visible = false;
                    this.tsmiQueryOpenOfBidsTemplate.Visible = false;
                    this.tsmiQueryEvaluationOfBidsTemplate.Visible = false;

                    this.tsmiOpenOfBids.Visible = false;
                    this.tsmiCheckIn.Visible = false;
                    this.tsmiDecryptBidFile.Visible = false;

                    this.tsmiEvaluationOfBids.Visible = true;
                    this.tsmiEOBPrepare.Visible = true;
                    this.tsmiEOBClean.Visible = true;
                    this.tsmiEOBQualificationReview.Visible = true;
                    this.tsmiEOBTechnologyReview.Visible = true;
                    this.tsmiEOBCommerceReview.Visible = true;
                    this.tsmiReviewResult.Visible = true;
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region 文件

        private void OnNewITenderTemplateToolStripMenuItemClick(object sender, EventArgs e)
        {
            CreateITenderTemplateForm createITenderTemplateForm = new CreateITenderTemplateForm();
            createITenderTemplateForm.ShowDialog(this);
            createITenderTemplateForm.Dispose();
        }

        private void OnNewITenderFileToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        private void OnNewBidFileToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        private void OnExitToolsStripMenuItemClick(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region 查看

        private void OnQueryITenderTemplateToolStripMenuItemClick(object sender, EventArgs e)
        {
            InviteTenderManageForm inviteTenderManageForm = new InviteTenderManageForm();
            inviteTenderManageForm.ShowDialog();
            inviteTenderManageForm.Dispose();
        }

        #endregion

        #region 开标

        #endregion

        #region 评标

        #endregion

        #region 帮助

        private void OnIndexToolStripMenuItemClick(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm");
        }

        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            AboutBoxForm aboutBoxForm = new AboutBoxForm();
            aboutBoxForm.ShowDialog(this);
            aboutBoxForm.Dispose();
        }

        #endregion
    }
}
