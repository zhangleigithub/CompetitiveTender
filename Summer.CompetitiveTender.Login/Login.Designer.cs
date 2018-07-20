namespace Summer.CompetitiveTender.Login
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.rbInviteTender = new System.Windows.Forms.RadioButton();
            this.rbTender = new System.Windows.Forms.RadioButton();
            this.rbExpert = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 21);
            this.textBox2.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(114, 204);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(236, 33);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "登  录";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // rbInviteTender
            // 
            this.rbInviteTender.AutoSize = true;
            this.rbInviteTender.Checked = true;
            this.rbInviteTender.Location = new System.Drawing.Point(159, 170);
            this.rbInviteTender.Name = "rbInviteTender";
            this.rbInviteTender.Size = new System.Drawing.Size(59, 16);
            this.rbInviteTender.TabIndex = 5;
            this.rbInviteTender.TabStop = true;
            this.rbInviteTender.Text = "招标人";
            this.rbInviteTender.UseVisualStyleBackColor = true;
            // 
            // rbTender
            // 
            this.rbTender.AutoSize = true;
            this.rbTender.Location = new System.Drawing.Point(231, 170);
            this.rbTender.Name = "rbTender";
            this.rbTender.Size = new System.Drawing.Size(59, 16);
            this.rbTender.TabIndex = 6;
            this.rbTender.Text = "投标人";
            this.rbTender.UseVisualStyleBackColor = true;
            // 
            // rbExpert
            // 
            this.rbExpert.AutoSize = true;
            this.rbExpert.Location = new System.Drawing.Point(303, 170);
            this.rbExpert.Name = "rbExpert";
            this.rbExpert.Size = new System.Drawing.Size(47, 16);
            this.rbExpert.TabIndex = 7;
            this.rbExpert.Text = "专家";
            this.rbExpert.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.rbExpert);
            this.Controls.Add(this.rbTender);
            this.Controls.Add(this.rbInviteTender);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RadioButton rbInviteTender;
        private System.Windows.Forms.RadioButton rbTender;
        private System.Windows.Forms.RadioButton rbExpert;
    }
}