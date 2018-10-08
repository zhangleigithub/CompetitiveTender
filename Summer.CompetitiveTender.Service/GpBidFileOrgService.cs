using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Summer.CompetitiveTender.Service.ServiceReferenceGpBidFileOrg;

namespace Summer.CompetitiveTender.Service
{
    /// <summary>
    /// 评分因素
    /// </summary>
    public class GpBidFileOrgService : IGpBidFileOrgService
    {
        #region 字段

        /// <summary>
        /// wsAgent
        /// </summary>
        private BaseBidFileOrgWebServiceClient wsAgent = null;

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public GpBidFileOrgService()
        {
            this.wsAgent = new BaseBidFileOrgWebServiceClient();
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="gpBidFileOrg">gpBidFileOrg</param>
        /// <returns>bool</returns>
        public bool Add(gpBidFileOrgWebDO gpBidFileOrg)
        {
            if (gpBidFileOrg == null)
            {
                throw new ArgumentNullException(nameof(gpBidFileOrg));
            }

            return this.wsAgent.save(gpBidFileOrg).success;
        }

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="bbfoId">bbfoId</param>
        /// <returns>bool</returns>
        public bool Remove(string bbfoId)
        {
            if (string.IsNullOrEmpty(bbfoId))
            {
                throw new ArgumentNullException(nameof(bbfoId));
            }

            return this.wsAgent.remove(bbfoId).success;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="gpBidFileOrg">gpBidFileOrg</param>
        /// <returns>bool</returns>
        public bool Update(gpBidFileOrgWebDO gpBidFileOrg)
        {
            if (gpBidFileOrg == null)
            {
                throw new ArgumentNullException(nameof(gpBidFileOrg));
            }

            return this.wsAgent.edit(gpBidFileOrg).success;
        }

        /// <summary>
        /// FindById
        /// </summary>
        /// <param name="bbfoId">bbfoId</param>
        /// <returns>gpBidFileOrgWebDO</returns>
        public gpBidFileOrgWebDO FindById(string bbfoId)
        {
            if (string.IsNullOrWhiteSpace(bbfoId))
            {
                throw new ArgumentNullException(nameof(bbfoId));
            }

            return this.wsAgent.getById(bbfoId).obj as gpBidFileOrgWebDO;
        }

        /// <summary>
        /// FindListByProjectIdAndSectionId
        /// </summary>
        /// <param name="sectionId">projectId</param>
        /// <param name="sectionId">sectionId</param>
        /// <returns>gpBidFileOrgWebDO[]</returns>
        public gpBidFileOrgWebDO[] FindListByProjectIdAndSectionId(string projectId, string sectionId)
        {
            resultDO result = this.wsAgent.findAll(projectId, sectionId);

            return ((object[])result.objList).Cast<gpBidFileOrgWebDO>().ToArray();
        }

        #endregion
    }
}
