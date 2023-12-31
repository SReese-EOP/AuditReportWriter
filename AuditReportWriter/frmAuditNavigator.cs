﻿using System;
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
        }


        private void frmAuditNavigator_Load(object sender, EventArgs e)
        {

        }

        private void lblSelectAudit_Click(object sender, EventArgs e)
        {

        }

        private void cboSourceApplication_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboSourceApplication.SelectedItem.ToString() != null && cboSourceApplication.SelectedItem.ToString() == "Exchange")
            {
                cboTypeofAudit.Items.Clear();
                cboTypeofAudit.Text = string.Empty;
                cboTypeofAudit.Items.Add("Email Audit");
                cboTypeofAudit.Enabled = true;
                //cboTypeofAudit.Items.Add("Calendar Audit");
            }
            if (cboSourceApplication.SelectedItem.ToString() != null && cboSourceApplication.SelectedItem.ToString() == "Mattermost")
            {
                cboTypeofAudit.Items.Clear();
                cboTypeofAudit.Text = string.Empty;
                cboTypeofAudit.Items.Add("Chat Audit");
                cboTypeofAudit.Enabled = true;
                //cboTypeofAudit.Items.Add("Other Audit");
            }
        }

        private void cboTypeofAudit_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboTypeofAudit != null)
            {
                btnGo.Enabled = true;
                bttnChanges.Enabled = true;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //This button will take the user to the selected audit page to enter and submit a new audit
            if (cboTypeofAudit.SelectedItem.ToString() != null && cboTypeofAudit.SelectedItem.ToString() == "Chat Audit")
            {
                frmMattermostChatsAudits frmMattermostChatsAudits = new frmMattermostChatsAudits(navUser);
                frmMattermostChatsAudits.Show();
                this.Close();
            }
            else
            {
                //nothing
            }

            if (cboTypeofAudit.SelectedItem.ToString() != null && cboTypeofAudit.SelectedItem.ToString() == "Email Audit")
            {
                frmEmailAuditReport frmEmailAuditReport = new frmEmailAuditReport(navUser);
                frmEmailAuditReport.Show();
                this.Close();
            }
            else
            {
                //nothing
            }
        }

        private void bttnChanges_Click_1(object sender, EventArgs e)
        {
            //Depending on what audit was selected this button will take the user the the audit corrections page for that audit
           
            if (cboTypeofAudit.SelectedItem.ToString() != null && cboTypeofAudit.SelectedItem.ToString() == "Chat Audit")
            {
                frmMattermostChatCorrections frmMattermostChatCorrections = new frmMattermostChatCorrections(navUser);
                frmMattermostChatCorrections.Show();
                this.Close();
            }

            if (cboTypeofAudit.SelectedItem.ToString() != null && cboTypeofAudit.SelectedItem.ToString() == "Email Audit")
            {
                frmEmailAuditsCorrections frmEmailAuditsCorrections = new frmEmailAuditsCorrections(navUser);
                frmEmailAuditsCorrections.Show();
                this.Close();

            }
        }
    }
}
