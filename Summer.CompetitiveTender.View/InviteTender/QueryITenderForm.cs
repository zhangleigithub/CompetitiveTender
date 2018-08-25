using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Summer.CompetitiveTender.View.InviteTender
{
    public partial class QueryITenderForm : MetroForm
    {
        public QueryITenderForm()
        {
            InitializeComponent();
        }

        private void QueryITenderForm_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                this.grdITender.Rows.Add("测试" + i, "测试", "测试", "测试", "测试", "测试", "测试", "测试", "项目详情", "编辑招标文件", "删除招标文件");
            }
        }

        private void grdITender_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.colITenderDetail.Index)
            {
                ITenderDetailForm iTenderDetailForm = new ITenderDetailForm();
                iTenderDetailForm.ShowDialog(this);
            }
            else if (e.ColumnIndex == this.colEditITenderFile.Index)
            {
                EditITenderForm editProjectForm = new EditITenderForm();
                editProjectForm.ShowDialog(this);
                editProjectForm.Dispose();
            }
            else if (e.ColumnIndex == this.colDeleteITenderFile.Index)
            {
                if (MetroMessageBox.Show(this, "确定要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.grdITender.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
