using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summer.CompetitiveTender.View.Bid
{
    public partial class BidManageForm : MetroForm
    {
        public BidManageForm()
        {
            InitializeComponent();
        }

        private void BidManage_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                DataGridViewRow Row = new DataGridViewRow();
                int index = dgv_BidFileList.Rows.Add(Row);
                dgv_BidFileList.Rows[index].Cells[0].Value = "测试" + i.ToString();
                dgv_BidFileList.Rows[index].Cells[1].Value = "项目" + i.ToString();
                dgv_BidFileList.Rows[index].Cells[2].Value = DateTime.Now.ToShortDateString();
                dgv_BidFileList.Rows[index].Cells[3].Value = "修改";
                dgv_BidFileList.Rows[index].Cells[4].Value = "删除";
                dgv_BidFileList.Rows[index].Cells[5].Value = "预览";
                dgv_BidFileList.Rows[index].Cells[6].Value = "打印";
                dgv_BidFileList.Rows[index].Cells[7].Value = "下载"; 
            }
        }
    }
}
