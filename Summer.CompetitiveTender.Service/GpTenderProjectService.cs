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
        /// FindById
        /// </summary>
        /// <param name="gtpId">gtpId</param>
        /// <returns>gpTenderProjectWebDO</returns>
        public gpTenderProjectWebDO FindById(string gtpId)
        {
            if (string.IsNullOrWhiteSpace(gtpId))
            {
                throw new ArgumentNullException(nameof(gtpId));
            }

            resultDO result = this.wsAgent.getById(gtpId);

            if (result.success)
            {
                return result.obj as gpTenderProjectWebDO;
            }
            else
            {
                throw new Exception(result.message);
            }
        }

        /// <summary>
        /// FindListByAuId
        /// </summary>
        /// <param name="auId">auId</param>
        /// <returns>gpTenderProjectWebDO[</returns>
        public gpTenderProjectWebDO[] FindListByAuId(string auId)
        {
            if (string.IsNullOrWhiteSpace(auId))
            {
                throw new ArgumentNullException(nameof(auId));
            }

            resultDO result = this.wsAgent.findList(auId);

            if (result.success)
            {
                return result.obj as gpTenderProjectWebDO[];
            }
            else
            {
                throw new Exception(result.message);
            }
        }

        /// <summary>
        /// FindListByCondition
        /// </summary>
        /// <param name="gtpId">gtpId</param>
        /// <param name="gsId">gsId</param>
        /// <param name="gtpName">gtpName</param>
        /// <param name="gtpCode">gtpCode</param>
        /// <returns>gpTenderProjectWebDO[]</returns>
        public gpTenderProjectWebDO[] FindListByCondition(string gtpId, string gsId, string gtpName, string gtpCode)
        {
            resultDO result = this.wsAgent.findBidProjecList(gtpId, gsId, gtpName, gtpCode);

            if (result.success)
            {
                return result.obj as gpTenderProjectWebDO[];
            }
            else
            {
                throw new Exception(result.message);
            }
        }

        #endregion
    }
}
