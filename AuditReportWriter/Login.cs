using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AuditReportWriter
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void LoginPrompts_Enter(object sender, EventArgs e)
        {

        }

        private void LOGINBUTTON_Click(object sender, EventArgs e)
        {
            //if (USerName.Text == "sa" && Password.Text == "PENT@gon500!!!")
            //{
            //    new frmEmailAuditReport().Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("The User name or password is not correct. \n Try User name sa and Password PENT@gon500!!!");
            //    USerName.Clear();
            //    Password.Clear();
            //    USerName.Focus();
            //}

            //create the user object and assign the inputs from the logon page to the object
            userInfo user = new userInfo();
            user.UserName = USerName.Text;
            user.Password = Password.Text;
            user.Server = ServerName.Text;
            user.Database = DataBaseName.Text;

            //make a quick connection to the database to verify that the user is able to authenticate
            string connectionString = $"Server={user.Server};Database={user.Database};User Id={user.UserName};Password={user.Password};";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    connection.Close();

                    //After Successfully connecting pass the user over to the next form
                    
                    frmEmailAuditReport frmEmailAuditReport = new frmEmailAuditReport();
                    frmEmailAuditReport.Show();
                    this.Hide();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Connection failed. Error: {ex.Message}");
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
