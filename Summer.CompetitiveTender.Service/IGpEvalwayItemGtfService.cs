using Summer.CompetitiveTender.Service.ServiceReferenceGpEvalwayItemGtf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Service
{
    /// <summary>
    /// IGpEvalwayItemGtfService
    /// </summary>
    public interface IGpEvalwayItemGtfService
    {
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="gpEvalWayItemGtf">gpEvalWayItemGtf</param>
        /// <returns>bool</returns>
        bool Add(gpEvalWayItemGtfWebDO gpEvalWayItemGtf);

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="gewigId">gewigId</param>
        /// <returns>bool</returns>
        bool Remove(string gewigId);

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="gpEvalWayItemGtf">gpEvalWayItemGtf</param>
        /// <returns>bool</returns>
        bool Update(gpEvalWayItemGtfWebDO gpEvalWayItemGtf);

        /// <summary>
        /// FindById
        /// </summary>
        /// <param name="gewigId">gewigId</param>
        /// <returns>gpEvalWayItemGtfWebDO</returns>
        gpEvalWayItemGtfWebDO FindById(string gewigId);

        /// <summary>
        /// FindListByGsIdAndGewigName
        /// </summary>
        /// <param name="gsId">gsId</param>
        /// <param name="gewigName">gewigName</param>
        /// <returns>gpEvalWayItemGtfWebDO[]</returns>
        gpEvalWayItemGtfWebDO[] FindListByGsIdAndGewigName(string gsId, string gewigName);
    }
}
