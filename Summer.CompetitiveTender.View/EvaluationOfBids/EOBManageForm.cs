using Summer.CompetitiveTender.View.Common;
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
    public partial class EOBManageForm : FormBase
    {
        public EOBManageForm()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            List<ComboBoxDataSource> lstEvalState = new List<ComboBoxDataSource>();
            lstEvalState.Add(new ComboBoxDataSource() { Text = "失败", Value = -1 });
            lstEvalState.Add(new ComboBoxDataSource() { Text = "成功", Value = 1 });
            lstEvalState.Add(new ComboBoxDataSource() { Text = "启动", Value = 2 });
            this.colProjectEvalState.DataSource = lstEvalState;
            this.colProjectEvalState.DisplayMember = "Text";
            this.colProjectEvalState.ValueMember = "Value";

            for (int i = 0; i < 30; i++)
            {
                this.grdProject.Rows.Add(i,"测试",i,"测试",2);
            }
        }

        private void btnRecJudges_Click(object sender, EventArgs e)
        {
            if (this.grdProject.CurrentRow != null)
            {
                SetRecJudgesForm setRecJudgesForm = new SetRecJudgesForm();
                setRecJudgesForm.ShowDialog(this);
                setRecJudgesForm.Dispose();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "请选择招标项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBidEval_Click(object sender, EventArgs e)
        {
            if (this.grdProject.CurrentRow != null)
            {
                EOBForm eOBForm = new EOBForm();
                eOBForm.ShowDialog(this);
                eOBForm.Dispose();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "请选择招标项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBidEvalReport_Click(object sender, EventArgs e)
        {
            if (this.grdProject.CurrentRow != null)
            {
                OpenFileDialog ofdl = new OpenFileDialog();
                ofdl.Filter = "word(*.doc)|*.doc";

                if (ofdl.ShowDialog() == DialogResult.OK)
                {
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "请选择招标项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (this.grdProject.CurrentRow != null)
            {
                EOBResultForm eOBResultForm = new EOBResultForm();
                eOBResultForm.ShowDialog(this);
                eOBResultForm.Dispose();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "请选择招标项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDownloadITenderFile_Click(object sender, EventArgs e)
        {
            if (this.grdProject.CurrentRow != null)
            {
                SaveFileDialog sfdl = new SaveFileDialog();
                sfdl.Filter = "word(*.doc)|*.doc|所有文件|*.*";
                sfdl.FileName = "xxxx";
                sfdl.DefaultExt = "doc";
                sfdl.AddExtension = true;

                if (sfdl.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "请选择招标项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
