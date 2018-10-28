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
using log4net;
using MetroFramework;

namespace Summer.CompetitiveTender.View.InviteTender
{
    public partial class GenerateBidFile : UserControl
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(GenerateBidFile));

        #endregion

        #region 事件

        private void OnCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "签章失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    return;
                }

                //文件
                if (e.ColumnIndex == this.colFileName.Index)
                {
                    string path = this.grdFile.Rows[e.RowIndex].Tag as string;

                    System.Diagnostics.Process.Start(path);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "打开文件失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                row.Cells[this.colFileName.Index].Value = item;
                row.Cells[this.colSign.Index].Value = "签章";
                row.Tag = item;

                this.grdFile.Rows.Add(row);
            }
        }

        #endregion
    }
}
