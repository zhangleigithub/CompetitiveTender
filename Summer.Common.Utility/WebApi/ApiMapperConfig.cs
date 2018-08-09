using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.Common.Utility.WebApi
{
    /// <summary>
    /// ApiMapperConfig
    /// </summary>
    public class ApiMapperConfig
    {
        #region 属性

        /// <summary>
        /// BaseUrl
        /// </summary>
        public string BaseUrl { get; private set; }

        /// <summary>
        /// ApiMappers
        /// </summary>
        public IDictionary<string, ApiMapper> ApiMappers { get; private set; }

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="baseUrl">baseUrl</param>
        /// <param name="apiMappers">apiMappers</param>
        public ApiMapperConfig(string baseUrl, IDictionary<string, ApiMapper> apiMappers)
        {
            this.BaseUrl = baseUrl;
            this.ApiMappers = apiMappers;
        }

        #endregion
    }
}
