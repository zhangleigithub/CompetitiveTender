using log4net;
using MetroFramework.Forms;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.View.Common;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTemplateNode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using Summer.CompetitiveTender.Service.ServiceReferenceLogin;
using Summer.CompetitiveTender.Model;
using System.IO;

namespace Summer.CompetitiveTender.View.InviteTender
{
    public partial class TemplateNodeManageForm : FormBase
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(TemplateNodeManageForm));

        /// <summary>
        /// gpTemplateService
        /// </summary>
        private IGpTemplateService gpTemplateService = null;

        /// <summary>
        /// gpTemplateNodeService
        /// </summary>
        private IGpTemplateNodeService gpTemplateNodeService = new GpTemplateNodeService();

        /// <summary>
        /// gptId
        /// </summary>
        private string gptId;

        /// <summary>
        /// gptnParentId
        /// </summary>
        private long gptnParentId = -1;

        #endregion

        #region 方法

        #endregion

        public TemplateNodeManageForm(IGpTemplateService gpTemplateService, string gptId)
        {
            InitializeComponent();
            this.gpTemplateService = gpTemplateService;
            this.gptId = gptId;
        }

        private void TemplateNodeManageForm_Shown(object sender, EventArgs e)
        {
            List<ComboBoxDataSource> lstProjectType = new List<ComboBoxDataSource>();
            lstProjectType.Add(new ComboBoxDataSource() { Text = "无", Value = 0 });
            lstProjectType.Add(new ComboBoxDataSource() { Text = "商务", Value = 1 });
            lstProjectType.Add(new ComboBoxDataSource() { Text = "技术", Value = 2 });
            lstProjectType.Add(new ComboBoxDataSource() { Text = "价格", Value = 3 });
            this.cboProjectType.DataSource = lstProjectType;
            this.cboProjectType.DisplayMember = "Text";
            this.cboProjectType.ValueMember = "Value";

            List<ComboBoxDataSource> lstCanModify = new List<ComboBoxDataSource>();
            lstCanModify.Add(new ComboBoxDataSource() { Text = "否", Value = 0 });
            lstCanModify.Add(new ComboBoxDataSource() { Text = "是", Value = 1 });
            this.cboCanModify.DataSource = lstCanModify;
            this.cboCanModify.DisplayMember = "Text";
            this.cboCanModify.ValueMember = "Value";

            this.cboCanDelete.DataSource = new List<ComboBoxDataSource>(lstCanModify);
            this.cboCanDelete.DisplayMember = "Text";
            this.cboCanDelete.ValueMember = "Value";

            List<ComboBoxDataSource> lstProperty = new List<ComboBoxDataSource>();
            lstProperty.Add(new ComboBoxDataSource() { Text = "普通文档", Value = 1 });
            lstProperty.Add(new ComboBoxDataSource() { Text = "文件夹", Value = 2 });
            lstProperty.Add(new ComboBoxDataSource() { Text = "专用文档", Value = 3 });
            this.cboProperty.DataSource = lstProperty;
            this.cboProperty.DisplayMember = "Text";
            this.cboProperty.ValueMember = "Value";

            List<ComboBoxDataSource> lstDocumentType = new List<ComboBoxDataSource>();
            lstDocumentType.Add(new ComboBoxDataSource() { Text = "doc", Value = 0 });
            this.cboDocumentType.DataSource = lstDocumentType;
            this.cboDocumentType.DisplayMember = "Text";
            this.cboDocumentType.ValueMember = "Value";

            this.cboCanModifyManage.DataSource = new List<ComboBoxDataSource>(lstCanModify);
            this.cboCanModifyManage.DisplayMember = "Text";
            this.cboCanModifyManage.ValueMember = "Value";

            this.cboDRBid.DataSource = new List<ComboBoxDataSource>(lstCanModify);
            this.cboDRBid.DisplayMember = "Text";
            this.cboDRBid.ValueMember = "Value";

            this.cboClient.DataSource = new List<ComboBoxDataSource>(lstCanModify);
            this.cboClient.DisplayMember = "Text";
            this.cboClient.ValueMember = "Value";

            this.cboCanModifyITender.DataSource = new List<ComboBoxDataSource>(lstCanModify);
            this.cboCanModifyITender.DisplayMember = "Text";
            this.cboCanModifyITender.ValueMember = "Value";

            try
            {
                this.LoadTree();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "获取失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trvTemplateNode_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                this.gptnParentId = -1;

                gpTemplateNodeWebDO gptn = e.Node.Tag as gpTemplateNodeWebDO;

                this.txtName.Text = gptn.gtnName;
                this.txtFileName.Text = gptn.gtnFileName;
                this.cboProjectType.SelectedValue = gptn.gtnFiletype;
                this.cboCanModify.SelectedValue = gptn.editState;
                this.cboCanDelete.SelectedValue = gptn.delState;
                this.cboProperty.SelectedValue = gptn.gtnAttr;
                this.cboDocumentType.SelectedValue = gptn.gtnDocType;
                this.cboCanModifyManage.SelectedValue = gptn.bossEditState;
                this.cboClient.SelectedValue = gptn.carryState;
                this.cboCanModifyITender.SelectedValue = gptn.biderEditState;
                this.txtSort.Text = gptn.sort.ToString();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "获取失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            this.txtName.Text = string.Empty;
            this.txtFileName.Text = string.Empty;
            this.txtSort.Text = string.Empty;

            if (this.trvTemplateNode.SelectedNode == null)
            {
                this.gptnParentId = 0;
            }
            else
            {
                gpTemplateNodeWebDO gptn = this.trvTemplateNode.SelectedNode.Tag as gpTemplateNodeWebDO;
                this.gptnParentId = gptn.gtnPid;
            }
        }

        private void tsmiSubNew_Click(object sender, EventArgs e)
        {
            if (this.trvTemplateNode.SelectedNode == null)
            {
                MetroMessageBox.Show(this, "请选择要添加节点的父节点！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.txtName.Text = string.Empty;
            this.txtFileName.Text = string.Empty;
            this.txtSort.Text = string.Empty;

            gpTemplateNodeWebDO gptn = this.trvTemplateNode.SelectedNode.Tag as gpTemplateNodeWebDO;
            this.gptnParentId = gptn.gtnId;
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.trvTemplateNode.SelectedNode == null)
                {
                    MetroMessageBox.Show(this, "请选择要删除的节点！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                gpTemplateNodeWebDO gptn = this.trvTemplateNode.SelectedNode.Tag as gpTemplateNodeWebDO;

                if (this.gpTemplateNodeService.Remove(gptn.gtnId))
                {
                    this.LoadTree();
                }
                else
                {
                    MetroMessageBox.Show(this, "删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                baseUserWebDO user = Cache.GetInstance().GetValue<baseUserWebDO>("login");

                gpTemplateNodeWebDO gptn = null;

                //修改
                if (this.gptnParentId == -1)
                {
                    gptn = this.trvTemplateNode.SelectedNode.Tag as gpTemplateNodeWebDO;
                    gptn.optId = user.auID;
                    gptn.optCoId = user.acId;
                    gptn.optTime = DateTime.Now;
                }
                else //新增
                {
                    gptn = new gpTemplateNodeWebDO();
                    gptn.gtId = gptId;
                    gptn.gtnPid = this.gptnParentId;
                    gptn.gtnPidSpecified = true;
                    gptn.adtId = user.auID;
                    gptn.adtCoId = user.acId;
                    gptn.adtTime = DateTime.Now;
                }

                gptn.gtnName = this.txtName.Text.Trim();
                gptn.gtnFileName = this.txtFileName.Text.Trim();
                gptn.gtnFiletype = (int)this.cboProjectType.SelectedValue;
                gptn.gtnFiletypeSpecified = true;
                gptn.editState = (int)this.cboCanModify.SelectedValue;
                gptn.editStateSpecified = true;
                gptn.delState = (int)this.cboCanDelete.SelectedValue;
                gptn.delStateSpecified = true;
                gptn.gtnAttr = (int)this.cboProperty.SelectedValue;
                gptn.gtnAttrSpecified = true;
                gptn.gtnDocType = (int)this.cboDocumentType.SelectedValue;
                gptn.gtnDocTypeSpecified = true;
                gptn.bossEditState = (int)this.cboCanModifyManage.SelectedValue;
                gptn.bossEditStateSpecified = true;
                gptn.carryState = (int)this.cboClient.SelectedValue;
                gptn.carryStateSpecified = true;
                gptn.biderEditState = (int)this.cboCanModifyITender.SelectedValue;
                gptn.biderEditStateSpecified = true;
                gptn.sort = int.Parse(this.txtSort.Text.Trim());
                gptn.sortSpecified = true;

                //修改
                if (this.gptnParentId == -1)
                {
                    if (this.gpTemplateNodeService.Update(gptn))
                    {
                        this.LoadTree();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "保存失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //新增
                {
                    if (this.gpTemplateNodeService.Add(gptn))
                    {
                        this.gptnParentId = -1;
                        this.LoadTree();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "保存失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "保存失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSummit_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofdl = new OpenFileDialog();
                ofdl.Filter = "word(*.doc)|*.doc";

                if (ofdl.ShowDialog() == DialogResult.OK)
                {
                    using (Stream stream = ofdl.OpenFile())
                    {
                        string fileName = Path.GetFileNameWithoutExtension(ofdl.FileName);
                        string extension = Path.GetExtension(ofdl.FileName);

                        byte[] bytes = new byte[stream.Length];
                        stream.Read(bytes, 0, bytes.Length);

                        baseUserWebDO user = Cache.GetInstance().GetValue<baseUserWebDO>("login");

                        this.gpTemplateService.FileUpload(this.gptId, user.auID, fileName, extension, bytes.Length, bytes);
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "提交失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadTree()
        {
            this.trvTemplateNode.Nodes.Clear();

            gpTemplateNodeWebDO[] gptns = this.gpTemplateNodeService.FindListByGtId(this.gptId);

            foreach (var item in gptns.Where(x => x.gtnPid == 0).OrderBy(x => x.sort))
            {
                TreeNode node = new TreeNode(item.gtnName);
                node.Tag = item;
                this.SetTreeData(gptns, node, item.gtnId);
                this.trvTemplateNode.Nodes.Add(node);
            }

            this.trvTemplateNode.ExpandAll();
        }

        public void SetTreeData(gpTemplateNodeWebDO[] gptns, TreeNode parentNode, long parentId)
        {
            foreach (var item in gptns.Where(x => x.gtnPid == parentId).OrderBy(x => x.sort))
            {
                TreeNode node = new TreeNode(item.gtnName);
                node.Tag = item;

                parentNode.Nodes.Add(node);
            }
        }
    }
}
