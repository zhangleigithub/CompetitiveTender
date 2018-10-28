using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTfOperation;

namespace Summer.CompetitiveTender.Service
{
    public class GpTfOperationService : IGpTfOperationService
    {
        #region 字段

        /// <summary>
        /// wsAgent
        /// </summary>
        private GpTfOperationWebServiceClient wsAgent = null;

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public GpTfOperationService()
        {
            this.wsAgent = new GpTfOperationWebServiceClient();
        }

        /// <summary>
        /// FindById
        /// </summary>
        /// <param name="gtoId">gtoId</param>
        /// <returns>gpTfOperationWebDO</returns>
        public gpTfOperationWebDO FindById(string gtoId)
        {
            if (string.IsNullOrWhiteSpace(gtoId))
            {
                throw new ArgumentNullException(nameof(gtoId));
            }

            return this.wsAgent.getById(gtoId).obj as gpTfOperationWebDO;
        }

        /// <summary>
        /// FindQuestions
        /// </summary>
        /// <param name="gtpId">gtpId</param>
        /// <param name="gsId">gsId</param>
        /// <param name="gtoTitle">gtoTitle</param>
        /// <param name="gtoType">gtoType</param>
        /// <returns>gpTfOperationWebDO[]</returns>
        public gpTfOperationWebDO[] FindQuestions(string gtpId, string gsId, string gtoTitle, int gtoType)
        {
            resultDO result = this.wsAgent.findQuestions(gtpId, gsId, gtoTitle, gtoType);

            if (result.objList == null)
            {
                return new gpTfOperationWebDO[0];
            }

            return ((object[])result.objList).Cast<gpTfOperationWebDO>().ToArray();
        }

        /// <summary>
        /// ReplayQuestion
        /// </summary>
        /// <param name="gtowd">gtowd</param>
        /// <returns>bool</returns>
        public bool ReplayQuestion(gpTfOperationWebDO gtowd)
        {
            return this.wsAgent.replayQuestions(gtowd).success;
        }

        #endregion
    }
}
