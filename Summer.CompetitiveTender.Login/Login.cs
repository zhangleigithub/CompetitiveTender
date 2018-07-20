using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Summer.CompetitiveTender.Login
{
    public partial class Login : Form
    {
        public UserType UserType
        {
            get
            {
                if (rbInviteTender.Checked)
                {
                    return UserType.InviteTender;
                }
                else if (rbTender.Checked)
                {
                    return UserType.Tender;
                }
                else if (rbExpert.Checked)
                {
                    return UserType.Expert;
                }
                else
                {
                    return UserType.Unkown;
                }
            }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
