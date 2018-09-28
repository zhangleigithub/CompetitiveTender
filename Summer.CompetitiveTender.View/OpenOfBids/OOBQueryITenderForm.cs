using log4net;
using MetroFramework;
using MetroFramework.Forms;
using Summer.CompetitiveTender.Model;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTenderProject;
using Summer.CompetitiveTender.Service.ServiceReferenceLogin;
using Summer.CompetitiveTender.View.InviteTender;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Summer.CompetitiveTender.View.OpenOfBids
{
    public partial class OOBQueryITenderForm : FormBase
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(OOBQueryITenderForm));

        /// <summary>
        /// gpTenderProjectService
        /// </summary>
        private IGpTenderProjectService gpTenderProjectService = new GpTenderProjectService();

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

            if (e.ColumnIndex == this.colIViewBid.Index)
            {
                OOBHallToForm oOBHallToForm = new OOBHallToForm();
                oOBHallToForm.ShowDialog(this);
                oOBHallToForm.Close();
            }
            else if (e.ColumnIndex == this.colOpenBid.Index)
            {
                OOBDecryptBidFileForm oOBDecryptBidFileForm = new OOBDecryptBidFileForm();
                oOBDecryptBidFileForm.ShowDialog(this);
                oOBDecryptBidFileForm.Close();
            }
        }

        #endregion

        #region 方法

        public OOBQueryITenderForm()
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
                row.Cells[this.colIViewBid.Index].Value = "开标一览";
                row.Cells[this.colOpenBid.Index].Value = "进入开标";
                row.Tag = item;
              
                this.grdITender.Rows.Add(row);
            }
        }

        #endregion
    }
}
