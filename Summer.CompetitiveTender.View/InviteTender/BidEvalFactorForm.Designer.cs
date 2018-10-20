namespace Summer.CompetitiveTender.View.InviteTender
{
    partial class BidEvalFactorForm
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtSort = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cboIsMust = new MetroFramework.Controls.MetroComboBox();
            this.btn_OK = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(74, 65);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "名称";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(117, 63);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "名称";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(232, 23);
            this.txtName.TabIndex = 3;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "名称";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(74, 104);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "排序";
            // 
            // txtSort
            // 
            // 
            // 
            // 
            this.txtSort.CustomButton.Image = null;
            this.txtSort.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txtSort.CustomButton.Name = "";
            this.txtSort.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSort.CustomButton.TabIndex = 1;
            this.txtSort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSort.CustomButton.UseSelectable = true;
            this.txtSort.CustomButton.Visible = false;
            this.txtSort.Lines = new string[0];
            this.txtSort.Location = new System.Drawing.Point(117, 102);
            this.txtSort.MaxLength = 32767;
            this.txtSort.Name = "txtSort";
            this.txtSort.PasswordChar = '\0';
            this.txtSort.PromptText = "排序";
            this.txtSort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSort.SelectedText = "";
            this.txtSort.SelectionLength = 0;
            this.txtSort.SelectionStart = 0;
            this.txtSort.ShortcutsEnabled = true;
            this.txtSort.Size = new System.Drawing.Size(232, 23);
            this.txtSort.TabIndex = 3;
            this.txtSort.UseSelectable = true;
            this.txtSort.WaterMark = "排序";
            this.txtSort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(46, 146);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "是否必需";
            // 
            // cboIsMust
            // 
            this.cboIsMust.FormattingEnabled = true;
            this.cboIsMust.ItemHeight = 23;
            this.cboIsMust.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cboIsMust.Location = new System.Drawing.Point(117, 141);
            this.cboIsMust.Name = "cboIsMust";
            this.cboIsMust.Size = new System.Drawing.Size(232, 29);
            this.cboIsMust.TabIndex = 1;
            this.cboIsMust.UseSelectable = true;
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(117, 194);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "提交";
            this.btn_OK.UseSelectable = true;
            this.btn_OK.Click += new System.EventHandler(this.btnSummit_Click);
            // 
            // BidEvalFactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(420, 240);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txtSort);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cboIsMust);
            this.Controls.Add(this.metroLabel5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BidEvalFactorForm";
            this.Resizable = false;
            this.Text = "新建评分因素";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtSort;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cboIsMust;
        private MetroFramework.Controls.MetroButton btn_OK;
    }
}