using MetroFramework.Forms;
using Summer.CompetitiveTender.View.Bid;
using Summer.CompetitiveTender.View.EvaluationOfBids;
using Summer.CompetitiveTender.View.InviteTender;
using Summer.CompetitiveTender.View.OpenOfBids;
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
                    this.tsmiQueryITenderFileQuestion.Visible = true;
                    this.tsmiQueryBidTemplate.Visible = false;
                    this.tsmiQueryBidFile.Visible = false;
                    this.tsmiQueryOpenOfBidsTemplate.Visible = true;
                    this.tsmiQueryEvaluationOfBidsTemplate.Visible = true;

                    this.tsmiOpenOfBids.Visible = true;
                    this.tsmiOOBCheckIn.Visible = true;
                    this.tsmiOOBDecryptBidFile.Visible = true;

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
                    this.tsmiQueryITenderFileQuestion.Visible = true;
                    this.tsmiQueryBidTemplate.Visible = true;
                    this.tsmiQueryBidFile.Visible = true;
                    this.tsmiQueryOpenOfBidsTemplate.Visible = true;
                    this.tsmiQueryEvaluationOfBidsTemplate.Visible = false;

                    this.tsmiOpenOfBids.Visible = true;
                    this.tsmiOOBCheckIn.Visible = true;
                    this.tsmiOOBDecryptBidFile.Visible = true;

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
                    this.tsmiQueryITenderFileQuestion.Visible = false;
                    this.tsmiQueryBidTemplate.Visible = true;
                    this.tsmiQueryBidFile.Visible = true;
                    this.tsmiQueryOpenOfBidsTemplate.Visible = false;
                    this.tsmiQueryEvaluationOfBidsTemplate.Visible = false;

                    this.tsmiOpenOfBids.Visible = true;
                    this.tsmiOOBCheckIn.Visible = true;
                    this.tsmiOOBDecryptBidFile.Visible = true;

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
                    this.tsmiQueryITenderFileQuestion.Visible = false;
                    this.tsmiQueryBidTemplate.Visible = false;
                    this.tsmiQueryBidFile.Visible = false;
                    this.tsmiQueryOpenOfBidsTemplate.Visible = false;
                    this.tsmiQueryEvaluationOfBidsTemplate.Visible = false;

                    this.tsmiOpenOfBids.Visible = false;
                    this.tsmiOOBCheckIn.Visible = false;
                    this.tsmiOOBDecryptBidFile.Visible = false;

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
            CreateITenderForm createITenderForm = new CreateITenderForm();
            createITenderForm.ShowDialog(this);
            createITenderForm.Dispose();
        }

        private void OnNewBidTemplateToolStripMenuItemClick(object sender, EventArgs e)
        {
            CreateBidTemplateForm createBidTemplateForm = new CreateBidTemplateForm();
            createBidTemplateForm.ShowDialog(this);
            createBidTemplateForm.Dispose();
        }

        private void OnNewBidFileToolStripMenuItemClick(object sender, EventArgs e)
        {
            CreateBidForm createBidForm = new CreateBidForm();
            createBidForm.ShowDialog(this);
            createBidForm.Dispose();
        }

        private void OnNewOpenOfBidsTemplateToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        private void OnNewEvaluationOfBidsTemplateToolStripMenuItemClick(object sender, EventArgs e)
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
            QueryITenderTemplateForm queryITenderTemplateForm = new QueryITenderTemplateForm();
            queryITenderTemplateForm.ShowDialog(this);
            queryITenderTemplateForm.Dispose();
        }

        private void OnQueryITenderFileToolStripMenuItemClick(object sender, EventArgs e)
        {
            QueryITenderForm queryITenderForm = new QueryITenderForm();
            queryITenderForm.ShowDialog(this);
            queryITenderForm.Dispose();
        }

        private void OnQueryITenderFileQuestionToolStripMenuItemClick(object sender, EventArgs e)
        {
            QueryITenderQuestionForm queryITenderQuestionForm = new QueryITenderQuestionForm();
            queryITenderQuestionForm.ShowDialog(this);
            queryITenderQuestionForm.Dispose();
        }

        private void OnQueryBidTemplateToolStripMenuItemClick(object sender, EventArgs e)
        {
            QueryBidTemplateForm queryBidTemplateForm = new QueryBidTemplateForm();
            queryBidTemplateForm.ShowDialog(this);
            queryBidTemplateForm.Dispose();
        }

        private void OnQueryBidFileToolStripMenuItemClick(object sender, EventArgs e)
        {
            QueryBidForm queryBidForm = new QueryBidForm();
            queryBidForm.ShowDialog(this);
            queryBidForm.Dispose();
        }

        private void OnQueryOpenOfBidsTemplateToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        private void OnQueryEvaluationOfBidsTemplateToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        #endregion

        #region 开标

        private void OnOOBCheckInToolStripMenuItemClick(object sender, EventArgs e)
        {
            OOBCheckInForm oOBCheckInForm = new OOBCheckInForm();
            oOBCheckInForm.ShowDialog(this);
            oOBCheckInForm.Dispose();
        }

        private void OnOOBDecryptBidFileToolStripMenuItemClick(object sender, EventArgs e)
        {
            OOBDecryptBidFileForm oOBDecryptBidFileForm = new OOBDecryptBidFileForm();
            oOBDecryptBidFileForm.ShowDialog(this);
            oOBDecryptBidFileForm.Dispose();
        }

        #endregion

        #region 评标

        private void OnEOBPrepareToolStripMenuItemClick(object sender, EventArgs e)
        {
            EOBPrepareForm eOBPrepareForm = new EOBPrepareForm();
            eOBPrepareForm.ShowDialog(this);
            eOBPrepareForm.Dispose();
        }

        private void OnEOBCleanToolStripMenuItemClick(object sender, EventArgs e)
        {
            EOBCleanForm eOBClean = new EOBCleanForm();
            eOBClean.ShowDialog(this);
            eOBClean.Dispose();
        }

        private void OnEOBQualificationReviewToolStripMenuItemClick(object sender, EventArgs e)
        {
            EOBQualificationReviewForm eOBQualificationReviewForm = new EOBQualificationReviewForm();
            eOBQualificationReviewForm.ShowDialog(this);
            eOBQualificationReviewForm.Dispose();
        }

        private void OnEOBTechnologyReviewToolStripMenuItemClick(object sender, EventArgs e)
        {
            EOBTechnologyReviewForm eOBTechnologyReviewForm = new EOBTechnologyReviewForm();
            eOBTechnologyReviewForm.ShowDialog(this);
            eOBTechnologyReviewForm.Dispose();
        }

        private void OnEOBCommerceReviewToolStripMenuItemClick(object sender, EventArgs e)
        {
            EOBCommerceReviewForm eOBCommerceReviewForm = new EOBCommerceReviewForm();
            eOBCommerceReviewForm.ShowDialog(this);
            eOBCommerceReviewForm.Dispose();
        }

        private void OnReviewResultToolStripMenuItemClick(object sender, EventArgs e)
        {
            ReviewResultForm reviewResultForm = new ReviewResultForm();
            reviewResultForm.ShowDialog(this);
            reviewResultForm.Dispose();
        }
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
