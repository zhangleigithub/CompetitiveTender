using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Service.BidService
{
    /// <summary>
    /// author:刘小兵
    /// memo:投标数据层接口
    /// </summary>
    public interface IBidService
    {
        /// <summary>
        /// 获取招标文件列表
        /// </summary>
        /// <param name="id">登录人ID</param>
        /// <returns></returns>
        string FindList(string id);
    }
}
