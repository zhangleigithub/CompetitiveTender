using log4net;
using MetroFramework;
using MetroFramework.Forms;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.Service.ServiceReferenceGpBidFileOrg;
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
    public partial class BidEvalFactorPage : MetroFramework.Controls.MetroUserControl
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(BidEvalFactorPage));

        /// <summary>
        /// gpBidFileOrgService
        /// </summary>
        private IGpBidFileOrgService gpBidFileOrgService;

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

        private void BidEvalFactorPage_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            BidEvalFactorForm frm = new BidEvalFactorForm(this.gpBidFileOrgService,this.projectId, this.sectionId, null);
            frm.Text = "新建评分因素";

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                this.LoadData();
            }

            frm.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.grdEvalFactor.CurrentRow != null)
            {
                gpBidFileOrgWebDO obj = this.grdEvalFactor.CurrentRow.Tag as gpBidFileOrgWebDO;

                BidEvalFactorForm frm = new BidEvalFactorForm(this.gpBidFileOrgService, obj.projectId, obj.sectionId, obj);
                frm.Text = "编辑评分因素";

                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    this.LoadData();
                }

                frm.Dispose();
            }
            else
            {
                MetroMessageBox.Show(this, "请选择要编辑的评分因素！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.grdEvalFactor.CurrentRow != null)
            {
                DialogResult result = MetroMessageBox.Show(this, "确定要删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    gpBidFileOrgWebDO obj = this.grdEvalFactor.CurrentRow.Tag as gpBidFileOrgWebDO;

                    if (this.gpBidFileOrgService.Remove(obj.bbfoId))
                    {
                        this.grdEvalFactor.Rows.Remove(this.grdEvalFactor.CurrentRow);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this, "请选择要删除的评分因素！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region 方法

        public BidEvalFactorPage(IGpBidFileOrgService gpBidFileOrgService,string projectId, string sectionId)
        {
            InitializeComponent();
            this.gpBidFileOrgService = gpBidFileOrgService;
            this.projectId = projectId;
            this.sectionId = sectionId;

            List<ComboBoxDataSource> lstIsNeed = new List<ComboBoxDataSource>();
            lstIsNeed.Add(new ComboBoxDataSource() { Text = "否", Value = 0 });
            lstIsNeed.Add(new ComboBoxDataSource() { Text = "是", Value = 1 });
            this.colRequire.DataSource = lstIsNeed;
            this.colRequire.DisplayMember = "Text";
            this.colRequire.ValueMember = "Value";
        }

        public void LoadData()
        {
            try
            {
                this.grdEvalFactor.Rows.Clear();
                var result = this.gpBidFileOrgService.FindListByProjectIdAndSectionId(this.projectId, this.sectionId);
                this.SetGridData(result);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "加载失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetGridData(gpBidFileOrgWebDO[] values)
        {
            this.grdEvalFactor.Rows.Clear();

            foreach (var item in values.OrderBy(x => x.sort))
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.grdEvalFactor);
                row.Cells[this.colName.Index].Value = item.bbfoName;
                row.Cells[this.colRequire.Index].Value = item.isMust;
                row.Cells[this.colSort.Index].Value = item.sort;
                row.Tag = item;

                this.grdEvalFactor.Rows.Add(row);
            }
        }

        #endregion
    }
}
