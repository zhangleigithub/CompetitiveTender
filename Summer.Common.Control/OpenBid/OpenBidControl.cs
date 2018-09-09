using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Summer.CompetitiveTender.Service.OpenBid;

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
                openBid.FindSectionList(gtpName, gsName, auId);
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
                openBid.getSectionById(gsId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return ret;
        }
    }
}
