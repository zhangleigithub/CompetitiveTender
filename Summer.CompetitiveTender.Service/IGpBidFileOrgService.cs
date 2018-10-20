using Summer.CompetitiveTender.Service.ServiceReferenceGpBidFileOrg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Service
{
    /// <summary>
    /// 评分因素
    /// </summary>
    public interface IGpBidFileOrgService
    {
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="gpBidFileOrg">gpBidFileOrg</param>
        /// <returns>bool</returns>
        bool Add(gpBidFileOrgWebDO gpBidFileOrg);

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="bbfoId">bbfoId</param>
        /// <returns>bool</returns>
        bool Remove(string bbfoId);

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="gpBidFileOrg">gpBidFileOrg</param>
        /// <returns>bool</returns>
        bool Update(gpBidFileOrgWebDO gpBidFileOrg);

        /// <summary>
        /// FindById
        /// </summary>
        /// <param name="bbfoId">bbfoId</param>
        /// <returns>gpBidFileOrgWebDO</returns>
        gpBidFileOrgWebDO FindById(string bbfoId);

        /// <summary>
        /// FindListByProjectIdAndSectionId
        /// </summary>
        /// <param name="sectionId">projectId</param>
        /// <param name="sectionId">sectionId</param>
        /// <returns>gpBidFileOrgWebDO[]</returns>
        gpBidFileOrgWebDO[] FindListByProjectIdAndSectionId(string projectId, string sectionId);
    }
}
