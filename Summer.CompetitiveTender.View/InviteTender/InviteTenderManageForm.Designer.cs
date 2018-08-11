﻿namespace Summer.CompetitiveTender.View.InviteTender
{
    partial class InviteTenderManageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InviteTenderManageForm));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.grdTemplate = new Summer.Common.Controls.MultiHeaderDataGridView();
            this.colTempleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemplateType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemplateProjectType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemplateNode = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colTemplateDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemplateCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemplateEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colTemplateDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colTemplatePreview = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colTemplatePrint = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colTemplateDownload = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnCreateTemplate = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage6 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage7 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage8 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage9 = new MetroFramework.Controls.MetroTabPage();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.colInviteTenderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInviteTenderCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetail = new System.Windows.Forms.DataGridViewLinkColumn();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTemplate)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.metroTabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage9);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Multiline = true;
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(867, 351);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.grdTemplate);
            this.metroTabPage1.Controls.Add(this.btnCreateTemplate);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(859, 309);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "制作模板";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // grdTemplate
            // 
            this.grdTemplate.AllowUserToAddRows = false;
            this.grdTemplate.AllowUserToDeleteRows = false;
            this.grdTemplate.AllowUserToResizeRows = false;
            this.grdTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTemplate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdTemplate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdTemplate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdTemplate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTemplate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdTemplate.ColumnHeadersHeight = 45;
            this.grdTemplate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTempleName,
            this.colTemplateType,
            this.colTemplateProjectType,
            this.colTemplateNode,
            this.colTemplateDescription,
            this.colTemplateCreateDate,
            this.colTemplateEdit,
            this.colTemplateDelete,
            this.colTemplatePreview,
            this.colTemplatePrint,
            this.colTemplateDownload});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTemplate.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdTemplate.EnableHeadersVisualStyles = false;
            this.grdTemplate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdTemplate.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdTemplate.Location = new System.Drawing.Point(3, 41);
            this.grdTemplate.Name = "grdTemplate";
            this.grdTemplate.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTemplate.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdTemplate.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdTemplate.RowTemplate.Height = 23;
            this.grdTemplate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTemplate.Size = new System.Drawing.Size(853, 265);
            this.grdTemplate.TabIndex = 3;
            this.grdTemplate.TopRow = null;
            this.grdTemplate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTemplate_CellContentClick);
            // 
            // colTempleName
            // 
            this.colTempleName.HeaderText = "名称";
            this.colTempleName.Name = "colTempleName";
            // 
            // colTemplateType
            // 
            this.colTemplateType.HeaderText = "类型";
            this.colTemplateType.Name = "colTemplateType";
            // 
            // colTemplateProjectType
            // 
            this.colTemplateProjectType.HeaderText = "项目分类";
            this.colTemplateProjectType.Name = "colTemplateProjectType";
            // 
            // colTemplateNode
            // 
            this.colTemplateNode.HeaderText = "节点信息";
            this.colTemplateNode.Name = "colTemplateNode";
            // 
            // colTemplateDescription
            // 
            this.colTemplateDescription.HeaderText = "说明";
            this.colTemplateDescription.Name = "colTemplateDescription";
            // 
            // colCreateDate
            // 
            this.colTemplateCreateDate.HeaderText = "创建时间";
            this.colTemplateCreateDate.Name = "colCreateDate";
            this.colTemplateCreateDate.Width = 120;
            // 
            // colEdit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTemplateEdit.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTemplateEdit.HeaderText = "编辑";
            this.colTemplateEdit.Name = "colEdit";
            this.colTemplateEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colDelete
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTemplateDelete.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTemplateDelete.HeaderText = "删除";
            this.colTemplateDelete.Name = "colDelete";
            this.colTemplateDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colPreview
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTemplatePreview.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTemplatePreview.HeaderText = "预览";
            this.colTemplatePreview.Name = "colPreview";
            this.colTemplatePreview.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colPrint
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTemplatePrint.DefaultCellStyle = dataGridViewCellStyle5;
            this.colTemplatePrint.HeaderText = "打印";
            this.colTemplatePrint.Name = "colPrint";
            this.colTemplatePrint.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colDownload
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTemplateDownload.DefaultCellStyle = dataGridViewCellStyle6;
            this.colTemplateDownload.HeaderText = "下载";
            this.colTemplateDownload.Name = "colDownload";
            this.colTemplateDownload.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnCreateTemplate
            // 
            this.btnCreateTemplate.Location = new System.Drawing.Point(3, 12);
            this.btnCreateTemplate.Name = "btnCreateTemplate";
            this.btnCreateTemplate.Size = new System.Drawing.Size(90, 23);
            this.btnCreateTemplate.TabIndex = 2;
            this.btnCreateTemplate.Text = "新增模板";
            this.btnCreateTemplate.UseSelectable = true;
            this.btnCreateTemplate.Click += new System.EventHandler(this.btnCreateTemplate_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroTabControl2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(859, 309);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "制作招标文件";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl2.Controls.Add(this.metroTabPage3);
            this.metroTabControl2.Controls.Add(this.metroTabPage4);
            this.metroTabControl2.Controls.Add(this.metroTabPage5);
            this.metroTabControl2.Controls.Add(this.metroTabPage6);
            this.metroTabControl2.Controls.Add(this.metroTabPage7);
            this.metroTabControl2.Controls.Add(this.metroTabPage8);
            this.metroTabControl2.Location = new System.Drawing.Point(3, 12);
            this.metroTabControl2.Multiline = true;
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(853, 294);
            this.metroTabControl2.TabIndex = 2;
            this.metroTabControl2.UseSelectable = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(845, 252);
            this.metroTabPage3.TabIndex = 0;
            this.metroTabPage3.Text = "招标文件";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(845, 252);
            this.metroTabPage4.TabIndex = 1;
            this.metroTabPage4.Text = "评标办法";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(845, 252);
            this.metroTabPage5.TabIndex = 2;
            this.metroTabPage5.Text = "开标一览表";
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
            // metroTabPage6
            // 
            this.metroTabPage6.HorizontalScrollbarBarColor = true;
            this.metroTabPage6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.HorizontalScrollbarSize = 10;
            this.metroTabPage6.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage6.Name = "metroTabPage6";
            this.metroTabPage6.Size = new System.Drawing.Size(845, 252);
            this.metroTabPage6.TabIndex = 3;
            this.metroTabPage6.Text = "投标文件组成";
            this.metroTabPage6.VerticalScrollbarBarColor = true;
            this.metroTabPage6.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.VerticalScrollbarSize = 10;
            // 
            // metroTabPage7
            // 
            this.metroTabPage7.HorizontalScrollbarBarColor = true;
            this.metroTabPage7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.HorizontalScrollbarSize = 10;
            this.metroTabPage7.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage7.Name = "metroTabPage7";
            this.metroTabPage7.Size = new System.Drawing.Size(845, 252);
            this.metroTabPage7.TabIndex = 4;
            this.metroTabPage7.Text = "其他文件";
            this.metroTabPage7.VerticalScrollbarBarColor = true;
            this.metroTabPage7.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.VerticalScrollbarSize = 10;
            // 
            // metroTabPage8
            // 
            this.metroTabPage8.HorizontalScrollbarBarColor = true;
            this.metroTabPage8.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage8.HorizontalScrollbarSize = 10;
            this.metroTabPage8.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage8.Name = "metroTabPage8";
            this.metroTabPage8.Size = new System.Drawing.Size(845, 252);
            this.metroTabPage8.TabIndex = 5;
            this.metroTabPage8.Text = "生成招标文件";
            this.metroTabPage8.VerticalScrollbarBarColor = true;
            this.metroTabPage8.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage8.VerticalScrollbarSize = 10;
            // 
            // metroTabPage9
            // 
            this.metroTabPage9.Controls.Add(this.metroGrid2);
            this.metroTabPage9.HorizontalScrollbarBarColor = true;
            this.metroTabPage9.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage9.HorizontalScrollbarSize = 10;
            this.metroTabPage9.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage9.Name = "metroTabPage9";
            this.metroTabPage9.Size = new System.Drawing.Size(859, 309);
            this.metroTabPage9.TabIndex = 2;
            this.metroTabPage9.Text = "讨论区";
            this.metroTabPage9.VerticalScrollbarBarColor = true;
            this.metroTabPage9.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage9.VerticalScrollbarSize = 10;
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToAddRows = false;
            this.metroGrid2.AllowUserToDeleteRows = false;
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInviteTenderName,
            this.colInviteTenderCreateDate,
            this.colDetail});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle11;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(3, 12);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.ReadOnly = true;
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.RowTemplate.Height = 23;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(853, 294);
            this.metroGrid2.TabIndex = 2;
            // 
            // colInviteTenderName
            // 
            this.colInviteTenderName.HeaderText = "文件名称";
            this.colInviteTenderName.Name = "colInviteTenderName";
            this.colInviteTenderName.ReadOnly = true;
            // 
            // colInviteTenderCreateDate
            // 
            this.colInviteTenderCreateDate.HeaderText = "创建时间";
            this.colInviteTenderCreateDate.Name = "colInviteTenderCreateDate";
            this.colInviteTenderCreateDate.ReadOnly = true;
            this.colInviteTenderCreateDate.Width = 120;
            // 
            // colDetail
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDetail.DefaultCellStyle = dataGridViewCellStyle10;
            this.colDetail.HeaderText = "详情";
            this.colDetail.Name = "colDetail";
            this.colDetail.ReadOnly = true;
            // 
            // InviteTenderManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 431);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InviteTenderManageForm";
            this.Text = "招标文件制作";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTemplate)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabControl2.ResumeLayout(false);
            this.metroTabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private Summer.Common.Controls.MultiHeaderDataGridView grdTemplate;
        private MetroFramework.Controls.MetroButton btnCreateTemplate;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private MetroFramework.Controls.MetroTabPage metroTabPage6;
        private MetroFramework.Controls.MetroTabPage metroTabPage7;
        private MetroFramework.Controls.MetroTabPage metroTabPage8;
        private MetroFramework.Controls.MetroTabPage metroTabPage9;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInviteTenderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInviteTenderCreateDate;
        private System.Windows.Forms.DataGridViewLinkColumn colDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTempleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemplateType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemplateProjectType;
        private System.Windows.Forms.DataGridViewLinkColumn colTemplateNode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemplateDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemplateCreateDate;
        private System.Windows.Forms.DataGridViewLinkColumn colTemplateEdit;
        private System.Windows.Forms.DataGridViewLinkColumn colTemplateDelete;
        private System.Windows.Forms.DataGridViewLinkColumn colTemplatePreview;
        private System.Windows.Forms.DataGridViewLinkColumn colTemplatePrint;
        private System.Windows.Forms.DataGridViewLinkColumn colTemplateDownload;
    }
}