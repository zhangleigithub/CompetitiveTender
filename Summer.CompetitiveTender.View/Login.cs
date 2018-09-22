using log4net;
using MetroFramework.Forms;
using Summer.CompetitiveTender.Model;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.Service.ServiceReferenceLogin;
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
                login login = new login();
                login.account = this.txtUserName.Text.Trim();
                login.password = this.txtPassword.Text.Trim();
                login.acRole = this.UserType.ToLonginString();
                login.macAddress = string.Empty;

                //登录
                baseUserWebDO result = userService.Login(login);

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
