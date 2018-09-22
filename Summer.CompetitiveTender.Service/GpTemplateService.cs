using Summer.Common.Utility.WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTemplate;

namespace Summer.CompetitiveTender.Service
{
    /// <summary>
    /// GpTemplateService
    /// </summary>
    public class GpTemplateService : IGpTemplateService
    {
        #region 字段

        /// <summary>
        /// wsAgent
        /// </summary>
        private GpTemplateWebServiceClient wsAgent = null;

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public GpTemplateService()
        {
            this.wsAgent = new GpTemplateWebServiceClient();
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="gpTemplate">gpTemplate</param>
        /// <returns>bool</returns>
        public bool Add(gpTemplateWebDO gpTemplate)
        {
            if (gpTemplate == null)
            {
                throw new ArgumentNullException(nameof(gpTemplate));
            }

            return this.wsAgent.add(gpTemplate).success;
        }

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="gtId">gtId</param>
        /// <returns>bool</returns>
        public bool Remove(string gtId)
        {
            if (string.IsNullOrEmpty(gtId))
            {
                throw new ArgumentNullException(nameof(gtId));
            }

            return this.wsAgent.remove(gtId).success;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="gtAddRequest">gtAddRequest</param>
        /// <returns>bool</returns>
        public bool Update(gpTemplateWebDO gpTemplate)
        {
            if (gpTemplate == null)
            {
                throw new ArgumentNullException(nameof(gpTemplate));
            }

            return this.wsAgent.edit(gpTemplate).success;
        }

        /// <summary>
        /// FindListById
        /// </summary>
        /// <param name="gtId">gtId</param>
        /// <returns>gpTemplateWebDO</returns>
        public gpTemplateWebDO FindListById(string gtId)
        {
            if (string.IsNullOrWhiteSpace(gtId))
            {
                throw new ArgumentNullException(nameof(gtId));
            }

            resultDO result = this.wsAgent.getById(gtId);

            if (result.success)
            {
                return result.obj as gpTemplateWebDO;
            }
            else
            {
                throw new Exception(result.message);
            }
        }

        /// <summary>
        /// FindListByAuIdAndName
        /// </summary>
        /// <param name="auId">auId</param>
        /// <param name="gtName">gtName</param>
        /// <returns>gpTemplateWebDO[]</returns>
        public gpTemplateWebDO[] FindListByAuIdAndName(string auId, string gtName)
        {
            if (string.IsNullOrWhiteSpace(auId))
            {
                throw new ArgumentNullException(nameof(auId));
            }

            resultDO result = this.wsAgent.findList(auId, gtName);

            if (result.success)
            {
                return result.objList as gpTemplateWebDO[];
            }
            else
            {
                throw new Exception(result.message);
            }
        }

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
        public int FileUpload(string fileName, string suffix, long partLength, byte[] fileContent, int totalSegment, int Segment, bool isNew, int userId)
        {
            return this.wsAgent.fileUpload(fileName, suffix, partLength, fileContent, totalSegment, Segment, isNew, userId);
        }

        /// <summary>
        /// FileDownload
        /// </summary>
        /// <param name="userId">userId</param>
        /// <param name="part">part</param>
        /// <param name="gtId">gtId</param>
        /// <returns>reslultInfoDO</returns>
        public reslultInfoDO FileDownload(int userId, int part, string gtId)
        {
            return this.wsAgent.templateDownLoad(userId, part, gtId);
        }

        #endregion
    }
}
