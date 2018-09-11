using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Web.Services.Description;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Reflection;

namespace Summer.Common.Utility.WebService
{
    /// <summary>
    /// WebServiceAgent
    /// </summary>
    public class WebServiceAgent
    {
        #region 字段

        /// <summary>
        /// agent
        /// </summary>
        private object agent = null;

        /// <summary>
        /// agentType
        /// </summary>
        private Type agentType = null;

        /// <summary>
        /// CODE_NAMESPACE
        /// </summary>
        private const string CODE_NAMESPACE = "Summer.WebServiceAgent.Dynamic";

        #endregion

        #region 属性

        /// <summary>
        /// 方法
        /// </summary>
        public MethodInfo[] Methods
        {
            get
            {
                if (agentType == null)
                {
                    throw new ArgumentNullException(nameof(agentType));
                }

                return agentType.GetMethods();
            }
        }

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="url">url</param>
        public WebServiceAgent(string url)
        {
            XmlTextReader reader = new XmlTextReader(url + "?wsdl");

            //创建和格式化 WSDL 文档
            ServiceDescription sd = ServiceDescription.Read(reader);

            //创建客户端代理代理类
            ServiceDescriptionImporter sdi = new ServiceDescriptionImporter();
            sdi.AddServiceDescription(sd, null, null);

            //使用CodeDom编译客户端代理类
            CodeNamespace cn = new CodeNamespace(WebServiceAgent.CODE_NAMESPACE);
            CodeCompileUnit ccu = new CodeCompileUnit();
            ccu.Namespaces.Add(cn);
            sdi.Import(cn, ccu);

            Microsoft.CSharp.CSharpCodeProvider icc = new Microsoft.CSharp.CSharpCodeProvider();
            CompilerParameters cp = new CompilerParameters();
            CompilerResults cr = icc.CompileAssemblyFromDom(cp, ccu);

            this.agentType = cr.CompiledAssembly.GetTypes()[0];
            this.agent = Activator.CreateInstance(agentType);
        }

        /// <summary>
        /// 调用指定方法
        /// </summary>
        /// <param name="methodName">方法名称</param>
        /// <param name="args">参数</param>
        /// <returns>值</returns>
        public object Invoke(string methodName, params object[] args)
        {
            MethodInfo mi = this.agentType.GetMethod(methodName);

            return this.Invoke(mi, args);
        }

        /// <summary>
        /// 调用指定方法
        /// </summary>
        /// <param name="method">方法</param>
        /// <param name="args">参数</param>
        /// <returns>值</returns>
        public object Invoke(MethodInfo method, params object[] args)
        {
            return method.Invoke(this.agent, args);
        }

        #endregion
    }
}
