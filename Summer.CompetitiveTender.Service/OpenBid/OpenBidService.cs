using Summer.CompetitiveTender.Service.OpenBidService;
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
        //实例化webService
        GpSectionWebServiceClient gpSectionWebService = new GpSectionWebServiceClient();

        /// <summary>
        /// 招标项目标段列表信息查询
        /// </summary>
        /// <param name="gtpName">招标项目名称</param>
        /// <param name="gsName">标段名称</param>
        /// <param name="auId">当前能登陆人id</param>
        /// <returns></returns>
        public string FindSectionList(string gtpName, string gsName, string auId)
        {
            string ret = string.Empty;
            try
            {
                gpSectionWebService.findSectionList(gtpName);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return ret;
        }

        /// <summary>
        /// 招标项目标段信息查询
        /// </summary>
        /// <param name="gsId">标段ID</param>
        /// <returns></returns>
        public string getSectionById(string gsId)
        {
            string ret = string.Empty;
            try
            {
                gpSectionWebService.getSectionById(gsId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return ret;
        }
    }
}
