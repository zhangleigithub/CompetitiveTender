using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Summer.CompetitiveTender.Service.ServiceReferenceGpApplyDetail;

namespace Summer.CompetitiveTender.Service
{
    public class GpApplyDetailService : IGpApplyDetailService
    {
        #region 字段

        /// <summary>
        /// wsAgent
        /// </summary>
        private GpApplyDetailWebServiceClient wsAgent = null;

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public GpApplyDetailService()
        {
            this.wsAgent = new GpApplyDetailWebServiceClient();
        }

        /// <summary>
        /// FindApplyFileBySectionId
        /// </summary>
        /// <param name="sectionId">sectionId</param>
        /// <returns>gpApplyDetailWebDO[]</returns>
        public gpApplyDetailWebDO[] FindApplyFileBySectionId(string sectionId)
        {
            resultDO result = this.wsAgent.getApplyFileList(sectionId);

            return ((object[])result.objList).Cast<gpApplyDetailWebDO>().ToArray();
        }

        #endregion
    }
}
