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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewITenderTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewITenderFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewBidTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewBidFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewOpenOfBidsTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewEvaluationOfBidsTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQueryITenderTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQueryITenderFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQueryITenderFileQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQueryBidTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQueryBidFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQueryOpenOfBidsTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQueryEvaluationOfBidsTemplate = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsmiQuery,
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
            this.tsmiNewITenderTemplate,
            this.tsmiNewITenderFile,
            this.tsmiNewBidTemplate,
            this.tsmiNewBidFile,
            this.tsmiNewOpenOfBidsTemplate,
            this.tsmiNewEvaluationOfBidsTemplate,
            this.toolStripSeparator5,
            this.tsmiExit});
            this.tsmiFile.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(58, 21);
            this.tsmiFile.Text = "文件(&F)";
            // 
            // tsmiNewITenderTemplate
            // 
            this.tsmiNewITenderTemplate.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsmiNewITenderTemplate.Name = "tsmiNewITenderTemplate";
            this.tsmiNewITenderTemplate.Size = new System.Drawing.Size(148, 22);
            this.tsmiNewITenderTemplate.Text = "新建招标模板";
            this.tsmiNewITenderTemplate.Click += new System.EventHandler(this.OnNewITenderTemplateToolStripMenuItemClick);
            // 
            // tsmiNewITenderFile
            // 
            this.tsmiNewITenderFile.Name = "tsmiNewITenderFile";
            this.tsmiNewITenderFile.Size = new System.Drawing.Size(148, 22);
            this.tsmiNewITenderFile.Text = "新建招标文件";
            this.tsmiNewITenderFile.Click += new System.EventHandler(this.OnNewITenderFileToolStripMenuItemClick);
            // 
            // tsmiNewBidTemplate
            // 
            this.tsmiNewBidTemplate.Name = "tsmiNewBidTemplate";
            this.tsmiNewBidTemplate.Size = new System.Drawing.Size(148, 22);
            this.tsmiNewBidTemplate.Text = "新建投标模板";
            this.tsmiNewBidTemplate.Click += new System.EventHandler(this.OnNewBidTemplateToolStripMenuItemClick);
            // 
            // tsmiNewBidFile
            // 
            this.tsmiNewBidFile.Name = "tsmiNewBidFile";
            this.tsmiNewBidFile.Size = new System.Drawing.Size(148, 22);
            this.tsmiNewBidFile.Text = "新建投标文件";
            this.tsmiNewBidFile.Click += new System.EventHandler(this.OnNewBidFileToolStripMenuItemClick);
            // 
            // tsmiNewOpenOfBidsTemplate
            // 
            this.tsmiNewOpenOfBidsTemplate.Name = "tsmiNewOpenOfBidsTemplate";
            this.tsmiNewOpenOfBidsTemplate.Size = new System.Drawing.Size(148, 22);
            this.tsmiNewOpenOfBidsTemplate.Text = "新建开标模板";
            this.tsmiNewOpenOfBidsTemplate.Click += new System.EventHandler(this.OnNewOpenOfBidsTemplateToolStripMenuItemClick);
            // 
            // tsmiNewEvaluationOfBidsTemplate
            // 
            this.tsmiNewEvaluationOfBidsTemplate.Name = "tsmiNewEvaluationOfBidsTemplate";
            this.tsmiNewEvaluationOfBidsTemplate.Size = new System.Drawing.Size(148, 22);
            this.tsmiNewEvaluationOfBidsTemplate.Text = "新建评标模板";
            this.tsmiNewEvaluationOfBidsTemplate.Click += new System.EventHandler(this.OnNewEvaluationOfBidsTemplateToolStripMenuItemClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(145, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(148, 22);
            this.tsmiExit.Text = "退出(&X)";
            this.tsmiExit.Click += new System.EventHandler(this.OnExitToolsStripMenuItemClick);
            // 
            // tsmiQuery
            // 
            this.tsmiQuery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiQueryITenderTemplate,
            this.tsmiQueryITenderFile,
            this.tsmiQueryITenderFileQuestion,
            this.tsmiQueryBidTemplate,
            this.tsmiQueryBidFile,
            this.tsmiQueryOpenOfBidsTemplate,
            this.tsmiQueryEvaluationOfBidsTemplate});
            this.tsmiQuery.Name = "tsmiQuery";
            this.tsmiQuery.Size = new System.Drawing.Size(59, 21);
            this.tsmiQuery.Text = "查看(&E)";
            // 
            // tsmiQueryITenderTemplate
            // 
            this.tsmiQueryITenderTemplate.Name = "tsmiQueryITenderTemplate";
            this.tsmiQueryITenderTemplate.Size = new System.Drawing.Size(148, 22);
            this.tsmiQueryITenderTemplate.Text = "浏览招标模板";
            this.tsmiQueryITenderTemplate.Click += new System.EventHandler(this.OnQueryITenderTemplateToolStripMenuItemClick);
            // 
            // tsmiQueryITenderFile
            // 
            this.tsmiQueryITenderFile.Name = "tsmiQueryITenderFile";
            this.tsmiQueryITenderFile.Size = new System.Drawing.Size(148, 22);
            this.tsmiQueryITenderFile.Text = "浏览招标文件";
            this.tsmiQueryITenderFile.Click += new System.EventHandler(this.OnQueryITenderFileToolStripMenuItemClick);
            // 
            // tsmiQueryITenderFileQuestion
            // 
            this.tsmiQueryITenderFileQuestion.Name = "tsmiQueryITenderFileQuestion";
            this.tsmiQueryITenderFileQuestion.Size = new System.Drawing.Size(148, 22);
            this.tsmiQueryITenderFileQuestion.Text = "投标文件澄清";
            this.tsmiQueryITenderFileQuestion.Click += new System.EventHandler(this.OnQueryITenderFileQuestionToolStripMenuItemClick);
            // 
            // tsmiQueryBidTemplate
            // 
            this.tsmiQueryBidTemplate.Name = "tsmiQueryBidTemplate";
            this.tsmiQueryBidTemplate.Size = new System.Drawing.Size(148, 22);
            this.tsmiQueryBidTemplate.Text = "浏览投标模板";
            this.tsmiQueryBidTemplate.Click += new System.EventHandler(this.OnQueryBidTemplateToolStripMenuItemClick);
            // 
            // tsmiQueryBidFile
            // 
            this.tsmiQueryBidFile.Name = "tsmiQueryBidFile";
            this.tsmiQueryBidFile.Size = new System.Drawing.Size(148, 22);
            this.tsmiQueryBidFile.Text = "浏览投标文件";
            this.tsmiQueryBidFile.Click += new System.EventHandler(this.OnQueryBidFileToolStripMenuItemClick);
            // 
            // tsmiQueryOpenOfBidsTemplate
            // 
            this.tsmiQueryOpenOfBidsTemplate.Name = "tsmiQueryOpenOfBidsTemplate";
            this.tsmiQueryOpenOfBidsTemplate.Size = new System.Drawing.Size(148, 22);
            this.tsmiQueryOpenOfBidsTemplate.Text = "浏览开标模板";
            this.tsmiQueryOpenOfBidsTemplate.Click += new System.EventHandler(this.OnQueryOpenOfBidsTemplateToolStripMenuItemClick);
            // 
            // tsmiQueryEvaluationOfBidsTemplate
            // 
            this.tsmiQueryEvaluationOfBidsTemplate.Name = "tsmiQueryEvaluationOfBidsTemplate";
            this.tsmiQueryEvaluationOfBidsTemplate.Size = new System.Drawing.Size(148, 22);
            this.tsmiQueryEvaluationOfBidsTemplate.Text = "浏览评标模板";
            this.tsmiQueryEvaluationOfBidsTemplate.Click += new System.EventHandler(this.OnQueryEvaluationOfBidsTemplateToolStripMenuItemClick);
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
            this.tsmiOOBCheckIn.Size = new System.Drawing.Size(152, 22);
            this.tsmiOOBCheckIn.Text = "在线签到";
            this.tsmiOOBCheckIn.Click += new System.EventHandler(this.OnOOBCheckInToolStripMenuItemClick);
            // 
            // tsmiOOBDecryptBidFile
            // 
            this.tsmiOOBDecryptBidFile.Name = "tsmiOOBDecryptBidFile";
            this.tsmiOOBDecryptBidFile.Size = new System.Drawing.Size(152, 22);
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
            this.tsmiEOBPrepare.Size = new System.Drawing.Size(152, 22);
            this.tsmiEOBPrepare.Text = "评标准备";
            this.tsmiEOBPrepare.Click += new System.EventHandler(this.OnEOBPrepareToolStripMenuItemClick);
            // 
            // tsmiEOBClean
            // 
            this.tsmiEOBClean.Name = "tsmiEOBClean";
            this.tsmiEOBClean.Size = new System.Drawing.Size(152, 22);
            this.tsmiEOBClean.Text = "清标";
            this.tsmiEOBClean.Click += new System.EventHandler(this.OnEOBCleanToolStripMenuItemClick);
            // 
            // tsmiEOBQualificationReview
            // 
            this.tsmiEOBQualificationReview.Name = "tsmiEOBQualificationReview";
            this.tsmiEOBQualificationReview.Size = new System.Drawing.Size(152, 22);
            this.tsmiEOBQualificationReview.Text = "资格评审";
            this.tsmiEOBQualificationReview.Click += new System.EventHandler(this.OnEOBQualificationReviewToolStripMenuItemClick);
            // 
            // tsmiEOBTechnologyReview
            // 
            this.tsmiEOBTechnologyReview.Name = "tsmiEOBTechnologyReview";
            this.tsmiEOBTechnologyReview.Size = new System.Drawing.Size(152, 22);
            this.tsmiEOBTechnologyReview.Text = "技术标评审";
            this.tsmiEOBTechnologyReview.Click += new System.EventHandler(this.OnEOBTechnologyReviewToolStripMenuItemClick);
            // 
            // tsmiEOBCommerceReview
            // 
            this.tsmiEOBCommerceReview.Name = "tsmiEOBCommerceReview";
            this.tsmiEOBCommerceReview.Size = new System.Drawing.Size(152, 22);
            this.tsmiEOBCommerceReview.Text = "商务标评审";
            this.tsmiEOBCommerceReview.Click += new System.EventHandler(this.OnEOBCommerceReviewToolStripMenuItemClick);
            // 
            // tsmiReviewResult
            // 
            this.tsmiReviewResult.Name = "tsmiReviewResult";
            this.tsmiReviewResult.Size = new System.Drawing.Size(152, 22);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 439);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
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
        private System.Windows.Forms.ToolStripMenuItem tsmiNewITenderTemplate;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewITenderFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewBidTemplate;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewBidFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewOpenOfBidsTemplate;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewEvaluationOfBidsTemplate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;

        private System.Windows.Forms.ToolStripMenuItem tsmiQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmiQueryITenderTemplate;
        private System.Windows.Forms.ToolStripMenuItem tsmiQueryITenderFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiQueryBidTemplate;
        private System.Windows.Forms.ToolStripMenuItem tsmiQueryBidFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiQueryOpenOfBidsTemplate;
        private System.Windows.Forms.ToolStripMenuItem tsmiQueryEvaluationOfBidsTemplate;

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
        private System.Windows.Forms.ToolStripMenuItem tsmiQueryITenderFileQuestion;
    }
}



