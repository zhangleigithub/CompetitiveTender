namespace Summer.CompetitiveTender.View.InviteTender
{
    partial class BidEvalClausePage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.grdData = new MetroFramework.Controls.MetroGrid();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaxScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsNeedFirstPara = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colFirstParaDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsNeeSecondPara = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSecondParaDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlgoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(263, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "删除评标条款";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(133, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "编辑评标条款";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(124, 23);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "新建评标条款";
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.AllowUserToDeleteRows = false;
            this.grdData.AllowUserToResizeRows = false;
            this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colName,
            this.colType,
            this.colMaxScore,
            this.colMinScore,
            this.colIsNeedFirstPara,
            this.colFirstParaDesc,
            this.colIsNeeSecondPara,
            this.colSecondParaDesc,
            this.colAlgoName,
            this.colRemark,
            this.colSort});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdData.DefaultCellStyle = dataGridViewCellStyle11;
            this.grdData.EnableHeadersVisualStyles = false;
            this.grdData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdData.Location = new System.Drawing.Point(3, 32);
            this.grdData.MultiSelect = false;
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grdData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdData.RowTemplate.Height = 23;
            this.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdData.Size = new System.Drawing.Size(903, 292);
            this.grdData.TabIndex = 8;
            // 
            // colCode
            // 
            this.colCode.HeaderText = "编码";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "名称";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
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
            // colMaxScore
            // 
            this.colMaxScore.HeaderText = "最高分";
            this.colMaxScore.Name = "colMaxScore";
            this.colMaxScore.ReadOnly = true;
            // 
            // colMinScore
            // 
            this.colMinScore.HeaderText = "最低分";
            this.colMinScore.Name = "colMinScore";
            this.colMinScore.ReadOnly = true;
            // 
            // colIsNeedFirstPara
            // 
            this.colIsNeedFirstPara.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colIsNeedFirstPara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colIsNeedFirstPara.HeaderText = "是否需要设置值1";
            this.colIsNeedFirstPara.Name = "colIsNeedFirstPara";
            this.colIsNeedFirstPara.ReadOnly = true;
            this.colIsNeedFirstPara.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsNeedFirstPara.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colFirstParaDesc
            // 
            this.colFirstParaDesc.HeaderText = "设置值1的说明";
            this.colFirstParaDesc.Name = "colFirstParaDesc";
            this.colFirstParaDesc.ReadOnly = true;
            // 
            // colIsNeeSecondPara
            // 
            this.colIsNeeSecondPara.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colIsNeeSecondPara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colIsNeeSecondPara.HeaderText = "是否需要设置值2";
            this.colIsNeeSecondPara.Name = "colIsNeeSecondPara";
            this.colIsNeeSecondPara.ReadOnly = true;
            this.colIsNeeSecondPara.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsNeeSecondPara.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colSecondParaDesc
            // 
            this.colSecondParaDesc.HeaderText = "设置值2的说明";
            this.colSecondParaDesc.Name = "colSecondParaDesc";
            this.colSecondParaDesc.ReadOnly = true;
            // 
            // colAlgoName
            // 
            this.colAlgoName.HeaderText = "算法名称";
            this.colAlgoName.Name = "colAlgoName";
            this.colAlgoName.ReadOnly = true;
            // 
            // colRemark
            // 
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
            this.colRemark.ReadOnly = true;
            // 
            // colSort
            // 
            this.colSort.HeaderText = "排序";
            this.colSort.Name = "colSort";
            this.colSort.ReadOnly = true;
            // 
            // BidEvalClausePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.grdData);
            this.Name = "BidEvalClausePage";
            this.Size = new System.Drawing.Size(909, 327);
            this.Load += new System.EventHandler(this.BidEvalClausePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroGrid grdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaxScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinScore;
        private System.Windows.Forms.DataGridViewComboBoxColumn colIsNeedFirstPara;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstParaDesc;
        private System.Windows.Forms.DataGridViewComboBoxColumn colIsNeeSecondPara;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecondParaDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlgoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSort;
    }
}