using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Summer.Common.Utility.WebService
{
    public class WebServiceResource
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(WebServiceResource));

        /// <summary>
        /// wsResource
        /// </summary>
        private static WebServiceResource wsResource = new WebServiceResource();

        /// <summary>
        /// config
        /// </summary>
        private ApiMapperConfig config = null;

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        private WebServiceResource()
        {
            //加载配置
            using (StreamReader sr = File.OpenText("ApiSettings.json"))
            {
                config = JsonConvert.DeserializeObject<ApiMapperConfig>(sr.ReadToEnd());
            }
        }

        /// <summary>
        /// 实例
        /// </summary>
        /// <returns>WebServiceResource</returns>
        public static WebServiceResource Instance()
        {
            return wsResource;
        }

        /// <summary>
        /// GetResource
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>ApiMapper</returns>
        public ApiMapper GetResource(string id)
        {
            ApiMapper api = this.config.ApiMappers[id].Clone() as ApiMapper;
            api.Url = this.config.BaseUrl + api.Resource;

            return api;
        }

        #endregion
    }
}
