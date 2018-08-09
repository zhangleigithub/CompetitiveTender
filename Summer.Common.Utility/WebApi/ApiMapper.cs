using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.Common.Utility.WebApi
{
    /// <summary>
    /// ApiMapper
    /// </summary>
    public class ApiMapper
    {
        #region 属性

        /// <summary>
        /// resource
        /// </summary>
        public string Resource { get; private set; }

        /// <summary>
        /// Method
        /// </summary>
        public HttpMethod Method { get; private set; }

        /// <summary>
        /// Desc
        /// </summary>
        public string Desc { get; private set; }

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="resource">resource</param>
        /// <param name="method">method</param>
        /// <param name="desc">desc</param>
        public ApiMapper(string resource, HttpMethod method, string desc)
        {
            this.Resource = resource;
            this.Method = method;
            this.Desc = desc;
        }

        #endregion
    }
}
