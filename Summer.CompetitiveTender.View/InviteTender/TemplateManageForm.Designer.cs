namespace Summer.CompetitiveTender.View.InviteTender
{
    partial class TemplateManageForm
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
            this.grdTemplate = new MetroFramework.Controls.MetroGrid();
            this.btnNewTemplate = new MetroFramework.Controls.MetroButton();
            this.btnEditTemplate = new MetroFramework.Controls.MetroButton();
            this.btnTemplateNode = new MetroFramework.Controls.MetroButton();
            this.btnDeleteTemplate = new MetroFramework.Controls.MetroButton();
            this.btnDownloadTemplate = new MetroFramework.Controls.MetroButton();
            this.colTemplateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemplateCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTempleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemplateType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTemplateProjectType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTemplateDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemplateCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemplateState = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdTemplate)).BeginInit();
            this.SuspendLayout();
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
            this.colTemplateId,
            this.colTemplateCode,
            this.colTempleName,
            this.colTemplateType,
            this.colTemplateProjectType,
            this.colTemplateDescription,
            this.colTemplateCreateDate,
            this.colTemplateState});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTemplate.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdTemplate.EnableHeadersVisualStyles = false;
            this.grdTemplate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdTemplate.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdTemplate.Location = new System.Drawing.Point(20, 63);
            this.grdTemplate.MultiSelect = false;
            this.grdTemplate.Name = "grdTemplate";
            this.grdTemplate.ReadOnly = true;
            this.grdTemplate.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTemplate.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdTemplate.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdTemplate.RowTemplate.Height = 23;
            this.grdTemplate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTemplate.Size = new System.Drawing.Size(984, 477);
            this.grdTemplate.TabIndex = 4;
            // 
            // btnNewTemplate
            // 
            this.btnNewTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewTemplate.Location = new System.Drawing.Point(23, 554);
            this.btnNewTemplate.Name = "btnNewTemplate";
            this.btnNewTemplate.Size = new System.Drawing.Size(75, 23);
            this.btnNewTemplate.TabIndex = 5;
            this.btnNewTemplate.Text = "新建模板";
            this.btnNewTemplate.UseSelectable = true;
            this.btnNewTemplate.Click += new System.EventHandler(this.btnNewTemplate_Click);
            // 
            // btnEditTemplate
            // 
            this.btnEditTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditTemplate.Location = new System.Drawing.Point(130, 554);
            this.btnEditTemplate.Name = "btnEditTemplate";
            this.btnEditTemplate.Size = new System.Drawing.Size(75, 23);
            this.btnEditTemplate.TabIndex = 6;
            this.btnEditTemplate.Text = "编辑模板";
            this.btnEditTemplate.UseSelectable = true;
            this.btnEditTemplate.Click += new System.EventHandler(this.btnEditTemplate_Click);
            // 
            // btnTemplateNode
            // 
            this.btnTemplateNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTemplateNode.Location = new System.Drawing.Point(237, 554);
            this.btnTemplateNode.Name = "btnTemplateNode";
            this.btnTemplateNode.Size = new System.Drawing.Size(75, 23);
            this.btnTemplateNode.TabIndex = 7;
            this.btnTemplateNode.Text = "模板设定";
            this.btnTemplateNode.UseSelectable = true;
            this.btnTemplateNode.Click += new System.EventHandler(this.btnTemplateNode_Click);
            // 
            // btnDeleteTemplate
            // 
            this.btnDeleteTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteTemplate.Location = new System.Drawing.Point(344, 554);
            this.btnDeleteTemplate.Name = "btnDeleteTemplate";
            this.btnDeleteTemplate.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTemplate.TabIndex = 8;
            this.btnDeleteTemplate.Text = "删除模板";
            this.btnDeleteTemplate.UseSelectable = true;
            this.btnDeleteTemplate.Click += new System.EventHandler(this.btnDeleteTemplate_Click);
            // 
            // btnDownloadTemplate
            // 
            this.btnDownloadTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDownloadTemplate.Location = new System.Drawing.Point(451, 554);
            this.btnDownloadTemplate.Name = "btnDownloadTemplate";
            this.btnDownloadTemplate.Size = new System.Drawing.Size(75, 23);
            this.btnDownloadTemplate.TabIndex = 9;
            this.btnDownloadTemplate.Text = "下载模板";
            this.btnDownloadTemplate.UseSelectable = true;
            this.btnDownloadTemplate.Click += new System.EventHandler(this.btnDownloadTemplate_Click);
            // 
            // colTemplateId
            // 
            this.colTemplateId.HeaderText = "模板ID";
            this.colTemplateId.Name = "colTemplateId";
            this.colTemplateId.ReadOnly = true;
            this.colTemplateId.Visible = false;
            // 
            // colTemplateCode
            // 
            this.colTemplateCode.HeaderText = "模板编号";
            this.colTemplateCode.Name = "colTemplateCode";
            this.colTemplateCode.ReadOnly = true;
            // 
            // colTempleName
            // 
            this.colTempleName.HeaderText = "名称";
            this.colTempleName.Name = "colTempleName";
            this.colTempleName.ReadOnly = true;
            // 
            // colTemplateType
            // 
            this.colTemplateType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colTemplateType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colTemplateType.HeaderText = "类型";
            this.colTemplateType.Name = "colTemplateType";
            this.colTemplateType.ReadOnly = true;
            this.colTemplateType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTemplateType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colTemplateProjectType
            // 
            this.colTemplateProjectType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colTemplateProjectType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colTemplateProjectType.HeaderText = "项目分类";
            this.colTemplateProjectType.Name = "colTemplateProjectType";
            this.colTemplateProjectType.ReadOnly = true;
            this.colTemplateProjectType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTemplateProjectType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colTemplateDescription
            // 
            this.colTemplateDescription.HeaderText = "说明";
            this.colTemplateDescription.Name = "colTemplateDescription";
            this.colTemplateDescription.ReadOnly = true;
            // 
            // colTemplateCreateDate
            // 
            this.colTemplateCreateDate.HeaderText = "创建时间";
            this.colTemplateCreateDate.Name = "colTemplateCreateDate";
            this.colTemplateCreateDate.ReadOnly = true;
            this.colTemplateCreateDate.Width = 120;
            // 
            // colTemplateState
            // 
            this.colTemplateState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTemplateState.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colTemplateState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colTemplateState.HeaderText = "状态";
            this.colTemplateState.Name = "colTemplateState";
            this.colTemplateState.ReadOnly = true;
            this.colTemplateState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTemplateState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TemplateManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.btnDownloadTemplate);
            this.Controls.Add(this.btnDeleteTemplate);
            this.Controls.Add(this.btnTemplateNode);
            this.Controls.Add(this.btnEditTemplate);
            this.Controls.Add(this.btnNewTemplate);
            this.Controls.Add(this.grdTemplate);
            this.Name = "TemplateManageForm";
            this.Text = "模板管理";
            this.Shown += new System.EventHandler(this.QueryITenderTemplateForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdTemplate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdTemplate;
        private MetroFramework.Controls.MetroButton btnNewTemplate;
        private MetroFramework.Controls.MetroButton btnEditTemplate;
        private MetroFramework.Controls.MetroButton btnTemplateNode;
        private MetroFramework.Controls.MetroButton btnDeleteTemplate;
        private MetroFramework.Controls.MetroButton btnDownloadTemplate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemplateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemplateCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTempleName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTemplateType;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTemplateProjectType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemplateDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemplateCreateDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTemplateState;
    }
}