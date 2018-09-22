using Summer.CompetitiveTender.Service.ServiceReferenceLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Service
{
    /// <summary>
    /// IUserService
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Login
        /// </summary>
        /// <param name="login">login</param>
        /// <returns>结果</returns>
        baseUserWebDO Login(login login);

        /// <summary>
        /// CALogin
        /// </summary>
        /// <param name="calogin">calogin</param>
        /// <returns>结果</returns>
        baseUserWebDO CALogin(CAlogin calogin);
    }
}
