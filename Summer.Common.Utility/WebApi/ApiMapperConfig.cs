using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace Summer.Common.Utility.WebApi
{
    public class ApiMapperConfig
    {
        /// <summary>
        /// BaseUrl
        /// </summary>
        public static string BaseUrl = "http://121.28.95.246:9090/";

        public static ApiMapper QueryApi(string impClass, string methodName)
        {
            return null;
        }

        /// <summary>
        /// 多字符替换(URL及参数处理)
        /// </summary>
        /// <param name="api">apiMap信息</param>
        /// <param name="dic">要替换的字符(key)和值(value)</param>
        /// <returns>加工后的字符串</returns>
        public static string MulCharReplace(ApiMapper api, IDictionary<string, string> dic)
        {
            if (dic == null || dic.Count == 0) return api.Url;

            //需要移除的key
            List<string> keys = new List<string>();

            //替换参数
            foreach (KeyValuePair<string, string> item in dic)
            {
                if (api.Url.Contains("{" + item.Key + "}"))
                {
                    //替换URL中的参数
                    api.Url = api.Url.Replace("{" + item.Key + "}", HttpUtility.UrlEncode(item.Value));
                    keys.Add(item.Key);
                }
                else
                {
                    //其余参数放在URL后面,POST提交方式的不在这里处理
                    if (api.Mode == RequestMethod.GET.ToString())
                    {
                        if (api.Url.Contains("?"))
                        {
                            api.Url += "&" + HttpUtility.UrlEncode(item.Key) + "=" + HttpUtility.UrlEncode(item.Value);
                        }
                        else
                        {
                            api.Url += "?" + HttpUtility.UrlEncode(item.Key) + "=" + HttpUtility.UrlEncode(item.Value);
                        }

                        keys.Add(item.Key);
                    }
                }
            }

            //移除已使用的key
            foreach (var item in keys)
            {
                dic.Remove(item);
            }

            return api.Url;
        }

    }
}
