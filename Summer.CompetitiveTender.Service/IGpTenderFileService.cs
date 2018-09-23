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
        /// <param name="fileContent">fileContent</param>
        /// <param name="totalSegment">totalSegment</param>
        /// <param name="Segment">Segment</param>
        /// <param name="isNew">isNew</param>
        /// <param name="gpTenderFileWebDO">gpTenderFileWebDO</param>
        /// <returns>int</returns>
        int UploadFile(long partLength, byte[] fileContent, int totalSegment, int Segment, bool isNew, gpTenderFileWebDO gpTenderFileWebDO);

        /// <summary>
        /// RemoveFile
        /// </summary>
        /// <param name="gtpId">gtpId</param>
        /// <param name="gsId">gsId</param>
        /// <returns>bool</returns>
        bool RemoveFile(string gtpId, string gsId);
    }
}
