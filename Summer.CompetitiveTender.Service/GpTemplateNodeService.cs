using Summer.Common.Utility.WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTemplateNode;

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
        private GpTemplateNodeWebServiceClient wsAgent = null;

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public GpTemplateNodeService()
        {
            this.wsAgent = new GpTemplateNodeWebServiceClient();
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="gpTemplateNode">gpTemplateNode</param>
        /// <returns>bool</returns>
        public bool Add(gpTemplateNodeWebDO gpTemplateNode)
        {
            if (gpTemplateNode == null)
            {
                throw new ArgumentNullException(nameof(gpTemplateNode));
            }

            return this.wsAgent.add(gpTemplateNode).success;
        }

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="gtnId">gtnId</param>
        /// <returns>bool</returns>
        public bool Remove(long gtnId)
        {
            return this.wsAgent.remove(gtnId).success;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="gpTemplateNode">gpTemplateNode</param>
        /// <returns>bool</returns>
        public bool Update(gpTemplateNodeWebDO gpTemplateNode)
        {
            if (gpTemplateNode == null)
            {
                throw new ArgumentNullException(nameof(gpTemplateNode));
            }

            return this.wsAgent.edit(gpTemplateNode).success;
        }

        /// <summary>
        /// FindById
        /// </summary>
        /// <param name="gtnId">gtnId</param>
        /// <returns>gpTemplateNodeWebDO</returns>
        public gpTemplateNodeWebDO FindById(long gtnId)
        {
            return this.wsAgent.getById(gtnId).obj as gpTemplateNodeWebDO;
        }

        /// <summary>
        /// FindListByGtId
        /// </summary>
        /// <param name="gtId">gtId</param>
        /// <returns>gpTemplateNodeWebDO[]</returns>
        public gpTemplateNodeWebDO[] FindListByGtId(string gtId)
        {
            if (string.IsNullOrWhiteSpace(gtId))
            {
                throw new ArgumentNullException(nameof(gtId));
            }

            resultDO result = this.wsAgent.findList(gtId);

            return ((object[])result.objList).Cast<gpTemplateNodeWebDO>().ToArray();
        }

        #endregion
    }
}
