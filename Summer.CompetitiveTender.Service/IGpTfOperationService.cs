using Summer.CompetitiveTender.Service.ServiceReferenceGpTfOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Service
{
    public interface IGpTfOperationService
    {
        /// <summary>
        /// FindById
        /// </summary>
        /// <param name="gtoId">gtoId</param>
        /// <returns>gpTfOperationWebDO</returns>
        gpTfOperationWebDO FindById(string gtoId);

        /// <summary>
        /// FindQuestions
        /// </summary>
        /// <param name="gtpId">gtpId</param>
        /// <param name="gsId">gsId</param>
        /// <param name="gtoTitle">gtoTitle</param>
        /// <param name="gtoType">gtoType</param>
        /// <returns>gpTfOperationWebDO[]</returns>
         gpTfOperationWebDO[] FindQuestions(string gtpId, string gsId, string gtoTitle, int gtoType);

        /// <summary>
        /// ReplayQuestion
        /// </summary>
        /// <param name="gtowd">gtowd</param>
        /// <returns>bool</returns>
        bool ReplayQuestion(gpTfOperationWebDO gtowd);
    }
}
