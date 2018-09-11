using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Model.Request
{
    /// <summary>
    /// LoginReq
    /// </summary>
    public class LoginRequest : IRequest
    {
        #region 属性

        /// <summary>
        /// UserName
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// UserType
        /// </summary>
        public string UserType { get; set; }

        /// <summary>
        /// MacAddress
        /// </summary>
        public string MacAddress { get; set; }

        #endregion

        #region 方法

        /// <summary>
        /// ToArgs
        /// </summary>
        /// <returns>object[]</returns>
        public object[] ToArgs()
        {
            object[] args = new object[4];

            args[0] = this.UserName;
            args[1] = this.Password;
            args[2] = this.UserType;
            args[3] = this.MacAddress;

            return args;
        }

        #endregion
    }
}
