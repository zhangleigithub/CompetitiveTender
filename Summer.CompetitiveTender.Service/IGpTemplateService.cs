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
        /// <param name="fileName">fileName</param>
        /// <param name="suffix">suffix</param>
        /// <param name="partLength">partLength</param>
        /// <param name="fileContent">fileContent</param>
        /// <param name="totalSegment">totalSegment</param>
        /// <param name="Segment">Segment</param>
        /// <param name="isNew">isNew</param>
        /// <param name="userId">userId</param>
        /// <returns>bool</returns>
        int FileUpload(string fileName, string suffix, long partLength, byte[] fileContent, int totalSegment, int Segment, bool isNew, int userId);

        /// <summary>
        /// FileDownload
        /// </summary>
        /// <param name="userId">userId</param>
        /// <param name="part">part</param>
        /// <param name="gtId">gtId</param>
        /// <returns>reslultInfoDO</returns>
        reslultInfoDO FileDownload(int userId, int part, string gtId);
    }
}
