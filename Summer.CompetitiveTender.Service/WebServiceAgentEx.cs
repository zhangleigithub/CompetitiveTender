using Newtonsoft.Json;
using Summer.Common.Utility;
using Summer.Common.Utility.WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Summer.CompetitiveTender.Service
{
    /// <summary>
    /// WebServiceAgentEx
    /// </summary>
    public static class WebServiceAgentEx
    {
        /// <summary>
        /// 调用指定方法
        /// </summary>
        /// <param name="wsAgent">wsAgent</param>
        /// <param name="resourceId">resourceId</param>
        /// <param name="args">参数</param>
        /// <returns>值</returns>
        public static T Invoke<T>(this WebServiceAgent wsAgent, string resourceId, params object[] args)
        {
            ApiMapper api = WebServiceResource.Instance().GetResource(resourceId);

            object obj = wsAgent.Invoke(api.MethodName, args);

            if (obj != null)
            {
                if ((bool)obj.GetType().GetField("success").GetValue(obj))
                {
                    string result = JsonConvert.SerializeObject(obj.GetType().GetField("obj").GetValue(obj));

                    return JsonConvert.DeserializeObject<T>(result);
                }
                else
                {
                    throw new MethodAccessException(string.Format("{0}:访问失败-{1}", api.MethodName, obj.GetType().GetField("message").GetValue(obj)));
                }
            }
            else
            {
                throw new MethodAccessException(api.MethodName);
            }
        }

        /// <summary>
        /// 调用指定方法
        /// </summary>
        /// <param name="wsAgent">wsAgent</param>
        /// <param name="resourceId">resourceId</param>
        /// <param name="args">参数</param>
        /// <returns>bool</returns>
        public static bool InvokeToBoolean(this WebServiceAgent wsAgent, string resourceId, params object[] args)
        {
            ApiMapper api = WebServiceResource.Instance().GetResource(resourceId);
            
            object obj = wsAgent.Invoke(api.MethodName, args);

            if (obj != null)
            {
                return (bool)obj.GetType().GetField("success").GetValue(obj);
            }
            else
            {
                throw new MethodAccessException(api.MethodName);
            }
        }
    }
}
