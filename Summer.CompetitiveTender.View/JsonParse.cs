using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.View
{
    public static class JsonParse
    {
        /// <summary>
        /// ToObject
        /// </summary>
        /// <typeparam name="T">T</typeparam>
        /// <param name="obj">this</param>
        /// <returns>T</returns>
        public static T ToObject<T>(this object obj)
        {
            if (obj==null)
            {
                return default(T);
            }

            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(obj.ToString());
        }
    }
}
