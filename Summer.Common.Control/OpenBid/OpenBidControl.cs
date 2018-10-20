using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Summer.CompetitiveTender.Service.openBidWebService;
using Summer.CompetitiveTender.Service.OpenBid;
using Summer.CompetitiveTender.Service.gpOpenBidWebService;

namespace Summer.Common.Controls.OpenBid
{
    /// <summary>
    /// author:刘小兵
    /// memo:开标业务层管理类
    /// </summary>
    public class OpenBidControl
    {
        IOpenBidService openBid = new OpenBidService();

        /// <summary>
        /// 主持人签到
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <param name="loginId">登录人ID</param>
        /// <returns></returns>
        public CompetitiveTender.Service.openBidWebService.resultDO HostSignIn(string gtpId, string loginId)
        {
            //签到
            CompetitiveTender.Service.openBidWebService.CompetitiveTender.Service.openBidWebService.resultDO ret = openBid.HostSignIn(gtpId, loginId);
            return ret;
        }

        /// <summary>
        /// 修改签到时间
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <param name="time">时间</param>
        /// <returns></returns>
        public CompetitiveTender.Service.openBidWebService.resultDO UpdataSignInTime(string gtpId, long time)
        {
            //修改签到时间
            CompetitiveTender.Service.openBidWebService.resultDO ret = openBid.UpdataSignInTime(gtpId, time);
            return ret;
        }

        /// <summary>
        /// 修改解密时间
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <param name="time">时间</param>
        /// <returns></returns>
        public CompetitiveTender.Service.openBidWebService.resultDO UpdataDecryptTime(string gtpId, long time)
        {
            //修改解密时间
            CompetitiveTender.Service.openBidWebService.resultDO ret = openBid.UpdataDecryptTime(gtpId, time);
            return ret;
        }

        /// <summary>
        /// 修改确认价格时间
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <param name="time">时间</param>
        /// <returns></returns>
        public CompetitiveTender.Service.openBidWebService.resultDO UpdataConfirmPriceTime(string gtpId, long time)
        {
            //修改确认价格时间
            CompetitiveTender.Service.openBidWebService.resultDO ret = openBid.UpdataConfirmPriceTime(gtpId, time);
            return ret;
        }

        /// <summary>
        /// 修改签字时间
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <param name="time">时间</param>
        /// <returns></returns>
        public CompetitiveTender.Service.openBidWebService.resultDO UpdataSignTime(string gtpId, long time)
        {
            //修改签字时间
            CompetitiveTender.Service.openBidWebService.resultDO ret = openBid.UpdataSignTime(gtpId, time);
            return ret;
        }

        /// <summary>
        /// 开标开始
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <returns></returns>
        public CompetitiveTender.Service.openBidWebService.resultDO OpenBidStart(string gtpId)
        {
            //开标开始
            CompetitiveTender.Service.openBidWebService.resultDO ret = openBid.OpenBidStart(gtpId);
            return ret;
        }

        /// <summary>
        /// 开标暂停
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <returns></returns>
        public CompetitiveTender.Service.openBidWebService.resultDO OpenBidPause(string gtpId)
        {
            //开标暂停
            CompetitiveTender.Service.openBidWebService.resultDO ret = openBid.OpenBidPause(gtpId);
            return ret;
        }

        /// <summary>
        /// 开标继续
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <returns></returns>
        public CompetitiveTender.Service.openBidWebService.resultDO OpenBidContinue(string gtpId)
        {
            //开标继续
            CompetitiveTender.Service.openBidWebService.resultDO ret = openBid.OpenBidContinue(gtpId);
            return ret;
        }

        /// <summary>
        /// 开标一览表
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <returns></returns>
        public CompetitiveTender.Service.gpOpenBidWebService.resultDO GetOpenBidList(string gtpId)
        {
            CompetitiveTender.Service.gpOpenBidWebService.resultDO ret = openBid.GetOpenBidList(gtpId);
            return ret;
        }
    }
}
