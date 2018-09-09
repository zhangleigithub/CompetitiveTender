using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Summer.CompetitiveTender.Service.BidService;

namespace Summer.Common.Controls.BidControl
{
    /// <summary>
    /// author:刘小兵
    /// memo:投标业务层管理类
    /// </summary>
    public class BidControl
    {
        IBidService bidService = new BidService();

        /// <summary>
        /// 获取招标文件列表
        /// </summary>
        /// <param name="id">登录人ID</param>
        /// <returns></returns>
        public string GetBidData(string id)
        {
            return bidService.FindList(id);
        }
    }
}
