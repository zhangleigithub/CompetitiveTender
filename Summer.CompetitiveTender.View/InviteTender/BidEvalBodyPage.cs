using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Summer.CompetitiveTender.Utility;

namespace Summer.CompetitiveTender.View.InviteTender
{
    public partial class BidEvalBodyPage : MetroFramework.Controls.MetroUserControl
    {
        public BidEvalBodyPage()
        {
            InitializeComponent();
        }

        private void btnImportFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdl = new OpenFileDialog();
            ofdl.Filter = "word(*.doc)|*.doc";

            if (ofdl.ShowDialog() == DialogResult.OK)
            {
                this.axFramerControl1.Open(ofdl.FileName);
            }
        }

        private void btnDZQZ_Click(object sender, EventArgs e)
        {
            string[] certIds = MonitorXTX.GetInstance().GetCertID();

            if (certIds.Length > 0)
            {
                MonitorXTX.GetInstance().XTX.SOF_SignFile(certIds[0], this.axFramerControl1.DocumentFullName);
            }
        }
    }
}
