using Summer.Common.Utility;
using Summer.Common.Utility.WebService;
using Summer.CompetitiveTender.Model.Request;
using Summer.CompetitiveTender.Model.Response;
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
        private WebServiceAgent wsAgent = null;

        /// <summary>
        /// RESOURCE_ID
        /// </summary>
        private const string RESOURCE_ID = "login";

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public UserService()
        {
            wsAgent = new WebServiceAgent(WebServiceResource.Instance().GetResource(UserService.RESOURCE_ID).Url);
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="loginRequest">loginRequest</param>
        /// <returns>结果</returns>
        public LoginResponse Login(LoginRequest loginRequest)
        {
            if (loginRequest == null)
            {
                throw new ArgumentNullException(nameof(loginRequest));
            }

            return this.wsAgent.Invoke<LoginResponse>(UserService.RESOURCE_ID, loginRequest.ToArgs());
        }

        #endregion
    }
}
