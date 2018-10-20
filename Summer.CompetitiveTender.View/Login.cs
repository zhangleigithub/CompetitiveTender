using log4net;
using MetroFramework.Forms;
using Summer.Common.Utility;
using Summer.CompetitiveTender.Model;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.Service.ServiceReferenceLogin;
using Summer.CompetitiveTender.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Summer.CompetitiveTender.View
{
    /// <summary>
    /// Login
    /// </summary>
    public partial class Login : FormBase
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(Login));

        /// <summary>
        /// userService
        /// </summary>
        private IUserService userService = new UserService();

        #endregion

        #region 属性

        /// <summary>
        /// UserType
        /// </summary>
        public UserType UserType
        {
            get
            {
                if (rbInviteTender.Checked)
                {
                    return UserType.InviteTender;
                }
                else if (rbAgency.Checked)
                {
                    return UserType.Agency;
                }
                else if (rbTender.Checked)
                {
                    return UserType.Tender;
                }
                else if (rbExpert.Checked)
                {
                    return UserType.Expert;
                }
                else
                {
                    return UserType.Unkown;
                }
            }
        }

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public Login()
        {
            InitializeComponent();

            //登录方式
            this.cboLoginType.SelectedIndex = MonitorXTX.GetInstance().XTX.GetDeviceCount() > 0 ? 1 : 0;
        }

        private void cboLoginType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboLoginType.SelectedIndex == 0)
            {
                this.txtUserName.Text = "td_zbr";
            }
            else
            {
                //填充账号
                string[] certIds = MonitorXTX.GetInstance().GetCertID();
   
                if (certIds.Length > 0)
                {
                    this.txtUserName.Text = certIds[0];
                }
            }
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender">发送者</param>
        /// <param name="e">参数</param>
        private void OnOkClick(object sender, EventArgs e)
        {
            try
            {
                baseUserWebDO result;

                //账号
                if (this.cboLoginType.SelectedIndex == 0)
                {
                    login login = new login();
                    login.account = this.txtUserName.Text.Trim();
                    login.password = this.txtPassword.Text.Trim();
                    login.acRole = this.UserType.ToLonginString();
                    login.macAddress = LocalInfo.GetMacAddress();
                    result = userService.Login(login);
                }
                else //CA
                {
                    CAlogin login = new CAlogin();
                    login.caSignCert = this.txtUserName.Text.Trim();
                    login.password = this.txtPassword.Text.Trim();
                    login.acRole = this.UserType.ToLonginString();
                    login.macAddress = LocalInfo.GetMacAddress();
                    result = userService.CALogin(login);
                }

                //缓存
                Cache.GetInstance().SetValue("login", result);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroFramework.MetroMessageBox.Show(this, "登录失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
