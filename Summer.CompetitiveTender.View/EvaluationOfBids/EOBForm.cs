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
    public partial class EOBForm : FormBase
    {
        public EOBForm()
        {
            InitializeComponent();
        }

        private void EOBForm_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                this.grdBids.Rows.Add("测试","测试",i,DateTime.Now.ToLongDateString(),"评分");
            }
        }

        private void grdBids_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==this.colReview.Index)
            {
                EOBReviewForm eOBReviewForm = new EOBReviewForm();
                eOBReviewForm.ShowDialog(this);
                eOBReviewForm.Dispose();
            }
        }
    }
}
