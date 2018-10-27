namespace Summer.CompetitiveTender.View.InviteTender
{
    partial class TemplateNodeManageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvTemplateNode = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSubNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtSort = new MetroFramework.Controls.MetroTextBox();
            this.cboCanModifyITender = new MetroFramework.Controls.MetroComboBox();
            this.cboClient = new MetroFramework.Controls.MetroComboBox();
            this.cboDRBid = new MetroFramework.Controls.MetroComboBox();
            this.cboCanModifyManage = new MetroFramework.Controls.MetroComboBox();
            this.cboDocumentType = new MetroFramework.Controls.MetroComboBox();
            this.cboProperty = new MetroFramework.Controls.MetroComboBox();
            this.cboCanDelete = new MetroFramework.Controls.MetroComboBox();
            this.cboCanModify = new MetroFramework.Controls.MetroComboBox();
            this.cboProjectType = new MetroFramework.Controls.MetroComboBox();
            this.txtFileName = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvTemplateNode);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Panel2.Controls.Add(this.txtSort);
            this.splitContainer1.Panel2.Controls.Add(this.cboCanModifyITender);
            this.splitContainer1.Panel2.Controls.Add(this.cboClient);
            this.splitContainer1.Panel2.Controls.Add(this.cboDRBid);
            this.splitContainer1.Panel2.Controls.Add(this.cboCanModifyManage);
            this.splitContainer1.Panel2.Controls.Add(this.cboDocumentType);
            this.splitContainer1.Panel2.Controls.Add(this.cboProperty);
            this.splitContainer1.Panel2.Controls.Add(this.cboCanDelete);
            this.splitContainer1.Panel2.Controls.Add(this.cboCanModify);
            this.splitContainer1.Panel2.Controls.Add(this.cboProjectType);
            this.splitContainer1.Panel2.Controls.Add(this.txtFileName);
            this.splitContainer1.Panel2.Controls.Add(this.txtName);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel12);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel11);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel10);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel9);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel8);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel7);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel6);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel5);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel4);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel3);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel2);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel1);
            this.splitContainer1.Size = new System.Drawing.Size(867, 508);
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.TabIndex = 0;
            // 
            // trvTemplateNode
            // 
            this.trvTemplateNode.ContextMenuStrip = this.contextMenuStrip1;
            this.trvTemplateNode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvTemplateNode.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trvTemplateNode.ItemHeight = 24;
            this.trvTemplateNode.Location = new System.Drawing.Point(0, 0);
            this.trvTemplateNode.Name = "trvTemplateNode";
            this.trvTemplateNode.Size = new System.Drawing.Size(289, 508);
            this.trvTemplateNode.TabIndex = 0;
            this.trvTemplateNode.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvTemplateNode_AfterSelect);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiSubNew,
            this.toolStripSeparator1,
            this.tsmiDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 76);
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.Size = new System.Drawing.Size(136, 22);
            this.tsmiNew.Text = "新增节点";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
            // 
            // tsmiSubNew
            // 
            this.tsmiSubNew.Name = "tsmiSubNew";
            this.tsmiSubNew.Size = new System.Drawing.Size(136, 22);
            this.tsmiSubNew.Text = "新增子节点";
            this.tsmiSubNew.Click += new System.EventHandler(this.tsmiSubNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(136, 22);
            this.tsmiDelete.Text = "删除节点";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(194, 463);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "提交";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSort
            // 
            this.txtSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSort.CustomButton.Image = null;
            this.txtSort.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtSort.CustomButton.Name = "";
            this.txtSort.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSort.CustomButton.TabIndex = 1;
            this.txtSort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSort.CustomButton.UseSelectable = true;
            this.txtSort.CustomButton.Visible = false;
            this.txtSort.Lines = new string[0];
            this.txtSort.Location = new System.Drawing.Point(194, 417);
            this.txtSort.MaxLength = 32767;
            this.txtSort.Name = "txtSort";
            this.txtSort.PasswordChar = '\0';
            this.txtSort.PromptText = "排序";
            this.txtSort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSort.SelectedText = "";
            this.txtSort.SelectionLength = 0;
            this.txtSort.SelectionStart = 0;
            this.txtSort.ShortcutsEnabled = true;
            this.txtSort.Size = new System.Drawing.Size(270, 23);
            this.txtSort.TabIndex = 23;
            this.txtSort.UseSelectable = true;
            this.txtSort.WaterMark = "排序";
            this.txtSort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboCanModifyITender
            // 
            this.cboCanModifyITender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCanModifyITender.FormattingEnabled = true;
            this.cboCanModifyITender.ItemHeight = 23;
            this.cboCanModifyITender.Location = new System.Drawing.Point(194, 380);
            this.cboCanModifyITender.Name = "cboCanModifyITender";
            this.cboCanModifyITender.Size = new System.Drawing.Size(270, 29);
            this.cboCanModifyITender.TabIndex = 22;
            this.cboCanModifyITender.UseSelectable = true;
            // 
            // cboClient
            // 
            this.cboClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboClient.FormattingEnabled = true;
            this.cboClient.ItemHeight = 23;
            this.cboClient.Location = new System.Drawing.Point(194, 343);
            this.cboClient.Name = "cboClient";
            this.cboClient.Size = new System.Drawing.Size(270, 29);
            this.cboClient.TabIndex = 21;
            this.cboClient.UseSelectable = true;
            // 
            // cboDRBid
            // 
            this.cboDRBid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDRBid.FormattingEnabled = true;
            this.cboDRBid.ItemHeight = 23;
            this.cboDRBid.Location = new System.Drawing.Point(194, 306);
            this.cboDRBid.Name = "cboDRBid";
            this.cboDRBid.Size = new System.Drawing.Size(270, 29);
            this.cboDRBid.TabIndex = 20;
            this.cboDRBid.UseSelectable = true;
            // 
            // cboCanModifyManage
            // 
            this.cboCanModifyManage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCanModifyManage.FormattingEnabled = true;
            this.cboCanModifyManage.ItemHeight = 23;
            this.cboCanModifyManage.Location = new System.Drawing.Point(194, 269);
            this.cboCanModifyManage.Name = "cboCanModifyManage";
            this.cboCanModifyManage.Size = new System.Drawing.Size(270, 29);
            this.cboCanModifyManage.TabIndex = 19;
            this.cboCanModifyManage.UseSelectable = true;
            // 
            // cboDocumentType
            // 
            this.cboDocumentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDocumentType.FormattingEnabled = true;
            this.cboDocumentType.ItemHeight = 23;
            this.cboDocumentType.Location = new System.Drawing.Point(194, 232);
            this.cboDocumentType.Name = "cboDocumentType";
            this.cboDocumentType.Size = new System.Drawing.Size(270, 29);
            this.cboDocumentType.TabIndex = 18;
            this.cboDocumentType.UseSelectable = true;
            // 
            // cboProperty
            // 
            this.cboProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProperty.FormattingEnabled = true;
            this.cboProperty.ItemHeight = 23;
            this.cboProperty.Location = new System.Drawing.Point(194, 195);
            this.cboProperty.Name = "cboProperty";
            this.cboProperty.Size = new System.Drawing.Size(270, 29);
            this.cboProperty.TabIndex = 17;
            this.cboProperty.UseSelectable = true;
            // 
            // cboCanDelete
            // 
            this.cboCanDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCanDelete.FormattingEnabled = true;
            this.cboCanDelete.ItemHeight = 23;
            this.cboCanDelete.Location = new System.Drawing.Point(194, 158);
            this.cboCanDelete.Name = "cboCanDelete";
            this.cboCanDelete.Size = new System.Drawing.Size(270, 29);
            this.cboCanDelete.TabIndex = 16;
            this.cboCanDelete.UseSelectable = true;
            // 
            // cboCanModify
            // 
            this.cboCanModify.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCanModify.FormattingEnabled = true;
            this.cboCanModify.ItemHeight = 23;
            this.cboCanModify.Location = new System.Drawing.Point(194, 121);
            this.cboCanModify.Name = "cboCanModify";
            this.cboCanModify.Size = new System.Drawing.Size(270, 29);
            this.cboCanModify.TabIndex = 15;
            this.cboCanModify.UseSelectable = true;
            // 
            // cboProjectType
            // 
            this.cboProjectType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProjectType.FormattingEnabled = true;
            this.cboProjectType.ItemHeight = 23;
            this.cboProjectType.Location = new System.Drawing.Point(194, 84);
            this.cboProjectType.Name = "cboProjectType";
            this.cboProjectType.Size = new System.Drawing.Size(270, 29);
            this.cboProjectType.TabIndex = 14;
            this.cboProjectType.UseSelectable = true;
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtFileName.CustomButton.Image = null;
            this.txtFileName.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtFileName.CustomButton.Name = "";
            this.txtFileName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFileName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFileName.CustomButton.TabIndex = 1;
            this.txtFileName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFileName.CustomButton.UseSelectable = true;
            this.txtFileName.CustomButton.Visible = false;
            this.txtFileName.Lines = new string[0];
            this.txtFileName.Location = new System.Drawing.Point(194, 53);
            this.txtFileName.MaxLength = 32767;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.PasswordChar = '\0';
            this.txtFileName.PromptText = "文件名称";
            this.txtFileName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFileName.SelectedText = "";
            this.txtFileName.SelectionLength = 0;
            this.txtFileName.SelectionStart = 0;
            this.txtFileName.ShortcutsEnabled = true;
            this.txtFileName.Size = new System.Drawing.Size(270, 23);
            this.txtFileName.TabIndex = 13;
            this.txtFileName.UseSelectable = true;
            this.txtFileName.WaterMark = "文件名称";
            this.txtFileName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFileName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(194, 22);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "名称";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(270, 23);
            this.txtName.TabIndex = 12;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "名称";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(151, 419);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(37, 19);
            this.metroLabel12.TabIndex = 11;
            this.metroLabel12.Text = "排序";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(95, 385);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(93, 19);
            this.metroLabel11.TabIndex = 10;
            this.metroLabel11.Text = "投标人可修改";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(137, 348);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(51, 19);
            this.metroLabel10.TabIndex = 9;
            this.metroLabel10.Text = "客户端";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(123, 311);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(65, 19);
            this.metroLabel9.TabIndex = 8;
            this.metroLabel9.Text = "代入招标";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(81, 274);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(107, 19);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "项目经理可修改";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(123, 237);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(65, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "文档类型";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(151, 200);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(37, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "属性";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(137, 163);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "可删除";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(137, 126);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "可修改";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(95, 89);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "投标文件类型";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(151, 24);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "名称";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(123, 55);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "文件名称";
            // 
            // TemplateNodeManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(907, 588);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TemplateNodeManageForm";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "模板节点";
            this.Shown += new System.EventHandler(this.TemplateNodeManageForm_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trvTemplateNode;
        private MetroFramework.Controls.MetroTextBox txtSort;
        private MetroFramework.Controls.MetroComboBox cboCanModifyITender;
        private MetroFramework.Controls.MetroComboBox cboClient;
        private MetroFramework.Controls.MetroComboBox cboDRBid;
        private MetroFramework.Controls.MetroComboBox cboCanModifyManage;
        private MetroFramework.Controls.MetroComboBox cboDocumentType;
        private MetroFramework.Controls.MetroComboBox cboProperty;
        private MetroFramework.Controls.MetroComboBox cboCanDelete;
        private MetroFramework.Controls.MetroComboBox cboCanModify;
        private MetroFramework.Controls.MetroComboBox cboProjectType;
        private MetroFramework.Controls.MetroTextBox txtFileName;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiSubNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
    }
}