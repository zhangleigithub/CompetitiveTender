using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Summer.CompetitiveTender.Service.openBidWebService;

namespace Summer.CompetitiveTender.Service.OpenBid
{
    /// <summary>
    /// author:刘小兵
    /// memo:开标数据层接口
    /// </summary>
    public interface IOpenBidService
    {
        /// <summary>
        /// 主持人签到
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <param name="loginId">登录人ID</param>
        /// <returns></returns>
        resultDO HostSignIn(string gtpId, string loginId);

        /// <summary>
        /// 修改签到时间
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <param name="time">时间</param>
        /// <returns></returns>
        resultDO UpdataSignInTime(string gtpId, long time);

        /// <summary>
        /// 修改解密时间
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <param name="time">时间</param>
        /// <returns></returns>
        resultDO UpdataDecryptTime(string gtpId, long time);

        /// <summary>
        /// 修改确认价格时间
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <param name="time">时间</param>
        /// <returns></returns>
        resultDO UpdataConfirmPriceTime(string gtpId, long time);

        /// <summary>
        /// 修改签字时间
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <param name="time">时间</param>
        /// <returns></returns>
        resultDO UpdataSignTime(string gtpId, long time);

        /// <summary>
        /// 开标开始
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <returns></returns>
        resultDO OpenBidStart(string gtpId);

        /// <summary>
        /// 开标暂停
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <returns></returns>
        resultDO OpenBidPause(string gtpId);

        /// <summary>
        /// 开标继续
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <returns></returns>
        resultDO OpenBidContinue(string gtpId);

        /// <summary>
        /// 开标一览表
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <returns></returns>
        gpOpenBidWebService.resultDO GetOpenBidList(string gtpId);
    }
}
