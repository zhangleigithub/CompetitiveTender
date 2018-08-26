using MetroFramework;
using MetroFramework.Forms;
using Summer.CompetitiveTender.View.InviteTender;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Summer.CompetitiveTender.View.OpenOfBids
{
    public partial class OOBQueryITenderForm : FormBase
    {
        public OOBQueryITenderForm()
        {
            InitializeComponent();
        }

        private void QueryITenderForm_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                this.grdITender.Rows.Add("测试" + i, "测试", "测试", "测试", "测试", "测试", "测试", "测试", "开标一览", "进入开标");
            }
        }

        private void grdITender_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.colIViewBid.Index)
            {
                OOBHallToForm oOBHallToForm = new OOBHallToForm();
                oOBHallToForm.ShowDialog(this);
                oOBHallToForm.Close();
            }
            else if (e.ColumnIndex == this.colOpenBid.Index)
            {
                OOBDecryptBidFileForm oOBDecryptBidFileForm = new OOBDecryptBidFileForm();
                oOBDecryptBidFileForm.ShowDialog(this);
                oOBDecryptBidFileForm.Close();
            }
        }
    }
}
