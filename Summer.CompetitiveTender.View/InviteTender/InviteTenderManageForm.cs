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
    public partial class InviteTenderManageForm : MetroForm
    {
        public InviteTenderManageForm()
        {
            InitializeComponent();

            this.grdTemplate.TopRow = new Common.Controls.MultiHeaderDataGridView.DataGridViewRowTopRow(this.grdTemplate);
            this.grdTemplate.TopRow.Cells[6].HeaderText = "操作";
            this.grdTemplate.TopRow.Cells[6].ColumnSpan = 5;
            this.grdTemplate.TopRow.Cells[6].ColumnIndex = -1;
            this.grdTemplate.TopRow.Cells[7].HeaderText = "操作";
            this.grdTemplate.TopRow.Cells[7].ColumnSpan = 5;
            this.grdTemplate.TopRow.Cells[7].ColumnIndex = -1;
            this.grdTemplate.TopRow.Cells[8].HeaderText = "操作";
            this.grdTemplate.TopRow.Cells[8].ColumnSpan = 5;
            this.grdTemplate.TopRow.Cells[8].ColumnIndex = -1;
            this.grdTemplate.TopRow.Cells[9].HeaderText = "操作";
            this.grdTemplate.TopRow.Cells[9].ColumnSpan = 5;
            this.grdTemplate.TopRow.Cells[9].ColumnIndex = -1;
            this.grdTemplate.TopRow.Cells[10].HeaderText = "操作";
            this.grdTemplate.TopRow.Cells[10].ColumnSpan = 5;
            this.grdTemplate.TopRow.Cells[10].ColumnIndex = 6;

            for (int i = 0; i < 30; i++)
            {
                this.grdTemplate.Rows.Add("测试" + i, "测试", "测试", "节点信息", "测试", DateTime.Now.ToLocalTime(), "编辑", "删除", "预览", "打印", "下载");
            }

            for (int i = 0; i < 30; i++)
            {
                this.metroGrid2.Rows.Add("测试" + i, DateTime.Now.ToLocalTime(), "详情");
            }
        }

        private void btnCreateTemplate_Click(object sender, EventArgs e)
        {
            CreateITenderTemplateForm createITenderTemplateForm = new CreateITenderTemplateForm();
            createITenderTemplateForm.ShowDialog();
        }

        private void grdTemplate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.colTemplateNode.Index)
            {
                ITenderTemplateNodeForm iTenderTemplateNodeForm = new ITenderTemplateNodeForm();
                iTenderTemplateNodeForm.ShowDialog();
            }
            else if (e.ColumnIndex == this.colTemplateEdit.Index)
            {
                CreateITenderTemplateForm createITenderTemplateForm = new CreateITenderTemplateForm();
                createITenderTemplateForm.Text = "编辑模板";
                createITenderTemplateForm.ShowDialog();
            }
            else if (e.ColumnIndex == this.colTemplateDelete.Index)
            {
                if (MetroMessageBox.Show(this, "确定要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.grdTemplate.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
