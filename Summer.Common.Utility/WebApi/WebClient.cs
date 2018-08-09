using log4net;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Summer.Common.Utility.WebApi
{
    /// <summary>
    /// WebClient
    /// </summary>
    public class WebClient
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(WebClient));

        /// <summary>
        /// webClient
        /// </summary>
        private static WebClient webClient = new WebClient();

        /// <summary>
        /// config
        /// </summary>
        private ApiMapperConfig config = null;

        #endregion

        #region 外部接口

        /// <summary>
        /// 实例
        /// </summary>
        /// <returns>WebClient</returns>
        public static WebClient Instance()
        {
            return webClient;
        }

        /// <summary>
        /// 请求
        /// </summary>
        /// <param name="id">资源标识</param>
        /// <param name="param">参数</param>
        /// <returns>结果</returns>
        public string Request(string id, IDictionary<string, object> param)
        {
            ApiMapper api = config.ApiMappers[id];

            return Request(config.BaseUrl, api.Resource, param, api.Method);
        }

        /// <summary>
        /// 请求
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="id">资源标识</param>
        /// <param name="param">参数</param>
        /// <returns>结果</returns>
        public T Request<T>(string id, IDictionary<string, object> param) where T : class
        {
            string result = Request(id, param);

            return JsonConvert.DeserializeObject<T>(result);
        }

        /// <summary>
        /// 请求
        /// </summary>
        /// <param name="baseUrl">url</param>
        /// <param name="resource">资源</param>
        /// <param name="param">参数</param>
        /// <param name="method">请求方法</param>
        /// <returns></returns>
        public string Request(string baseUrl, string resource, IDictionary<string, object> param, HttpMethod method)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, method.ToMethod());

            //文件头
            request.AddHeader("X-HTTP-Method-Override", "POST");

            //Url路径替换参数
            foreach (KeyValuePair<string, object> item in param)
            {
                if (TypeCode.String == Type.GetTypeCode(item.Value.GetType()))
                {
                    request.AddUrlSegment(item.Key, (string)item.Value);
                }
            }

            //请求参数
            request.AddParameter("application/json; charset=utf-8", request.JsonSerializer.Serialize(param), ParameterType.RequestBody);

            try
            {
                //执行
                IRestResponse response = client.Execute(request);

                return response.Content;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                throw ex;
            }
        }

        #endregion

        #region 内部接口

        /// <summary>
        /// 构造函数
        /// </summary>
        private WebClient()
        {
            //加载配置
            using (StreamReader sr = File.OpenText("ApiSettings.json"))
            {
                config = JsonConvert.DeserializeObject<ApiMapperConfig>(sr.ReadToEnd());
            }
        }

        #endregion
    }
}
