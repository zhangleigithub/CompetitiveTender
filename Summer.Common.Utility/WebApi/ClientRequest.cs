using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer.Common.Utility.WebApi
{
    public class ClientRequest
    {
        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(ClientRequest));

        /// <summary>
        /// 根据不同的请求方式获取接口返回值
        /// </summary>
        /// <param name="api">Api对象</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        public static string RequestMethodControl(ApiMapper api, IDictionary<string, string> parameters)
        {
            try
            {
                string reValue = "";
                //替换参数
                ApiMapperConfig.MulCharReplace(api, parameters);

                log.Info(api.Key + ".UrlInfo:" + JsonConvert.SerializeObject(api));
                log.Info(api.Key + ".parameters:" + JsonConvert.SerializeObject(parameters));
                
                //添加服务器地址
                api.Url = ApiMapperConfig.BaseUrl + api.Url;

                //判断使用哪个方法
                reValue = HttpEx.CreateRequest(api, parameters);

                log.Info(api.Key + ".returnValues:" + reValue);
                log.Info("--------------------------------------------------------------------------------");
                
                //返回请求结果
                return reValue;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return ex.ToString();
            }
        }

        /// <summary>
        /// 获取请求结果,自动转换成目标对象列表
        /// </summary>
        /// <typeparam name="T">目标对象</typeparam>
        /// <param name="impClass">实现类名称</param>
        /// <param name="methodName">方法名称</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        public static JResult<List<T>> GetListResult<T>(string impClass, string methodName, Dictionary<string, string> parameters)
        {
            try
            {
                //获取地址
                ApiMapper api = ApiMapperConfig.QueryApi(impClass, methodName);
                
                //获取响应
                string response = RequestMethodControl(api, parameters);

                if (string.IsNullOrEmpty(response)) return null;

                //对象转换
                JResult<List<T>> result = JsonConvert.DeserializeObject<JResult<List<T>>>(response);
                
                //判断是否获取到数据
                if (result.Success == true)
                { 
                    return result;
                }
                else
                { 
                    return new JResult<List<T>>();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return new JResult<List<T>>();
            }
        }

        /// <summary>
        /// 获取请求结果,自动转换成目标对象
        /// </summary>
        /// <typeparam name="T">目标对象</typeparam>
        /// <param name="impClass">实现类名称</param>
        /// <param name="methodName">方法名称</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        public static JResult<T> GetModelResult<T>(string impClass, string methodName, Dictionary<string, string> parameters)
        {
            try
            {
                //获取地址
                ApiMapper api = ApiMapperConfig.QueryApi(impClass, methodName);
                //获取响应
                string response = RequestMethodControl(api, parameters);

                //if (string.IsNullOrEmpty(response)) return default(T);

                //对象转换
                JResult<T> result = JsonConvert.DeserializeObject< JResult<T>>(response);
                
                //判断是否获取到数据
                if (result.Success == true && result.Result != null)
                { 
                    return result;
                }
                else
                { 
                    return default(JResult<T>);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return default(JResult<T>);
            }
        }

        /// <summary>
        /// 获取请求结果
        /// </summary>
        /// <typeparam name="T">目标对象</typeparam>
        /// <param name="impClass">实现类名称</param>
        /// <param name="methodName">方法名称</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        public static JResult<T> GetResult<T>(string impClass, string methodName, Dictionary<string, string> parameters)
        {
            try
            {
                //获取地址
                ApiMapper api = ApiMapperConfig.QueryApi(impClass, methodName);
                
                //获取响应
                string response = RequestMethodControl(api, parameters);

                if (string.IsNullOrEmpty(response))
                { 
                    return null;
                }

                //对象转换
                JResult<T> result = JsonConvert.DeserializeObject<JResult<T>>(response);
                
                //判断是否获取到数据
                return result;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return new JResult<T> { Code = "Error", Message = "系统捕获到异常:" + ex.ToString(), Success = false };
            }
        }

        /// <summary>
        /// 根据不同的请求方式获取接口返回值
        /// </summary>
        /// <param name="impClass">实现类名称</param>
        /// <param name="methodName">方法名称</param>
        /// <param name="parameters">参数</param>
        /// <param name="fileName">文件名</param>
        /// <param name="filePath">文件路径</param>
        /// <returns></returns>
        public static JResult<T> UpLoad<T>(string impClass, string methodName, IDictionary<string, string> parameters, string fileName, string filePath)
        {
            try
            {
                string reValue = "";

                //获取地址
                ApiMapper api = ApiMapperConfig.QueryApi(impClass, methodName);

                //替换参数
                ApiMapperConfig.MulCharReplace(api, parameters);

                //添加服务器地址
                api.Url = ApiMapperConfig.BaseUrl + api.Url;

                //判断使用哪个方法
                reValue = HttpEx.UpLoad(api, fileName, filePath);

                log.Info(api.Key + ".returnValues:" + reValue);

                if (string.IsNullOrEmpty(reValue))
                {
                    return null;
                }
                //对象转换
                JResult<T> result = JsonConvert.DeserializeObject<JResult<T>>(reValue);
               
                //返回请求结果
                return result;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return new JResult<T> { Code = "Error", Message = "系统捕获到异常:" + ex.ToString(), Success = false };
            }
        }

        /// <summary>
        /// 文件下载
        /// </summary>
        /// <param name="impClass">实现类名称</param>
        /// <param name="methodName">方法名称</param>
        /// <param name="parameters">参数</param>
        /// <param name="filePath">文件保存路径</param>
        public static bool DownLoad(string impClass, string methodName, IDictionary<string, string> parameters, string filePath)
        {
            try
            {
                bool reValue = false;
                // 获取地址
                ApiMapper api = ApiMapperConfig.QueryApi(impClass, methodName);

                //替换参数
                ApiMapperConfig.MulCharReplace(api, parameters);

                //添加服务器地址
                api.Url = ApiMapperConfig.BaseUrl + api.Url;

                //判断使用哪个方法
                reValue = HttpEx.DownLoad(api, filePath);

                //返回请求结果
                return reValue;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return false;
            }
        }
    }
}
