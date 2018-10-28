using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Summer.CompetitiveTender.Utility;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.Service.ServiceReferenceLogin;
using Summer.CompetitiveTender.Model;
using Summer.CompetitiveTender.View.Common;
using MetroFramework;
using log4net;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTemplate;

namespace Summer.CompetitiveTender.View.InviteTender
{
    public partial class BidEvalTemplatePage : MetroFramework.Controls.MetroUserControl
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(BidEvalTemplatePage));

        /// <summary>
        /// gpTemplateService
        /// </summary>
        private IGpTemplateService gpTemplateService = new GpTemplateService();

        #endregion

        #region 事件

        private void BidEvalBodyPage_Load(object sender, EventArgs e)
        {
            List<ComboBoxDataSource> lstType = new List<ComboBoxDataSource>();
            lstType.Add(new ComboBoxDataSource() { Text = "招标", Value = 1 });
            this.colTemplateType.DataSource = lstType;
            this.colTemplateType.DisplayMember = "Text";
            this.colTemplateType.ValueMember = "Value";

            List<ComboBoxDataSource> lstProjectType = new List<ComboBoxDataSource>();
            lstProjectType.Add(new ComboBoxDataSource() { Text = "货物", Value = 1 });
            lstProjectType.Add(new ComboBoxDataSource() { Text = "服务", Value = 2 });
            lstProjectType.Add(new ComboBoxDataSource() { Text = "工程", Value = 3 });
            this.colTemplateProjectType.DataSource = lstProjectType;
            this.colTemplateProjectType.DisplayMember = "Text";
            this.colTemplateProjectType.ValueMember = "Value";

            List<ComboBoxDataSource> lstState = new List<ComboBoxDataSource>();
            lstState.Add(new ComboBoxDataSource() { Text = "未生成", Value = 0 });
            lstState.Add(new ComboBoxDataSource() { Text = "已生成", Value = 1 });
            this.colTemplateState.DataSource = lstState;
            this.colTemplateState.DisplayMember = "Text";
            this.colTemplateState.ValueMember = "Value";

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

        #endregion

        #region 方法

        public BidEvalTemplatePage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// LoadData
        /// </summary>
        public void LoadData()
        {
            this.grdTemplate.Rows.Clear();
            baseUserWebDO loginResponse = Cache.GetInstance().GetValue<baseUserWebDO>("login");
            var result = gpTemplateService.FindListByAuIdAndName(loginResponse.auID, string.Empty, 1);

            //已生成，升序
            foreach (var item in result.Where(x => x.fileMakeState == 1).OrderBy(x => x.sort))
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.grdTemplate);
                row.Cells[this.colTemplateId.Index].Value = item.gtId;
                row.Cells[this.colTemplateCode.Index].Value = item.gtCode;
                row.Cells[this.colTempleName.Index].Value = item.gtName;
                row.Cells[this.colTemplateType.Index].Value = item.gtType;
                row.Cells[this.colTemplateProjectType.Index].Value = item.gtGroup;
                row.Cells[this.colTemplateDescription.Index].Value = item.remark;
                row.Cells[this.colTemplateCreateDate.Index].Value = item.adtTime;
                row.Cells[this.colTemplateState.Index].Value = item.fileMakeState;
                row.Tag = item;

                this.grdTemplate.Rows.Add(row);
            }
        }

        public gpTemplateWebDO GetTemplate()
        {
            return this.grdTemplate.CurrentRow.Tag as gpTemplateWebDO;
        }

        #endregion
    }
}
