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
        /// FindBidEvaluationResultByProjectIdAndSectionId
        /// </summary>
        /// <param name="projectId">projectId</param>
        /// <param name="sectionId">sectionId</param>
        /// <returns>gpEvalResultWebDO[]</returns>
        gpEvalResultWebDO[] FindBidEvaluationResultByProjectIdAndSectionId(string projectId, string sectionId);
    }
}
