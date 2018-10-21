using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Summer.CompetitiveTender.Service.BidService;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTenderProject;

namespace Summer.Common.Controls.BidControl
{
    /// <summary>
    /// author:刘小兵
    /// memo:投标业务层管理类
    /// </summary>
    public class BidControl
    {
        //投标服务层实体
        private IBidService bidService = new BidService();
        //招标服务层实体
        private IGpTenderProjectService gpTenderProjectService = new GpTenderProjectService();


        /// <summary>
        /// 获取招标文件列表
        /// </summary>
        /// <returns></returns>
        public gpTenderProjectWebDO[] GetBidData()
        {
            return gpTenderProjectService.FindBidProjecList(string.Empty, string.Empty, string.Empty, string.Empty);
        }
    }
}
