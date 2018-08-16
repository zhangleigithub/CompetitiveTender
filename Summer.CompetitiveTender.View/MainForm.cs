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

        #region 视图

        private void OnToolBarToolStripMenuItemClick(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void OnStatusBarToolStripMenuItemClick(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        #endregion

        #region 窗口

        private void OnCascadeToolStripMenuItemClick(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void OnTileVerticalToolStripMenuItemClick(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void OnTileHorizontalToolStripMenuItemClick(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void OnArrangeIconsToolStripMenuItemClick(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void OnCloseAllToolStripMenuItemClick(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
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
