namespace Summer.CompetitiveTender.View.InviteTender
{
    partial class BidEvalScoringPointForm
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
            this.btn_OK = new MetroFramework.Controls.MetroButton();
            this.cboCanDelete = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txtLittleNum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txtLittleWay = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtGreatNum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtGreatWay = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtStandard = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtMinScore = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtMaxScore = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtGrads = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtNum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtUnit = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(165, 469);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 28;
            this.btn_OK.Text = "提交";
            this.btn_OK.UseSelectable = true;
            this.btn_OK.Click += new System.EventHandler(this.btnSummit_Click);
            // 
            // cboCanDelete
            // 
            this.cboCanDelete.FormattingEnabled = true;
            this.cboCanDelete.ItemHeight = 23;
            this.cboCanDelete.Items.AddRange(new object[] {
            "可以",
            "不可以"});
            this.cboCanDelete.Location = new System.Drawing.Point(165, 407);
            this.cboCanDelete.Name = "cboCanDelete";
            this.cboCanDelete.Size = new System.Drawing.Size(205, 29);
            this.cboCanDelete.TabIndex = 27;
            this.cboCanDelete.UseSelectable = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(66, 412);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(93, 19);
            this.metroLabel14.TabIndex = 15;
            this.metroLabel14.Text = "是否可以删除";
            // 
            // txtLittleNum
            // 
            // 
            // 
            // 
            this.txtLittleNum.CustomButton.Image = null;
            this.txtLittleNum.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtLittleNum.CustomButton.Name = "";
            this.txtLittleNum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLittleNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLittleNum.CustomButton.TabIndex = 1;
            this.txtLittleNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLittleNum.CustomButton.UseSelectable = true;
            this.txtLittleNum.CustomButton.Visible = false;
            this.txtLittleNum.Lines = new string[0];
            this.txtLittleNum.Location = new System.Drawing.Point(165, 376);
            this.txtLittleNum.MaxLength = 32767;
            this.txtLittleNum.Name = "txtLittleNum";
            this.txtLittleNum.PasswordChar = '\0';
            this.txtLittleNum.PromptText = "小于基准梯度值";
            this.txtLittleNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLittleNum.SelectedText = "";
            this.txtLittleNum.SelectionLength = 0;
            this.txtLittleNum.SelectionStart = 0;
            this.txtLittleNum.ShortcutsEnabled = true;
            this.txtLittleNum.Size = new System.Drawing.Size(205, 23);
            this.txtLittleNum.TabIndex = 23;
            this.txtLittleNum.UseSelectable = true;
            this.txtLittleNum.WaterMark = "小于基准梯度值";
            this.txtLittleNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLittleNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(52, 378);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(107, 19);
            this.metroLabel13.TabIndex = 14;
            this.metroLabel13.Text = "小于基准梯度值";
            // 
            // txtLittleWay
            // 
            // 
            // 
            // 
            this.txtLittleWay.CustomButton.Image = null;
            this.txtLittleWay.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtLittleWay.CustomButton.Name = "";
            this.txtLittleWay.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLittleWay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLittleWay.CustomButton.TabIndex = 1;
            this.txtLittleWay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLittleWay.CustomButton.UseSelectable = true;
            this.txtLittleWay.CustomButton.Visible = false;
            this.txtLittleWay.Lines = new string[0];
            this.txtLittleWay.Location = new System.Drawing.Point(165, 345);
            this.txtLittleWay.MaxLength = 32767;
            this.txtLittleWay.Name = "txtLittleWay";
            this.txtLittleWay.PasswordChar = '\0';
            this.txtLittleWay.PromptText = "小于基准算法";
            this.txtLittleWay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLittleWay.SelectedText = "";
            this.txtLittleWay.SelectionLength = 0;
            this.txtLittleWay.SelectionStart = 0;
            this.txtLittleWay.ShortcutsEnabled = true;
            this.txtLittleWay.Size = new System.Drawing.Size(205, 23);
            this.txtLittleWay.TabIndex = 20;
            this.txtLittleWay.UseSelectable = true;
            this.txtLittleWay.WaterMark = "小于基准算法";
            this.txtLittleWay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLittleWay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(66, 347);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(93, 19);
            this.metroLabel12.TabIndex = 13;
            this.metroLabel12.Text = "小于基准算法";
            // 
            // txtGreatNum
            // 
            // 
            // 
            // 
            this.txtGreatNum.CustomButton.Image = null;
            this.txtGreatNum.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtGreatNum.CustomButton.Name = "";
            this.txtGreatNum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGreatNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGreatNum.CustomButton.TabIndex = 1;
            this.txtGreatNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGreatNum.CustomButton.UseSelectable = true;
            this.txtGreatNum.CustomButton.Visible = false;
            this.txtGreatNum.Lines = new string[0];
            this.txtGreatNum.Location = new System.Drawing.Point(165, 314);
            this.txtGreatNum.MaxLength = 32767;
            this.txtGreatNum.Name = "txtGreatNum";
            this.txtGreatNum.PasswordChar = '\0';
            this.txtGreatNum.PromptText = "大于基准梯度值";
            this.txtGreatNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGreatNum.SelectedText = "";
            this.txtGreatNum.SelectionLength = 0;
            this.txtGreatNum.SelectionStart = 0;
            this.txtGreatNum.ShortcutsEnabled = true;
            this.txtGreatNum.Size = new System.Drawing.Size(205, 23);
            this.txtGreatNum.TabIndex = 26;
            this.txtGreatNum.UseSelectable = true;
            this.txtGreatNum.WaterMark = "大于基准梯度值";
            this.txtGreatNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGreatNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(52, 316);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(107, 19);
            this.metroLabel11.TabIndex = 11;
            this.metroLabel11.Text = "大于基准梯度值";
            // 
            // txtGreatWay
            // 
            // 
            // 
            // 
            this.txtGreatWay.CustomButton.Image = null;
            this.txtGreatWay.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtGreatWay.CustomButton.Name = "";
            this.txtGreatWay.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGreatWay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGreatWay.CustomButton.TabIndex = 1;
            this.txtGreatWay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGreatWay.CustomButton.UseSelectable = true;
            this.txtGreatWay.CustomButton.Visible = false;
            this.txtGreatWay.Lines = new string[0];
            this.txtGreatWay.Location = new System.Drawing.Point(165, 283);
            this.txtGreatWay.MaxLength = 32767;
            this.txtGreatWay.Name = "txtGreatWay";
            this.txtGreatWay.PasswordChar = '\0';
            this.txtGreatWay.PromptText = "大于基准算法";
            this.txtGreatWay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGreatWay.SelectedText = "";
            this.txtGreatWay.SelectionLength = 0;
            this.txtGreatWay.SelectionStart = 0;
            this.txtGreatWay.ShortcutsEnabled = true;
            this.txtGreatWay.Size = new System.Drawing.Size(205, 23);
            this.txtGreatWay.TabIndex = 16;
            this.txtGreatWay.UseSelectable = true;
            this.txtGreatWay.WaterMark = "大于基准算法";
            this.txtGreatWay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGreatWay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(66, 285);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(93, 19);
            this.metroLabel10.TabIndex = 10;
            this.metroLabel10.Text = "大于基准算法";
            // 
            // txtStandard
            // 
            // 
            // 
            // 
            this.txtStandard.CustomButton.Image = null;
            this.txtStandard.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtStandard.CustomButton.Name = "";
            this.txtStandard.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStandard.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStandard.CustomButton.TabIndex = 1;
            this.txtStandard.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStandard.CustomButton.UseSelectable = true;
            this.txtStandard.CustomButton.Visible = false;
            this.txtStandard.Lines = new string[0];
            this.txtStandard.Location = new System.Drawing.Point(165, 252);
            this.txtStandard.MaxLength = 32767;
            this.txtStandard.Name = "txtStandard";
            this.txtStandard.PasswordChar = '\0';
            this.txtStandard.PromptText = "基准";
            this.txtStandard.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStandard.SelectedText = "";
            this.txtStandard.SelectionLength = 0;
            this.txtStandard.SelectionStart = 0;
            this.txtStandard.ShortcutsEnabled = true;
            this.txtStandard.Size = new System.Drawing.Size(205, 23);
            this.txtStandard.TabIndex = 17;
            this.txtStandard.UseSelectable = true;
            this.txtStandard.WaterMark = "基准";
            this.txtStandard.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStandard.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(122, 254);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(37, 19);
            this.metroLabel9.TabIndex = 4;
            this.metroLabel9.Text = "基准";
            // 
            // txtMinScore
            // 
            // 
            // 
            // 
            this.txtMinScore.CustomButton.Image = null;
            this.txtMinScore.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtMinScore.CustomButton.Name = "";
            this.txtMinScore.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMinScore.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMinScore.CustomButton.TabIndex = 1;
            this.txtMinScore.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMinScore.CustomButton.UseSelectable = true;
            this.txtMinScore.CustomButton.Visible = false;
            this.txtMinScore.Lines = new string[0];
            this.txtMinScore.Location = new System.Drawing.Point(165, 221);
            this.txtMinScore.MaxLength = 32767;
            this.txtMinScore.Name = "txtMinScore";
            this.txtMinScore.PasswordChar = '\0';
            this.txtMinScore.PromptText = "基准分数最小值";
            this.txtMinScore.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMinScore.SelectedText = "";
            this.txtMinScore.SelectionLength = 0;
            this.txtMinScore.SelectionStart = 0;
            this.txtMinScore.ShortcutsEnabled = true;
            this.txtMinScore.Size = new System.Drawing.Size(205, 23);
            this.txtMinScore.TabIndex = 19;
            this.txtMinScore.UseSelectable = true;
            this.txtMinScore.WaterMark = "基准分数最小值";
            this.txtMinScore.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMinScore.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(52, 223);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(107, 19);
            this.metroLabel8.TabIndex = 9;
            this.metroLabel8.Text = "基准分数最小值";
            // 
            // txtMaxScore
            // 
            // 
            // 
            // 
            this.txtMaxScore.CustomButton.Image = null;
            this.txtMaxScore.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtMaxScore.CustomButton.Name = "";
            this.txtMaxScore.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaxScore.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaxScore.CustomButton.TabIndex = 1;
            this.txtMaxScore.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaxScore.CustomButton.UseSelectable = true;
            this.txtMaxScore.CustomButton.Visible = false;
            this.txtMaxScore.Lines = new string[0];
            this.txtMaxScore.Location = new System.Drawing.Point(165, 190);
            this.txtMaxScore.MaxLength = 32767;
            this.txtMaxScore.Name = "txtMaxScore";
            this.txtMaxScore.PasswordChar = '\0';
            this.txtMaxScore.PromptText = "基准分数最大值";
            this.txtMaxScore.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaxScore.SelectedText = "";
            this.txtMaxScore.SelectionLength = 0;
            this.txtMaxScore.SelectionStart = 0;
            this.txtMaxScore.ShortcutsEnabled = true;
            this.txtMaxScore.Size = new System.Drawing.Size(205, 23);
            this.txtMaxScore.TabIndex = 21;
            this.txtMaxScore.UseSelectable = true;
            this.txtMaxScore.WaterMark = "基准分数最大值";
            this.txtMaxScore.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaxScore.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(52, 192);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(107, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "基准分数最大值";
            // 
            // txtGrads
            // 
            // 
            // 
            // 
            this.txtGrads.CustomButton.Image = null;
            this.txtGrads.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtGrads.CustomButton.Name = "";
            this.txtGrads.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGrads.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGrads.CustomButton.TabIndex = 1;
            this.txtGrads.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGrads.CustomButton.UseSelectable = true;
            this.txtGrads.CustomButton.Visible = false;
            this.txtGrads.Lines = new string[0];
            this.txtGrads.Location = new System.Drawing.Point(165, 159);
            this.txtGrads.MaxLength = 32767;
            this.txtGrads.Name = "txtGrads";
            this.txtGrads.PasswordChar = '\0';
            this.txtGrads.PromptText = "评标因素数值梯度";
            this.txtGrads.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGrads.SelectedText = "";
            this.txtGrads.SelectionLength = 0;
            this.txtGrads.SelectionStart = 0;
            this.txtGrads.ShortcutsEnabled = true;
            this.txtGrads.Size = new System.Drawing.Size(205, 23);
            this.txtGrads.TabIndex = 22;
            this.txtGrads.UseSelectable = true;
            this.txtGrads.WaterMark = "评标因素数值梯度";
            this.txtGrads.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGrads.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(38, 161);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(121, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "评标因素数值梯度";
            // 
            // txtNum
            // 
            // 
            // 
            // 
            this.txtNum.CustomButton.Image = null;
            this.txtNum.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtNum.CustomButton.Name = "";
            this.txtNum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNum.CustomButton.TabIndex = 1;
            this.txtNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNum.CustomButton.UseSelectable = true;
            this.txtNum.CustomButton.Visible = false;
            this.txtNum.Lines = new string[0];
            this.txtNum.Location = new System.Drawing.Point(165, 128);
            this.txtNum.MaxLength = 32767;
            this.txtNum.Name = "txtNum";
            this.txtNum.PasswordChar = '\0';
            this.txtNum.PromptText = "评标因素数值";
            this.txtNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNum.SelectedText = "";
            this.txtNum.SelectionLength = 0;
            this.txtNum.SelectionStart = 0;
            this.txtNum.ShortcutsEnabled = true;
            this.txtNum.Size = new System.Drawing.Size(205, 23);
            this.txtNum.TabIndex = 24;
            this.txtNum.UseSelectable = true;
            this.txtNum.WaterMark = "评标因素数值";
            this.txtNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(66, 130);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(93, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "评标因素数值";
            // 
            // txtUnit
            // 
            // 
            // 
            // 
            this.txtUnit.CustomButton.Image = null;
            this.txtUnit.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtUnit.CustomButton.Name = "";
            this.txtUnit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUnit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnit.CustomButton.TabIndex = 1;
            this.txtUnit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnit.CustomButton.UseSelectable = true;
            this.txtUnit.CustomButton.Visible = false;
            this.txtUnit.Lines = new string[0];
            this.txtUnit.Location = new System.Drawing.Point(165, 97);
            this.txtUnit.MaxLength = 32767;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.PasswordChar = '\0';
            this.txtUnit.PromptText = "评标因素单位";
            this.txtUnit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUnit.SelectedText = "";
            this.txtUnit.SelectionLength = 0;
            this.txtUnit.SelectionStart = 0;
            this.txtUnit.ShortcutsEnabled = true;
            this.txtUnit.Size = new System.Drawing.Size(205, 23);
            this.txtUnit.TabIndex = 25;
            this.txtUnit.UseSelectable = true;
            this.txtUnit.WaterMark = "评标因素单位";
            this.txtUnit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUnit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(66, 99);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "评标因素单位";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(165, 66);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "名称";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(205, 23);
            this.txtName.TabIndex = 18;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "名称";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(122, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "名称";
            // 
            // BidEvalScoringPointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 512);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.cboCanDelete);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.txtLittleNum);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.txtLittleWay);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.txtGreatNum);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.txtGreatWay);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txtStandard);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtMinScore);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txtMaxScore);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtGrads);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BidEvalScoringPointForm";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "评分点";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_OK;
        private MetroFramework.Controls.MetroComboBox cboCanDelete;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txtLittleNum;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox txtLittleWay;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtGreatNum;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtGreatWay;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtStandard;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtMinScore;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtMaxScore;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtGrads;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtNum;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtUnit;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}