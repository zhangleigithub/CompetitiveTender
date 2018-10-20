using MetroFramework.Forms;
using Summer.Common.Controls.OpenBid;
using Summer.CompetitiveTender.Model;
using Summer.CompetitiveTender.Service.ServiceReferenceLogin;
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
    public partial class OOBDecryptBidFileForm : MetroForm
    {
        //实例化开标业务层对象
        private OpenBidControl openBidControl = new OpenBidControl();
        //获取登录信息
        private baseUserWebDO loginInfo = Cache.GetInstance().GetValue<baseUserWebDO>("login");
        //项目ID,进入开标大厅时赋值
        public string gtpId { get; set; }

        public OOBDecryptBidFileForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 主持人签到
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_signIn_Click(object sender, EventArgs e)
        {
            try
            {
                //签到
                Service.openBidWebService.resultDO ret = openBidControl.HostSignIn(gtpId, loginInfo.acId);

                if (ret.success)
                {
                    //MessageBox.Show("签到成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ret.message, "失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //TODO:日志记录
                MessageBox.Show(ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 修改签到时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_setSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                //获取签到时间
                string strTime = txtSignInTime.Text.Trim();
                //转换为长整型
                long time = Convert.ToInt64(strTime);
                //修改
                Service.openBidWebService.resultDO ret = openBidControl.UpdataSignInTime(loginInfo.acId, time);

                if (ret.success)
                {
                    MessageBox.Show("修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ret.message, "失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //TODO:日志记录
                MessageBox.Show(ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 修改解密时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_setDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                //获取解密时间
                string strTime = txtDecrypt.Text.Trim();
                //转换为长整型
                long time = Convert.ToInt64(strTime);
                //修改
                Service.openBidWebService.resultDO ret = openBidControl.UpdataDecryptTime(loginInfo.acId, time);

                if (ret.success)
                {
                    MessageBox.Show("修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ret.message, "失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //TODO:日志记录
                MessageBox.Show(ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 修改确认价格时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmPrice_Click(object sender, EventArgs e)
        {
            try
            {
                //修改确认价格时间
                string strTime = txtConfirmPrice.Text.Trim();
                //转换为长整型
                long time = Convert.ToInt64(strTime);
                //修改
                Service.openBidWebService.resultDO ret = openBidControl.UpdataConfirmPriceTime(loginInfo.acId, time);

                if (ret.success)
                {
                    MessageBox.Show("修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ret.message, "失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //TODO:日志记录
                MessageBox.Show(ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 修改签字时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sign_Click(object sender, EventArgs e)
        {
            try
            {
                //修改签字时间
                string strTime = txtSign.Text.Trim();
                //转换为长整型
                long time = Convert.ToInt64(strTime);
                //修改
                Service.openBidWebService.resultDO ret = openBidControl.UpdataSignTime(loginInfo.acId, time);

                if (ret.success)
                {
                    MessageBox.Show("修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ret.message, "失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //TODO:日志记录
                MessageBox.Show(ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 开标开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                //开标开始
                Service.openBidWebService.resultDO ret = openBidControl.OpenBidStart(gtpId);

                if (ret.success)
                {
                    MessageBox.Show("开标开始！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ret.message, "失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //TODO:日志记录
                MessageBox.Show(ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 开标暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_pause_Click(object sender, EventArgs e)
        {
            try
            {
                //开标暂停
                Service.openBidWebService.resultDO ret = openBidControl.OpenBidPause(gtpId);

                if (ret.success)
                {
                    MessageBox.Show("开标暂停！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ret.message, "失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //TODO:日志记录
                MessageBox.Show(ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 开标继续
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_continue_Click(object sender, EventArgs e)
        {
            try
            {
                //开标继续
                Service.openBidWebService.resultDO ret = openBidControl.OpenBidContinue(gtpId);

                if (ret.success)
                {
                    MessageBox.Show("开标继续！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ret.message, "失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //TODO:日志记录
                MessageBox.Show(ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OOBDecryptBidFileForm_Load(object sender, EventArgs e)
        {

        }

        public void GetOpenBidList()
        {
            Service.gpOpenBidWebService.resultDO ret = openBidControl.GetOpenBidList(gtpId);

            this.gOpenBidList.Rows.Clear();
            //绑定招标文件列表
            foreach (var item in ret.objList)
            {
                //DataGridViewRow row = new DataGridViewRow();
                //row.CreateCells(this.gOpenBidList);
                //row.Cells[this.gtpCode.Index].Value = item.;
                //row.Cells[this.gtpName.Index].Value = item.gtpName;
                //row.Cells[this.colSectionCode.Index].Value = item.gsCode;
                //row.Cells[this.colSectionName.Index].Value = item.gsName;
                //row.Cells[this.colDownLoad.Index].Value = "下载";
                //row.Tag = item;

                //this.dgv_tenderFile.Rows.Add(row);
            }
        }
    }
}
