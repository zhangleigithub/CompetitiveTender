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
        /// GetById
        /// </summary>
        /// <param name="gtpId">gtpId</param>
        /// <returns>gpTenderProjectWebDO</returns>
        gpTenderProjectWebDO GetById(string gtpId);

        /// <summary>
        /// FindList
        /// </summary>
        /// <param name="auId">auId</param>
        /// <returns>gpTenderProjectWebDO[</returns>
        gpTenderProjectWebDO[] FindList(string auId);

        /// <summary>
        /// FindBidProjecList
        /// </summary>
        /// <param name="gtpId">gtpId</param>
        /// <param name="gsId">gsId</param>
        /// <param name="gtpName">gtpName</param>
        /// <param name="gtpCode">gtpCode</param>
        /// <returns>gpTenderProjectWebDO[]</returns>
        gpTenderProjectWebDO[] FindBidProjecList(string gtpId, string gsId, string gtpName, string gtpCode);
    }
}
