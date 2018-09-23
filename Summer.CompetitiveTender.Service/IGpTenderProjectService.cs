using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTenderProject;

namespace Summer.CompetitiveTender.Service
{
    public interface IGpTenderProjectService
    {
        /// <summary>
        /// FindById
        /// </summary>
        /// <param name="gtpId">gtpId</param>
        /// <returns>gpTenderProjectWebDO</returns>
        gpTenderProjectWebDO FindById(string gtpId);

        /// <summary>
        /// FindListByAuId
        /// </summary>
        /// <param name="auId">auId</param>
        /// <returns>gpTenderProjectWebDO[</returns>
        gpTenderProjectWebDO[] FindListByAuId(string auId);

        /// <summary>
        /// FindListByCondition
        /// </summary>
        /// <param name="gtpId">gtpId</param>
        /// <param name="gsId">gsId</param>
        /// <param name="gtpName">gtpName</param>
        /// <param name="gtpCode">gtpCode</param>
        /// <returns>gpTenderProjectWebDO[]</returns>
        gpTenderProjectWebDO[] FindListByCondition(string gtpId, string gsId, string gtpName, string gtpCode);
    }
}
