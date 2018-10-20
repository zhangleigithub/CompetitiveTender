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

namespace Summer.CompetitiveTender.View.Bid
{
    public partial class BidManageForm : MetroForm
    {
        public BidManageForm()
        {
            InitializeComponent();
        }

        private void BidManage_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                DataGridViewRow Row = new DataGridViewRow();
                int index = dgv_tenderFile.Rows.Add(Row);
                dgv_tenderFile.Rows[index].Cells[0].Value = "测试" + i.ToString();
                dgv_tenderFile.Rows[index].Cells[1].Value = "项目" + i.ToString();
                dgv_tenderFile.Rows[index].Cells[2].Value = DateTime.Now.ToShortDateString();
                dgv_tenderFile.Rows[index].Cells[3].Value = "下载";
                int indexOnHistory = dgv_historyFile.Rows.Add(Row.Clone());
                dgv_historyFile.Rows[indexOnHistory].Cells[0].Value = "项目" + i.ToString();
                dgv_historyFile.Rows[indexOnHistory].Cells[1].Value = DateTime.Now.ToShortDateString();
                dgv_historyFile.Rows[indexOnHistory].Cells[2].Value = "结果" + i.ToString();
                dgv_historyFile.Rows[indexOnHistory].Cells[3].Value = "下载";
            }
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
