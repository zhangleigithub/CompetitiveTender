namespace Summer.CompetitiveTender.View.InviteTender
{
    partial class QueryITenderQuestionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboType = new MetroFramework.Controls.MetroComboBox();
            this.txtTitle = new Summer.Common.Controls.MetroSearchTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnQuestQuery = new MetroFramework.Controls.MetroButton();
            this.grdITQuest = new MetroFramework.Controls.MetroGrid();
            this.colOperationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSectionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetail = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colReplayQuestion = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdITQuest)).BeginInit();
            this.SuspendLayout();
            // 
            // cboType
            // 
            this.cboType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboType.FormattingEnabled = true;
            this.cboType.ItemHeight = 23;
            this.cboType.Items.AddRange(new object[] {
            "澄清",
            "修改"});
            this.cboType.Location = new System.Drawing.Point(881, 63);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 29);
            this.cboType.TabIndex = 25;
            this.cboType.UseSelectable = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtTitle.CustomButton.Image = null;
            this.txtTitle.CustomButton.Location = new System.Drawing.Point(298, 1);
            this.txtTitle.CustomButton.Name = "";
            this.txtTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitle.CustomButton.TabIndex = 1;
            this.txtTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitle.CustomButton.UseSelectable = true;
            this.txtTitle.CustomButton.Visible = false;
            this.txtTitle.Guid = "c3071cfc-24a9-4014-ae6d-4cd7d84444cc";
            this.txtTitle.Lines = new string[0];
            this.txtTitle.Location = new System.Drawing.Point(512, 66);
            this.txtTitle.MaxLength = 32767;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PromptText = "标题";
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitle.SelectedText = "";
            this.txtTitle.SelectionLength = 0;
            this.txtTitle.SelectionStart = 0;
            this.txtTitle.ShortcutsEnabled = true;
            this.txtTitle.Size = new System.Drawing.Size(320, 23);
            this.txtTitle.TabIndex = 24;
            this.txtTitle.UseSelectable = true;
            this.txtTitle.WaterMark = "标题";
            this.txtTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(838, 68);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "类型";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(469, 68);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "标题";
            // 
            // btnQuestQuery
            // 
            this.btnQuestQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuestQuery.Location = new System.Drawing.Point(1008, 66);
            this.btnQuestQuery.Name = "btnQuestQuery";
            this.btnQuestQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuestQuery.TabIndex = 15;
            this.btnQuestQuery.Text = "查询";
            this.btnQuestQuery.UseSelectable = true;
            this.btnQuestQuery.Click += new System.EventHandler(this.btnQuestQuery_Click);
            // 
            // grdITQuest
            // 
            this.grdITQuest.AllowUserToAddRows = false;
            this.grdITQuest.AllowUserToDeleteRows = false;
            this.grdITQuest.AllowUserToResizeRows = false;
            this.grdITQuest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdITQuest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdITQuest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdITQuest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdITQuest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdITQuest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdITQuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdITQuest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOperationId,
            this.colProjectCode,
            this.colSectionCode,
            this.colFileId,
            this.colCaption,
            this.colType,
            this.colContent,
            this.colCreateDate,
            this.colState,
            this.colDetail,
            this.colReplayQuestion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdITQuest.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdITQuest.EnableHeadersVisualStyles = false;
            this.grdITQuest.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdITQuest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdITQuest.Location = new System.Drawing.Point(23, 98);
            this.grdITQuest.Name = "grdITQuest";
            this.grdITQuest.ReadOnly = true;
            this.grdITQuest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdITQuest.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdITQuest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdITQuest.RowTemplate.Height = 23;
            this.grdITQuest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdITQuest.Size = new System.Drawing.Size(1060, 376);
            this.grdITQuest.TabIndex = 14;
            this.grdITQuest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdITQuest_CellContentClick);
            // 
            // colOperationId
            // 
            this.colOperationId.HeaderText = "操作编码";
            this.colOperationId.Name = "colOperationId";
            this.colOperationId.ReadOnly = true;
            // 
            // colProjectCode
            // 
            this.colProjectCode.HeaderText = "项目编码";
            this.colProjectCode.Name = "colProjectCode";
            this.colProjectCode.ReadOnly = true;
            this.colProjectCode.Width = 120;
            // 
            // colSectionCode
            // 
            this.colSectionCode.HeaderText = "标段编码";
            this.colSectionCode.Name = "colSectionCode";
            this.colSectionCode.ReadOnly = true;
            // 
            // colFileId
            // 
            this.colFileId.HeaderText = "文件标识";
            this.colFileId.Name = "colFileId";
            this.colFileId.ReadOnly = true;
            // 
            // colCaption
            // 
            this.colCaption.HeaderText = "标题";
            this.colCaption.Name = "colCaption";
            this.colCaption.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colType.HeaderText = "类型";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colContent
            // 
            this.colContent.HeaderText = "内容";
            this.colContent.Name = "colContent";
            this.colContent.ReadOnly = true;
            // 
            // colCreateDate
            // 
            this.colCreateDate.HeaderText = "创建时间";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.ReadOnly = true;
            // 
            // colState
            // 
            this.colState.HeaderText = "状态";
            this.colState.Name = "colState";
            this.colState.ReadOnly = true;
            // 
            // colDetail
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDetail.HeaderText = "详情";
            this.colDetail.Name = "colDetail";
            this.colDetail.ReadOnly = true;
            // 
            // colReplayQuestion
            // 
            this.colReplayQuestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colReplayQuestion.HeaderText = "回复";
            this.colReplayQuestion.Name = "colReplayQuestion";
            this.colReplayQuestion.ReadOnly = true;
            // 
            // QueryITenderQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 497);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnQuestQuery);
            this.Controls.Add(this.grdITQuest);
            this.Name = "QueryITenderQuestionForm";
            this.Text = "招标文件澄清";
            this.Shown += new System.EventHandler(this.QueryITenderQuestionForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdITQuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cboType;
        private Summer.Common.Controls.MetroSearchTextBox txtTitle;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnQuestQuery;
        private MetroFramework.Controls.MetroGrid grdITQuest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaption;
        private System.Windows.Forms.DataGridViewComboBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colState;
        private System.Windows.Forms.DataGridViewLinkColumn colDetail;
        private System.Windows.Forms.DataGridViewLinkColumn colReplayQuestion;
    }
}