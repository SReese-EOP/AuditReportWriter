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
        private userInfo user;

        public frmMattermostChatsAudits()
        {
            InitializeComponent();
        }

        private void dtAuditDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboOverallAuditResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOverallAuditResult.SelectedItem != null && cboOverallAuditResult.SelectedItem.ToString() == "FAIL")
            {
                //enable the groups for the audit reults
                grpCreatedTime.Enabled = true;
                grpUpdateTime.Enabled = true;
                grpMessageText.Enabled = true;
                grpAttachments.Enabled = true;
                grpEmail.Enabled = true;
                grpUserName.Enabled = true;
                //set the groups to blank for data entry
                cboCreatedTimeResult.SelectedItem = null;
                cboUpdatedTimeResult.SelectedItem = null;
                cboMessageTextAuditResult.SelectedItem = null;
                cboEmailAuditResult.SelectedItem = null;
                cboUsernameResult.SelectedItem = null;
                cboAttachmentsResult.SelectedItem = null;

            }
            else
            {
                //disable all the groups since the audit results are passing
                grpCreatedTime.Enabled = false;
                grpUpdateTime.Enabled = false;
                grpMessageText.Enabled = false;
                grpAttachments.Enabled = false;
                grpEmail.Enabled = false;
                grpUserName.Enabled = false;

                //mark all of the audit results as passing
                cboCreatedTimeResult.SelectedItem = "PASS";
                cboUpdatedTimeResult.SelectedItem = "PASS";
                cboMessageTextAuditResult.SelectedItem = "PASS";
                cboEmailAuditResult.SelectedItem = "PASS";
                cboUsernameResult.SelectedItem = "PASS";
                cboAttachmentsResult.SelectedItem = "PASS";
            }
        }

        private void bttnReturntoNav_Click(object sender, EventArgs e)
        {
            frmAuditNavigator frmAuditNavigator = new frmAuditNavigator(user);
            frmAuditNavigator.Show();
            this.Hide();
        }
    }
}
