using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer.Common.Utility.WebApi
{
    public class ApiMapperCategory
    {
        /// <summary>
        /// 类别名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 类别值
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 类别代号
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 此类别下的所有地址
        /// </summary>
        public List<ApiMapper> ApiMappers { get; set; }
    }
}
