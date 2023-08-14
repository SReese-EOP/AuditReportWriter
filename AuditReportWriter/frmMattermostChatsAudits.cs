using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmMattermostChatsAudits : Form
    {
        public userInfo user;

        public frmMattermostChatsAudits()
        {
            InitializeComponent();
            
        }

        private void dtAuditDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bttnReturntoNav_Click(object sender, EventArgs e)
        {
            frmAuditNavigator frmAuditNavigator = new frmAuditNavigator(user);
            frmAuditNavigator.Show();
            this.Close();
        }

        private void bttnReset_Click(object sender, EventArgs e)
        {
            frmMattermostChatsAudits frmMattermostChatsAudits = new frmMattermostChatsAudits();
            frmMattermostChatsAudits.Show();
            frmMattermostChatsAudits.Close();
        }

        private void bttnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
