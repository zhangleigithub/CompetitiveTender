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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("招标模板");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("评标条款");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("评 分 点");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("生成招标文件");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("上传招标文件");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("打印招标文件");
            this.pnelFrame = new MetroFramework.Controls.MetroPanel();
            this.trvMenu = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
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
            this.pnelFrame.Location = new System.Drawing.Point(209, 63);
            this.pnelFrame.Name = "pnelFrame";
            this.pnelFrame.Size = new System.Drawing.Size(568, 514);
            this.pnelFrame.TabIndex = 0;
            this.pnelFrame.VerticalScrollbar = true;
            this.pnelFrame.VerticalScrollbarBarColor = false;
            this.pnelFrame.VerticalScrollbarHighlightOnWheel = true;
            this.pnelFrame.VerticalScrollbarSize = 10;
            // 
            // trvMenu
            // 
            this.trvMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trvMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trvMenu.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trvMenu.FullRowSelect = true;
            this.trvMenu.HideSelection = false;
            this.trvMenu.HotTracking = true;
            this.trvMenu.ItemHeight = 27;
            this.trvMenu.Location = new System.Drawing.Point(23, 63);
            this.trvMenu.Name = "trvMenu";
            treeNode1.Name = "";
            treeNode1.Text = "招标模板";
            treeNode2.Name = "";
            treeNode2.Text = "评标条款";
            treeNode3.Name = "";
            treeNode3.Text = "评 分 点";
            treeNode5.Name = "";
            treeNode5.Text = "生成招标文件";
            treeNode6.Name = "";
            treeNode6.Text = "上传招标文件";
            treeNode7.Name = "";
            treeNode7.Text = "打印招标文件";
            this.trvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode5,
            treeNode6,
            treeNode7});
            this.trvMenu.ShowLines = false;
            this.trvMenu.Size = new System.Drawing.Size(180, 514);
            this.trvMenu.TabIndex = 2;
            this.trvMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvMenu_AfterSelect);
            // 
            // EditITenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.trvMenu);
            this.Controls.Add(this.pnelFrame);
            this.Name = "EditITenderForm";
            this.Text = "编辑招标文件";
            this.Shown += new System.EventHandler(this.EditITenderForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel pnelFrame;
        private System.Windows.Forms.TreeView trvMenu;
    }
}