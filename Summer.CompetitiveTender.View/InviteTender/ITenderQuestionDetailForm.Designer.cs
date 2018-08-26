namespace Summer.CompetitiveTender.View.InviteTender
{
    partial class ITenderQuestionDetailForm
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
            this.txtDetail = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // txtDetail
            // 
            // 
            // 
            // 
            this.txtDetail.CustomButton.Image = null;
            this.txtDetail.CustomButton.Location = new System.Drawing.Point(162, 2);
            this.txtDetail.CustomButton.Name = "";
            this.txtDetail.CustomButton.Size = new System.Drawing.Size(395, 395);
            this.txtDetail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDetail.CustomButton.TabIndex = 1;
            this.txtDetail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDetail.CustomButton.UseSelectable = true;
            this.txtDetail.CustomButton.Visible = false;
            this.txtDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetail.Lines = new string[0];
            this.txtDetail.Location = new System.Drawing.Point(20, 60);
            this.txtDetail.MaxLength = 32767;
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.PasswordChar = '\0';
            this.txtDetail.ReadOnly = true;
            this.txtDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetail.SelectedText = "";
            this.txtDetail.SelectionLength = 0;
            this.txtDetail.SelectionStart = 0;
            this.txtDetail.ShortcutsEnabled = true;
            this.txtDetail.Size = new System.Drawing.Size(560, 400);
            this.txtDetail.TabIndex = 0;
            this.txtDetail.UseSelectable = true;
            this.txtDetail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDetail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ITenderQuestionDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Controls.Add(this.txtDetail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ITenderQuestionDetailForm";
            this.Resizable = false;
            this.Text = "招标文件问题详细信息";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtDetail;
    }
}