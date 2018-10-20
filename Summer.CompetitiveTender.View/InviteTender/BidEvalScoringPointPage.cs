using log4net;
using MetroFramework.Forms;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.View.Common;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTenderEvalEle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;

namespace Summer.CompetitiveTender.View.InviteTender
{
    public partial class BidEvalScoringPointPage : MetroFramework.Controls.MetroUserControl
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(BidEvalScoringPointPage));

        /// <summary>
        /// gpTenderEvalEleService
        /// </summary>
        private IGpTenderEvalEleService gpTenderEvalEleService;

        /// <summary>
        /// projectId
        /// </summary>
        private string projectId;

        /// <summary>
        /// sectionId
        /// </summary>
        private string sectionId;

        #endregion

        #region 事件

        private void BidEvalScoringPointPage_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            BidEvalScoringPointForm frm = new BidEvalScoringPointForm(this.gpTenderEvalEleService, this.projectId, this.sectionId, null);
            frm.Text = "新建评分点";

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                this.LoadData();
            }

            frm.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.grdData.CurrentRow != null)
            {
                gpTenderEvalEleWebDO obj = this.grdData.CurrentRow.Tag as gpTenderEvalEleWebDO;

                BidEvalScoringPointForm frm = new BidEvalScoringPointForm(this.gpTenderEvalEleService, obj.gtpId, obj.gsId, obj);
                frm.Text = "编辑评分点";

                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    this.LoadData();
                }

                frm.Dispose();
            }
            else
            {
                MetroMessageBox.Show(this, "请选择要编辑的评分点！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.grdData.CurrentRow != null)
            {
                DialogResult result = MetroMessageBox.Show(this, "确定要删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    gpTenderEvalEleWebDO obj = this.grdData.CurrentRow.Tag as gpTenderEvalEleWebDO;

                    if (this.gpTenderEvalEleService.Remove(obj.gteeId))
                    {
                        this.grdData.Rows.Remove(this.grdData.CurrentRow);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this, "请选择要删除的评分点！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region 方法

        public BidEvalScoringPointPage(IGpTenderEvalEleService gpTenderEvalEleService, string projectId, string sectionId)
        {
            InitializeComponent();
            this.gpTenderEvalEleService = gpTenderEvalEleService;
            this.projectId = projectId;
            this.sectionId = sectionId;

            List<ComboBoxDataSource> lstIsNeed = new List<ComboBoxDataSource>();
            lstIsNeed.Add(new ComboBoxDataSource() { Text = "不可以", Value = 0 });
            lstIsNeed.Add(new ComboBoxDataSource() { Text = "可以", Value = 1 });
            this.colCanDelete.DataSource = lstIsNeed;
            this.colCanDelete.DisplayMember = "Text";
            this.colCanDelete.ValueMember = "Value";
        }

        public void LoadData()
        {
            try
            {
                this.grdData.Rows.Clear();
                var result = this.gpTenderEvalEleService.FindListByGsIdAndGteeName(this.sectionId, string.Empty);
                this.SetGridData(result);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "加载失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetGridData(gpTenderEvalEleWebDO[] values)
        {
            this.grdData.Rows.Clear();

            foreach (var item in values)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.grdData);
                row.Cells[this.colName.Index].Value = item.gteeName;
                row.Cells[this.colUnit.Index].Value = item.evalUnit;
                row.Cells[this.colNum.Index].Value = item.evalNum;
                row.Cells[this.colGrads.Index].Value = item.evalGrads;
                row.Cells[this.colMaxScore.Index].Value = item.maxScore;
                row.Cells[this.colMinScore.Index].Value = item.minScore;
                row.Cells[this.colStandard.Index].Value = item.standard;
                row.Cells[this.colGreatWay.Index].Value = item.greatWay;
                row.Cells[this.colGreatNum.Index].Value = item.greatNum;
                row.Cells[this.colLittleWay.Index].Value = item.littleWay;
                row.Cells[this.colLittleNum.Index].Value = item.littleNum;
                row.Cells[this.colCanDelete.Index].Value = item.canDel;
                row.Tag = item;

                this.grdData.Rows.Add(row);
            }
        }

        #endregion
    }
}
