using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTemplate;

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
        /// <param name="gpTemplate">gpTemplate</param>
        /// <returns>bool</returns>
        bool Add(gpTemplateWebDO gpTemplate);

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="gtId">gtId</param>
        /// <returns>bool</returns>
        bool Remove(string gtId);

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="gpTemplate">gpTemplate</param>
        /// <returns>bool</returns>
        bool Update(gpTemplateWebDO gpTemplate);

        /// <summary>
        /// FindListById
        /// </summary>
        /// <param name="gtId">gtId</param>
        /// <returns>gpTemplateWebDO</returns>
        gpTemplateWebDO FindById(string gtId);

        /// <summary>
        /// FindListByAuIdAndName
        /// </summary>
        /// <param name="auId">auId</param>
        /// <param name="gtName">gtName</param>
        /// <returns>gpTemplateWebDO[]</returns>
        gpTemplateWebDO[] FindListByAuIdAndName(string auId, string gtName);

        /// <summary>
        /// FileUpload
        /// </summary>
        /// <param name="gtId">gtId</param>
        /// <param name="buId">buId</param>
        /// <param name="gtFileName">gtFileName</param>
        /// <param name="gtFileSuffix">gtFileSuffix</param>
        /// <param name="gtFileSize">gtFileSize</param>
        /// <param name="gtFileContent">gtFileContent</param>
        /// <returns>bool</returns>
        bool FileUpload(string gtId, string buId, string gtFileName, string gtFileSuffix, long gtFileSize, byte[] gtFileContent);

        /// <summary>
        /// FileDownload
        /// </summary>
        /// <param name="gtId">gtId</param>
        /// <returns>resultDO</returns>
        resultDO FileDownload(string gtId);
    }
}
