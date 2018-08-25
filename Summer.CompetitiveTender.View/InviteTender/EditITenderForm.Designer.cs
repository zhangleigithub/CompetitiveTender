namespace Summer.CompetitiveTender.View.InviteTender
{
    partial class EditITenderForm
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
            this.pnlMenu = new MetroFramework.Controls.MetroPanel();
            this.rbGeneral = new System.Windows.Forms.RadioButton();
            this.rbEvalFactor = new System.Windows.Forms.RadioButton();
            this.rbEvalPoint = new System.Windows.Forms.RadioButton();
            this.rbEvalClause = new System.Windows.Forms.RadioButton();
            this.rbTenderBody = new System.Windows.Forms.RadioButton();
            this.pnelFrame = new MetroFramework.Controls.MetroPanel();
            this.rbPrint = new System.Windows.Forms.RadioButton();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.Controls.Add(this.rbPrint);
            this.pnlMenu.Controls.Add(this.rbGeneral);
            this.pnlMenu.Controls.Add(this.rbEvalFactor);
            this.pnlMenu.Controls.Add(this.rbEvalPoint);
            this.pnlMenu.Controls.Add(this.rbEvalClause);
            this.pnlMenu.Controls.Add(this.rbTenderBody);
            this.pnlMenu.HorizontalScrollbarBarColor = true;
            this.pnlMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMenu.HorizontalScrollbarSize = 10;
            this.pnlMenu.Location = new System.Drawing.Point(23, 63);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(152, 514);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.VerticalScrollbarBarColor = true;
            this.pnlMenu.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMenu.VerticalScrollbarSize = 10;
            // 
            // rbGeneral
            // 
            this.rbGeneral.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbGeneral.AutoSize = true;
            this.rbGeneral.BackColor = System.Drawing.Color.Transparent;
            this.rbGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbGeneral.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.rbGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbGeneral.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbGeneral.Location = new System.Drawing.Point(0, 104);
            this.rbGeneral.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.rbGeneral.Name = "rbGeneral";
            this.rbGeneral.Size = new System.Drawing.Size(152, 26);
            this.rbGeneral.TabIndex = 7;
            this.rbGeneral.TabStop = true;
            this.rbGeneral.Text = "生成招标文件";
            this.rbGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbGeneral.UseVisualStyleBackColor = false;
            this.rbGeneral.Click += new System.EventHandler(this.rb_Click);
            // 
            // rbEvalFactor
            // 
            this.rbEvalFactor.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbEvalFactor.AutoSize = true;
            this.rbEvalFactor.BackColor = System.Drawing.Color.Transparent;
            this.rbEvalFactor.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbEvalFactor.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.rbEvalFactor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbEvalFactor.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbEvalFactor.Location = new System.Drawing.Point(0, 78);
            this.rbEvalFactor.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.rbEvalFactor.Name = "rbEvalFactor";
            this.rbEvalFactor.Size = new System.Drawing.Size(152, 26);
            this.rbEvalFactor.TabIndex = 5;
            this.rbEvalFactor.TabStop = true;
            this.rbEvalFactor.Text = "评分因素";
            this.rbEvalFactor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbEvalFactor.UseVisualStyleBackColor = false;
            this.rbEvalFactor.Click += new System.EventHandler(this.rb_Click);
            // 
            // rbEvalPoint
            // 
            this.rbEvalPoint.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbEvalPoint.AutoSize = true;
            this.rbEvalPoint.BackColor = System.Drawing.Color.Transparent;
            this.rbEvalPoint.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbEvalPoint.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.rbEvalPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbEvalPoint.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbEvalPoint.Location = new System.Drawing.Point(0, 52);
            this.rbEvalPoint.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.rbEvalPoint.Name = "rbEvalPoint";
            this.rbEvalPoint.Size = new System.Drawing.Size(152, 26);
            this.rbEvalPoint.TabIndex = 4;
            this.rbEvalPoint.TabStop = true;
            this.rbEvalPoint.Text = "评 分 点";
            this.rbEvalPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbEvalPoint.UseVisualStyleBackColor = false;
            this.rbEvalPoint.Click += new System.EventHandler(this.rb_Click);
            // 
            // rbEvalClause
            // 
            this.rbEvalClause.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbEvalClause.AutoSize = true;
            this.rbEvalClause.BackColor = System.Drawing.Color.Transparent;
            this.rbEvalClause.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbEvalClause.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.rbEvalClause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbEvalClause.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbEvalClause.Location = new System.Drawing.Point(0, 26);
            this.rbEvalClause.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.rbEvalClause.Name = "rbEvalClause";
            this.rbEvalClause.Size = new System.Drawing.Size(152, 26);
            this.rbEvalClause.TabIndex = 3;
            this.rbEvalClause.TabStop = true;
            this.rbEvalClause.Text = "评分条款";
            this.rbEvalClause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbEvalClause.UseVisualStyleBackColor = false;
            this.rbEvalClause.Click += new System.EventHandler(this.rb_Click);
            // 
            // rbTenderBody
            // 
            this.rbTenderBody.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbTenderBody.AutoSize = true;
            this.rbTenderBody.BackColor = System.Drawing.Color.Transparent;
            this.rbTenderBody.Checked = true;
            this.rbTenderBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbTenderBody.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.rbTenderBody.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbTenderBody.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbTenderBody.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbTenderBody.Location = new System.Drawing.Point(0, 0);
            this.rbTenderBody.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.rbTenderBody.Name = "rbTenderBody";
            this.rbTenderBody.Size = new System.Drawing.Size(152, 26);
            this.rbTenderBody.TabIndex = 3;
            this.rbTenderBody.TabStop = true;
            this.rbTenderBody.Text = "招标正文";
            this.rbTenderBody.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbTenderBody.UseVisualStyleBackColor = false;
            this.rbTenderBody.Click += new System.EventHandler(this.rb_Click);
            // 
            // pnelFrame
            // 
            this.pnelFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnelFrame.AutoScroll = true;
            this.pnelFrame.HorizontalScrollbar = true;
            this.pnelFrame.HorizontalScrollbarBarColor = true;
            this.pnelFrame.HorizontalScrollbarHighlightOnWheel = false;
            this.pnelFrame.HorizontalScrollbarSize = 10;
            this.pnelFrame.Location = new System.Drawing.Point(181, 63);
            this.pnelFrame.Name = "pnelFrame";
            this.pnelFrame.Size = new System.Drawing.Size(596, 514);
            this.pnelFrame.TabIndex = 0;
            this.pnelFrame.VerticalScrollbar = true;
            this.pnelFrame.VerticalScrollbarBarColor = false;
            this.pnelFrame.VerticalScrollbarHighlightOnWheel = true;
            this.pnelFrame.VerticalScrollbarSize = 10;
            // 
            // rbPrint
            // 
            this.rbPrint.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPrint.AutoSize = true;
            this.rbPrint.BackColor = System.Drawing.Color.Transparent;
            this.rbPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbPrint.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.rbPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbPrint.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbPrint.Location = new System.Drawing.Point(0, 130);
            this.rbPrint.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.rbPrint.Name = "rbPrint";
            this.rbPrint.Size = new System.Drawing.Size(152, 26);
            this.rbPrint.TabIndex = 8;
            this.rbPrint.TabStop = true;
            this.rbPrint.Text = "打印招标文件";
            this.rbPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPrint.UseVisualStyleBackColor = false;
            this.rbPrint.Click += new System.EventHandler(this.rb_Click);
            // 
            // EditITenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnelFrame);
            this.Controls.Add(this.pnlMenu);
            this.Name = "EditITenderForm";
            this.Text = "编辑招标文件";
            this.Shown += new System.EventHandler(this.EditITenderForm_Shown);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlMenu;
        private System.Windows.Forms.RadioButton rbEvalClause;
        private System.Windows.Forms.RadioButton rbTenderBody;
        private MetroFramework.Controls.MetroPanel pnelFrame;
        private System.Windows.Forms.RadioButton rbGeneral;
        private System.Windows.Forms.RadioButton rbEvalFactor;
        private System.Windows.Forms.RadioButton rbEvalPoint;
        private System.Windows.Forms.RadioButton rbPrint;
    }
}