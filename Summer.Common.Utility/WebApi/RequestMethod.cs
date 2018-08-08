using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer.Common.Utility.WebApi
{
    public enum RequestModeEnum
    {
        /// <summary>
        /// Put请求 1
        /// </summary>
        [Description("Put请求")]
        PUT = 1,

        /// <summary>
        /// Get请求 2
        /// </summary>
        [Description("Get请求")]
        GET = 2,

        /// <summary>
        /// Post请求 3
        /// </summary>
        [Description("Post请求")]
        POST = 3,

        /// <summary>
        /// Delete请求 4
        /// </summary>
        [Description("Delete请求")]
        DELETE = 4
    }
}
