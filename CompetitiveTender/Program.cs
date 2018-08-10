﻿using Summer.CompetitiveTender.View.InviteTender;
using Summer.CompetitiveTender.View.Bid;
using Summer.CompetitiveTender.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CompetitiveTender
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            log4net.Config.XmlConfigurator.ConfigureAndWatch(new System.IO.FileInfo("log4net.config"));
            
            Login login = new Login();

            if (login.ShowDialog() == DialogResult.OK)
            {
                if (login.UserType == UserType.InviteTender)
                {
                    Application.Run(new InviteTenderManageForm());
                }
                else if (login.UserType == UserType.Agency)
                {
                    MessageBox.Show("疯狂开发中...");
                }
                else if (login.UserType == UserType.Tender)
                {
                    Application.Run(new BidManageForm());
                }
                else if (login.UserType == UserType.Expert)
                {
                    MessageBox.Show("疯狂开发中...");
                }
                else
                {
                    MessageBox.Show("用户类型未知！");
                }
            }
        }
    }
}
