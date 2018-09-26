using Summer.CompetitiveTender.Service.ServiceReferenceGpTenderFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Service
{
    public interface IGpTenderFileService
    {
        /// <summary>
        /// UploadFile
        /// </summary>
        /// <param name="partLength">partLength</param>
        /// <param name="packageFileContent">packageFileContent</param>
        /// <param name="totalSegment">totalSegment</param>
        /// <param name="segment">segment</param>
        /// <param name="isNew">isNew</param>
        /// <param name="buId">buId</param>
        /// <param name="gtpId">gtpId</param>
        /// <param name="gsId">gsId</param>
        /// <param name="packageFileName">packageFileName</param>
        /// <param name="packageFileSuffix">packageFileSuffix</param>
        /// <param name="packageFileSize">packageFileSize</param>
        /// <returns>bool</returns>
        bool UploadFile(long partLength, byte[] packageFileContent, int totalSegment, int segment, bool isNew, string buId, string gtpId, string gsId, string packageFileName, string packageFileSuffix, long packageFileSize);

        /// <summary>
        /// RemoveFile
        /// </summary>
        /// <param name="gtpId">gtpId</param>
        /// <param name="gsId">gsId</param>
        /// <returns>bool</returns>
        bool RemoveFile(string gtpId, string gsId);
    }
}
