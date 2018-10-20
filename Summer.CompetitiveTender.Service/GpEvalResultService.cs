using System;
using System.Collections.Generic;
using Summer.CompetitiveTender.Service.ServiceReferenceGpEvalResult;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Service
{
    public class GpEvalResultService: IGpEvalResultService
    {
        #region 字段

        /// <summary>
        /// wsAgent
        /// </summary>
        private GpEvalResultWebServiceClient wsAgent = null;

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public GpEvalResultService()
        {
            this.wsAgent = new GpEvalResultWebServiceClient();
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="gpEvalResult">gpEvalResult</param>
        /// <returns>bool</returns>
        public bool Add(gpEvalResultWebDO gpEvalResult)
        {
            if (gpEvalResult == null)
            {
                throw new ArgumentNullException(nameof(gpEvalResult));
            }

            return this.wsAgent.save(gpEvalResult).success;
        }

        #endregion
    }
}
