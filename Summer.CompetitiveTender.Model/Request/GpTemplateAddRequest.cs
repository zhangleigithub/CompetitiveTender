using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Model.Request
{
    public class GpTemplateAddRequest : IRequest
    {
        #region 属性

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// Group
        /// </summary>
        public int Group { get; set; }

        /// <summary>
        /// Remark
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// AdtId
        /// </summary>
        public string AdtId { get; set; }

        /// <summary>
        /// AdtCoId
        /// </summary>
        public string AdtCoId { get; set; }

        /// <summary>
        /// AdtTime
        /// </summary>
        public DateTime AdtTime { get; set; }

        #endregion

        #region 方法

        /// <summary>
        /// ToArgs
        /// </summary>
        /// <returns>object[]</returns>
        public object[] ToArgs()
        {
            object[] args = new object[10];

            args[0] = this.Name;
            args[1] = this.Type;
            args[3] = this.Group;
            args[5] = this.Remark;
            args[6] = this.AdtId;
            args[7] = this.AdtCoId;
            args[8] = this.AdtTime;

            return args;
        }

        #endregion
    }
}
