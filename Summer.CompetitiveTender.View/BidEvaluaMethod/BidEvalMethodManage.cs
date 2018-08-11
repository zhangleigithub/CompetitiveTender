using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Summer.CompetitiveTender.View.BidEvaluaMethod
{
    public partial class BidEvalMethodManage : MetroForm
    {
        public BidEvalMethodManage()
        {
            InitializeComponent();
        }

        private void BidEvalMethodManage_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddBidEvalMethod addBidEvalMethod = new BidEvaluaMethod.AddBidEvalMethod();
            addBidEvalMethod.ShowDialog();
            addBidEvalMethod.Dispose();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AddScoringPoint addScoringPoint = new BidEvaluaMethod.AddScoringPoint();
            addScoringPoint.ShowDialog();
            addScoringPoint.Dispose();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            AddScoringFactor addScoringFactor = new BidEvaluaMethod.AddScoringFactor();
            addScoringFactor.ShowDialog();
            addScoringFactor.Dispose();
        }
    }
}
