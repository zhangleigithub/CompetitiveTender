using Summer.CompetitiveTender.Model.Request;
using Summer.CompetitiveTender.Model.Response;
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
        /// <param name="loginRequest">loginRequest</param>
        /// <returns>结果</returns>
        LoginResponse Login(LoginRequest loginRequest);
    }
}
