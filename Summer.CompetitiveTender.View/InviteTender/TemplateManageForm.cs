using log4net;
using MetroFramework;
using MetroFramework.Forms;
using Summer.CompetitiveTender.Model;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.Service.ServiceReferenceLogin;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTemplate;
using Summer.CompetitiveTender.View.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Summer.CompetitiveTender.View.InviteTender
{
    public partial class TemplateManageForm : FormBase
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(TemplateManageForm));

        /// <summary>
        /// gpTemplateService
        /// </summary>
        private IGpTemplateService gpTemplateService = new GpTemplateService();

        #endregion

        #region 事件

        private void QueryITenderTemplateForm_Shown(object sender, EventArgs e)
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

        private void btnNewTemplate_Click(object sender, EventArgs e)
        {
            CreateTemplateForm createTemplateForm = new CreateTemplateForm();

            if (createTemplateForm.ShowDialog(this) == DialogResult.OK)
            {
                this.LoadData();
            }

            createTemplateForm.Dispose();
        }

        private void btnEditTemplate_Click(object sender, EventArgs e)
        {
            if (this.grdTemplate.CurrentRow != null)
            {
                gpTemplateWebDO gpt = this.grdTemplate.CurrentRow.Tag as gpTemplateWebDO;

                EditTemplateForm editTemplateForm = new EditTemplateForm(this.gpTemplateService, gpt.gtId);

                if (editTemplateForm.ShowDialog(this) == DialogResult.OK)
                {
                    this.LoadData();
                }

                editTemplateForm.Dispose();
            }
            else
            {
                MetroMessageBox.Show(this, "请选择要编辑的模板！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTemplateNode_Click(object sender, EventArgs e)
        {
            if (this.grdTemplate.CurrentRow != null)
            {
                gpTemplateWebDO gpt = this.grdTemplate.CurrentRow.Tag as gpTemplateWebDO;

                TemplateNodeManageForm templateNodeManageForm = new TemplateNodeManageForm(this.gpTemplateService, gpt.gtId);

                if (templateNodeManageForm.ShowDialog(this) == DialogResult.OK)
                {
                    this.LoadData();
                }

                templateNodeManageForm.Dispose();
            }
            else
            {
                MetroMessageBox.Show(this, "请选择要编辑的模板！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteTemplate_Click(object sender, EventArgs e)
        {
            if (this.grdTemplate.CurrentRow != null)
            {
                DialogResult result = MetroMessageBox.Show(this, "确定要删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    gpTemplateWebDO gpt = this.grdTemplate.CurrentRow.Tag as gpTemplateWebDO;

                    if (this.gpTemplateService.Remove(gpt.gtId))
                    {
                        this.grdTemplate.Rows.Remove(this.grdTemplate.CurrentRow);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this, "请选择要删除的模板！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDownloadTemplate_Click(object sender, EventArgs e)
        {
            if (this.grdTemplate.CurrentRow != null)
            {
                gpTemplateWebDO gpt = this.grdTemplate.CurrentRow.Tag as gpTemplateWebDO;

                Service.ServiceReferenceGpTemplate.resultDO result = this.gpTemplateService.FileDownload(gpt.gtId);
                gpTemplateWebDO obj = result.obj as gpTemplateWebDO;

                SaveFileDialog sfdl = new SaveFileDialog();
                sfdl.Filter = "word(*.doc)|*.doc|所有文件|*.*";
                sfdl.FileName = obj.gtName;
                sfdl.DefaultExt = obj.gtFileSuffix;
                sfdl.AddExtension = true;

                if (sfdl.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = File.Create(sfdl.FileName))
                    {
                        fs.Write(result.fileContent, 0, result.fileContent.Length);
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this, "请选择要下载的模板！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public TemplateManageForm()
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
            var result = gpTemplateService.FindListByAuIdAndName(loginResponse.auID, string.Empty);

            //升序
            foreach (var item in result.OrderBy(x => x.sort))
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

        #endregion
    }
}
