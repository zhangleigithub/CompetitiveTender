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
    public partial class EditITenderForm : FormBase
    {
        public EditITenderForm()
        {
            InitializeComponent();
        }

        private void EditITenderForm_Shown(object sender, EventArgs e)
        {
            this.rb_Click(this.rbTenderBody, new EventArgs());
        }

        private void rb_Click(object sender, EventArgs e)
        {
            this.pnelFrame.Controls.Clear();

            RadioButton rb = sender as RadioButton;

            if (rb.Name == this.rbTenderBody.Name)
            {
                BidEvalBodyPage bidEvalBodyPage = new BidEvalBodyPage();
                bidEvalBodyPage.Dock = DockStyle.Fill;
                this.pnelFrame.Controls.Add(bidEvalBodyPage);
            }
            else if (rb.Name == this.rbEvalClause.Name)
            {
                BidEvalClausePage bidEvalClausePage = new BidEvalClausePage();
                bidEvalClausePage.Dock = DockStyle.Fill;
                this.pnelFrame.Controls.Add(bidEvalClausePage);
            }
            else if (rb.Name == this.rbEvalPoint.Name)
            {
                BidEvalScoringPointPage bidEvalScoringPointPage = new BidEvalScoringPointPage();
                bidEvalScoringPointPage.Dock = DockStyle.Fill;
                this.pnelFrame.Controls.Add(bidEvalScoringPointPage);
            }
            else if (rb.Name == this.rbEvalFactor.Name)
            {
                BidEvalFactorPage bidEvalFactorPage = new BidEvalFactorPage();
                bidEvalFactorPage.Dock = DockStyle.Fill;
                this.pnelFrame.Controls.Add(bidEvalFactorPage);
            }
            else
            {
            }
        }
    }
}
