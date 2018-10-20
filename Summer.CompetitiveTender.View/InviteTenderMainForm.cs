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
    public partial class InviteTenderMainForm : FormBase
    {
        #region 方法

        public InviteTenderMainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region 文件

        private void OnOpenProjectToolStripMenuItemClick(object sender, EventArgs e)
        {
            QueryITenderForm queryITenderForm = new QueryITenderForm();
            queryITenderForm.ShowDialog(this);
            queryITenderForm.Dispose();
        }

        private void OnProjectDiscussToolStripMenuItemClick(object sender, EventArgs e)
        {
            QueryITenderQuestionForm queryITenderQuestionForm = new QueryITenderQuestionForm();
            queryITenderQuestionForm.ShowDialog(this);
            queryITenderQuestionForm.Dispose();
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

        private void OnOpenOfBidsToolStripMenuItemClick(object sender, EventArgs e)
        {
            OOBQueryITenderForm oOBQueryITenderForm = new OOBQueryITenderForm();
            oOBQueryITenderForm.ShowDialog(this);
            oOBQueryITenderForm.Dispose();
        }

        #endregion

        #region 评标

        private void OnEvaluationOfBidsToolStripMenuItemClick(object sender, EventArgs e)
        {
            EOBManageForm eOBManageForm = new EOBManageForm();
            eOBManageForm.ShowDialog(this);
            eOBManageForm.Dispose();
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
