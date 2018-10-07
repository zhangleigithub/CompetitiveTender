using Summer.CompetitiveTender.Service.ServiceReferenceGpTenderEvalEle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Service
{
    /// <summary>
    /// IGpTenderEvalEleService
    /// </summary>
    public interface IGpTenderEvalEleService
    {
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="gpTenderEvalEle">gpTenderEvalEle</param>
        /// <returns>bool</returns>
        bool Add(gpTenderEvalEleWebDO gpTenderEvalEle);

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="gteeId">gteeId</param>
        /// <returns>bool</returns>
        bool Remove(string gteeId);

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="gpTenderEvalEle">gpTenderEvalEle</param>
        /// <returns>bool</returns>
        bool Update(gpTenderEvalEleWebDO gpTenderEvalEle);

        /// <summary>
        /// FindById
        /// </summary>
        /// <param name="gewigId">gewigId</param>
        /// <returns>gpEvalWayItemGtfWebDO</returns>
        gpTenderEvalEleWebDO FindById(string gteeId);

        /// <summary>
        /// FindListByGsIdAndGteeName
        /// </summary>
        /// <param name="gsId">gsId</param>
        /// <param name="gteeName">gteeName</param>
        /// <returns>gpTenderEvalEleWebDO[]</returns>
        gpTenderEvalEleWebDO[] FindListByGsIdAndGteeName(string gsId, string gteeName);
    }
}
