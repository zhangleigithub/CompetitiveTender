using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer.Common.Utility.WebApi
{
    public class JResult<T>
    {
        /// <summary>
        /// 错误编号，success=true时为null，success=false时有值。
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 错误描述，success=true时为null，success=false时有值。
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 返回数据，success=true时有值，success=false时为null。
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// 处理结果，bool值，非空，true:成功;false:失败。
        /// </summary>
        public bool Success { get; set; }
    }
}
