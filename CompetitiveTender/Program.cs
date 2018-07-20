using Summer.CompetitiveTender.InviteTender;
using Summer.CompetitiveTender.Login;
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

            Login login = new Login();

            if (login.ShowDialog() == DialogResult.OK)
            {
                if (login.UserType == UserType.InviteTender)
                {
                    Application.Run(new Summer.CompetitiveTender.InviteTender.MainForm());
                }
                else if (login.UserType == UserType.Tender)
                {
                    Application.Run(new Summer.CompetitiveTender.Tender.MainForm());
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
