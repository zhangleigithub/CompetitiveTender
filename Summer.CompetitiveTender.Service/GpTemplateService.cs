using Summer.Common.Utility.WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Summer.CompetitiveTender.Model.Request;

namespace Summer.CompetitiveTender.Service
{
    /// <summary>
    /// GpTemplateService
    /// </summary>
    public class GpTemplateService : IGpTemplateService
    {
        #region 字段

        /// <summary>
        /// wsAgent
        /// </summary>
        private WebServiceAgent wsAgent = null;

        /// <summary>
        /// RESOURCE_ID_ADD
        /// </summary>
        private const string RESOURCE_ID_ADD = "gpTemplateAdd";

        /// <summary>
        /// RESOURCE_ID_FINDLIST
        /// </summary>
        private const string RESOURCE_ID_FINDLIST = "gpTemplateFindList";

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public GpTemplateService()
        {
            wsAgent = new WebServiceAgent(WebServiceResource.Instance().GetResource(GpTemplateService.RESOURCE_ID_ADD).Url);
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="gpTemplateAddRequest">gpTemplateAddRequest</param>
        /// <returns>bool</returns>
        public bool Add(GpTemplateAddRequest gpTemplateAddRequest)
        {
            if (gpTemplateAddRequest == null)
            {
                throw new ArgumentNullException(nameof(gpTemplateAddRequest));
            }

            return this.wsAgent.InvokeToBoolean(GpTemplateService.RESOURCE_ID_ADD, gpTemplateAddRequest.ToArgs());
        }

        /// <summary>
        /// FindListByAuId
        /// </summary>
        /// <param name="auId">auId</param>
        /// <returns>object</returns>
        public object FindListByAuId(string auId)
        {
            if (string.IsNullOrWhiteSpace(auId))
            {
                throw new ArgumentNullException(nameof(auId));
            }

            return this.wsAgent.Invoke<object>(GpTemplateService.RESOURCE_ID_FINDLIST, auId);
        }

        #endregion
    }
}
