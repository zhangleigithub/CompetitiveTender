using Summer.CompetitiveTender.Service.openBidWebService;
using Summer.CompetitiveTender.Service.gpOpenBidWebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Service.OpenBid
{
    /// <summary>
    /// author:刘小兵
    /// memo:开标数据层实现类
    /// </summary>
    public class OpenBidService : IOpenBidService
    {
        //实例化开标接口
        OpenBidWebServiceClient openBidWebServiceClient = new OpenBidWebServiceClient();
        GpOpenBidWebServiceClient gpOpenBidWebServiceClient = new GpOpenBidWebServiceClient();

        /// <summary>
        /// 主持人签到
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <param name="loginId">登录人ID</param>
        /// <returns></returns>
        public openBidWebService.resultDO HostSignIn(string gtpId, string loginId)
        {
            //签到
            openBidWebService.resultDO ret = openBidWebServiceClient.moderatorRegistIn(gtpId, loginId);
            return ret;
        }

        /// <summary>
        /// 修改签到时间
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <param name="time">时间</param>
        /// <returns></returns>
        public openBidWebService.resultDO UpdataSignInTime(string gtpId, long time)
        {
            //修改签到时间
            openBidWebService.resultDO ret = openBidWebServiceClient.setRegistTimeLimit(gtpId, time);
            return ret;
        }

        /// <summary>
        /// 修改解密时间
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <param name="time">时间</param>
        /// <returns></returns>
        public openBidWebService.resultDO UpdataDecryptTime(string gtpId, long time)
        {
            //修改解密时间
            openBidWebService.resultDO ret = openBidWebServiceClient.setDecodeTimeLimit(gtpId, time);
            return ret;
        }

        /// <summary>
        /// 修改确认价格时间
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <param name="time">时间</param>
        /// <returns></returns>
        public openBidWebService.resultDO UpdataConfirmPriceTime(string gtpId, long time)
        {
            //修改确认价格时间
            openBidWebService.resultDO ret = openBidWebServiceClient.setConfirmTimeLimit(gtpId, time);
            return ret;
        }

        /// <summary>
        /// 修改签字时间
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <param name="time">时间</param>
        /// <returns></returns>
        public openBidWebService.resultDO UpdataSignTime(string gtpId, long time)
        {
            //修改签字时间
            openBidWebService.resultDO ret = openBidWebServiceClient.setSignTimeLimit(gtpId, time);
            return ret;
        }

        /// <summary>
        /// 开标开始
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <returns></returns>
        public openBidWebService.resultDO OpenBidStart(string gtpId)
        {
            //开标开始
            openBidWebService.resultDO ret = openBidWebServiceClient.openBidStart(gtpId);
            return ret;
        }

        /// <summary>
        /// 开标暂停
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <returns></returns>
        public openBidWebService.resultDO OpenBidPause(string gtpId)
        {
            //开标暂停
            openBidWebService.resultDO ret = openBidWebServiceClient.openBidPause(gtpId);
            return ret;
        }

        /// <summary>
        /// 开标继续
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <returns></returns>
        public openBidWebService.resultDO OpenBidContinue(string gtpId)
        {
            //开标继续
            openBidWebService.resultDO ret = openBidWebServiceClient.openBidContinue(gtpId);
            return ret;
        }

        /// <summary>
        /// 开标一览表
        /// </summary>
        /// <param name="gtpId">项目ID</param>
        /// <returns></returns>
        public gpOpenBidWebService.resultDO GetOpenBidList(string gtpId)
        {
            gpOpenBidWebService.resultDO ret = gpOpenBidWebServiceClient.getDecRecordByGtpId(gtpId);
            return ret;
        }
    }
}
