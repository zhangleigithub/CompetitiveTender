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
        /// FindById
        /// </summary>
        /// <param name="gtId">gtId</param>
        /// <returns>gpTemplateWebDO</returns>
        public gpTemplateWebDO FindById(string gtId)
        {
            if (string.IsNullOrWhiteSpace(gtId))
            {
                throw new ArgumentNullException(nameof(gtId));
            }

            return this.wsAgent.getById(gtId).obj as gpTemplateWebDO;
        }

        /// <summary>
        /// FindListByAuIdAndName
        /// </summary>
        /// <param name="auId">auId</param>
        /// <param name="gtName">gtName</param>
        /// <param name="state">state</param>
        /// <returns>gpTemplateWebDO[]</returns>
        public gpTemplateWebDO[] FindListByAuIdAndName(string auId, string gtName,int state)
        {
            if (string.IsNullOrWhiteSpace(auId))
            {
                throw new ArgumentNullException(nameof(auId));
            }

            resultDO result = this.wsAgent.findList(auId, gtName, state);

            return ((object[])result.objList).Cast<gpTemplateWebDO>().ToArray();
        }

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
        public bool FileUpload(string gtId, string buId, string gtFileName, string gtFileSuffix, long gtFileSize, byte[] gtFileContent)
        {
            return this.wsAgent.uploadFile( gtId,  buId,  gtFileName,  gtFileSuffix,  gtFileSize,  gtFileContent).success;
        }

        /// <summary>
        /// FileDownload
        /// </summary>
        /// <param name="gtId">gtId</param>
        /// <returns>resultDO</returns>
        public resultDO FileDownload(string gtId)
        {
            return this.wsAgent.downLoadFile(gtId);
        }

        #endregion
    }
}
