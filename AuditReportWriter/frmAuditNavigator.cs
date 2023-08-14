using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace AuditReportWriter
{
    public partial class frmAuditNavigator : Form
    {
        private userInfo navUser;

        public frmAuditNavigator(userInfo user)
        {
            InitializeComponent();
            navUser = user;
            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[AuditOverview]";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cboSourceApplication.ValueMember = "AuditSource";
            cboSourceApplication.DisplayMember = "AuditSource";
            cboSourceApplication.DataSource = dt;
            cboTypeofAudit.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAuditNavigator_Load(object sender, EventArgs e)
        {

        }

        private void bttnEmailAudit_Click_1(object sender, EventArgs e)
        {
            frmEmailAuditReport frmEmailAuditReport = new frmEmailAuditReport(navUser);
            frmEmailAuditReport.Show();
            this.Hide();
        }

        private void bttnChatAudit_Click(object sender, EventArgs e)
        {
            frmMattermostChatsAudits frmMattermostChatsAudits = new frmMattermostChatsAudits();
            frmMattermostChatsAudits.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cboSourceApplication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSourceApplication.SelectedValue.ToString() != null)
            {
                string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "select * from [dbo].[AuditOverview] where AuditSource = @AuditSource";
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                sqlconn.Open();
                sqlcomm.Parameters.AddWithValue("@AuditSource", cboSourceApplication.SelectedValue.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cboTypeofAudit.ValueMember = "Audits";
                cboTypeofAudit.DisplayMember = "Audits";
                cboTypeofAudit.DataSource = dt;
                cboTypeofAudit.Enabled = true;
            }
        }
    }
}
