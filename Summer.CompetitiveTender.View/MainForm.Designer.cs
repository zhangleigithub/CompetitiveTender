namespace Summer.CompetitiveTender.View
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewITenderTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewITenderFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewBidFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQueryITenderTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQueryITenderFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQueryBidFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenOfBids = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEvaluationOfBids = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiArrangeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbNewITenderTemplate = new System.Windows.Forms.ToolStripButton();
            this.tsbNewITenderFile = new System.Windows.Forms.ToolStripButton();
            this.tsbNewBidFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiQuery,
            this.tsmiOpenOfBids,
            this.tsmiEvaluationOfBids,
            this.tsmiView,
            this.tsmiWindows,
            this.tsmiHelp});
            this.menuStrip.Location = new System.Drawing.Point(20, 60);
            this.menuStrip.MdiWindowListItem = this.tsmiWindows;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(592, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewITenderTemplate,
            this.tsmiNewITenderFile,
            this.tsmiNewBidFile,
            this.toolStripSeparator5,
            this.tsmiExit});
            this.tsmiFile.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(58, 21);
            this.tsmiFile.Text = "文件(&F)";
            // 
            // tsmiNewITenderTemplate
            // 
            this.tsmiNewITenderTemplate.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNewITenderTemplate.Image")));
            this.tsmiNewITenderTemplate.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsmiNewITenderTemplate.Name = "tsmiNewITenderTemplate";
            this.tsmiNewITenderTemplate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiNewITenderTemplate.Size = new System.Drawing.Size(213, 22);
            this.tsmiNewITenderTemplate.Text = "新建招标模板(&N)";
            this.tsmiNewITenderTemplate.Click += new System.EventHandler(this.OnNewITenderTemplateToolStripMenuItemClick);
            // 
            // tsmiNewITenderFile
            // 
            this.tsmiNewITenderFile.Name = "tsmiNewITenderFile";
            this.tsmiNewITenderFile.Size = new System.Drawing.Size(213, 22);
            this.tsmiNewITenderFile.Text = "新建招标文件";
            this.tsmiNewITenderFile.Click += new System.EventHandler(this.OnNewITenderFileToolStripMenuItemClick);
            // 
            // tsmiNewBidFile
            // 
            this.tsmiNewBidFile.Name = "tsmiNewBidFile";
            this.tsmiNewBidFile.Size = new System.Drawing.Size(213, 22);
            this.tsmiNewBidFile.Text = "新建投标文件";
            this.tsmiNewBidFile.Click += new System.EventHandler(this.OnNewBidFileToolStripMenuItemClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(210, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(213, 22);
            this.tsmiExit.Text = "退出(&X)";
            this.tsmiExit.Click += new System.EventHandler(this.OnExitToolsStripMenuItemClick);
            // 
            // tsmiQuery
            // 
            this.tsmiQuery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiQueryITenderTemplate,
            this.tsmiQueryITenderFile,
            this.tsmiQueryBidFile});
            this.tsmiQuery.Name = "tsmiQuery";
            this.tsmiQuery.Size = new System.Drawing.Size(59, 21);
            this.tsmiQuery.Text = "查看(&E)";
            // 
            // tsmiQueryITenderTemplate
            // 
            this.tsmiQueryITenderTemplate.Name = "tsmiQueryITenderTemplate";
            this.tsmiQueryITenderTemplate.Size = new System.Drawing.Size(152, 22);
            this.tsmiQueryITenderTemplate.Text = "查询招标模板";
            this.tsmiQueryITenderTemplate.Click += new System.EventHandler(this.OnQueryITenderTemplateToolStripMenuItemClick);
            // 
            // tsmiQueryITenderFile
            // 
            this.tsmiQueryITenderFile.Name = "tsmiQueryITenderFile";
            this.tsmiQueryITenderFile.Size = new System.Drawing.Size(152, 22);
            this.tsmiQueryITenderFile.Text = "查询招标文件";
            // 
            // tsmiQueryBidFile
            // 
            this.tsmiQueryBidFile.Name = "tsmiQueryBidFile";
            this.tsmiQueryBidFile.Size = new System.Drawing.Size(152, 22);
            this.tsmiQueryBidFile.Text = "查询投标文件";
            // 
            // tsmiOpenOfBids
            // 
            this.tsmiOpenOfBids.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.tsmiOpenOfBids.Name = "tsmiOpenOfBids";
            this.tsmiOpenOfBids.Size = new System.Drawing.Size(62, 21);
            this.tsmiOpenOfBids.Text = "开标(&O)";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.optionsToolStripMenuItem.Text = "选项(&O)";
            // 
            // tsmiEvaluationOfBids
            // 
            this.tsmiEvaluationOfBids.Name = "tsmiEvaluationOfBids";
            this.tsmiEvaluationOfBids.Size = new System.Drawing.Size(59, 21);
            this.tsmiEvaluationOfBids.Text = "评标(&P)";
            // 
            // tsmiView
            // 
            this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(60, 21);
            this.tsmiView.Text = "视图(&V)";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.toolBarToolStripMenuItem.Text = "工具栏(&T)";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.OnToolBarToolStripMenuItemClick);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.statusBarToolStripMenuItem.Text = "状态栏(&S)";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.OnStatusBarToolStripMenuItemClick);
            // 
            // tsmiWindows
            // 
            this.tsmiWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCascade,
            this.tsmiTileVertical,
            this.tsmiTileHorizontal,
            this.tsmiCloseAll,
            this.tsmiArrangeIcons});
            this.tsmiWindows.Name = "tsmiWindows";
            this.tsmiWindows.Size = new System.Drawing.Size(64, 21);
            this.tsmiWindows.Text = "窗口(&W)";
            // 
            // tsmiCascade
            // 
            this.tsmiCascade.Name = "tsmiCascade";
            this.tsmiCascade.Size = new System.Drawing.Size(141, 22);
            this.tsmiCascade.Text = "层叠(&C)";
            this.tsmiCascade.Click += new System.EventHandler(this.OnCascadeToolStripMenuItemClick);
            // 
            // tsmiTileVertical
            // 
            this.tsmiTileVertical.Name = "tsmiTileVertical";
            this.tsmiTileVertical.Size = new System.Drawing.Size(141, 22);
            this.tsmiTileVertical.Text = "垂直平铺(&V)";
            this.tsmiTileVertical.Click += new System.EventHandler(this.OnTileVerticalToolStripMenuItemClick);
            // 
            // tsmiTileHorizontal
            // 
            this.tsmiTileHorizontal.Name = "tsmiTileHorizontal";
            this.tsmiTileHorizontal.Size = new System.Drawing.Size(141, 22);
            this.tsmiTileHorizontal.Text = "水平平铺(&H)";
            this.tsmiTileHorizontal.Click += new System.EventHandler(this.OnTileHorizontalToolStripMenuItemClick);
            // 
            // tsmiCloseAll
            // 
            this.tsmiCloseAll.Name = "tsmiCloseAll";
            this.tsmiCloseAll.Size = new System.Drawing.Size(141, 22);
            this.tsmiCloseAll.Text = "全部关闭(&L)";
            this.tsmiCloseAll.Click += new System.EventHandler(this.OnCloseAllToolStripMenuItemClick);
            // 
            // tsmiArrangeIcons
            // 
            this.tsmiArrangeIcons.Name = "tsmiArrangeIcons";
            this.tsmiArrangeIcons.Size = new System.Drawing.Size(141, 22);
            this.tsmiArrangeIcons.Text = "排列图标(&A)";
            this.tsmiArrangeIcons.Click += new System.EventHandler(this.OnArrangeIconsToolStripMenuItemClick);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIndex,
            this.toolStripSeparator8,
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(61, 21);
            this.tsmiHelp.Text = "帮助(&H)";
            // 
            // tsmiIndex
            // 
            this.tsmiIndex.Image = ((System.Drawing.Image)(resources.GetObject("tsmiIndex.Image")));
            this.tsmiIndex.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsmiIndex.Name = "tsmiIndex";
            this.tsmiIndex.Size = new System.Drawing.Size(142, 22);
            this.tsmiIndex.Text = "索引(&I)";
            this.tsmiIndex.Click += new System.EventHandler(this.OnIndexToolStripMenuItemClick);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(139, 6);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(142, 22);
            this.tsmiAbout.Text = "关于(&A) ... ...";
            this.tsmiAbout.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewITenderTemplate,
            this.tsbNewITenderFile,
            this.tsbNewBidFile,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(20, 85);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(592, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // tsbNewITenderTemplate
            // 
            this.tsbNewITenderTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewITenderTemplate.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewITenderTemplate.Image")));
            this.tsbNewITenderTemplate.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbNewITenderTemplate.Name = "tsbNewITenderTemplate";
            this.tsbNewITenderTemplate.Size = new System.Drawing.Size(23, 22);
            this.tsbNewITenderTemplate.Text = "新建招标模板";
            this.tsbNewITenderTemplate.Click += new System.EventHandler(this.OnNewITenderTemplateToolStripMenuItemClick);
            // 
            // tsbNewITenderFile
            // 
            this.tsbNewITenderFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewITenderFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewITenderFile.Image")));
            this.tsbNewITenderFile.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbNewITenderFile.Name = "tsbNewITenderFile";
            this.tsbNewITenderFile.Size = new System.Drawing.Size(23, 22);
            this.tsbNewITenderFile.Text = "新建招标文件";
            // 
            // tsbNewBidFile
            // 
            this.tsbNewBidFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewBidFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewBidFile.Image")));
            this.tsbNewBidFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewBidFile.Name = "tsbNewBidFile";
            this.tsbNewBidFile.Size = new System.Drawing.Size(23, 22);
            this.tsbNewBidFile.Text = "新建投标文件";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "帮助";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslState});
            this.statusStrip.Location = new System.Drawing.Point(20, 378);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(592, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // tsslState
            // 
            this.tsslState.Name = "tsslState";
            this.tsslState.Size = new System.Drawing.Size(32, 17);
            this.tsslState.Text = "状态";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 418);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 18);
            this.Text = "招投标工具";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel tsslState;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewITenderTemplate;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenOfBids;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiWindows;
        private System.Windows.Forms.ToolStripMenuItem tsmiCascade;
        private System.Windows.Forms.ToolStripMenuItem tsmiTileVertical;
        private System.Windows.Forms.ToolStripMenuItem tsmiCloseAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiArrangeIcons;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiIndex;
        private System.Windows.Forms.ToolStripButton tsbNewITenderTemplate;
        private System.Windows.Forms.ToolStripButton tsbNewITenderFile;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tsmiEvaluationOfBids;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewITenderFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewBidFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiQueryITenderTemplate;
        private System.Windows.Forms.ToolStripMenuItem tsmiQueryITenderFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiQueryBidFile;
        private System.Windows.Forms.ToolStripButton tsbNewBidFile;
    }
}



