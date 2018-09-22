using Summer.Common.Utility;
using Summer.Common.Utility.WebService;
using Summer.CompetitiveTender.Service.ServiceReferenceLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Service
{
    /// <summary>
    /// UserService
    /// </summary>
    public class UserService : IUserService
    {
        #region 字段

        /// <summary>
        /// wsAgent
        /// </summary>
        private LoginWebServiceClient wsAgent = null;

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public UserService()
        {
            this.wsAgent = new LoginWebServiceClient();
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="login">login</param>
        /// <returns>结果</returns>
        public baseUserWebDO Login(login login)
        {
            if (login == null)
            {
                throw new ArgumentNullException(nameof(login));
            }
          
            resultDO result= this.wsAgent.login(login.account, login.password, login.acRole, login.macAddress);

            if (result.success)
            {
               return result.obj as baseUserWebDO;
            }
            else
            {
                throw new Exception(result.message);
            }
        }

        /// <summary>
        /// CALogin
        /// </summary>
        /// <param name="calogin">calogin</param>
        /// <returns>结果</returns>
        public baseUserWebDO CALogin(CAlogin calogin)
        {
            if (calogin == null)
            {
                throw new ArgumentNullException(nameof(calogin));
            }

            resultDO result = this.wsAgent.CAlogin(calogin.caSignCert, calogin.password, calogin.acRole, calogin.macAddress);

            if (result.success)
            {
                return result.obj as baseUserWebDO;
            }
            else
            {
                throw new Exception(result.message);
            }
        }

        #endregion
    }
}
