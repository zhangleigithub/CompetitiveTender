using Summer.Common.Utility;
using Summer.CompetitiveTender.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Service
{
    /// <summary>
    /// UserService
    /// </summary>
    public class UserService
    {
        #region 字段

        /// <summary>
        /// wsAgent
        /// </summary>
        private WebServiceAgent wsAgent = null;

        /// <summary>
        /// URL
        /// </summary>
        private const string URL = "http://121.28.95.246:9090/webservice/loginWebService/login";

        /// <summary>
        /// LOGIN
        /// </summary>
        private const string LOGIN = "login";

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public UserService()
        {
            wsAgent = new WebServiceAgent(UserService.URL);
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="req"></param>
        /// <returns>结果</returns>
        public object Login(LoginReq req)
        {
            if (req == null)
            {
                throw new ArgumentNullException(nameof(req));
            }

            return this.wsAgent.Invoke<string>(UserService.LOGIN, req.ToArgs());
        }

        #endregion
    }
}
