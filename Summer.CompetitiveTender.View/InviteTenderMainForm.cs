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
    public partial class InviteTenderMainForm : MetroForm
    {
        #region 方法

        public InviteTenderMainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region 文件

        private void OnNewProjectToolStripMenuItemClick(object sender, EventArgs e)
        {
            EditProjectForm editProjectForm = new EditProjectForm();
            editProjectForm.ShowDialog(this);
            editProjectForm.Dispose();
        }

        private void OnOpenProjectToolStripMenuItemClick(object sender, EventArgs e)
        {
        }

        private void OnTemplateManageToolStripMenuItemClick(object sender, EventArgs e)
        {
            TemplateManageForm templateManageForm = new TemplateManageForm();
            templateManageForm.ShowDialog(this);
            templateManageForm.Dispose();
        }

        private void OnExitToolsStripMenuItemClick(object sender, EventArgs e)
        {
            this.Close();
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
