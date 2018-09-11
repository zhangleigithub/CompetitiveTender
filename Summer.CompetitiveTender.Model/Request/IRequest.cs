using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Model.Request
{
    /// <summary>
    /// IRequest
    /// </summary>
    public interface IRequest
    {
        /// <summary>
        /// ToArgs
        /// </summary>
        /// <returns>object[]</returns>
        object[] ToArgs();
    }
}
