using log4net;
using MetroFramework;
using MetroFramework.Forms;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.Service.ServiceReferenceGpEvalwayItemGtf;
using Summer.CompetitiveTender.View.Common;
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
    public partial class BidEvalClausePage : MetroFramework.Controls.MetroUserControl
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(BidEvalClausePage));

        /// <summary>
        /// gpEvalwayItemGtfService
        /// </summary>
        private IGpEvalwayItemGtfService gpEvalwayItemGtfService;

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

        private void BidEvalClausePage_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            BidEvalClauseForm frm = new BidEvalClauseForm(this.gpEvalwayItemGtfService,this.projectId, this.sectionId, null);
            frm.Text = "新建评标条款";

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
                gpEvalWayItemGtfWebDO obj = this.grdData.CurrentRow.Tag as gpEvalWayItemGtfWebDO;

                BidEvalClauseForm frm = new BidEvalClauseForm(this.gpEvalwayItemGtfService,this.projectId, obj.gsId, obj);
                frm.Text = "编辑评标条款";

                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    this.LoadData();
                }

                frm.Dispose();
            }
            else
            {
                MetroMessageBox.Show(this, "请选择要编辑的评标条款！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.grdData.CurrentRow != null)
            {
                DialogResult result = MetroMessageBox.Show(this, "确定要删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    gpEvalWayItemGtfWebDO obj = this.grdData.CurrentRow.Tag as gpEvalWayItemGtfWebDO;

                    if (this.gpEvalwayItemGtfService.Remove(obj.gewigId))
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
                MetroMessageBox.Show(this, "请选择要删除的评标条款！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region 方法

        public BidEvalClausePage(IGpEvalwayItemGtfService gpEvalwayItemGtfService, string projectId, string sectionId)
        {
            InitializeComponent();
            this.gpEvalwayItemGtfService = gpEvalwayItemGtfService;
            this.projectId = projectId;
            this.sectionId = sectionId;

            List<ComboBoxDataSource> lstType = new List<ComboBoxDataSource>();
            lstType.Add(new ComboBoxDataSource() { Text = "符合性", Value = 0 });
            lstType.Add(new ComboBoxDataSource() { Text = "评分", Value = 1 });
            this.colType.DataSource = lstType;
            this.colType.DisplayMember = "Text";
            this.colType.ValueMember = "Value";

            List<ComboBoxDataSource> lstIsNeed = new List<ComboBoxDataSource>();
            lstIsNeed.Add(new ComboBoxDataSource() { Text = "不需要", Value = 0 });
            lstIsNeed.Add(new ComboBoxDataSource() { Text = "需要", Value = 1 });
            this.colIsNeedFirstPara.DataSource = lstIsNeed;
            this.colIsNeedFirstPara.DisplayMember = "Text";
            this.colIsNeedFirstPara.ValueMember = "Value";

            this.colIsNeeSecondPara.DataSource = lstIsNeed;
            this.colIsNeeSecondPara.DisplayMember = "Text";
            this.colIsNeeSecondPara.ValueMember = "Value";
        }

        public void LoadData()
        {
            try
            {
                this.grdData.Rows.Clear();
                var result = this.gpEvalwayItemGtfService.FindListByGsIdAndGewigName(this.sectionId, string.Empty);
                this.SetGridData(result);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "加载失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetGridData(gpEvalWayItemGtfWebDO[] values)
        {
            this.grdData.Rows.Clear();

            foreach (var item in values.OrderBy(x => x.sort))
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.grdData);
                row.Cells[this.colCode.Index].Value = item.gewigCode;
                row.Cells[this.colName.Index].Value = item.gewigName;
                row.Cells[this.colType.Index].Value = item.gewigType;
                row.Cells[this.colMaxScore.Index].Value = item.maxScore;
                row.Cells[this.colMinScore.Index].Value = item.minScore;
                row.Cells[this.colIsNeedFirstPara.Index].Value = item.isNeedFirstPara;
                row.Cells[this.colFirstParaDesc.Index].Value = item.firstParaDesc;
                row.Cells[this.colIsNeeSecondPara.Index].Value = item.isNeeSecondPara;
                row.Cells[this.colSecondParaDesc.Index].Value = item.secondParaDesc;
                row.Cells[this.colAlgoName.Index].Value = item.algoName;
                row.Cells[this.colRemark.Index].Value = item.remark;
                row.Cells[this.colSort.Index].Value = item.sort;
                row.Tag = item;

                this.grdData.Rows.Add(row);
            }
        }

        #endregion
    }
}
