using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

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
            List<string> result = new List<string>();

            foreach (var item in (XmlNode[])obj)
            {
                result.Add(Newtonsoft.Json.JsonConvert.SerializeXmlNode(item).Trim('{', '}'));
            }

            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>("{" + string.Join(",", result) + "}");
        }
    }
}
