using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.View
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
        /// 代理机构
        /// </summary>
        Agency,

        /// <summary>
        /// 投标
        /// </summary>
        Tender,

        /// <summary>
        /// 专家
        /// </summary>
        Expert
    }

    /// <summary>
    /// UserTypeEx
    /// </summary>
    internal static class UserTypeEx
    {
        /// <summary>
        /// 转换为登录编码
        /// </summary>
        /// <param name="userType">userType</param>
        /// <returns>string</returns>
        public static string ToLonginString(this UserType userType)
        {
            switch (userType)
            {
                case UserType.Unkown:
                    throw new ArgumentOutOfRangeException("Unkown");
                case UserType.InviteTender:
                    return "01";
                case UserType.Agency:
                    return "02";
                case UserType.Tender:
                    return "03";
                case UserType.Expert:
                    return "04";
                default:
                    throw new ArgumentOutOfRangeException("Unkown");
            }
        }
    }
}
