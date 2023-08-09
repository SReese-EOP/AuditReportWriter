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
    public partial class frmMattermostChatAudit : Form
    {
        private userInfo mattermostuser;

        public frmMattermostChatAudit(userInfo navUser)
        {
            InitializeComponent();
            mattermostuser = navUser;
        }

        private void bttnReturnNav_Click(object sender, EventArgs e)
        {


            frmAuditNavigator frmAuditNavigator = new frmAuditNavigator(mattermostuser);

            frmAuditNavigator.Show();
            this.Hide();
        }

        private void lblMattermostHome_Click(object sender, EventArgs e)
        {

        }
    }
}
