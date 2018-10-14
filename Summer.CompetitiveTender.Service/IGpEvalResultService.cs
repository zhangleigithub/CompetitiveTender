using Summer.CompetitiveTender.Service.ServiceReferenceGpEvalResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Service
{
    public interface IGpEvalResultService
    {
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="gpEvalResult">gpEvalResult</param>
        /// <returns>bool</returns>
        bool Add(gpEvalResultWebDO gpEvalResult);
    }
}
