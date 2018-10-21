namespace Summer.CompetitiveTender.View.EvaluationOfBids
{
    partial class EOBBidFileForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdBids = new MetroFramework.Controls.MetroGrid();
            this.colTbrCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTbrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTbrCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBidTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReview = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdBids)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBids
            // 
            this.grdBids.AllowUserToAddRows = false;
            this.grdBids.AllowUserToDeleteRows = false;
            this.grdBids.AllowUserToResizeRows = false;
            this.grdBids.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdBids.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdBids.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdBids.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBids.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdBids.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBids.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTbrCompanyName,
            this.colTbrName,
            this.colTbrCode,
            this.colBidTime,
            this.colReview});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBids.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdBids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBids.EnableHeadersVisualStyles = false;
            this.grdBids.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdBids.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdBids.Location = new System.Drawing.Point(20, 60);
            this.grdBids.Name = "grdBids";
            this.grdBids.ReadOnly = true;
            this.grdBids.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBids.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdBids.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdBids.RowTemplate.Height = 23;
            this.grdBids.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBids.Size = new System.Drawing.Size(553, 305);
            this.grdBids.TabIndex = 0;
            this.grdBids.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBids_CellContentClick);
            // 
            // colTbrCompanyName
            // 
            this.colTbrCompanyName.HeaderText = "企业名称";
            this.colTbrCompanyName.Name = "colTbrCompanyName";
            this.colTbrCompanyName.ReadOnly = true;
            // 
            // colTbrName
            // 
            this.colTbrName.HeaderText = "投标人";
            this.colTbrName.Name = "colTbrName";
            this.colTbrName.ReadOnly = true;
            // 
            // colTbrCode
            // 
            this.colTbrCode.HeaderText = "投标人代码";
            this.colTbrCode.Name = "colTbrCode";
            this.colTbrCode.ReadOnly = true;
            // 
            // colBidTime
            // 
            this.colBidTime.HeaderText = "投标时间";
            this.colBidTime.Name = "colBidTime";
            this.colBidTime.ReadOnly = true;
            // 
            // colReview
            // 
            this.colReview.HeaderText = "评分";
            this.colReview.Name = "colReview";
            this.colReview.ReadOnly = true;
            // 
            // EOBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(593, 385);
            this.Controls.Add(this.grdBids);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EOBForm";
            this.Text = "投标文件";
            this.Shown += new System.EventHandler(this.EOBForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdBids)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdBids;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTbrCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTbrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTbrCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBidTime;
        private System.Windows.Forms.DataGridViewLinkColumn colReview;
    }
}