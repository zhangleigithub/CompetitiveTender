using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Summer.Common.Utility.WebApi
{
    public class HttpEx
    {
        /// <summary>
        /// 用户代理
        /// </summary>
        static string USERAGENT = "We are a team of dreams, and we struggle for dreams!";

        /// <summary>
        /// 创建请求
        /// </summary>
        /// <param name="api">URL信息</param>
        /// <param name="parameter">参数</param>
        /// <returns>响应结果</returns>
        public static string CreateRequest(ApiMapper api, IDictionary<string, string> parameter)
        {
            #region 创建请求对象
            //请求对象
            HttpWebRequest request = null;
            //请求路径
            string url = api.Url;

            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                //发送HTTPS请求
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                request = WebRequest.Create(url) as HttpWebRequest;
            }
            else
            {
                //发送HTTP请求
                request = WebRequest.Create(url) as HttpWebRequest;
            }
            #endregion

            #region 设置请求参数
            //请求方式POST
            request.Method = api.Mode;
            //请求或者响应的内容类型
            request.ContentType = api.ContentType;
            //代理
            request.UserAgent = USERAGENT;
            //超时时间
            //request.Timeout = SystemConfig.GetHttpTimeOut();
            //添加密钥验证
            //request.Headers.Add("Identity-Token", UserInfoCache.AuthKey);
            //终端类型
            request.Headers.Add("Remote-Token", "Excel");
            #endregion

            #region 从缓存中读取cookies
            //CookieCollection cookiesOld = null;
            //bool isExit = CacheHelper<string, CookieCollection>.TryGetValue("SysCookies", out cookiesOld);
            //if (isExit)
            //{
            //    request.CookieContainer = new CookieContainer();
            //    request.CookieContainer.Add(cookiesOld);
            //}
            #endregion

            #region 参数
            if (parameter != null && parameter.Count != 0)
            {
                //请求内容
                StringBuilder buffer = new StringBuilder();
                if (api.ContentType == "")
                {
                    //以json的方式响应
                    if (parameter.Count > 1)
                    {
                        //多个转换成json对象,写入
                        buffer.Append(JsonConvert.SerializeObject(parameter));
                    }
                    else
                    {
                        //只有一个参数,直接写入
                        buffer.Append(parameter.First().Value);
                    }
                }
                else
                {
                    //form请求的方式
                    int i = 0;
                    foreach (string key in parameter.Keys)
                    {
                        if (i > 0)
                        {
                            buffer.AppendFormat("&{0}={1}", HttpUtility.UrlEncode(key), HttpUtility.UrlEncode(parameter[key]));
                        }
                        else
                        {
                            buffer.AppendFormat("{0}={1}", HttpUtility.UrlEncode(key), HttpUtility.UrlEncode(parameter[key]));
                            i++;
                        }
                    }
                }

                //将参数转换成字节数组,写入请求流
                byte[] data = Encoding.UTF8.GetBytes(buffer.ToString());
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }
            #endregion

            #region 请求并获取响应
            //获取响应
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            ////读取响应cookies
            //CookieCollection cookiesNew = response.Cookies;
            ////将cookies写入缓存
            //CacheHelper<string, CookieCollection>.Add("SysCookies", cookiesNew);
            //读取响应流
            using (Stream s = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(s, Encoding.UTF8);
                return reader.ReadToEnd();
            }
            #endregion
        }

        /// <summary>
        /// 文件上传
        /// </summary>
        /// <param name="api">URL信息</param>
        /// <param name="fileName">文件名</param>
        /// <param name="filePath">文件路径</param>
        /// <returns>响应结果</returns>
        public static string UpLoad(ApiMapper api, string fileName, string filePath)
        {
            #region 创建请求对象
            //请求对象
            HttpWebRequest request = null;
            //请求路径
            string url = api.Url;

            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                //发送HTTPS请求
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                request = WebRequest.Create(url) as HttpWebRequest;
            }
            else
            {
                //发送HTTP请求
                request = WebRequest.Create(url) as HttpWebRequest;
            }
            #endregion

            #region 设置请求参数
            //请求方式POST
            request.Method = api.Mode;
            //请求或者响应的内容类型
            request.ContentType = api.ContentType;
            //代理
            request.UserAgent = USERAGENT;
            //超时时间
            //request.Timeout = SystemConfig.GetHttpTimeOut();
            //添加密钥验证
            //request.Headers.Add("Identity-Token", UserInfoCache.AuthKey);
            //终端类型
            request.Headers.Add("Remote-Token", "Excel");
            #endregion

            #region 参数
            if (api.ContentType == "" && !string.IsNullOrEmpty(fileName) && !string.IsNullOrEmpty(filePath))
            {
                //multipart/form-data 请求的方式,文件上传,文件必须有数据,否则报错
                //边界值
                string strBoundary = "----------" + DateTime.Now.Ticks.ToString("x");
                //请求头边界
                StringBuilder boundary = new StringBuilder();
                boundary.Append("--");
                boundary.Append(strBoundary);
                boundary.Append("\r\n Content-Disposition: form-data; name=\"file\"; filename=\"");
                boundary.Append(fileName);
                boundary.Append("\";\r\n Content-Type: application/octet-stream\r\n\r\n");

                //获取文件流
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                //读取字节
                BinaryReader reader = new BinaryReader(fs);

                //内容类型加上边界
                request.ContentType += "; boundary=" + strBoundary;
                //获取请求流
                Stream stream = request.GetRequestStream();
                //写入请求头
                byte[] postHeaderBytes = Encoding.UTF8.GetBytes(boundary.ToString());
                stream.Write(postHeaderBytes, 0, postHeaderBytes.Length);

                try
                {
                    //将参数转换成字节数组,写入请求流
                    //--------------------写入文件------------------------------
                    //每次上传 256
                    int bufferLength = 256;
                    byte[] buffer = new byte[bufferLength];
                    int size = reader.Read(buffer, 0, bufferLength);
                    while (size > 0)
                    {
                        stream.Write(buffer, 0, size);
                        size = reader.Read(buffer, 0, bufferLength);
                    }
                    //--------------------写入文件------------------------------
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    fs.Close();
                    reader.Close();
                }

                //添加尾部的时间戳
                byte[] boundaryBytes = Encoding.UTF8.GetBytes("\r\n--" + strBoundary + "--\r\n");
                stream.Write(boundaryBytes, 0, boundaryBytes.Length);
                //全部写入,关闭流
                stream.Flush();
                stream.Close();
            }
            #endregion

            #region 请求并获取响应
            //获取响应
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            //读取响应流
            using (Stream s = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(s, Encoding.UTF8);
                return reader.ReadToEnd();
            }
            #endregion
        }

        /// <summary>
        /// 文件下载
        /// </summary>
        /// <param name="api">URL信息</param>
        /// <param name="fileName">文件名</param>
        /// <returns>响应结果</returns>
        public static bool DownLoad(ApiMapper api, string fileName)
        {
            #region 创建请求对象
            //请求对象
            HttpWebRequest request = null;
            //请求路径
            string url = api.Url;

            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                //发送HTTPS请求
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                request = WebRequest.Create(url) as HttpWebRequest;
            }
            else
            {
                //发送HTTP请求
                request = WebRequest.Create(url) as HttpWebRequest;
            }
            #endregion

            #region 设置请求参数
            //请求方式POST
            request.Method = api.Mode;
            //请求或者响应的内容类型
            request.ContentType = api.ContentType;
            //代理
            request.UserAgent = USERAGENT;
            //超时时间
            //request.Timeout = SystemConfig.GetHttpTimeOut();
            //添加密钥验证
            //request.Headers.Add("Identity-Token", UserInfoCache.AuthKey);
            //终端类型
            request.Headers.Add("Remote-Token", "Excel");
            #endregion

            #region 请求并获取响应
            //获取响应
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            //返回值,表示下载成功或者失败
            bool Value = true;
            byte[] buffer = new byte[256];
            try
            {
                //删除原有文件
                if (File.Exists(fileName))
                    File.Delete(fileName);
                //创建文件流
                Stream outStream = File.Create(fileName);
                //获取响应流
                Stream inStream = response.GetResponseStream();
                //单次读取字节数
                int oneSize;
                do
                {
                    //读取响应流
                    oneSize = inStream.Read(buffer, 0, buffer.Length);
                    //写入文件
                    if (oneSize > 0) outStream.Write(buffer, 0, oneSize);
                }
                while (oneSize > 0);
                //关闭流
                outStream.Close();
                inStream.Close();
            }
            catch
            {
                Value = false;
            }
            return Value;
            #endregion
        }

        /// <summary>
        /// 将二进制文件保存到磁盘
        /// </summary>
        /// <param name="response"></param>
        /// <param name="FileName"></param>
        /// <returns></returns>
        private static bool SaveBinaryFile(WebResponse response, string FileName)
        {
            bool Value = true;
            byte[] buffer = new byte[1024];
            try
            {
                if (File.Exists(FileName))
                    File.Delete(FileName);
                Stream outStream = System.IO.File.Create(FileName);
                Stream inStream = response.GetResponseStream();
                int l;
                do
                {
                    l = inStream.Read(buffer, 0, buffer.Length);
                    if (l > 0)
                        outStream.Write(buffer, 0, l);
                }
                while (l > 0);
                outStream.Close();
                inStream.Close();
            }
            catch
            {
                Value = false;
            }
            return Value;
        }

        #region 保留方法

        /// <summary>
        /// 获取请求的数据
        /// </summary>
        public static string GetResponseString(HttpWebResponse webresponse)
        {
            using (Stream s = webresponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(s, Encoding.UTF8);
                return reader.ReadToEnd();
            }
        }

        /// <summary>
        /// 创建GET方式的HTTP请求  
        /// </summary>
        /// <param name="url">地址</param>
        /// <param name="timeout">超时时间</param>
        /// <param name="userAgent">用户代理</param>
        /// <param name="cookies"></param>
        /// <returns></returns>
        public static HttpWebResponse CreateGetHttpResponse(string url, int timeout, string userAgent, CookieCollection cookies)
        {
            HttpWebRequest request = null;
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                //对服务端证书进行有效性校验（非第三方权威机构颁发的证书，如自己生成的，不进行验证，这里返回true）
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version10;    //http版本，默认是1.1,这里设置为1.0
            }
            else
            {
                request = WebRequest.Create(url) as HttpWebRequest;
            }
            request.Method = "GET";

            //设置代理UserAgent和超时
            request.UserAgent = userAgent;
            request.Timeout = timeout;
            if (cookies != null)
            {
                request.CookieContainer = new CookieContainer();
                request.CookieContainer.Add(cookies);
            }
            return request.GetResponse() as HttpWebResponse;
        }

        /// <summary>
        /// 创建POST方式的HTTP请求  
        /// </summary>
        /// <param name="url">地址</param>
        /// <param name="parameters">请求参数</param>
        /// <param name="timeout">超时时间</param>
        /// <param name="userAgent">用户代理</param>
        /// <param name="cookies"></param>
        /// <returns></returns>
        public static HttpWebResponse CreatePostHttpResponse(string url, IDictionary<string, string> parameters, int timeout, string userAgent, CookieCollection cookies)
        {
            HttpWebRequest request = null;
            //如果是发送HTTPS请求  
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version10;
            }
            else
            {
                request = WebRequest.Create(url) as HttpWebRequest;
            }
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            //设置代理UserAgent和超时
            request.UserAgent = userAgent;
            request.Timeout = timeout;

            if (cookies != null)
            {
                request.CookieContainer = new CookieContainer();
                request.CookieContainer.Add(cookies);
            }
            //发送POST数据  
            if (!(parameters == null || parameters.Count == 0))
            {
                StringBuilder buffer = new StringBuilder();
                int i = 0;
                foreach (string key in parameters.Keys)
                {
                    if (i > 0)
                    {
                        buffer.AppendFormat("&{0}={1}", HttpUtility.UrlEncode(key), HttpUtility.UrlEncode(parameters[key]));
                    }
                    else
                    {
                        buffer.AppendFormat("{0}={1}", HttpUtility.UrlEncode(key), HttpUtility.UrlEncode(parameters[key]));
                        i++;
                    }
                }
                byte[] data = Encoding.UTF8.GetBytes(buffer.ToString());
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }
            string[] values = request.Headers.GetValues("Content-Type");
            return request.GetResponse() as HttpWebResponse;
        }

        /// <summary>
        /// 验证证书
        /// </summary>
        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            if (errors == SslPolicyErrors.None)
                return true;
            return false;
        }

        #endregion
    }
}
