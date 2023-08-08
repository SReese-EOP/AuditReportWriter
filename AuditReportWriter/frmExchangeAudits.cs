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
    public partial class frmExchangeAudits : Form
    {
        private userInfo exchUser;
        public frmExchangeAudits(userInfo navuser)
        {
            InitializeComponent();
            exchUser = navuser;
            
        }

        private void bttnEmail_Click(object sender, EventArgs e)
        {
            frmEmailAuditReport frmEmailAuditReport = new frmEmailAuditReport(exchUser);
            frmEmailAuditReport.Show();
            this.Hide();
        }

        private void frmExchangeAudits_Load(object sender, EventArgs e)
        {

        }
    }
}
