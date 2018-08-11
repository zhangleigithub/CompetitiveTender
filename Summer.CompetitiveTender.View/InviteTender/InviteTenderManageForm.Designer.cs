namespace Summer.CompetitiveTender.View.InviteTender
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InviteTenderManageForm));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.grdTemplate = new Summer.Common.Controls.MultiHeaderDataGridView();
            this.colTempleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemplateType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemplateProjectType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemplateNode = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colTemplateDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colPreview = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colPrint = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colDownload = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnCreateTemplate = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnQuery = new MetroFramework.Controls.MetroButton();
            this.txtProjectId = new MetroFramework.Controls.MetroTextBox();
            this.grdITender = new MetroFramework.Controls.MetroGrid();
            this.metroTabPage9 = new MetroFramework.Controls.MetroTabPage();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.colInviteTenderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInviteTenderCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetail = new System.Windows.Forms.DataGridViewLinkColumn();
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
            this.colDeleteITenderFile = new System.Windows.Forms.DataGridViewLinkColumn();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTemplate)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdITender)).BeginInit();
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
            this.metroTabControl1.SelectedIndex = 1;
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
            this.colCreateDate,
            this.colEdit,
            this.colDelete,
            this.colPreview,
            this.colPrint,
            this.colDownload});
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
            this.colCreateDate.HeaderText = "创建时间";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.Width = 120;
            // 
            // colEdit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colEdit.DefaultCellStyle = dataGridViewCellStyle2;
            this.colEdit.HeaderText = "编辑";
            this.colEdit.Name = "colEdit";
            this.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colDelete
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDelete.HeaderText = "删除";
            this.colDelete.Name = "colDelete";
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colPreview
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colPreview.DefaultCellStyle = dataGridViewCellStyle4;
            this.colPreview.HeaderText = "预览";
            this.colPreview.Name = "colPreview";
            this.colPreview.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colPrint
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colPrint.DefaultCellStyle = dataGridViewCellStyle5;
            this.colPrint.HeaderText = "打印";
            this.colPrint.Name = "colPrint";
            this.colPrint.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colDownload
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDownload.DefaultCellStyle = dataGridViewCellStyle6;
            this.colDownload.HeaderText = "下载";
            this.colDownload.Name = "colDownload";
            this.colDownload.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.metroTabPage2.Controls.Add(this.btnQuery);
            this.metroTabPage2.Controls.Add(this.txtProjectId);
            this.metroTabPage2.Controls.Add(this.grdITender);
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
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Location = new System.Drawing.Point(781, 12);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseSelectable = true;
            // 
            // txtProjectId
            // 
            this.txtProjectId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtProjectId.CustomButton.Image = null;
            this.txtProjectId.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtProjectId.CustomButton.Name = "";
            this.txtProjectId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProjectId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProjectId.CustomButton.TabIndex = 1;
            this.txtProjectId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProjectId.CustomButton.UseSelectable = true;
            this.txtProjectId.CustomButton.Visible = false;
            this.txtProjectId.Lines = new string[0];
            this.txtProjectId.Location = new System.Drawing.Point(564, 12);
            this.txtProjectId.MaxLength = 32767;
            this.txtProjectId.Name = "txtProjectId";
            this.txtProjectId.PasswordChar = '\0';
            this.txtProjectId.PromptText = "项目编号";
            this.txtProjectId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProjectId.SelectedText = "";
            this.txtProjectId.SelectionLength = 0;
            this.txtProjectId.SelectionStart = 0;
            this.txtProjectId.ShortcutsEnabled = true;
            this.txtProjectId.Size = new System.Drawing.Size(211, 23);
            this.txtProjectId.TabIndex = 3;
            this.txtProjectId.UseSelectable = true;
            this.txtProjectId.WaterMark = "项目编号";
            this.txtProjectId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProjectId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // grdITender
            // 
            this.grdITender.AllowUserToResizeRows = false;
            this.grdITender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdITender.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdITender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdITender.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdITender.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdITender.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
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
            this.colDeleteITenderFile});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdITender.DefaultCellStyle = dataGridViewCellStyle10;
            this.grdITender.EnableHeadersVisualStyles = false;
            this.grdITender.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdITender.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdITender.Location = new System.Drawing.Point(3, 43);
            this.grdITender.Name = "grdITender";
            this.grdITender.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdITender.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.grdITender.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdITender.RowTemplate.Height = 23;
            this.grdITender.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdITender.Size = new System.Drawing.Size(853, 263);
            this.grdITender.TabIndex = 2;
            this.grdITender.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdITender_CellContentClick);
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInviteTenderName,
            this.colInviteTenderCreateDate,
            this.colDetail});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle14;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(3, 12);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.ReadOnly = true;
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDetail.DefaultCellStyle = dataGridViewCellStyle13;
            this.colDetail.HeaderText = "详情";
            this.colDetail.Name = "colDetail";
            this.colDetail.ReadOnly = true;
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
            this.colITenderTYJYBSM.Width = 150;
            // 
            // colITenderProjectName
            // 
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
            this.colITenderProjectAreaName.Width = 150;
            // 
            // colITenderProjectAgencyType
            // 
            this.colITenderProjectAgencyType.HeaderText = "代理机构代码类型";
            this.colITenderProjectAgencyType.Name = "colITenderProjectAgencyType";
            this.colITenderProjectAgencyType.Width = 150;
            // 
            // colITenderProjectContent
            // 
            this.colITenderProjectContent.HeaderText = "内容与范围及招标方案说明";
            this.colITenderProjectContent.Name = "colITenderProjectContent";
            this.colITenderProjectContent.Width = 180;
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
            // colITenderFileDelete
            // 
            this.colDeleteITenderFile.HeaderText = "删除招标文件";
            this.colDeleteITenderFile.Name = "colITenderFileDelete";
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
            ((System.ComponentModel.ISupportInitialize)(this.grdITender)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateDate;
        private System.Windows.Forms.DataGridViewLinkColumn colEdit;
        private System.Windows.Forms.DataGridViewLinkColumn colDelete;
        private System.Windows.Forms.DataGridViewLinkColumn colPreview;
        private System.Windows.Forms.DataGridViewLinkColumn colPrint;
        private System.Windows.Forms.DataGridViewLinkColumn colDownload;
        private MetroFramework.Controls.MetroButton btnQuery;
        private MetroFramework.Controls.MetroTextBox txtProjectId;
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
        private System.Windows.Forms.DataGridViewLinkColumn colDeleteITenderFile;
    }
}