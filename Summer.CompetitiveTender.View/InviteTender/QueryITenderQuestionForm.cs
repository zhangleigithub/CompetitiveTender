using MetroFramework.Forms;
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
    public partial class QueryITenderQuestionForm : FormBase
    {
        public QueryITenderQuestionForm()
        {
            InitializeComponent();
        }

        private void btnQuestQuery_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                this.grdITQuest.Rows.Add("测试" + i, "测试", "测试", "测试", "测试", "测试", "测试", DateTime.Now.ToLocalTime(), "澄清", "详情","回复");
            }
        }

        private void grdITQuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.colItQuestDetail.Index)
            {
                ITenderQuestionDetailForm iTenderQuestionDetailForm = new ITenderQuestionDetailForm();
                iTenderQuestionDetailForm.ShowDialog(this);
                iTenderQuestionDetailForm.Dispose();
            }
            else if (e.ColumnIndex == this.colReplayQuestion.Index)
            {
                ReplayQuestionForm replayQuestionForm = new ReplayQuestionForm();
                replayQuestionForm.ShowDialog(this);
                replayQuestionForm.Dispose();
            }
        }
    }
}
