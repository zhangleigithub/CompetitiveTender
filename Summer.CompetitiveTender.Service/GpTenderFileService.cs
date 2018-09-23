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
        /// <param name="fileContent">fileContent</param>
        /// <param name="totalSegment">totalSegment</param>
        /// <param name="Segment">Segment</param>
        /// <param name="isNew">isNew</param>
        /// <param name="gpTenderFileWebDO">gpTenderFileWebDO</param>
        /// <returns>int</returns>
        public int UploadFile(long partLength, byte[] fileContent, int totalSegment, int Segment, bool isNew, gpTenderFileWebDO gpTenderFileWebDO)
        {
            return this.wsAgent.getFile(partLength, fileContent, totalSegment, Segment, isNew, gpTenderFileWebDO);
        }

        /// <summary>
        /// RemoveFile
        /// </summary>
        /// <param name="gtpId">gtpId</param>
        /// <param name="gsId">gsId</param>
        /// <returns>bool</returns>
        public bool RemoveFile(string gtpId, string gsId)
        {
            if (string.IsNullOrWhiteSpace(gtpId))
            {
                throw new ArgumentNullException(nameof(gtpId));
            }

            if (string.IsNullOrWhiteSpace(gsId))
            {
                throw new ArgumentNullException(nameof(gsId));
            }

            return this.wsAgent.removeFileInfo(gtpId, gsId).success;
        }

        #endregion
    }
}
