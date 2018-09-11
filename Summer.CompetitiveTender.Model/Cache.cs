using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Model
{
    /// <summary>
    /// Cache
    /// </summary>
    public class Cache
    {
        #region 字段

        /// <summary>
        /// cacheValues
        /// </summary>
        private IDictionary<string, object> cacheValues = new Dictionary<string, object>();

        /// <summary>
        /// instance
        /// </summary>
        private static Cache instance = new Cache();

        #endregion

        #region 方法

        private Cache()
        {
        }

        /// <summary>
        /// GetInstance
        /// </summary>
        /// <returns>Cache</returns>
        public static Cache GetInstance()
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
            this.cacheValues[key] = value;
        }

        /// <summary>
        /// GetValue
        /// </summary>
        /// <typeparam name="T">T</typeparam>
        /// <param name="key">key</param>
        /// <returns>T</returns>
        public T GetValue<T>(string key)
        {
            return (T)this.cacheValues[key];
        }

        #endregion
    }
}
