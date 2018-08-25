namespace Summer.CompetitiveTender.View.Bid
{
    partial class BidManageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tab_UploadFile = new MetroFramework.Controls.MetroTabPage();
            this.btn_upload = new MetroFramework.Controls.MetroButton();
            this.btn_browse = new MetroFramework.Controls.MetroButton();
            this.txt_path = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.tab_MakeTenderFile = new MetroFramework.Controls.MetroTabPage();
            this.dgv_tenderFile = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tab_DiscussArea = new MetroFramework.Controls.MetroTabPage();
            this.tab_HistoryData = new MetroFramework.Controls.MetroTabPage();
            this.dgv_historyFile = new MetroFramework.Controls.MetroGrid();
            this.project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.download = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabControl1.SuspendLayout();
            this.tab_UploadFile.SuspendLayout();
            this.tab_MakeTenderFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tenderFile)).BeginInit();
            this.tab_HistoryData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historyFile)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_UploadFile);
            this.tabControl1.Controls.Add(this.tab_MakeTenderFile);
            this.tabControl1.Controls.Add(this.tab_HistoryData);
            this.tabControl1.Controls.Add(this.tab_DiscussArea);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(724, 459);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.UseSelectable = true;
            // 
            // tab_UploadFile
            // 
            this.tab_UploadFile.Controls.Add(this.btn_upload);
            this.tab_UploadFile.Controls.Add(this.btn_browse);
            this.tab_UploadFile.Controls.Add(this.txt_path);
            this.tab_UploadFile.Controls.Add(this.htmlLabel2);
            this.tab_UploadFile.Controls.Add(this.metroComboBox1);
            this.tab_UploadFile.Controls.Add(this.htmlLabel1);
            this.tab_UploadFile.HorizontalScrollbarBarColor = true;
            this.tab_UploadFile.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_UploadFile.HorizontalScrollbarSize = 10;
            this.tab_UploadFile.Location = new System.Drawing.Point(4, 38);
            this.tab_UploadFile.Name = "tab_UploadFile";
            this.tab_UploadFile.Size = new System.Drawing.Size(716, 417);
            this.tab_UploadFile.TabIndex = 4;
            this.tab_UploadFile.Text = "投标文件上传";
            this.tab_UploadFile.VerticalScrollbarBarColor = true;
            this.tab_UploadFile.VerticalScrollbarHighlightOnWheel = false;
            this.tab_UploadFile.VerticalScrollbarSize = 10;
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(404, 234);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_upload.TabIndex = 2;
            this.btn_upload.Text = "上传";
            this.btn_upload.UseSelectable = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(420, 151);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(60, 23);
            this.btn_browse.TabIndex = 1;
            this.btn_browse.Text = "浏览";
            this.btn_browse.UseSelectable = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // txt_path
            // 
            // 
            // 
            // 
            this.txt_path.CustomButton.Image = null;
            this.txt_path.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txt_path.CustomButton.Name = "";
            this.txt_path.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_path.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_path.CustomButton.TabIndex = 1;
            this.txt_path.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_path.CustomButton.UseSelectable = true;
            this.txt_path.CustomButton.Visible = false;
            this.txt_path.Lines = new string[0];
            this.txt_path.Location = new System.Drawing.Point(189, 151);
            this.txt_path.MaxLength = 32767;
            this.txt_path.Name = "txt_path";
            this.txt_path.PasswordChar = '\0';
            this.txt_path.ReadOnly = true;
            this.txt_path.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_path.SelectedText = "";
            this.txt_path.SelectionLength = 0;
            this.txt_path.SelectionStart = 0;
            this.txt_path.ShortcutsEnabled = true;
            this.txt_path.Size = new System.Drawing.Size(232, 23);
            this.txt_path.TabIndex = 5;
            this.txt_path.UseSelectable = true;
            this.txt_path.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_path.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(70, 22);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(107, 151);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel2.TabIndex = 4;
            this.htmlLabel2.Text = "投标文件：";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "项目1",
            "项目2",
            "项目3"});
            this.metroComboBox1.Location = new System.Drawing.Point(189, 82);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(291, 29);
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.UseSelectable = true;
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(70, 22);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(107, 89);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel1.TabIndex = 2;
            this.htmlLabel1.Text = "所属项目：";
            // 
            // tab_MakeTenderFile
            // 
            this.tab_MakeTenderFile.Controls.Add(this.dgv_tenderFile);
            this.tab_MakeTenderFile.HorizontalScrollbarBarColor = true;
            this.tab_MakeTenderFile.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_MakeTenderFile.HorizontalScrollbarSize = 10;
            this.tab_MakeTenderFile.Location = new System.Drawing.Point(4, 38);
            this.tab_MakeTenderFile.Name = "tab_MakeTenderFile";
            this.tab_MakeTenderFile.Padding = new System.Windows.Forms.Padding(3);
            this.tab_MakeTenderFile.Size = new System.Drawing.Size(716, 417);
            this.tab_MakeTenderFile.TabIndex = 1;
            this.tab_MakeTenderFile.Text = "招标文件";
            this.tab_MakeTenderFile.UseVisualStyleBackColor = true;
            this.tab_MakeTenderFile.VerticalScrollbarBarColor = true;
            this.tab_MakeTenderFile.VerticalScrollbarHighlightOnWheel = false;
            this.tab_MakeTenderFile.VerticalScrollbarSize = 10;
            // 
            // dgv_tenderFile
            // 
            this.dgv_tenderFile.AllowUserToAddRows = false;
            this.dgv_tenderFile.AllowUserToResizeRows = false;
            this.dgv_tenderFile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_tenderFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_tenderFile.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_tenderFile.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tenderFile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_tenderFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tenderFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewLinkColumn1});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tenderFile.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_tenderFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tenderFile.EnableHeadersVisualStyles = false;
            this.dgv_tenderFile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_tenderFile.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_tenderFile.Location = new System.Drawing.Point(3, 3);
            this.dgv_tenderFile.Name = "dgv_tenderFile";
            this.dgv_tenderFile.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tenderFile.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_tenderFile.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_tenderFile.RowTemplate.Height = 23;
            this.dgv_tenderFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tenderFile.Size = new System.Drawing.Size(710, 411);
            this.dgv_tenderFile.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "文件名称";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "所属项目";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "创建时间";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.HeaderText = "下载";
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            // 
            // tab_DiscussArea
            // 
            this.tab_DiscussArea.HorizontalScrollbarBarColor = true;
            this.tab_DiscussArea.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_DiscussArea.HorizontalScrollbarSize = 10;
            this.tab_DiscussArea.Location = new System.Drawing.Point(4, 38);
            this.tab_DiscussArea.Name = "tab_DiscussArea";
            this.tab_DiscussArea.Size = new System.Drawing.Size(716, 417);
            this.tab_DiscussArea.TabIndex = 2;
            this.tab_DiscussArea.Text = "讨论区";
            this.tab_DiscussArea.UseVisualStyleBackColor = true;
            this.tab_DiscussArea.VerticalScrollbarBarColor = true;
            this.tab_DiscussArea.VerticalScrollbarHighlightOnWheel = false;
            this.tab_DiscussArea.VerticalScrollbarSize = 10;
            // 
            // tab_HistoryData
            // 
            this.tab_HistoryData.Controls.Add(this.dgv_historyFile);
            this.tab_HistoryData.HorizontalScrollbarBarColor = true;
            this.tab_HistoryData.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_HistoryData.HorizontalScrollbarSize = 10;
            this.tab_HistoryData.Location = new System.Drawing.Point(4, 38);
            this.tab_HistoryData.Name = "tab_HistoryData";
            this.tab_HistoryData.Size = new System.Drawing.Size(716, 417);
            this.tab_HistoryData.TabIndex = 3;
            this.tab_HistoryData.Text = "历史投标列表";
            this.tab_HistoryData.VerticalScrollbarBarColor = true;
            this.tab_HistoryData.VerticalScrollbarHighlightOnWheel = false;
            this.tab_HistoryData.VerticalScrollbarSize = 10;
            // 
            // dgv_historyFile
            // 
            this.dgv_historyFile.AllowUserToResizeRows = false;
            this.dgv_historyFile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_historyFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_historyFile.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_historyFile.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_historyFile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_historyFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historyFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.project,
            this.bidDate,
            this.c11,
            this.download});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_historyFile.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_historyFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_historyFile.EnableHeadersVisualStyles = false;
            this.dgv_historyFile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_historyFile.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_historyFile.Location = new System.Drawing.Point(0, 0);
            this.dgv_historyFile.Name = "dgv_historyFile";
            this.dgv_historyFile.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_historyFile.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_historyFile.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_historyFile.RowTemplate.Height = 23;
            this.dgv_historyFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_historyFile.Size = new System.Drawing.Size(716, 417);
            this.dgv_historyFile.TabIndex = 2;
            // 
            // project
            // 
            this.project.HeaderText = "所属项目";
            this.project.Name = "project";
            // 
            // bidDate
            // 
            this.bidDate.HeaderText = "投标日期";
            this.bidDate.Name = "bidDate";
            // 
            // c11
            // 
            this.c11.HeaderText = "投标结果";
            this.c11.Name = "c11";
            // 
            // download
            // 
            this.download.HeaderText = "下载";
            this.download.Name = "download";
            // 
            // BidManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 539);
            this.Controls.Add(this.tabControl1);
            this.Name = "BidManageForm";
            this.Text = "投标管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BidManage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_UploadFile.ResumeLayout(false);
            this.tab_MakeTenderFile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tenderFile)).EndInit();
            this.tab_HistoryData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historyFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl1;
        private MetroFramework.Controls.MetroTabPage tab_MakeTenderFile;
        private MetroFramework.Controls.MetroTabPage tab_DiscussArea;
        private MetroFramework.Controls.MetroTabPage tab_HistoryData;
        private MetroFramework.Controls.MetroTabPage tab_UploadFile;
        private MetroFramework.Controls.MetroGrid dgv_historyFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn project;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn c11;
        private System.Windows.Forms.DataGridViewLinkColumn download;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroButton btn_upload;
        private MetroFramework.Controls.MetroButton btn_browse;
        private MetroFramework.Controls.MetroTextBox txt_path;
        private MetroFramework.Controls.MetroGrid dgv_tenderFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
    }
}