using Summer.CompetitiveTender.Service.ServiceReferenceGpApplyDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Service
{
    public interface IGpApplyDetailService
    {
        /// <summary>
        /// FindApplyFileBySectionId
        /// </summary>
        /// <param name="sectionId">sectionId</param>
        /// <returns>gpApplyDetailWebDO[]</returns>
        gpApplyDetailWebDO[] FindApplyFileBySectionId(string sectionId);
    }
}
