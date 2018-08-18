namespace Summer.CompetitiveTender.View.InviteTender
{
    partial class QueryITenderTemplateForm
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
            this.grdTemplate = new MetroFramework.Controls.MetroGrid();
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
            ((System.ComponentModel.ISupportInitialize)(this.grdTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTemplate
            // 
            this.grdTemplate.AllowUserToAddRows = false;
            this.grdTemplate.AllowUserToDeleteRows = false;
            this.grdTemplate.AllowUserToResizeRows = false;
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
            this.grdTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTemplate.EnableHeadersVisualStyles = false;
            this.grdTemplate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdTemplate.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdTemplate.Location = new System.Drawing.Point(20, 60);
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
            this.grdTemplate.Size = new System.Drawing.Size(984, 520);
            this.grdTemplate.TabIndex = 4;
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
            // colTemplateCreateDate
            // 
            this.colTemplateCreateDate.HeaderText = "创建时间";
            this.colTemplateCreateDate.Name = "colTemplateCreateDate";
            this.colTemplateCreateDate.Width = 120;
            // 
            // colTemplateEdit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTemplateEdit.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTemplateEdit.HeaderText = "编辑";
            this.colTemplateEdit.Name = "colTemplateEdit";
            this.colTemplateEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colTemplateDelete
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTemplateDelete.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTemplateDelete.HeaderText = "删除";
            this.colTemplateDelete.Name = "colTemplateDelete";
            this.colTemplateDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colTemplatePreview
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTemplatePreview.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTemplatePreview.HeaderText = "预览";
            this.colTemplatePreview.Name = "colTemplatePreview";
            this.colTemplatePreview.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colTemplatePrint
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTemplatePrint.DefaultCellStyle = dataGridViewCellStyle5;
            this.colTemplatePrint.HeaderText = "打印";
            this.colTemplatePrint.Name = "colTemplatePrint";
            this.colTemplatePrint.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colTemplateDownload
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTemplateDownload.DefaultCellStyle = dataGridViewCellStyle6;
            this.colTemplateDownload.HeaderText = "下载";
            this.colTemplateDownload.Name = "colTemplateDownload";
            this.colTemplateDownload.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // QueryITenderTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.grdTemplate);
            this.Name = "QueryITenderTemplateForm";
            this.Text = "浏览招标模板";
            this.Shown += new System.EventHandler(this.QueryITenderTemplateForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdTemplate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdTemplate;
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