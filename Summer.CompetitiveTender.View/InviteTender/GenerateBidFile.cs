using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Summer.CompetitiveTender.Utility;

namespace Summer.CompetitiveTender.View.InviteTender
{
    public partial class GenerateBidFile : UserControl
    {
        #region 事件

        private void OnCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            //签章
            if (e.ColumnIndex == this.colSign.Index)
            {
                string path = this.grdFile.Rows[e.RowIndex].Tag as string;

                string[] certIds = MonitorXTX.GetInstance().GetCertID();

                if (certIds.Length > 0)
                {
                    MonitorXTX.GetInstance().XTX.SOF_SignFile(certIds[0], path);
                }
            }
        }

        #endregion

        #region 方法

        public GenerateBidFile(string[] paths)
        {
            InitializeComponent();

            foreach (var item in paths)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.grdFile);
                row.Cells[this.colFileName.Index].Value = Path.GetFileName(item);
                row.Cells[this.colSign.Index].Value = "签章";
                row.Tag = item;

                this.grdFile.Rows.Add(row);
            }
        }

        #endregion
    }
}
