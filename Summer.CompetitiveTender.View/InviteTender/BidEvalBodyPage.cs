using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

            if (ofdl.ShowDialog()==DialogResult.OK)
            {
                this.axFramerControl1.Open(ofdl.FileName);
            }
        }
    }
}
