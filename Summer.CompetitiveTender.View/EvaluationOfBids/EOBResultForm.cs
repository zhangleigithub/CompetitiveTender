using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Summer.CompetitiveTender.View.EvaluationOfBids
{
    public partial class EOBResultForm : FormBase
    {
        public EOBResultForm()
        {
            InitializeComponent();
        }

        private void EOBResultForm_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                this.grdBidEvalResult.Rows.Add("测试", "测试", i, "100", "100","测试");
            }
        }
    }
}
