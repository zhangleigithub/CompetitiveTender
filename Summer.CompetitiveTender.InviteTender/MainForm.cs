using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Summer.CompetitiveTender.InviteTender
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();

            this.metroGrid1.TopRow = new Common.Controls.MultiHeaderDataGridView.DataGridViewRowTopRow(this.metroGrid1);
            this.metroGrid1.TopRow.Cells[3].HeaderText = "操作";
            this.metroGrid1.TopRow.Cells[3].ColumnSpan = 5;
            this.metroGrid1.TopRow.Cells[3].ColumnIndex = -1;
            this.metroGrid1.TopRow.Cells[4].HeaderText = "操作";
            this.metroGrid1.TopRow.Cells[4].ColumnSpan = 5;
            this.metroGrid1.TopRow.Cells[4].ColumnIndex = -1;
            this.metroGrid1.TopRow.Cells[5].HeaderText = "操作";
            this.metroGrid1.TopRow.Cells[5].ColumnSpan = 5;
            this.metroGrid1.TopRow.Cells[5].ColumnIndex = -1;
            this.metroGrid1.TopRow.Cells[6].HeaderText = "操作";
            this.metroGrid1.TopRow.Cells[6].ColumnSpan = 5;
            this.metroGrid1.TopRow.Cells[6].ColumnIndex = -1;
            this.metroGrid1.TopRow.Cells[7].HeaderText = "操作";
            this.metroGrid1.TopRow.Cells[7].ColumnSpan = 5;
            this.metroGrid1.TopRow.Cells[7].ColumnIndex = 3;

            for (int i = 0; i < 30; i++)
            {
                this.metroGrid1.Rows.Add("测试" + i, "v" + i, DateTime.Now.ToLocalTime(), "编辑", "删除", "预览", "打印", "下载");
            }

            for (int i = 0; i < 30; i++)
            {
                this.metroGrid2.Rows.Add("测试" + i, DateTime.Now.ToLocalTime(), "详情");
            }
        }
    }
}
