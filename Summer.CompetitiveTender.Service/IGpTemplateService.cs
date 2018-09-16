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
        /// <param name="gtAddRequest">gtAddRequest</param>
        /// <returns>bool</returns>
        bool Add(GpTemplateAddRequest gtAddRequest);

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="gtId">gtId</param>
        /// <returns>bool</returns>
        bool Remove(string gtId);

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="gtAddRequest">gtAddRequest</param>
        /// <returns>bool</returns>
        bool Update(GpTemplateAddRequest gtAddRequest);

        /// <summary>
        /// FindListById
        /// </summary>
        /// <param name="gtId">gtId</param>
        /// <returns>object</returns>
        object FindListById(string gtId);

        /// <summary>
        /// FindListByAuIdAndName
        /// </summary>
        /// <param name="auId">auId</param>
        /// <param name="gtName">gtName</param>
        /// <returns>object</returns>
        object FindListByAuIdAndName(string auId, string gtName);

        /// <summary>
        /// FileUpload
        /// </summary>
        /// <param name="obj">obj</param>
        /// <returns>object</returns>
        object FileUpload(object obj);

        /// <summary>
        /// FileDownload
        /// </summary>
        /// <param name="obj">obj</param>
        /// <returns>object</returns>
        object FileDownload(object obj);
    }
}
