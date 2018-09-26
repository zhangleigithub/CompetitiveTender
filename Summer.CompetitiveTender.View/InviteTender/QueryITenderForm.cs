using log4net;
using MetroFramework;
using MetroFramework.Forms;
using Summer.CompetitiveTender.Model;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.Service.ServiceReferenceLogin;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTenderProject;
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
    public partial class QueryITenderForm : FormBase
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(QueryITenderForm));

        /// <summary>
        /// gpTenderProjectService
        /// </summary>
        private IGpTenderProjectService gpTenderProjectService = new GpTenderProjectService();

        /// <summary>
        /// gpTenderFileService
        /// </summary>
        private IGpTenderFileService gpTenderFileService = new GpTenderFileService();

        #endregion

        #region 事件

        private void QueryITenderForm_Shown(object sender, EventArgs e)
        {
            try
            {
                this.LoadData();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "加载失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdITender_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            gpTenderProjectWebDO gptp = this.grdITender.Rows[e.RowIndex].Tag as gpTenderProjectWebDO;

            if (e.ColumnIndex == this.colITenderDetail.Index)
            {
                ITenderDetailForm iTenderDetailForm = new ITenderDetailForm(gptp);
                iTenderDetailForm.ShowDialog(this);
                iTenderDetailForm.Dispose();
            }
            else if (e.ColumnIndex == this.colEditITenderFile.Index)
            {
                EditITenderForm editProjectForm = new EditITenderForm();
                editProjectForm.ShowDialog(this);
                editProjectForm.Dispose();
            }
            else if (e.ColumnIndex == this.colDeleteITenderFile.Index)
            {
                if (MetroMessageBox.Show(this, "确定要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (this.gpTenderFileService.RemoveFile(gptp.gtpId, gptp.gpId))
                    {
                        MetroMessageBox.Show(this, "删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                var result = gpTenderProjectService.FindListByCondition(string.Empty, string.Empty, string.Empty, this.txtProjectId.Text.Trim());
                this.SetGridData(result);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "加载失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 方法

        public QueryITenderForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            this.grdITender.Rows.Clear();
            baseUserWebDO loginResponse = Cache.GetInstance().GetValue<baseUserWebDO>("login");
            var result = gpTenderProjectService.FindListByAuId(loginResponse.auID);
            this.SetGridData(result);
        }

        public void SetGridData(gpTenderProjectWebDO[] values)
        {
            this.grdITender.Rows.Clear();

            foreach (var item in values)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.grdITender);
                row.Cells[this.colITenderProjectCode.Index].Value = item.gpCode;
                row.Cells[this.colITenderTYJYBSM.Index].Value = item.unifiedDealCode;
                row.Cells[this.colITenderProjectName.Index].Value = item.gtpName;
                row.Cells[this.colITenderProjectTypeName.Index].Value = item.tdrPrjName;
                row.Cells[this.colITenderProjectGroupName.Index].Value = item.tdrPrjClassifyName;
                row.Cells[this.colITenderProjectAreaName.Index].Value = item.regionName;
                row.Cells[this.colITenderProjectAgencyType.Index].Value = item.tdrAgencyCodeType;
                row.Cells[this.colITenderProjectContent.Index].Value = item.content;
                row.Cells[this.colITenderDetail.Index].Value = "项目详情";
                row.Cells[this.colEditITenderFile.Index].Value = "编辑招标文件";
                row.Cells[this.colDeleteITenderFile.Index].Value = "删除招标文件";
                row.Tag = item;

                this.grdITender.Rows.Add(row);
            }
        }

        #endregion
    }
}
