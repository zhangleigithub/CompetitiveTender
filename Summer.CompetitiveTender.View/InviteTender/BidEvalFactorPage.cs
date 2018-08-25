using MetroFramework.Forms;
using Summer.CompetitiveTender.View.BidEvaluaMethod;
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
    public partial class BidEvalFactorPage : MetroFramework.Controls.MetroUserControl
    {
        public BidEvalFactorPage()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddScoringFactor addScoringFactor = new AddScoringFactor();
            addScoringFactor.ShowDialog(this);
            addScoringFactor.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ModifyScoringFactor modifyScoringFactor = new ModifyScoringFactor();
            modifyScoringFactor.ShowDialog(this);
            modifyScoringFactor.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.grdEvalFactor.CurrentRow != null)
            {
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, "确定要删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    this.grdEvalFactor.Rows.Remove(this.grdEvalFactor.CurrentRow);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "请选择要删除的评分因素！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
