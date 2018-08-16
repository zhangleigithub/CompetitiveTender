﻿using Summer.CompetitiveTender.View.InviteTender;
using Summer.CompetitiveTender.View.Bid;
using Summer.CompetitiveTender.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Summer.CompetitiveTender.View.Agency;
using Summer.CompetitiveTender.View.Expert;

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
                    Application.Run(new MainForm());
                }
                else if (login.UserType == UserType.Agency)
                {
                    Application.Run(new AgencyManageForm());
                }
                else if (login.UserType == UserType.Tender)
                {
                    Application.Run(new BidManageForm());
                }
                else if (login.UserType == UserType.Expert)
                {
                    Application.Run(new ExpertManageForm());
                }
                else
                {
                    MessageBox.Show("用户类型未知！");
                }
            }
        }
    }
}
