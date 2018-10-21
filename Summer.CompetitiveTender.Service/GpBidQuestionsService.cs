using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Summer.CompetitiveTender.Service.ServiceReferenceGpBidQuestions;

namespace Summer.CompetitiveTender.Service
{
    /// <summary>
    /// GpBidQuestionsService
    /// </summary>
    public class GpBidQuestionsService: IGpBidQuestionsService
    {
        #region 字段

        /// <summary>
        /// wsAgent
        /// </summary>
        private GpBidQuestionsWebServiceClient wsAgent = null;

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public GpBidQuestionsService()
        {
            this.wsAgent = new GpBidQuestionsWebServiceClient();
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="gpBidQuestions">gpBidQuestions</param>
        /// <returns>bool</returns>
        public bool Add(gpBidQuestionsWebDO gpBidQuestions)
        {
            if (gpBidQuestions == null)
            {
                throw new ArgumentNullException(nameof(gpBidQuestions));
            }

            return this.wsAgent.add(gpBidQuestions).success;
        }

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="gbqId">gbqId</param>
        /// <returns>bool</returns>
        public bool Remove(string gbqId)
        {
            return this.wsAgent.remove(gbqId).success;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="gpBidQuestions">gpBidQuestions</param>
        /// <returns>bool</returns>
        public bool Update(gpBidQuestionsWebDO gpBidQuestions)
        {
            if (gpBidQuestions == null)
            {
                throw new ArgumentNullException(nameof(gpBidQuestions));
            }

            return this.wsAgent.edit(gpBidQuestions).success;
        }

        /// <summary>
        /// FindList
        /// </summary>
        /// <param name="gtpId">gtpId</param>
        /// <param name="gsId">gsId</param>
        /// <param name="gbqAgainstCoName">gbqAgainstCoName</param>
        /// <returns>gpBidQuestionsWebDO[]</returns>
        public gpBidQuestionsWebDO[] FindList(string gtpId, string gsId, string gbqAgainstCoName)
        {
            resultDO result = this.wsAgent.findList( gtpId,  gsId,  gbqAgainstCoName);

            return ((object[])result.objList).Cast<gpBidQuestionsWebDO>().ToArray();
        }

        #endregion
    }
}
