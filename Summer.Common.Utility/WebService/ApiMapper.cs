using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.Common.Utility.WebService
{
    /// <summary>
    /// ApiMapper
    /// </summary>
    public class ApiMapper : ICloneable
    {
        #region 属性

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// resource
        /// </summary>
        public string Resource { get; private set; }

        /// <summary>
        /// Method
        /// </summary>
        public string MethodName { get; private set; }

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
        /// <param name="methodName">methodName</param>
        /// <param name="desc">desc</param>
        public ApiMapper(string resource, string methodName, string desc)
        {
            this.Resource = resource;
            this.MethodName = methodName;
            this.Desc = desc;
        }

        /// <summary>
        /// Clone
        /// </summary>
        /// <returns>Clone</returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion
    }
}
