using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Service.OpenBid
{
    /// <summary>
    /// author:刘小兵
    /// memo:开标数据层接口
    /// </summary>
    public interface IOpenBidService
    {
        /// <summary>
        /// 招标项目标段列表信息查询
        /// </summary>
        /// <param name="gtpName">招标项目名称</param>
        /// <param name="gsName">标段名称</param>
        /// <param name="auId">当前能登陆人id</param>
        /// <returns></returns>
        string FindSectionList(string gtpName, string gsName, string auId);

        /// <summary>
        /// 招标项目标段信息查询
        /// </summary>
        /// <param name="gsId">标段ID</param>
        /// <returns></returns>
        string getSectionById(string gsId);
    }
}
