using Summer.CompetitiveTender.View.InviteTender;
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
                switch (login.UserType)
                {
                    case UserType.Unkown:
                        break;
                    case UserType.InviteTender:
                        Application.Run(new InviteTenderMainForm());
                        break;
                    case UserType.Agency:
                        Application.Run(new MainForm(login.UserType));
                        break;
                    case UserType.Tender:
                        Application.Run(new MainForm(login.UserType));
                        break;
                    case UserType.Expert:
                        Application.Run(new MainForm(login.UserType));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
