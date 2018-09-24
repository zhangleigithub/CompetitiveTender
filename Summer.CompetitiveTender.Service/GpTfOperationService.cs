using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTfOperation;

namespace Summer.CompetitiveTender.Service
{
    public class GpTfOperationService
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

            resultDO result = this.wsAgent.getById(gtoId);

            if (result.success)
            {
                return result.obj as gpTfOperationWebDO;
            }
            else
            {
                throw new Exception(result.message);
            }
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

            if (result.success)
            {
                return result.objList as gpTfOperationWebDO[];
            }
            else
            {
                throw new Exception(result.message);
            }
        }

        /// <summary>
        /// ReplayQuestion
        /// </summary>
        /// <param name="gtowd">gtowd</param>
        /// <returns>bool</returns>
        public bool ReplayQuestion(gpTfOperationWebDO gtowd)
        {
            resultDO result = this.wsAgent.replayQuestions(gtowd);

            return result.success;
        }

        #endregion
    }
}
