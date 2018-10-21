using Summer.CompetitiveTender.Service.ServiceReferenceBidEvaluation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Service
{
    public interface IBidEvaluationService
    {
        /// <summary>
        /// AuxiliaryAnalysis
        /// </summary>
        /// <param name="gsId">gsId</param>
        /// <returns></returns>
        object AuxiliaryAnalysis(string gsId);

        /// <summary>
        /// PriceAnalysis
        /// </summary>
        /// <param name="gsId">gsId</param>
        /// <returns></returns>
        object PriceAnalysis(string gsId);

        /// <summary>
        /// ConformanceContrastResult
        /// </summary>
        /// <param name="gsId">gsId</param>
        /// <returns></returns>
        object ConformanceContrastResult(string gsId);

        /// <summary>
        /// EvaluationFactorsAnalysis
        /// </summary>
        /// <param name="gsId">gsId</param>
        /// <returns></returns>
        object EvaluationFactorsAnalysis(string gsId);

        /// <summary>
        /// FileDifferenceResult
        /// </summary>
        /// <param name="gsId">gsId</param>
        /// <returns></returns>
        object FileDifferenceResult(string gsId);

        /// <summary>
        /// FileExceptionResult
        /// </summary>
        /// <param name="gsId">gsId</param>
        /// <returns></returns>
        object FileExceptionResult(string gsId);

        /// <summary>
        /// AutomaticScoreResult
        /// </summary>
        /// <param name="gsId">gsId</param>
        /// <returns></returns>
        object AutomaticScoreResult(string gsId);

        /// <summary>
        /// BidFileResave
        /// </summary>
        /// <param name="gpSectionWebDO">gpSectionWebDO</param>
        /// <param name="evalReportFile">evalReportFile</param>
        /// <returns>bool</returns>
        bool BidFileResave(gpSectionWebDO gpSectionWebDO, byte[] evalReportFile);

        /// <summary>
        /// GetBidEvaluationReportFile
        /// </summary>
        /// <param name="gsId">gsId</param>
        /// <returns>resultDO</returns>
        resultDO GetBidEvaluationReportFile(string gsId);

        /// <summary>
        /// UpdateBidEvaluationSingState
        /// </summary>
        /// <param name="gpSectionWebDO">gpSectionWebDO</param>
        /// <param name="evalReportFile">evalReportFile</param>
        /// <returns>bool</returns>
        bool UpdateBidEvaluationSingState(gpSectionWebDO gpSectionWebDO, byte[] evalReportFile);

        /// <summary>
        /// FindBidEvaluationResultByProjectIdAndSectionId
        /// </summary>
        /// <param name="projectId">projectId</param>
        /// <param name="sectionId">sectionId</param>
        /// <returns>gpEvalResultWebDO[]</returns>
        gpEvalResultWebDO[] FindBidEvaluationResultByProjectIdAndSectionId(string projectId, string sectionId);
    }
}
