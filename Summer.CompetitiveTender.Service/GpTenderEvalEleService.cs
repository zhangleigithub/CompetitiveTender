using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTenderEvalEle;

namespace Summer.CompetitiveTender.Service
{
    /// <summary>
    /// 评分点
    /// </summary>
    public class GpTenderEvalEleService : IGpTenderEvalEleService
    {
        #region 字段

        /// <summary>
        /// wsAgent
        /// </summary>
        private GpTenderEvalEleWebServiceClient wsAgent = null;

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public GpTenderEvalEleService()
        {
            this.wsAgent = new GpTenderEvalEleWebServiceClient();
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="gpTenderEvalEle">gpTenderEvalEle</param>
        /// <returns>bool</returns>
        public bool Add(gpTenderEvalEleWebDO gpTenderEvalEle)
        {
            if (gpTenderEvalEle == null)
            {
                throw new ArgumentNullException(nameof(gpTenderEvalEle));
            }

            return this.wsAgent.save(gpTenderEvalEle).success;
        }

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="gteeId">gteeId</param>
        /// <returns>bool</returns>
        public bool Remove(string gteeId)
        {
            if (string.IsNullOrEmpty(gteeId))
            {
                throw new ArgumentNullException(nameof(gteeId));
            }

            return this.wsAgent.remove(gteeId).success;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="gpTenderEvalEle">gpTenderEvalEle</param>
        /// <returns>bool</returns>
        public bool Update(gpTenderEvalEleWebDO gpTenderEvalEle)
        {
            if (gpTenderEvalEle == null)
            {
                throw new ArgumentNullException(nameof(gpTenderEvalEle));
            }

            return this.wsAgent.edit(gpTenderEvalEle).success;
        }

        /// <summary>
        /// FindById
        /// </summary>
        /// <param name="gewigId">gewigId</param>
        /// <returns>gpEvalWayItemGtfWebDO</returns>
        public gpTenderEvalEleWebDO FindById(string gteeId)
        {
            if (string.IsNullOrWhiteSpace(gteeId))
            {
                throw new ArgumentNullException(nameof(gteeId));
            }

            return this.wsAgent.getById(gteeId).obj as gpTenderEvalEleWebDO;
        }

        /// <summary>
        /// FindListByGsIdAndGteeName
        /// </summary>
        /// <param name="gsId">gsId</param>
        /// <param name="gteeName">gteeName</param>
        /// <returns>gpTenderEvalEleWebDO[]</returns>
        public gpTenderEvalEleWebDO[] FindListByGsIdAndGteeName(string gsId, string gteeName)
        {
            if (string.IsNullOrWhiteSpace(gsId))
            {
                throw new ArgumentNullException(nameof(gsId));
            }

            resultDO result = this.wsAgent.findAll(gsId, gteeName);

            return ((object[])result.objList).Cast<gpTenderEvalEleWebDO>().ToArray();
        }

        #endregion
    }
}
