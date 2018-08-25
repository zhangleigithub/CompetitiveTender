namespace Summer.CompetitiveTender.View
{
    partial class InviteTenderMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InviteTenderMainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.tssFile1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTemplateManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tssFile2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenOfBids = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOOBCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOOBDecryptBidFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEvaluationOfBids = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEOBPrepare = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEOBClean = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEOBQualificationReview = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEOBTechnologyReview = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEOBCommerceReview = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReviewResult = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiOpenOfBids,
            this.tsmiEvaluationOfBids,
            this.tsmiHelp});
            this.menuStrip.Location = new System.Drawing.Point(20, 60);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(718, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewProject,
            this.tsmiOpenProject,
            this.tssFile1,
            this.tsmiTemplateManage,
            this.tssFile2,
            this.tsmiExit});
            this.tsmiFile.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(58, 21);
            this.tsmiFile.Text = "文件(&F)";
            // 
            // tsmiNewProject
            // 
            this.tsmiNewProject.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsmiNewProject.Name = "tsmiNewProject";
            this.tsmiNewProject.Size = new System.Drawing.Size(152, 22);
            this.tsmiNewProject.Text = "新建项目";
            this.tsmiNewProject.Click += new System.EventHandler(this.OnNewProjectToolStripMenuItemClick);
            // 
            // tsmiOpenProject
            // 
            this.tsmiOpenProject.Name = "tsmiOpenProject";
            this.tsmiOpenProject.Size = new System.Drawing.Size(152, 22);
            this.tsmiOpenProject.Text = "打开项目";
            this.tsmiOpenProject.Click += new System.EventHandler(this.OnOpenProjectToolStripMenuItemClick);
            // 
            // tssFile1
            // 
            this.tssFile1.Name = "tssFile1";
            this.tssFile1.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmiTemplateManage
            // 
            this.tsmiTemplateManage.Name = "tsmiTemplateManage";
            this.tsmiTemplateManage.Size = new System.Drawing.Size(152, 22);
            this.tsmiTemplateManage.Text = "模板管理";
            this.tsmiTemplateManage.Click += new System.EventHandler(this.OnTemplateManageToolStripMenuItemClick);
            // 
            // tssFile2
            // 
            this.tssFile2.Name = "tssFile2";
            this.tssFile2.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(152, 22);
            this.tsmiExit.Text = "退出(&X)";
            this.tsmiExit.Click += new System.EventHandler(this.OnExitToolsStripMenuItemClick);
            // 
            // tsmiOpenOfBids
            // 
            this.tsmiOpenOfBids.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOOBCheckIn,
            this.tsmiOOBDecryptBidFile});
            this.tsmiOpenOfBids.Name = "tsmiOpenOfBids";
            this.tsmiOpenOfBids.Size = new System.Drawing.Size(62, 21);
            this.tsmiOpenOfBids.Text = "开标(&O)";
            // 
            // tsmiOOBCheckIn
            // 
            this.tsmiOOBCheckIn.Name = "tsmiOOBCheckIn";
            this.tsmiOOBCheckIn.Size = new System.Drawing.Size(148, 22);
            this.tsmiOOBCheckIn.Text = "在线签到";
            this.tsmiOOBCheckIn.Click += new System.EventHandler(this.OnOOBCheckInToolStripMenuItemClick);
            // 
            // tsmiOOBDecryptBidFile
            // 
            this.tsmiOOBDecryptBidFile.Name = "tsmiOOBDecryptBidFile";
            this.tsmiOOBDecryptBidFile.Size = new System.Drawing.Size(148, 22);
            this.tsmiOOBDecryptBidFile.Text = "解密投标文件";
            this.tsmiOOBDecryptBidFile.Click += new System.EventHandler(this.OnOOBDecryptBidFileToolStripMenuItemClick);
            // 
            // tsmiEvaluationOfBids
            // 
            this.tsmiEvaluationOfBids.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEOBPrepare,
            this.tsmiEOBClean,
            this.tsmiEOBQualificationReview,
            this.tsmiEOBTechnologyReview,
            this.tsmiEOBCommerceReview,
            this.tsmiReviewResult});
            this.tsmiEvaluationOfBids.Name = "tsmiEvaluationOfBids";
            this.tsmiEvaluationOfBids.Size = new System.Drawing.Size(59, 21);
            this.tsmiEvaluationOfBids.Text = "评标(&P)";
            // 
            // tsmiEOBPrepare
            // 
            this.tsmiEOBPrepare.Name = "tsmiEOBPrepare";
            this.tsmiEOBPrepare.Size = new System.Drawing.Size(136, 22);
            this.tsmiEOBPrepare.Text = "评标准备";
            this.tsmiEOBPrepare.Click += new System.EventHandler(this.OnEOBPrepareToolStripMenuItemClick);
            // 
            // tsmiEOBClean
            // 
            this.tsmiEOBClean.Name = "tsmiEOBClean";
            this.tsmiEOBClean.Size = new System.Drawing.Size(136, 22);
            this.tsmiEOBClean.Text = "清标";
            this.tsmiEOBClean.Click += new System.EventHandler(this.OnEOBCleanToolStripMenuItemClick);
            // 
            // tsmiEOBQualificationReview
            // 
            this.tsmiEOBQualificationReview.Name = "tsmiEOBQualificationReview";
            this.tsmiEOBQualificationReview.Size = new System.Drawing.Size(136, 22);
            this.tsmiEOBQualificationReview.Text = "资格评审";
            this.tsmiEOBQualificationReview.Click += new System.EventHandler(this.OnEOBQualificationReviewToolStripMenuItemClick);
            // 
            // tsmiEOBTechnologyReview
            // 
            this.tsmiEOBTechnologyReview.Name = "tsmiEOBTechnologyReview";
            this.tsmiEOBTechnologyReview.Size = new System.Drawing.Size(136, 22);
            this.tsmiEOBTechnologyReview.Text = "技术标评审";
            this.tsmiEOBTechnologyReview.Click += new System.EventHandler(this.OnEOBTechnologyReviewToolStripMenuItemClick);
            // 
            // tsmiEOBCommerceReview
            // 
            this.tsmiEOBCommerceReview.Name = "tsmiEOBCommerceReview";
            this.tsmiEOBCommerceReview.Size = new System.Drawing.Size(136, 22);
            this.tsmiEOBCommerceReview.Text = "商务标评审";
            this.tsmiEOBCommerceReview.Click += new System.EventHandler(this.OnEOBCommerceReviewToolStripMenuItemClick);
            // 
            // tsmiReviewResult
            // 
            this.tsmiReviewResult.Name = "tsmiReviewResult";
            this.tsmiReviewResult.Size = new System.Drawing.Size(136, 22);
            this.tsmiReviewResult.Text = "评审结果";
            this.tsmiReviewResult.Click += new System.EventHandler(this.OnReviewResultToolStripMenuItemClick);
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
            // InviteTenderMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 439);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "InviteTenderMainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 18);
            this.Text = "招投标工具";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;

        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewProject;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenProject;
        private System.Windows.Forms.ToolStripSeparator tssFile1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;

        private System.Windows.Forms.ToolStripMenuItem tsmiOpenOfBids;
        private System.Windows.Forms.ToolStripMenuItem tsmiOOBCheckIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiOOBDecryptBidFile;

        private System.Windows.Forms.ToolStripMenuItem tsmiEvaluationOfBids;
        private System.Windows.Forms.ToolStripMenuItem tsmiEOBPrepare;
        private System.Windows.Forms.ToolStripMenuItem tsmiEOBClean;
        private System.Windows.Forms.ToolStripMenuItem tsmiEOBQualificationReview;
        private System.Windows.Forms.ToolStripMenuItem tsmiEOBTechnologyReview;
        private System.Windows.Forms.ToolStripMenuItem tsmiEOBCommerceReview;
        private System.Windows.Forms.ToolStripMenuItem tsmiReviewResult;

        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiIndex;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiTemplateManage;
        private System.Windows.Forms.ToolStripSeparator tssFile2;
    }
}



