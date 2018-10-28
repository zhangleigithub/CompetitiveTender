namespace Summer.CompetitiveTender.View.InviteTender
{
    partial class QueryITenderForm
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
            this.btnQuery = new MetroFramework.Controls.MetroButton();
            this.txtProjectId = new Summer.Common.Controls.MetroSearchTextBox();
            this.grdITender = new MetroFramework.Controls.MetroGrid();
            this.colITenderProjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colITenderTYJYBSM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colITenderProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colITenderProjectTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colITenderProjectGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colITenderProjectAreaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colITenderProjectAgencyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colITenderProjectContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colITenderDetail = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colEditITenderFile = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colQuestion = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colDeleteITenderFile = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdITender)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Location = new System.Drawing.Point(926, 63);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 7;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseSelectable = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtProjectId
            // 
            this.txtProjectId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProjectId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtProjectId.CustomButton.Image = null;
            this.txtProjectId.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.txtProjectId.CustomButton.Name = "";
            this.txtProjectId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProjectId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProjectId.CustomButton.TabIndex = 1;
            this.txtProjectId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProjectId.CustomButton.UseSelectable = true;
            this.txtProjectId.CustomButton.Visible = false;
            this.txtProjectId.Guid = "d92b3fde-1663-4962-9210-051b92257d88";
            this.txtProjectId.Lines = new string[0];
            this.txtProjectId.Location = new System.Drawing.Point(709, 63);
            this.txtProjectId.MaxLength = 32767;
            this.txtProjectId.Name = "txtProjectId";
            this.txtProjectId.PasswordChar = '\0';
            this.txtProjectId.PromptText = "项目编号";
            this.txtProjectId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProjectId.SelectedText = "";
            this.txtProjectId.SelectionLength = 0;
            this.txtProjectId.SelectionStart = 0;
            this.txtProjectId.ShortcutsEnabled = true;
            this.txtProjectId.Size = new System.Drawing.Size(210, 23);
            this.txtProjectId.TabIndex = 6;
            this.txtProjectId.UseSelectable = true;
            this.txtProjectId.WaterMark = "项目编号";
            this.txtProjectId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProjectId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // grdITender
            // 
            this.grdITender.AllowUserToAddRows = false;
            this.grdITender.AllowUserToDeleteRows = false;
            this.grdITender.AllowUserToResizeRows = false;
            this.grdITender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdITender.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdITender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdITender.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdITender.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdITender.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdITender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdITender.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colITenderProjectCode,
            this.colITenderTYJYBSM,
            this.colITenderProjectName,
            this.colITenderProjectTypeName,
            this.colITenderProjectGroupName,
            this.colITenderProjectAreaName,
            this.colITenderProjectAgencyType,
            this.colITenderProjectContent,
            this.colITenderDetail,
            this.colEditITenderFile,
            this.colQuestion,
            this.colDeleteITenderFile});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdITender.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdITender.EnableHeadersVisualStyles = false;
            this.grdITender.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdITender.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdITender.Location = new System.Drawing.Point(23, 92);
            this.grdITender.Name = "grdITender";
            this.grdITender.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdITender.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdITender.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdITender.RowTemplate.Height = 23;
            this.grdITender.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdITender.Size = new System.Drawing.Size(978, 485);
            this.grdITender.TabIndex = 5;
            this.grdITender.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdITender_CellContentClick);
            // 
            // colITenderProjectCode
            // 
            this.colITenderProjectCode.HeaderText = "项目编号";
            this.colITenderProjectCode.Name = "colITenderProjectCode";
            // 
            // colITenderTYJYBSM
            // 
            this.colITenderTYJYBSM.HeaderText = "统一交易标识码";
            this.colITenderTYJYBSM.Name = "colITenderTYJYBSM";
            this.colITenderTYJYBSM.Visible = false;
            this.colITenderTYJYBSM.Width = 150;
            // 
            // colITenderProjectName
            // 
            this.colITenderProjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colITenderProjectName.HeaderText = "项目名称";
            this.colITenderProjectName.Name = "colITenderProjectName";
            // 
            // colITenderProjectTypeName
            // 
            this.colITenderProjectTypeName.HeaderText = "类型名称";
            this.colITenderProjectTypeName.Name = "colITenderProjectTypeName";
            // 
            // colITenderProjectGroupName
            // 
            this.colITenderProjectGroupName.HeaderText = "分类名称";
            this.colITenderProjectGroupName.Name = "colITenderProjectGroupName";
            // 
            // colITenderProjectAreaName
            // 
            this.colITenderProjectAreaName.HeaderText = "所在行政区域名称";
            this.colITenderProjectAreaName.Name = "colITenderProjectAreaName";
            this.colITenderProjectAreaName.Visible = false;
            this.colITenderProjectAreaName.Width = 150;
            // 
            // colITenderProjectAgencyType
            // 
            this.colITenderProjectAgencyType.HeaderText = "代理机构代码类型";
            this.colITenderProjectAgencyType.Name = "colITenderProjectAgencyType";
            this.colITenderProjectAgencyType.Visible = false;
            this.colITenderProjectAgencyType.Width = 150;
            // 
            // colITenderProjectContent
            // 
            this.colITenderProjectContent.HeaderText = "内容与范围及招标方案说明";
            this.colITenderProjectContent.Name = "colITenderProjectContent";
            this.colITenderProjectContent.Visible = false;
            this.colITenderProjectContent.Width = 210;
            // 
            // colITenderDetail
            // 
            this.colITenderDetail.HeaderText = "项目详情";
            this.colITenderDetail.Name = "colITenderDetail";
            this.colITenderDetail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colITenderDetail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colEditITenderFile
            // 
            this.colEditITenderFile.HeaderText = "编辑招标文件";
            this.colEditITenderFile.Name = "colEditITenderFile";
            // 
            // colQuestion
            // 
            this.colQuestion.HeaderText = "问题澄清";
            this.colQuestion.Name = "colQuestion";
            // 
            // colDeleteITenderFile
            // 
            this.colDeleteITenderFile.HeaderText = "删除招标文件";
            this.colDeleteITenderFile.Name = "colDeleteITenderFile";
            // 
            // QueryITenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtProjectId);
            this.Controls.Add(this.grdITender);
            this.Name = "QueryITenderForm";
            this.Text = "浏览招标文件";
            this.Shown += new System.EventHandler(this.QueryITenderForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdITender)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnQuery;
        private Summer.Common.Controls.MetroSearchTextBox txtProjectId;
        private MetroFramework.Controls.MetroGrid grdITender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colITenderProjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colITenderTYJYBSM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colITenderProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colITenderProjectTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colITenderProjectGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colITenderProjectAreaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colITenderProjectAgencyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colITenderProjectContent;
        private System.Windows.Forms.DataGridViewLinkColumn colITenderDetail;
        private System.Windows.Forms.DataGridViewLinkColumn colEditITenderFile;
        private System.Windows.Forms.DataGridViewLinkColumn colQuestion;
        private System.Windows.Forms.DataGridViewLinkColumn colDeleteITenderFile;
    }
}