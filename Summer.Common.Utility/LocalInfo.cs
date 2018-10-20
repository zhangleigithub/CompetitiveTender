using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.Common.Utility
{
    public class LocalInfo
    {
        /// <summary>
        /// 获取本机的MAC地址
        /// </summary>
        /// <returns>MacAddress</returns>
        public static string GetMacAddress()
        {
            using (System.Management.ManagementClass mc = new System.Management.ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                using (System.Management.ManagementObjectCollection moc = mc.GetInstances())
                {
                    string macAddress = string.Empty;

                    foreach (System.Management.ManagementBaseObject item in moc)
                    {
                        if ((bool)item["IpEnabled"])
                        {
                            macAddress = item["MacAddress"].ToString();
                            break;
                        }
                    }

                    return macAddress;
                }
            }
        }
    }
}
