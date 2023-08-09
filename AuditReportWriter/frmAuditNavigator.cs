﻿using System;
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
        private userInfo navUser;
      
        public frmAuditNavigator(userInfo user)
        {
            InitializeComponent();
            navUser = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void bttnEmailAudit_Click(object sender, EventArgs e)
        {

            frmExchangeAudits frmExchangeAudits = new frmExchangeAudits(navUser);
            frmExchangeAudits.Show();
            this.Hide();
            
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
            frmEmailAuditReport frmEmailAuditReport = new frmEmailAuditReport(navUser);
            frmEmailAuditReport.Show();
            this.Hide();
        }

        private void bttnChat_Click(object sender, EventArgs e)
        {
            frmMattermostChatAudit frmMattermostChatAudit = new frmMattermostChatAudit(navUser);
            frmMattermostChatAudit.Show();
            this.Hide();
        }

        private void frmAuditNavigator_Load(object sender, EventArgs e)
        {

        }
    }
}
