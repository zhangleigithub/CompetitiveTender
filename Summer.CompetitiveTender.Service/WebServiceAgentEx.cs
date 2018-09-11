using Summer.Common.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        /// <param name="methodName">方法名称</param>
        /// <param name="args">参数</param>
        /// <returns>值</returns>
        public static T Invoke<T>(this WebServiceAgent wsAgent, string methodName, params object[] args)
        {
            object obj = wsAgent.Invoke(methodName, args);

            if (obj != null)
            {
                if ((bool)obj.GetType().GetField("success").GetValue(obj))
                {
                    return default(T);
                }
                else
                {
                    throw new MethodAccessException(string.Format("{0}:访问失败-{1}", methodName, obj.GetType().GetField("message").GetValue(obj)));
                }
            }
            else
            {
                throw new MethodAccessException(methodName);
            }
        }
    }
}
