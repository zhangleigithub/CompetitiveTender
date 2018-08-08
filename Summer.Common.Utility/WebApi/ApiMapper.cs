using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer.Common.Utility.WebApi
{
    public class ApiMapper
    {
        public ApiMapper()
        {
            //默认为json方式
            ContentType = "application/json";
        }

        /// <summary>
        /// 唯一key值
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 访问路径
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 请求方式
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// 地址说明
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 响应内容类型(默认为Json)
        /// </summary>
        public string ContentType { get; set; }
    }
}
