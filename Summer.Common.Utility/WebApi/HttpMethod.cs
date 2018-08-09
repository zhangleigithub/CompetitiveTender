using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.Common.Utility.WebApi
{
    /// <summary>
    /// HttpMethod
    /// </summary>
    public enum HttpMethod
    {
        GET = 0,
        POST = 1,
        PUT = 2,
        DELETE = 3,
        HEAD = 4,
        OPTIONS = 5,
        PATCH = 6,
        MERGE = 7
    }

    /// <summary>
    /// HttpMethodEx
    /// </summary>
    public static class HttpMethodEx
    {
        /// <summary>
        /// 转换为Method
        /// </summary>
        /// <param name="method">method</param>
        /// <returns>Method</returns>
        public static Method ToMethod(this HttpMethod method)
        {
            switch (method)
            {
                case HttpMethod.GET:
                    return Method.GET;
                case HttpMethod.POST:
                    return Method.POST;
                case HttpMethod.PUT:
                    return Method.PUT;
                case HttpMethod.DELETE:
                    return Method.DELETE;
                case HttpMethod.HEAD:
                    return Method.HEAD;
                case HttpMethod.OPTIONS:
                    return Method.OPTIONS;
                case HttpMethod.PATCH:
                    return Method.PATCH;
                case HttpMethod.MERGE:
                    return Method.MERGE;
                default:
                    throw new ArithmeticException("httpMethod");
            }
        }
    }
}
