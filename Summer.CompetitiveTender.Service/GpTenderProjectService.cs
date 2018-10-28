using Summer.CompetitiveTender.Service.ServiceReferenceGpTenderProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Service
{
    public class GpTenderProjectService : IGpTenderProjectService
    {
        #region 字段

        /// <summary>
        /// wsAgent
        /// </summary>
        private GpTenderProjectWebServiceClient wsAgent = null;

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public GpTenderProjectService()
        {
            this.wsAgent = new GpTenderProjectWebServiceClient();
        }

        /// <summary>
        /// GetById
        /// </summary>
        /// <param name="gtpId">gtpId</param>
        /// <returns>gpTenderProjectWebDO</returns>
        public gpTenderProjectWebDO GetById(string gtpId)
        {
            if (string.IsNullOrWhiteSpace(gtpId))
            {
                throw new ArgumentNullException(nameof(gtpId));
            }

            return this.wsAgent.getById(gtpId).obj as gpTenderProjectWebDO;
        }

        /// <summary>
        /// FindList
        /// </summary>
        /// <param name="auId">auId</param>
        /// <returns>gpTenderProjectWebDO[</returns>
        public gpTenderProjectWebDO[] FindList(string auId)
        {
            if (string.IsNullOrWhiteSpace(auId))
            {
                throw new ArgumentNullException(nameof(auId));
            }

            resultDO result = this.wsAgent.findList(auId);

            return ((object[])result.objList).Cast<gpTenderProjectWebDO>().ToArray();
        }

        /// <summary>
        /// FindBidProjecList
        /// </summary>
        /// <param name="gtpId">gtpId</param>
        /// <param name="gsId">gsId</param>
        /// <param name="gtpName">gtpName</param>
        /// <param name="gtpCode">gtpCode</param>
        /// <returns>gpTenderProjectWebDO[]</returns>
        public gpTenderProjectWebDO[] FindBidProjecList(string gtpId, string gsId, string gtpName, string gtpCode)
        {
            resultDO result = this.wsAgent.findBidProjecList(gtpId, gsId, gtpName, gtpCode);

            if (result.objList == null)
            {
                return new gpTenderProjectWebDO[0];
            }

            return ((object[])result.objList).Cast<gpTenderProjectWebDO>().ToArray();
        }

        #endregion
    }
}
