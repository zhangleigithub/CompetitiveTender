using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Summer.CompetitiveTender.Service.ServiceReferenceBidEvaluation;

namespace Summer.CompetitiveTender.Service
{
    public class BidEvaluationService : IBidEvaluationService
    {
        #region 字段

        /// <summary>
        /// wsAgent
        /// </summary>
        private BidEvaluationWebServiceClient wsAgent = null;

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public BidEvaluationService()
        {
            this.wsAgent = new BidEvaluationWebServiceClient();
        }

        /// <summary>
        /// FindBidEvaluationResultByProjectIdAndSectionId
        /// </summary>
        /// <param name="projectId">projectId</param>
        /// <param name="sectionId">sectionId</param>
        /// <returns>gpEvalResultWebDO[]</returns>
        public gpEvalResultWebDO[] FindBidEvaluationResultByProjectIdAndSectionId(string projectId, string sectionId)
        {
            resultDO result = this.wsAgent.getBidEvaluationResult(projectId, sectionId);

            return ((object[])result.objList).Cast<gpEvalResultWebDO>().ToArray();
        }

        #endregion
    }
}
