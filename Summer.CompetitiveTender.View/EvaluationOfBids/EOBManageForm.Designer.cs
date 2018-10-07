namespace Summer.CompetitiveTender.View.EvaluationOfBids
{
    partial class EOBManageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtProjectCode = new MetroFramework.Controls.MetroTextBox();
            this.txtProjectName = new MetroFramework.Controls.MetroTextBox();
            this.txtSectionCode = new MetroFramework.Controls.MetroTextBox();
            this.txtSectionName = new MetroFramework.Controls.MetroTextBox();
            this.btnQuery = new MetroFramework.Controls.MetroButton();
            this.grdProject = new MetroFramework.Controls.MetroGrid();
            this.btnRecJudges = new MetroFramework.Controls.MetroButton();
            this.btnBidEval = new MetroFramework.Controls.MetroButton();
            this.btnDownloadITenderFile = new MetroFramework.Controls.MetroButton();
            this.btnResult = new MetroFramework.Controls.MetroButton();
            this.btnBidEvalReport = new MetroFramework.Controls.MetroButton();
            this.colProjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSectionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectEvalState = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdProject)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "招标项目编号";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(51, 96);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "标段编号";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(345, 65);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "招标项目名称";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(373, 96);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "标段名称";
            // 
            // txtProjectCode
            // 
            // 
            // 
            // 
            this.txtProjectCode.CustomButton.Image = null;
            this.txtProjectCode.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txtProjectCode.CustomButton.Name = "";
            this.txtProjectCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProjectCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProjectCode.CustomButton.TabIndex = 1;
            this.txtProjectCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProjectCode.CustomButton.UseSelectable = true;
            this.txtProjectCode.CustomButton.Visible = false;
            this.txtProjectCode.Lines = new string[0];
            this.txtProjectCode.Location = new System.Drawing.Point(122, 63);
            this.txtProjectCode.MaxLength = 32767;
            this.txtProjectCode.Name = "txtProjectCode";
            this.txtProjectCode.PasswordChar = '\0';
            this.txtProjectCode.PromptText = "招标项目编号";
            this.txtProjectCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProjectCode.SelectedText = "";
            this.txtProjectCode.SelectionLength = 0;
            this.txtProjectCode.SelectionStart = 0;
            this.txtProjectCode.ShortcutsEnabled = true;
            this.txtProjectCode.Size = new System.Drawing.Size(217, 23);
            this.txtProjectCode.TabIndex = 4;
            this.txtProjectCode.UseSelectable = true;
            this.txtProjectCode.WaterMark = "招标项目编号";
            this.txtProjectCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProjectCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtProjectName.CustomButton.Image = null;
            this.txtProjectName.CustomButton.Location = new System.Drawing.Point(433, 1);
            this.txtProjectName.CustomButton.Name = "";
            this.txtProjectName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProjectName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProjectName.CustomButton.TabIndex = 1;
            this.txtProjectName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProjectName.CustomButton.UseSelectable = true;
            this.txtProjectName.CustomButton.Visible = false;
            this.txtProjectName.Lines = new string[0];
            this.txtProjectName.Location = new System.Drawing.Point(444, 63);
            this.txtProjectName.MaxLength = 32767;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.PasswordChar = '\0';
            this.txtProjectName.PromptText = "招标项目名称";
            this.txtProjectName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProjectName.SelectedText = "";
            this.txtProjectName.SelectionLength = 0;
            this.txtProjectName.SelectionStart = 0;
            this.txtProjectName.ShortcutsEnabled = true;
            this.txtProjectName.Size = new System.Drawing.Size(455, 23);
            this.txtProjectName.TabIndex = 5;
            this.txtProjectName.UseSelectable = true;
            this.txtProjectName.WaterMark = "招标项目名称";
            this.txtProjectName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProjectName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSectionCode
            // 
            // 
            // 
            // 
            this.txtSectionCode.CustomButton.Image = null;
            this.txtSectionCode.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txtSectionCode.CustomButton.Name = "";
            this.txtSectionCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSectionCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSectionCode.CustomButton.TabIndex = 1;
            this.txtSectionCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSectionCode.CustomButton.UseSelectable = true;
            this.txtSectionCode.CustomButton.Visible = false;
            this.txtSectionCode.Lines = new string[0];
            this.txtSectionCode.Location = new System.Drawing.Point(122, 94);
            this.txtSectionCode.MaxLength = 32767;
            this.txtSectionCode.Name = "txtSectionCode";
            this.txtSectionCode.PasswordChar = '\0';
            this.txtSectionCode.PromptText = "标段编号";
            this.txtSectionCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSectionCode.SelectedText = "";
            this.txtSectionCode.SelectionLength = 0;
            this.txtSectionCode.SelectionStart = 0;
            this.txtSectionCode.ShortcutsEnabled = true;
            this.txtSectionCode.Size = new System.Drawing.Size(217, 23);
            this.txtSectionCode.TabIndex = 6;
            this.txtSectionCode.UseSelectable = true;
            this.txtSectionCode.WaterMark = "标段编号";
            this.txtSectionCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSectionCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSectionName
            // 
            this.txtSectionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSectionName.CustomButton.Image = null;
            this.txtSectionName.CustomButton.Location = new System.Drawing.Point(433, 1);
            this.txtSectionName.CustomButton.Name = "";
            this.txtSectionName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSectionName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSectionName.CustomButton.TabIndex = 1;
            this.txtSectionName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSectionName.CustomButton.UseSelectable = true;
            this.txtSectionName.CustomButton.Visible = false;
            this.txtSectionName.Lines = new string[0];
            this.txtSectionName.Location = new System.Drawing.Point(444, 94);
            this.txtSectionName.MaxLength = 32767;
            this.txtSectionName.Name = "txtSectionName";
            this.txtSectionName.PasswordChar = '\0';
            this.txtSectionName.PromptText = "标段名称";
            this.txtSectionName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSectionName.SelectedText = "";
            this.txtSectionName.SelectionLength = 0;
            this.txtSectionName.SelectionStart = 0;
            this.txtSectionName.ShortcutsEnabled = true;
            this.txtSectionName.Size = new System.Drawing.Size(455, 23);
            this.txtSectionName.TabIndex = 7;
            this.txtSectionName.UseSelectable = true;
            this.txtSectionName.WaterMark = "标段名称";
            this.txtSectionName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSectionName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Location = new System.Drawing.Point(824, 123);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 8;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseSelectable = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // grdProject
            // 
            this.grdProject.AllowUserToAddRows = false;
            this.grdProject.AllowUserToDeleteRows = false;
            this.grdProject.AllowUserToResizeRows = false;
            this.grdProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grdProject.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdProject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdProject.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdProject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProjectCode,
            this.colProjectName,
            this.colSectionCode,
            this.colSectionName,
            this.colProjectEvalState});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdProject.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdProject.EnableHeadersVisualStyles = false;
            this.grdProject.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdProject.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdProject.Location = new System.Drawing.Point(23, 152);
            this.grdProject.MultiSelect = false;
            this.grdProject.Name = "grdProject";
            this.grdProject.ReadOnly = true;
            this.grdProject.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProject.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdProject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdProject.RowTemplate.Height = 23;
            this.grdProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProject.Size = new System.Drawing.Size(876, 325);
            this.grdProject.TabIndex = 9;
            // 
            // btnRecJudges
            // 
            this.btnRecJudges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRecJudges.Location = new System.Drawing.Point(23, 483);
            this.btnRecJudges.Name = "btnRecJudges";
            this.btnRecJudges.Size = new System.Drawing.Size(98, 23);
            this.btnRecJudges.TabIndex = 10;
            this.btnRecJudges.Text = "推荐评委主任";
            this.btnRecJudges.UseSelectable = true;
            this.btnRecJudges.Click += new System.EventHandler(this.btnRecJudges_Click);
            // 
            // btnBidEval
            // 
            this.btnBidEval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBidEval.Location = new System.Drawing.Point(137, 483);
            this.btnBidEval.Name = "btnBidEval";
            this.btnBidEval.Size = new System.Drawing.Size(94, 23);
            this.btnBidEval.TabIndex = 11;
            this.btnBidEval.Text = "评    标";
            this.btnBidEval.UseSelectable = true;
            this.btnBidEval.Click += new System.EventHandler(this.btnBidEval_Click);
            // 
            // btnDownloadITenderFile
            // 
            this.btnDownloadITenderFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDownloadITenderFile.Location = new System.Drawing.Point(429, 483);
            this.btnDownloadITenderFile.Name = "btnDownloadITenderFile";
            this.btnDownloadITenderFile.Size = new System.Drawing.Size(75, 23);
            this.btnDownloadITenderFile.TabIndex = 12;
            this.btnDownloadITenderFile.Text = "下载文件";
            this.btnDownloadITenderFile.UseSelectable = true;
            this.btnDownloadITenderFile.Click += new System.EventHandler(this.btnDownloadITenderFile_Click);
            // 
            // btnResult
            // 
            this.btnResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResult.Location = new System.Drawing.Point(338, 483);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 14;
            this.btnResult.Text = "查看结果";
            this.btnResult.UseSelectable = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnBidEvalReport
            // 
            this.btnBidEvalReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBidEvalReport.Location = new System.Drawing.Point(247, 483);
            this.btnBidEvalReport.Name = "btnBidEvalReport";
            this.btnBidEvalReport.Size = new System.Drawing.Size(75, 23);
            this.btnBidEvalReport.TabIndex = 15;
            this.btnBidEvalReport.Text = "评标报告";
            this.btnBidEvalReport.UseSelectable = true;
            this.btnBidEvalReport.Click += new System.EventHandler(this.btnBidEvalReport_Click);
            // 
            // colProjectCode
            // 
            this.colProjectCode.HeaderText = "招标项目编号";
            this.colProjectCode.Name = "colProjectCode";
            this.colProjectCode.ReadOnly = true;
            this.colProjectCode.Width = 108;
            // 
            // colProjectName
            // 
            this.colProjectName.HeaderText = "招标项目名称";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.ReadOnly = true;
            this.colProjectName.Width = 108;
            // 
            // colSectionCode
            // 
            this.colSectionCode.HeaderText = "标段编号";
            this.colSectionCode.Name = "colSectionCode";
            this.colSectionCode.ReadOnly = true;
            this.colSectionCode.Width = 82;
            // 
            // colSectionName
            // 
            this.colSectionName.HeaderText = "标段名称";
            this.colSectionName.Name = "colSectionName";
            this.colSectionName.ReadOnly = true;
            this.colSectionName.Width = 82;
            // 
            // colProjectEvalState
            // 
            this.colProjectEvalState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProjectEvalState.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colProjectEvalState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colProjectEvalState.HeaderText = "评标状态";
            this.colProjectEvalState.Name = "colProjectEvalState";
            this.colProjectEvalState.ReadOnly = true;
            // 
            // EOBManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 529);
            this.Controls.Add(this.btnBidEvalReport);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnDownloadITenderFile);
            this.Controls.Add(this.btnBidEval);
            this.Controls.Add(this.btnRecJudges);
            this.Controls.Add(this.grdProject);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtSectionName);
            this.Controls.Add(this.txtSectionCode);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.txtProjectCode);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "EOBManageForm";
            this.Text = "评标管理";
            ((System.ComponentModel.ISupportInitialize)(this.grdProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtProjectCode;
        private MetroFramework.Controls.MetroTextBox txtProjectName;
        private MetroFramework.Controls.MetroTextBox txtSectionCode;
        private MetroFramework.Controls.MetroTextBox txtSectionName;
        private MetroFramework.Controls.MetroButton btnQuery;
        private MetroFramework.Controls.MetroGrid grdProject;
        private MetroFramework.Controls.MetroButton btnRecJudges;
        private MetroFramework.Controls.MetroButton btnBidEval;
        private MetroFramework.Controls.MetroButton btnDownloadITenderFile;
        private MetroFramework.Controls.MetroButton btnResult;
        private MetroFramework.Controls.MetroButton btnBidEvalReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colProjectEvalState;
    }
}