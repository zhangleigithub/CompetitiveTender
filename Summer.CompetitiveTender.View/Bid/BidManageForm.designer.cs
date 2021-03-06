﻿namespace Summer.CompetitiveTender.View.Bid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab_tenderList = new MetroFramework.Controls.MetroTabControl();
            this.tab_UploadFile = new MetroFramework.Controls.MetroTabPage();
            this.btn_upload = new MetroFramework.Controls.MetroButton();
            this.btn_StorePath = new MetroFramework.Controls.MetroButton();
            this.txt_StorePath = new MetroFramework.Controls.MetroTextBox();
            this.btn_browse = new MetroFramework.Controls.MetroButton();
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txt_path = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.cob_objectList = new MetroFramework.Controls.MetroComboBox();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.tab_MakeTenderFile = new MetroFramework.Controls.MetroTabPage();
            this.dgv_tenderFile = new MetroFramework.Controls.MetroGrid();
            this.tab_HistoryData = new MetroFramework.Controls.MetroTabPage();
            this.dgv_historyFile = new MetroFramework.Controls.MetroGrid();
            this.project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.download = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tab_DiscussArea = new MetroFramework.Controls.MetroTabPage();
            this.colProjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSectionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDownLoad = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tab_tenderList.SuspendLayout();
            this.tab_UploadFile.SuspendLayout();
            this.tab_MakeTenderFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tenderFile)).BeginInit();
            this.tab_HistoryData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historyFile)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_tenderList
            // 
            this.tab_tenderList.Controls.Add(this.tab_UploadFile);
            this.tab_tenderList.Controls.Add(this.tab_MakeTenderFile);
            this.tab_tenderList.Controls.Add(this.tab_HistoryData);
            this.tab_tenderList.Controls.Add(this.tab_DiscussArea);
            this.tab_tenderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_tenderList.Location = new System.Drawing.Point(20, 60);
            this.tab_tenderList.Name = "tab_tenderList";
            this.tab_tenderList.SelectedIndex = 0;
            this.tab_tenderList.Size = new System.Drawing.Size(724, 459);
            this.tab_tenderList.TabIndex = 0;
            this.tab_tenderList.UseSelectable = true;
            // 
            // tab_UploadFile
            // 
            this.tab_UploadFile.Controls.Add(this.btn_upload);
            this.tab_UploadFile.Controls.Add(this.btn_StorePath);
            this.tab_UploadFile.Controls.Add(this.txt_StorePath);
            this.tab_UploadFile.Controls.Add(this.btn_browse);
            this.tab_UploadFile.Controls.Add(this.htmlLabel3);
            this.tab_UploadFile.Controls.Add(this.txt_path);
            this.tab_UploadFile.Controls.Add(this.htmlLabel2);
            this.tab_UploadFile.Controls.Add(this.cob_objectList);
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
            this.btn_upload.Location = new System.Drawing.Point(404, 278);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_upload.TabIndex = 2;
            this.btn_upload.Text = "上传";
            this.btn_upload.UseSelectable = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_StorePath
            // 
            this.btn_StorePath.Location = new System.Drawing.Point(419, 215);
            this.btn_StorePath.Name = "btn_StorePath";
            this.btn_StorePath.Size = new System.Drawing.Size(60, 23);
            this.btn_StorePath.TabIndex = 1;
            this.btn_StorePath.Text = "浏览";
            this.btn_StorePath.UseSelectable = true;
            this.btn_StorePath.Click += new System.EventHandler(this.btn_StorePath_Click);
            // 
            // txt_StorePath
            // 
            // 
            // 
            // 
            this.txt_StorePath.CustomButton.Image = null;
            this.txt_StorePath.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txt_StorePath.CustomButton.Name = "";
            this.txt_StorePath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_StorePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_StorePath.CustomButton.TabIndex = 1;
            this.txt_StorePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_StorePath.CustomButton.UseSelectable = true;
            this.txt_StorePath.CustomButton.Visible = false;
            this.txt_StorePath.Lines = new string[0];
            this.txt_StorePath.Location = new System.Drawing.Point(188, 215);
            this.txt_StorePath.MaxLength = 32767;
            this.txt_StorePath.Name = "txt_StorePath";
            this.txt_StorePath.PasswordChar = '\0';
            this.txt_StorePath.ReadOnly = true;
            this.txt_StorePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_StorePath.SelectedText = "";
            this.txt_StorePath.SelectionLength = 0;
            this.txt_StorePath.SelectionStart = 0;
            this.txt_StorePath.ShortcutsEnabled = true;
            this.txt_StorePath.Size = new System.Drawing.Size(232, 23);
            this.txt_StorePath.TabIndex = 5;
            this.txt_StorePath.UseSelectable = true;
            this.txt_StorePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_StorePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // htmlLabel3
            // 
            this.htmlLabel3.AutoScroll = true;
            this.htmlLabel3.AutoScrollMinSize = new System.Drawing.Size(70, 22);
            this.htmlLabel3.AutoSize = false;
            this.htmlLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel3.Location = new System.Drawing.Point(106, 215);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel3.TabIndex = 4;
            this.htmlLabel3.Text = "存放位置：";
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
            // cob_objectList
            // 
            this.cob_objectList.FormattingEnabled = true;
            this.cob_objectList.ItemHeight = 23;
            this.cob_objectList.Items.AddRange(new object[] {
            "项目1",
            "项目2",
            "项目3"});
            this.cob_objectList.Location = new System.Drawing.Point(189, 82);
            this.cob_objectList.Name = "cob_objectList";
            this.cob_objectList.Size = new System.Drawing.Size(291, 29);
            this.cob_objectList.TabIndex = 0;
            this.cob_objectList.UseSelectable = true;
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
            this.dgv_tenderFile.AllowUserToDeleteRows = false;
            this.dgv_tenderFile.AllowUserToResizeRows = false;
            this.dgv_tenderFile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_tenderFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_tenderFile.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_tenderFile.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tenderFile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tenderFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tenderFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProjectCode,
            this.colProjectName,
            this.colSectionCode,
            this.colSectionName,
            this.colDownLoad});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tenderFile.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_tenderFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tenderFile.EnableHeadersVisualStyles = false;
            this.dgv_tenderFile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_tenderFile.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_tenderFile.Location = new System.Drawing.Point(3, 3);
            this.dgv_tenderFile.Name = "dgv_tenderFile";
            this.dgv_tenderFile.ReadOnly = true;
            this.dgv_tenderFile.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tenderFile.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_tenderFile.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_tenderFile.RowTemplate.Height = 23;
            this.dgv_tenderFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tenderFile.Size = new System.Drawing.Size(710, 411);
            this.dgv_tenderFile.TabIndex = 3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_historyFile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_historyFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historyFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.project,
            this.bidDate,
            this.c11,
            this.download});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_historyFile.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_historyFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_historyFile.EnableHeadersVisualStyles = false;
            this.dgv_historyFile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_historyFile.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_historyFile.Location = new System.Drawing.Point(0, 0);
            this.dgv_historyFile.Name = "dgv_historyFile";
            this.dgv_historyFile.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_historyFile.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            // colProjectCode
            // 
            this.colProjectCode.HeaderText = "项目编号";
            this.colProjectCode.Name = "colProjectCode";
            this.colProjectCode.ReadOnly = true;
            // 
            // colProjectName
            // 
            this.colProjectName.HeaderText = "项目名称";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.ReadOnly = true;
            // 
            // colSectionCode
            // 
            this.colSectionCode.HeaderText = "标段编号";
            this.colSectionCode.Name = "colSectionCode";
            this.colSectionCode.ReadOnly = true;
            // 
            // colSectionName
            // 
            this.colSectionName.HeaderText = "标段名称";
            this.colSectionName.Name = "colSectionName";
            this.colSectionName.ReadOnly = true;
            // 
            // colDownLoad
            // 
            this.colDownLoad.HeaderText = "下载";
            this.colDownLoad.Name = "colDownLoad";
            this.colDownLoad.ReadOnly = true;
            // 
            // BidManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 539);
            this.Controls.Add(this.tab_tenderList);
            this.Name = "BidManageForm";
            this.Text = "投标管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BidManage_Load);
            this.tab_tenderList.ResumeLayout(false);
            this.tab_UploadFile.ResumeLayout(false);
            this.tab_MakeTenderFile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tenderFile)).EndInit();
            this.tab_HistoryData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historyFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tab_tenderList;
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
        private MetroFramework.Controls.MetroComboBox cob_objectList;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroButton btn_upload;
        private MetroFramework.Controls.MetroButton btn_browse;
        private MetroFramework.Controls.MetroTextBox txt_path;
        private MetroFramework.Controls.MetroGrid dgv_tenderFile;
        private MetroFramework.Controls.MetroButton btn_StorePath;
        private MetroFramework.Controls.MetroTextBox txt_StorePath;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionName;
        private System.Windows.Forms.DataGridViewLinkColumn colDownLoad;
    }
}