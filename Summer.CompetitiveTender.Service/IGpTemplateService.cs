using Summer.CompetitiveTender.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Service
{
    /// <summary>
    /// IGpTemplateService
    /// </summary>
    public interface IGpTemplateService
    {
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="gpTemplateAddRequest">gpTemplateAddRequest</param>
        /// <returns>bool</returns>
        bool Add(GpTemplateAddRequest gpTemplateAddRequest);

        /// <summary>
        /// FindListByAuId
        /// </summary>
        /// <param name="auId">auId</param>
        /// <returns>object</returns>
        object FindListByAuId(string auId);
    }
}
