using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Service.BidService
{
    /// <summary>
    /// author:刘小兵
    /// memo:投标数据层实现类
    /// </summary>
    public class BidService : IBidService
    {
        /// <summary>
        /// 获取招标文件列表
        /// </summary>
        /// <param name="id">登录人ID</param>
        /// <returns></returns>
        public string FindList(string id)
        {
            string list = null;

            try
            {
                //GpTemplateWebServiceClient gpTemplateWebService = new GpTemplateWebServiceClient();
                //resultDO ret = gpTemplateWebService.findList(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
    }
}
