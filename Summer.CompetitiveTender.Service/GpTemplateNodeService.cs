using Summer.Common.Utility.WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Service
{
    /// <summary>
    /// GpTemplateNodeService
    /// </summary>
    public class GpTemplateNodeService : IGpTemplateNodeService
    {
        #region 字段

        /// <summary>
        /// wsAgent
        /// </summary>
        private WebServiceAgent wsAgent = null;

        /// <summary>
        /// RESOURCE_ID_ADD
        /// </summary>
        private const string RESOURCE_ID_ADD = "gpTemplateNodeAdd";

        /// <summary>
        /// RESOURCE_ID_REMOVE
        /// </summary>
        private const string RESOURCE_ID_REMOVE = "gpTemplateNodeRemove";

        /// <summary>
        /// RESOURCE_ID_EDIT
        /// </summary>
        private const string RESOURCE_ID_EDIT = "gpTemplateNodeEdit";

        /// <summary>
        /// RESOURCE_ID_GETBYID
        /// </summary>
        private const string RESOURCE_ID_GETBYID = "gpTemplateNodeGetById";

        /// <summary>
        /// RESOURCE_ID_FINDLIST
        /// </summary>
        private const string RESOURCE_ID_FINDLIST = "gpTemplateNodeFindList";

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public GpTemplateNodeService()
        {
            this.wsAgent = new WebServiceAgent(WebServiceResource.Instance().GetResource(GpTemplateNodeService.RESOURCE_ID_ADD).Url);
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="gtnAddRequest">gtnAddRequest</param>
        /// <returns>bool</returns>
        public bool Add(object gtnAddRequest)
        {
            return false;
        }

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="gtnId">gtnId</param>
        /// <returns>bool</returns>
        public bool Remove(string gtnId)
        {
            return false;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="gtnAddRequest">gtnAddRequest</param>
        /// <returns>bool</returns>
        public bool Update(object gtnAddRequest)
        {
            return false;
        }

        /// <summary>
        /// FindListById
        /// </summary>
        /// <param name="gtnId">gtnId</param>
        /// <returns>object</returns>
        public object FindListById(string gtnId)
        {
            return null;
        }

        /// <summary>
        /// FindListByGtId
        /// </summary>
        /// <param name="gtId">gtId</param>
        /// <returns>object</returns>
        public object FindListByGtId(string gtId)
        {
            return null;
        }

        #endregion
    }
}
