using log4net;
using MetroFramework.Forms;
using Summer.CompetitiveTender.Model;
using Summer.CompetitiveTender.Model.Request;
using Summer.CompetitiveTender.Model.Response;
using Summer.CompetitiveTender.Service;
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
                LoginRequest loginRequest = new LoginRequest();
                loginRequest.UserName = this.txtUserName.Text.Trim();
                loginRequest.Password = this.txtPassword.Text.Trim();
                loginRequest.UserType = this.UserType.ToLonginString();

                //登录
                LoginResponse result = userService.Login(loginRequest);

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
