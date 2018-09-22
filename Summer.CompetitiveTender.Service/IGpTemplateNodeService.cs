using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTemplateNode;

namespace Summer.CompetitiveTender.Service
{
    /// <summary>
    /// IGpTemplateNodeService
    /// </summary>
    public interface IGpTemplateNodeService
    {
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="gpTemplateNode">gpTemplateNode</param>
        /// <returns>bool</returns>
        bool Add(gpTemplateNodeWebDO gpTemplateNode);

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="gtnId">gtnId</param>
        /// <returns>bool</returns>
        bool Remove(long gtnId);

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="gpTemplateNode">gpTemplateNode</param>
        /// <returns>bool</returns>
        bool Update(gpTemplateNodeWebDO gpTemplateNode);

        /// <summary>
        /// FindListById
        /// </summary>
        /// <param name="gtnId">gtnId</param>
        /// <returns>gpTemplateNodeWebDO</returns>
        gpTemplateNodeWebDO FindListById(string gtnId);

        /// <summary>
        /// FindListByGtId
        /// </summary>
        /// <param name="gtId">gtId</param>
        /// <returns>gpTemplateNodeWebDO[]</returns>
        gpTemplateNodeWebDO[] FindListByGtId(string gtId);
    }
}
