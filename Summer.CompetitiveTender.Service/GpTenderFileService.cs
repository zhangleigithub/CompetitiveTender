using System;
using System.Collections.Generic;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTenderFile;
using System.Linq;
using System.Text;
using System.IO;

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
        /// UploadFile
        /// </summary>
        /// <param name="fileName">fileName</param>
        /// <param name="buId">buId</param>
        /// <param name="gtpId">gtpId</param>
        /// <param name="gsId">gsId</param>
        /// <returns>bool</returns>
        public bool UploadFile(string fileName, string buId, string gtpId, string gsId)
        {
            int size = 1 * 1024 * 1024;
            int total = 0;
            string packageFileName = Path.GetFileNameWithoutExtension(fileName);
            string packageFileSuffix = Path.GetExtension(fileName).Remove(0, 1);
            long packageFileSize = 0;

            using (FileStream fs = File.OpenRead(fileName))
            {
                packageFileSize = fs.Length;
                total = (int)(fs.Length / size) + (fs.Length % size == 0 ? 0 : 1);
                using (BinaryReader br = new BinaryReader(fs))
                {
                    for (int i = 1; i <= total; i++)
                    {
                        byte[] bytes = br.ReadBytes(size);

                        resultDO result = this.wsAgent.uploadTenderpackage(bytes.Length, bytes, total, i, true, buId, gtpId, gsId, packageFileName, packageFileSuffix, packageFileSize);

                        if (result.code != i)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
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
        /// DownloadFile
        /// </summary>
        /// <param name="filePath">filePath</param>
        /// <param name="gtpId">gtpId</param>
        /// <param name="gsId">gsId</param>
        /// <param name="buId">buId</param>
        /// <returns>bool</returns>
        public bool DownloadFile(string filePath, string gtpId, string gsId, string buId)
        {
            resultDO obj = this.wsAgent.downloadTenderpackage(gtpId, gsId, 1, buId);

            if (!obj.success)
            {
                return false;
            }

            reslultInfoDO fileInfo = obj.obj as reslultInfoDO;
            string fileName = Path.Combine(filePath, fileInfo.fileName + "." + fileInfo.suffix);
            long fileSize = fileInfo.fileSize;
            long size = obj.fileContent.Length;
            int total = fileInfo.totalSegment;

            using (FileStream fs = File.Open(fileName, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    bw.Write(obj.fileContent);
                    bw.Flush();

                    for (int i = 2; i <= total; i++)
                    {
                        resultDO temp = this.wsAgent.downloadTenderpackage(gtpId, gsId, i, buId);

                        if (temp.success)
                        {
                            bw.Write(temp.fileContent);
                            bw.Flush();
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
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
