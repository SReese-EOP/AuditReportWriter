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
    public partial class frmAuditNavigator : Form
    {
        public frmAuditNavigator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bttnEmail_Click(object sender, EventArgs e)
        {
            frmEmailAuditReport frmEmailAuditReport = new frmEmailAuditReport();
            frmEmailAuditReport.Show();
            this.Hide();
        }

        private void bttnChat_Click(object sender, EventArgs e)
        {
            frmMattermostChatAudit frmMattermostChatAudit = new frmMattermostChatAudit();
            frmMattermostChatAudit.Show();
            this.Hide();
        }
    }
}
