using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuditReportWriter
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginPrompts_Enter(object sender, EventArgs e)
        {

        }

        private void LOGINBUTTON_Click(object sender, EventArgs e)
        {
            if (USerName.Text == "sa" && Password.Text == "PENT@gon500!!!")
            {
                new frmEmailAuditReport().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The User name or password is not correct. \n Try User name sa and Password PENT@gon500!!!");
                USerName.Clear();
                Password.Clear();
                USerName.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            USerName.Clear();
            Password.Clear();
            DataBaseName.Clear();
            ServerName.Clear();
            USerName.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ServerName_TextChanged(object sender, EventArgs e)
        {
            ServerName.Text = "74.235.100.158";
        }

        private void DataBaseName_TextChanged(object sender, EventArgs e)
        {
            DataBaseName.Text = "auditdemo";
        }
    }
}
