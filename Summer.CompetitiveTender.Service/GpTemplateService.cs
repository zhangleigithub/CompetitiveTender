using Summer.Common.Utility.WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Summer.CompetitiveTender.Model.Request;

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
        private WebServiceAgent wsAgent = null;

        /// <summary>
        /// RESOURCE_ID_ADD
        /// </summary>
        private const string RESOURCE_ID_ADD = "gpTemplateAdd";

        /// <summary>
        /// RESOURCE_ID_REMOVE
        /// </summary>
        private const string RESOURCE_ID_REMOVE = "gpTemplateRemove";

        /// <summary>
        /// RESOURCE_ID_EDIT
        /// </summary>
        private const string RESOURCE_ID_EDIT = "gpTemplateEdit";

        /// <summary>
        /// RESOURCE_ID_GETBYID
        /// </summary>
        private const string RESOURCE_ID_GETBYID = "gpTemplateGetById";

        /// <summary>
        /// RESOURCE_ID_FINDLIST
        /// </summary>
        private const string RESOURCE_ID_FINDLIST = "gpTemplateFindList";

        /// <summary>
        /// RESOURCE_ID_FILEUPLOAD
        /// </summary>
        private const string RESOURCE_ID_FILEUPLOAD = "gpTemplateFileUpload";

        /// <summary>
        /// RESOURCE_ID_FILEDOWNLOAD
        /// </summary>
        private const string RESOURCE_ID_FILEDOWNLOAD = "gpTemplateFileDownload";

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public GpTemplateService()
        {
            this.wsAgent = new WebServiceAgent(WebServiceResource.Instance().GetResource(GpTemplateService.RESOURCE_ID_ADD).Url);
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="gtAddRequest">gtAddRequest</param>
        /// <returns>bool</returns>
        public bool Add(GpTemplateAddRequest gtAddRequest)
        {
            if (gtAddRequest == null)
            {
                throw new ArgumentNullException(nameof(gtAddRequest));
            }

            return this.wsAgent.InvokeToBoolean(GpTemplateService.RESOURCE_ID_ADD, gtAddRequest.ToArgs());
        }

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="gtId">gtId</param>
        /// <returns>bool</returns>
        public bool Remove(string gtId)
        {
            return false;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="gtAddRequest">gtAddRequest</param>
        /// <returns>bool</returns>
        public bool Update(GpTemplateAddRequest gtAddRequest)
        {
            return false;
        }

        /// <summary>
        /// FindListById
        /// </summary>
        /// <param name="gtId">gtId</param>
        /// <returns>object</returns>
        public object FindListById(string gtId)
        {
            if (string.IsNullOrWhiteSpace(gtId))
            {
                throw new ArgumentNullException(nameof(gtId));
            }

            return this.wsAgent.Invoke<object>(GpTemplateService.RESOURCE_ID_GETBYID, gtId);
        }

        /// <summary>
        /// FindListByAuIdAndName
        /// </summary>
        /// <param name="auId">auId</param>
        /// <param name="gtName">gtName</param>
        /// <returns>object</returns>
        public object FindListByAuIdAndName(string auId, string gtName)
        {
            if (string.IsNullOrWhiteSpace(auId))
            {
                throw new ArgumentNullException(nameof(auId));
            }

            return this.wsAgent.Invoke<object>(GpTemplateService.RESOURCE_ID_FINDLIST, auId, gtName);
        }

        /// <summary>
        /// FileUpload
        /// </summary>
        /// <param name="obj">obj</param>
        /// <returns>object</returns>
        public object FileUpload(object obj)
        {
            return null;
        }

        /// <summary>
        /// FileDownload
        /// </summary>
        /// <param name="obj">obj</param>
        /// <returns>object</returns>
        public object FileDownload(object obj)
        {
            return null;
        }

        #endregion
    }
}
