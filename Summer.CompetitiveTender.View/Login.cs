using log4net;
using MetroFramework.Forms;
using Summer.Common.Utility.WebApi;
using Summer.CompetitiveTender.Model.Response;
using Summer.CompetitiveTender.Service.LoginServiceReference;
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
                LoginWebServiceClient client1 = new LoginWebServiceClient();
                json result = client1.login(this.txtUserName.Text, this.txtPassword.Text, this.UserType.ToLonginString(), string.Empty);

                if (result.success)
                {
                    log.Debug(result.obj);
                    //LoginRes loginRes = result.obj.ToObject<LoginRes>();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    log.Error(result.message);
                    MetroFramework.MetroMessageBox.Show(this, "登录失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
