using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Summer.CompetitiveTender.Service.ServiceReferenceBidEvaluation;

namespace Summer.CompetitiveTender.Service
{
    /// <summary>
    /// BidEvaluationService
    /// </summary>
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
        /// AuxiliaryAnalysis
        /// </summary>
        /// <param name="gsId">gsId</param>
        /// <returns></returns>
        public object AuxiliaryAnalysis(string gsId)
        {
            resultDO result = this.wsAgent.auxiliaryAnalysis(gsId);

            return result;
        }

        /// <summary>
        /// PriceAnalysis
        /// </summary>
        /// <param name="gsId">gsId</param>
        /// <returns></returns>
        public object PriceAnalysis(string gsId)
        {
            resultDO result = this.wsAgent.priceAnalysis(gsId);

            return result;
        }

        /// <summary>
        /// ConformanceContrastResult
        /// </summary>
        /// <param name="gsId">gsId</param>
        /// <returns></returns>
        public object ConformanceContrastResult(string gsId)
        {
            resultDO result = this.wsAgent.conformanceContrastResult(gsId);

            return result;
        }

        /// <summary>
        /// EvaluationFactorsAnalysis
        /// </summary>
        /// <param name="gsId">gsId</param>
        /// <returns></returns>
        public object EvaluationFactorsAnalysis(string gsId)
        {
            resultDO result = this.wsAgent.evaluationFactorsAnalysis(gsId);

            return result;
        }

        /// <summary>
        /// FileDifferenceResult
        /// </summary>
        /// <param name="gsId">gsId</param>
        /// <returns></returns>
        public object FileDifferenceResult(string gsId)
        {
            resultDO result = this.wsAgent.fileDifferenceResult(gsId);

            return result;
        }

        /// <summary>
        /// FileExceptionResult
        /// </summary>
        /// <param name="gsId">gsId</param>
        /// <returns></returns>
        public object FileExceptionResult(string gsId)
        {
            resultDO result = this.wsAgent.fileExceptionResult(gsId);

            return result;
        }

        /// <summary>
        /// AutomaticScoreResult
        /// </summary>
        /// <param name="gsId">gsId</param>
        /// <returns></returns>
        public object AutomaticScoreResult(string gsId)
        {
            resultDO result = this.wsAgent.automaticScoreResult(gsId);

            return result;
        }

        /// <summary>
        /// BidFileResave
        /// </summary>
        /// <param name="gpSectionWebDO">gpSectionWebDO</param>
        /// <param name="evalReportFile">evalReportFile</param>
        /// <returns>bool</returns>
        public bool BidFileResave(gpSectionWebDO gpSectionWebDO, byte[] evalReportFile)
        {
            resultDO result = this.wsAgent.bidFileResave(gpSectionWebDO, evalReportFile);

            return result.success;
        }

        /// <summary>
        /// GetBidEvaluationReportFile
        /// </summary>
        /// <param name="gsId">gsId</param>
        /// <returns>bool</returns>
        public resultDO GetBidEvaluationReportFile(string gsId)
        {
            resultDO result = this.wsAgent.getBidEvaluationReportFile(gsId);

            return result;
        }

        /// <summary>
        /// UpdateBidEvaluationSingState
        /// </summary>
        /// <param name="gpSectionWebDO">gpSectionWebDO</param>
        /// <param name="evalReportFile">evalReportFile</param>
        /// <returns>bool</returns>
        public bool UpdateBidEvaluationSingState(gpSectionWebDO gpSectionWebDO, byte[] evalReportFile)
        {
            resultDO result = this.wsAgent.updateBidEvaluationSingState(gpSectionWebDO, evalReportFile);

            return result.success;
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
