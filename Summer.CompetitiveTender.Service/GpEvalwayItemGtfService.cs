using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Summer.CompetitiveTender.Service.ServiceReferenceGpEvalwayItemGtf;

namespace Summer.CompetitiveTender.Service
{
    /// <summary>
    /// 评标条款
    /// </summary>
    public class GpEvalwayItemGtfService: IGpEvalwayItemGtfService
    {
        #region 字段

        /// <summary>
        /// wsAgent
        /// </summary>
        private GpEvalwayItemGtfWebServiceClient wsAgent = null;

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public GpEvalwayItemGtfService()
        {
            this.wsAgent = new GpEvalwayItemGtfWebServiceClient();
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="gpEvalWayItemGtf">gpEvalWayItemGtf</param>
        /// <returns>bool</returns>
        public bool Add(gpEvalWayItemGtfWebDO gpEvalWayItemGtf)
        {
            if (gpEvalWayItemGtf == null)
            {
                throw new ArgumentNullException(nameof(gpEvalWayItemGtf));
            }

            return this.wsAgent.save(gpEvalWayItemGtf).success;
        }

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="gewigId">gewigId</param>
        /// <returns>bool</returns>
        public bool Remove(string gewigId)
        {
            if (string.IsNullOrEmpty(gewigId))
            {
                throw new ArgumentNullException(nameof(gewigId));
            }

            return this.wsAgent.remove(gewigId).success;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="gpEvalWayItemGtf">gpEvalWayItemGtf</param>
        /// <returns>bool</returns>
        public bool Update(gpEvalWayItemGtfWebDO gpEvalWayItemGtf)
        {
            if (gpEvalWayItemGtf == null)
            {
                throw new ArgumentNullException(nameof(gpEvalWayItemGtf));
            }

            return this.wsAgent.edit(gpEvalWayItemGtf).success;
        }

        /// <summary>
        /// FindById
        /// </summary>
        /// <param name="gewigId">gewigId</param>
        /// <returns>gpEvalWayItemGtfWebDO</returns>
        public gpEvalWayItemGtfWebDO FindById(string gewigId)
        {
            if (string.IsNullOrWhiteSpace(gewigId))
            {
                throw new ArgumentNullException(nameof(gewigId));
            }

            return this.wsAgent.getById(gewigId).obj as gpEvalWayItemGtfWebDO;
        }

        /// <summary>
        /// FindListByGsIdAndGewigName
        /// </summary>
        /// <param name="gsId">gsId</param>
        /// <param name="gewigName">gewigName</param>
        /// <returns>gpEvalWayItemGtfWebDO[]</returns>
        public gpEvalWayItemGtfWebDO[] FindListByGsIdAndGewigName(string gsId, string gewigName)
        {
            if (string.IsNullOrWhiteSpace(gsId))
            {
                throw new ArgumentNullException(nameof(gsId));
            }

            resultDO result = this.wsAgent.findAll(gsId, gewigName);

            return ((object[])result.objList).Cast<gpEvalWayItemGtfWebDO>().ToArray();
        }

        #endregion
    }
}
