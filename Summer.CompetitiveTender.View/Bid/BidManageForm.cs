using MetroFramework.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Summer.Common.Utility.Commnd;
using Summer.Common.Controls.BidControl;

namespace Summer.CompetitiveTender.View.Bid
{
    public partial class BidManageForm : MetroForm
    {
        //投标文件业务层实体
        BidControl bidControl = new BidControl();

        public BidManageForm()
        {
            InitializeComponent();
        }

        private void BidManage_Load(object sender, EventArgs e)
        {
            //绑定招标文件
            BindTenderData();
        }

        /// <summary>
        /// 绑定招标文件
        /// </summary>
        public void BindTenderData()
        {
            //获取招标文件数据
            var tenderData = bidControl.GetBidData();
            //清空招标文件展示列表
            this.dgv_tenderFile.Rows.Clear();
            //绑定招标文件列表
            foreach (var item in tenderData)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dgv_tenderFile);
                row.Cells[this.colProjectCode.Index].Value = item.gtpCode;
                row.Cells[this.colProjectName.Index].Value = item.gtpName;
                row.Cells[this.colSectionCode.Index].Value = item.gsCode;
                row.Cells[this.colSectionName.Index].Value = item.gsName;
                row.Cells[this.colDownLoad.Index].Value = "下载";
                row.Tag = item;

                this.dgv_tenderFile.Rows.Add(row);
            }
            //绑定招标文件下拉框
            this.cob_objectList.DataSource = tenderData;
            this.cob_objectList.DisplayMember = "gtpName";
            this.cob_objectList.ValueMember = "gtpCode";
        }

        /// <summary>
        /// 上传投标文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_browse_Click(object sender, EventArgs e)
        {
            //初始化一个OpenFileDialog类
            OpenFileDialog fileDialog = new OpenFileDialog();

            //判断用户是否正确的选择了文件
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //获取用户选择文件的后缀名
                string extension = Path.GetExtension(fileDialog.FileName);
                //声明允许的后缀名
                string[] str = new string[] { ".doc", ".pdf" };
                if (!((IList)str).Contains(extension))
                {
                    MessageBox.Show("仅能上传doc,pdf格式的图片！");
                }
                else
                {
                    //获取用户选择的文件，并判断文件大小不能超过20K，fileInfo.Length是以字节为单位的
                    FileInfo fileInfo = new FileInfo(fileDialog.FileName);
                    if (fileInfo.Length > 2048000)
                    {
                        MessageBox.Show("上传的图片不能大于2000K");
                    }
                    else
                    {
                        txt_path.Text = fileDialog.FileName;
                    }
                }
            }
        }

        /// <summary>
        /// 压缩文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_upload_Click(object sender, EventArgs e)
        {
            //Utility utility = new Utility();
            //压缩文件
            //utility.CompressRar(txt_path.Text, txt_StorePath.Text);
            MessageBox.Show("上传成功！");
        }
        /// <summary>
        /// 获取压缩文件存放路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_StorePath_Click(object sender, EventArgs e)
        {
            //初始化一个OpenFileDialog类
            OpenFileDialog fileDialog = new OpenFileDialog();

            //判断用户是否正确的选择了文件
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_StorePath.Text = fileDialog.FileName;
            }
        }
        
    }
}
