using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XTXAppCOMLib;

namespace Summer.CompetitiveTender.Utility
{
    public class MonitorXTX
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(MonitorXTX));

        /// <summary>
        /// instance
        /// </summary>
        private static MonitorXTX instance = new MonitorXTX();

        /// <summary>
        /// xtx
        /// </summary>
        private XTXAppClass xtx = new XTXAppClass();

        #endregion

        #region 属性

        /// <summary>
        /// XTX
        /// </summary>
        public XTXAppClass XTX { get { return this.xtx; } }

        #endregion

        #region 方法

        /// <summary>
        /// 
        /// </summary>
        private MonitorXTX()
        {
            this.xtx.OnUsbkeyInsert += Xtx_OnUsbkeyInsert;
            this.xtx.OnUsbkeyRemove += Xtx_OnUsbkeyRemove;

            bool b = this.xtx.CheckSoftDeviceEnv();
        }

        /// <summary>
        /// UsbkeyInsert
        /// </summary>
        private void Xtx_OnUsbkeyInsert()
        {
            log.Info("UsbkeyInsert");
        }

        /// <summary>
        /// UsbkeyRemove
        /// </summary>
        private void Xtx_OnUsbkeyRemove()
        {
            log.Info("UsbkeyRemove");
        }

        /// <summary>
        /// GetInstance
        /// </summary>
        /// <returns>MonitorXTX</returns>
        public static MonitorXTX GetInstance()
        {
            return instance;
        }

        public string[] GetCertID()
        {
            List<string> result = new List<string>();

            string strUserList = MonitorXTX.GetInstance().XTX.SOF_GetUserList();

            if (!string.IsNullOrWhiteSpace(strUserList))
            {
                string[] userList = strUserList.Split(new string[] { "&&&" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in userList)
                {
                    result.Add(userList[0].Split(new string[] { "||" }, StringSplitOptions.RemoveEmptyEntries)[1]);
                }
            }

            return result.ToArray();
        }

        #endregion
    }
}
