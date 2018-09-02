using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Model
{
    public class CacheData
    {
        #region 字段

        /// <summary>
        /// cacheDatas
        /// </summary>
        private IDictionary<string, object> cacheDatas = new Dictionary<string, object>();

        /// <summary>
        /// instance
        /// </summary>
        private static CacheData instance = new CacheData();

        #endregion

        #region 方法

        private CacheData()
        {
        }

        /// <summary>
        /// GetInstance
        /// </summary>
        /// <returns>CacheData</returns>
        public static CacheData GetInstance()
        {
            return instance;
        }

        /// <summary>
        /// SetValue
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        public void SetValue(string key,object value)
        {
            this.cacheDatas[key] = value;
        }

        public T GetValue<T>(string key)
        {
            return (T)this.cacheDatas[key];
        }

        #endregion
    }
}
