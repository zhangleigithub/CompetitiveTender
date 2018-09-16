using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        /// <param name="gtnAddRequest">gtnAddRequest</param>
        /// <returns>bool</returns>
        bool Add(object gtnAddRequest);

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="gtnId">gtnId</param>
        /// <returns>bool</returns>
        bool Remove(string gtnId);

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="gtnAddRequest">gtnAddRequest</param>
        /// <returns>bool</returns>
        bool Update(object gtnAddRequest);

        /// <summary>
        /// FindListById
        /// </summary>
        /// <param name="gtnId">gtnId</param>
        /// <returns>object</returns>
        object FindListById(string gtnId);

        /// <summary>
        /// FindListByGtId
        /// </summary>
        /// <param name="gtId">gtId</param>
        /// <returns>object</returns>
        object FindListByGtId(string gtId);

    }
}
