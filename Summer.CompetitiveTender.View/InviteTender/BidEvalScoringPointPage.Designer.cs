namespace Summer.CompetitiveTender.View.InviteTender
{
    partial class BidEvalScoringPointPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.grdData = new MetroFramework.Controls.MetroGrid();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStandard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGreatWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGreatNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLittleWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLittleNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCanDelete = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(263, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "删除评分点";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(133, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 23);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "编辑评分点";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(124, 23);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "新建评分点";
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colUnit,
            this.colNum,
            this.colGrads,
            this.colMaxScore,
            this.colMinScore,
            this.colStandard,
            this.colGreatWay,
            this.colGreatNum,
            this.colLittleWay,
            this.colLittleNum,
            this.colCanDelete});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdData.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdData.EnableHeadersVisualStyles = false;
            this.grdData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdData.Location = new System.Drawing.Point(3, 32);
            this.grdData.MultiSelect = false;
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdData.RowTemplate.Height = 23;
            this.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdData.Size = new System.Drawing.Size(715, 378);
            this.grdData.TabIndex = 12;
            // 
            // colName
            // 
            this.colName.HeaderText = "评标因素名称";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "评标因素单位";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // colNum
            // 
            this.colNum.HeaderText = "评标因素数值";
            this.colNum.Name = "colNum";
            this.colNum.ReadOnly = true;
            // 
            // colGrads
            // 
            this.colGrads.HeaderText = "评标因素数值梯度";
            this.colGrads.Name = "colGrads";
            this.colGrads.ReadOnly = true;
            // 
            // colMaxScore
            // 
            this.colMaxScore.HeaderText = "基准分数最大值";
            this.colMaxScore.Name = "colMaxScore";
            this.colMaxScore.ReadOnly = true;
            // 
            // colMinScore
            // 
            this.colMinScore.HeaderText = "基准分数最小值";
            this.colMinScore.Name = "colMinScore";
            this.colMinScore.ReadOnly = true;
            // 
            // colStandard
            // 
            this.colStandard.HeaderText = "基准";
            this.colStandard.Name = "colStandard";
            this.colStandard.ReadOnly = true;
            // 
            // colGreatWay
            // 
            this.colGreatWay.HeaderText = "大于基准算法";
            this.colGreatWay.Name = "colGreatWay";
            this.colGreatWay.ReadOnly = true;
            // 
            // colGreatNum
            // 
            this.colGreatNum.HeaderText = "大于基准梯度值";
            this.colGreatNum.Name = "colGreatNum";
            this.colGreatNum.ReadOnly = true;
            // 
            // colLittleWay
            // 
            this.colLittleWay.HeaderText = "小于基准算法";
            this.colLittleWay.Name = "colLittleWay";
            this.colLittleWay.ReadOnly = true;
            // 
            // colLittleNum
            // 
            this.colLittleNum.HeaderText = "小于基准梯度值";
            this.colLittleNum.Name = "colLittleNum";
            this.colLittleNum.ReadOnly = true;
            // 
            // colCanDelete
            // 
            this.colCanDelete.HeaderText = "是否可以删除";
            this.colCanDelete.Name = "colCanDelete";
            this.colCanDelete.ReadOnly = true;
            this.colCanDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCanDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BidEvalScoringPointPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.grdData);
            this.Name = "BidEvalScoringPointPage";
            this.Size = new System.Drawing.Size(721, 413);
            this.Load += new System.EventHandler(this.BidEvalScoringPointPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroGrid grdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrads;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaxScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStandard;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGreatWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGreatNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLittleWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLittleNum;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCanDelete;
    }
}