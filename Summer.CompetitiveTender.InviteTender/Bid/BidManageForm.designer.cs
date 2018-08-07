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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tab_MakeTemplate = new MetroFramework.Controls.MetroTabPage();
            this.dgv_BidFileList = new MetroFramework.Controls.MetroGrid();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.c5 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.c6 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.c7 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.c8 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btn_AddBidFileTemp = new MetroFramework.Controls.MetroButton();
            this.tab_MakeTenderFile = new MetroFramework.Controls.MetroTabPage();
            this.tab_DiscussArea = new MetroFramework.Controls.MetroTabPage();
            this.tabControl1.SuspendLayout();
            this.tab_MakeTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BidFileList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_MakeTemplate);
            this.tabControl1.Controls.Add(this.tab_MakeTenderFile);
            this.tabControl1.Controls.Add(this.tab_DiscussArea);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(724, 459);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.UseSelectable = true;
            // 
            // tab_MakeTemplate
            // 
            this.tab_MakeTemplate.Controls.Add(this.dgv_BidFileList);
            this.tab_MakeTemplate.Controls.Add(this.btn_AddBidFileTemp);
            this.tab_MakeTemplate.HorizontalScrollbarBarColor = true;
            this.tab_MakeTemplate.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_MakeTemplate.HorizontalScrollbarSize = 10;
            this.tab_MakeTemplate.Location = new System.Drawing.Point(4, 38);
            this.tab_MakeTemplate.Name = "tab_MakeTemplate";
            this.tab_MakeTemplate.Padding = new System.Windows.Forms.Padding(3);
            this.tab_MakeTemplate.Size = new System.Drawing.Size(716, 417);
            this.tab_MakeTemplate.TabIndex = 0;
            this.tab_MakeTemplate.Text = "制作模板";
            this.tab_MakeTemplate.UseVisualStyleBackColor = true;
            this.tab_MakeTemplate.VerticalScrollbarBarColor = true;
            this.tab_MakeTemplate.VerticalScrollbarHighlightOnWheel = false;
            this.tab_MakeTemplate.VerticalScrollbarSize = 10;
            // 
            // dgv_BidFileList
            // 
            this.dgv_BidFileList.AllowUserToAddRows = false;
            this.dgv_BidFileList.AllowUserToResizeRows = false;
            this.dgv_BidFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_BidFileList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_BidFileList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_BidFileList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_BidFileList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BidFileList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_BidFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BidFileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5,
            this.c6,
            this.c7,
            this.c8});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BidFileList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_BidFileList.EnableHeadersVisualStyles = false;
            this.dgv_BidFileList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_BidFileList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_BidFileList.Location = new System.Drawing.Point(3, 51);
            this.dgv_BidFileList.Name = "dgv_BidFileList";
            this.dgv_BidFileList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BidFileList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_BidFileList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_BidFileList.RowTemplate.Height = 23;
            this.dgv_BidFileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_BidFileList.Size = new System.Drawing.Size(710, 382);
            this.dgv_BidFileList.TabIndex = 2;
            // 
            // c1
            // 
            this.c1.HeaderText = "模板名称";
            this.c1.Name = "c1";
            // 
            // c2
            // 
            this.c2.HeaderText = "所属项目";
            this.c2.Name = "c2";
            // 
            // c3
            // 
            this.c3.HeaderText = "创建时间";
            this.c3.Name = "c3";
            // 
            // c4
            // 
            this.c4.HeaderText = "修改";
            this.c4.Name = "c4";
            // 
            // c5
            // 
            this.c5.HeaderText = "删除";
            this.c5.Name = "c5";
            // 
            // c6
            // 
            this.c6.HeaderText = "预览";
            this.c6.Name = "c6";
            // 
            // c7
            // 
            this.c7.HeaderText = "打印";
            this.c7.Name = "c7";
            // 
            // c8
            // 
            this.c8.HeaderText = "下载";
            this.c8.Name = "c8";
            // 
            // btn_AddBidFileTemp
            // 
            this.btn_AddBidFileTemp.Location = new System.Drawing.Point(6, 12);
            this.btn_AddBidFileTemp.Name = "btn_AddBidFileTemp";
            this.btn_AddBidFileTemp.Size = new System.Drawing.Size(90, 23);
            this.btn_AddBidFileTemp.TabIndex = 1;
            this.btn_AddBidFileTemp.Text = "新增模板";
            this.btn_AddBidFileTemp.UseSelectable = true;
            // 
            // tab_MakeTenderFile
            // 
            this.tab_MakeTenderFile.HorizontalScrollbarBarColor = true;
            this.tab_MakeTenderFile.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_MakeTenderFile.HorizontalScrollbarSize = 10;
            this.tab_MakeTenderFile.Location = new System.Drawing.Point(4, 38);
            this.tab_MakeTenderFile.Name = "tab_MakeTenderFile";
            this.tab_MakeTenderFile.Padding = new System.Windows.Forms.Padding(3);
            this.tab_MakeTenderFile.Size = new System.Drawing.Size(756, 497);
            this.tab_MakeTenderFile.TabIndex = 1;
            this.tab_MakeTenderFile.Text = "制作招标文件";
            this.tab_MakeTenderFile.UseVisualStyleBackColor = true;
            this.tab_MakeTenderFile.VerticalScrollbarBarColor = true;
            this.tab_MakeTenderFile.VerticalScrollbarHighlightOnWheel = false;
            this.tab_MakeTenderFile.VerticalScrollbarSize = 10;
            // 
            // tab_DiscussArea
            // 
            this.tab_DiscussArea.HorizontalScrollbarBarColor = true;
            this.tab_DiscussArea.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_DiscussArea.HorizontalScrollbarSize = 10;
            this.tab_DiscussArea.Location = new System.Drawing.Point(4, 38);
            this.tab_DiscussArea.Name = "tab_DiscussArea";
            this.tab_DiscussArea.Size = new System.Drawing.Size(756, 497);
            this.tab_DiscussArea.TabIndex = 2;
            this.tab_DiscussArea.Text = "讨论区";
            this.tab_DiscussArea.UseVisualStyleBackColor = true;
            this.tab_DiscussArea.VerticalScrollbarBarColor = true;
            this.tab_DiscussArea.VerticalScrollbarHighlightOnWheel = false;
            this.tab_DiscussArea.VerticalScrollbarSize = 10;
            // 
            // BidManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 539);
            this.Controls.Add(this.tabControl1);
            this.Name = "BidManageForm";
            this.Text = "投标文件制作";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BidManage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_MakeTemplate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BidFileList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl1;
        private MetroFramework.Controls.MetroTabPage tab_MakeTemplate;
        private MetroFramework.Controls.MetroButton btn_AddBidFileTemp;
        private MetroFramework.Controls.MetroTabPage tab_MakeTenderFile;
        private MetroFramework.Controls.MetroTabPage tab_DiscussArea;
        private MetroFramework.Controls.MetroGrid dgv_BidFileList;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewLinkColumn c4;
        private System.Windows.Forms.DataGridViewLinkColumn c5;
        private System.Windows.Forms.DataGridViewLinkColumn c6;
        private System.Windows.Forms.DataGridViewLinkColumn c7;
        private System.Windows.Forms.DataGridViewLinkColumn c8;
    }
}