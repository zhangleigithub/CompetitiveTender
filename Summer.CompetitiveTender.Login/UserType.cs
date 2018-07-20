using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Login
{
    /// <summary>
    /// 用户类型
    /// </summary>
    public enum UserType
    {
        /// <summary>
        /// 未知
        /// </summary>
        Unkown,

        /// <summary>
        /// 招标
        /// </summary>
        InviteTender,

        /// <summary>
        /// 投标
        /// </summary>
        Tender,

        /// <summary>
        /// 专家
        /// </summary>
        Expert
    }
}
