using Summer.CompetitiveTender.Service.ServiceReferenceGpBidQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Service
{
    /// <summary>
    /// IGpBidQuestionsService
    /// </summary>
    public interface IGpBidQuestionsService
    {
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="gpBidQuestions">gpBidQuestions</param>
        /// <returns>bool</returns>
        bool Add(gpBidQuestionsWebDO gpBidQuestions);

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="gbqId">gbqId</param>
        /// <returns>bool</returns>
        bool Remove(string gbqId);

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="gpBidQuestions">gpBidQuestions</param>
        /// <returns>bool</returns>
        bool Update(gpBidQuestionsWebDO gpBidQuestions);

        /// <summary>
        /// FindList
        /// </summary>
        /// <param name="gtpId">gtpId</param>
        /// <param name="gsId">gsId</param>
        /// <param name="gbqAgainstCoName">gbqAgainstCoName</param>
        /// <returns>gpBidQuestionsWebDO[]</returns>
        gpBidQuestionsWebDO[] FindList(string gtpId, string gsId, string gbqAgainstCoName);
    }
}
