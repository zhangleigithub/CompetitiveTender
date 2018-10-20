using System;
using System.Collections.Generic;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTenderFile;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Service
{
    public class GpTenderFileService : IGpTenderFileService
    {
        #region 字段

        /// <summary>
        /// wsAgent
        /// </summary>
        private GpTenderFileWebServiceClient wsAgent = null;

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public GpTenderFileService()
        {
            this.wsAgent = new GpTenderFileWebServiceClient();
        }

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
        public bool UploadFile(long partLength, byte[] packageFileContent, int totalSegment, int segment, bool isNew, string buId, string gtpId, string gsId, string packageFileName, string packageFileSuffix, long packageFileSize)
        {
            return this.wsAgent.uploadTenderpackage(partLength, packageFileContent, totalSegment, segment, isNew, buId, gtpId, gsId, packageFileName, packageFileSuffix, packageFileSize).success;
        }

        /// <summary>
        /// DownloadFile
        /// </summary>
        /// <param name="gtpId">gtpId</param>
        /// <param name="gsId">gsId</param>
        /// <param name="part">gsId</param>
        /// <param name="buId">gsId</param>
        /// <returns>bool</returns>
        public bool DownloadFile(string gtpId, string gsId, int part, string buId)
        {
            return this.wsAgent.downloadTenderpackage(gtpId, gsId, part, buId).success;
        }

        /// <summary>
        /// RemoveFile
        /// </summary>
        /// <param name="gtpId">gtpId</param>
        /// <param name="gsId">gsId</param>
        /// <returns>bool</returns>
        public bool RemoveFile(string gtpId, string gsId)
        {
            return this.wsAgent.removeFileInfo(gtpId, gsId).success;
        }

        #endregion
    }
}
