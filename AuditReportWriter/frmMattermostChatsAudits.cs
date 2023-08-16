﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AuditReportWriter.AuditReportController;
using static AuditReportWriter.Utilities;

namespace AuditReportWriter
{
    public partial class frmMattermostChatsAudits : Form
    {
        public userInfo user;

        public frmMattermostChatsAudits(userInfo navuser)
        {
            InitializeComponent();
            user = navuser;

        }
        /*       private void dtAuditDateTime_ValueChanged(object sender, EventArgs e) 
               {

               }*/

        private void bttnReturntoNav_Click(object sender, EventArgs e)
        {
            frmAuditNavigator frmAuditNavigator = new frmAuditNavigator(user);
            frmAuditNavigator.Show();
            this.Close();
        }

        private void bttnReset_Click(object sender, EventArgs e)
        {
            //ResetAllControls(this);
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void bttnSubmit_Click(object sender, EventArgs e)
        {
            //init a new email audit report object
            MMAuditReport mmAuditReport = new MMAuditReport();

            //init a new controller to write the audit report
            MMAuditReportController MMauditReportController = new MMAuditReportController();

            //add the audit report data
            mmAuditReport.AuditDateTime = dtAuditDateTime.Value;
            mmAuditReport.ChannelID = txtChannelID.Text;
            mmAuditReport.PostID = txtMessageID.Text;
            mmAuditReport.CreateTime = cboCreatedTimeResult.SelectedItem.ToString();
            mmAuditReport.CreateTimeValueMM = dtMMCreatedTime.Value;
            mmAuditReport.CreateTimeValueOBS = dtOBSCreatedTime.Value;
            mmAuditReport.UpdateTime = cboUpdatedTimeResult.SelectedItem.ToString();
            mmAuditReport.UpdateTimeValueMM = dtMMUpdatedTime.Value;
            mmAuditReport.UpdateTimeValueOBS = dtOBSUpdatedTime.Value;
            mmAuditReport.MessageText = cboMessageTextAuditResult.SelectedItem.ToString();
            mmAuditReport.MessageTextValueMM = txtMMMessageTextResult.Text;
            mmAuditReport.MessageTextValueOBS = txtOBSMessageTextResult.Text;
            mmAuditReport.Attachments = cboAttachmentsResult.SelectedItem.ToString();
            mmAuditReport.AttachmentsValueMM = txtMMAttachmentsResult.Text;
            mmAuditReport.AttachmentsValueOBS = txtOBSAttachmentsResult.Text;
            mmAuditReport.Email = cboEmailAuditResult.SelectedItem.ToString();
            mmAuditReport.EmailValueMM = txtMMEmailResult.Text;
            mmAuditReport.EmailValueOBS = txtOBSEmailResult.Text;
            mmAuditReport.UserName = cboUsernameResult.SelectedItem.ToString();
            mmAuditReport.UserNameValueMM = txtMMUsernameResult.Text;
            mmAuditReport.UserNameValueOBS = txtOBSUsernameResult.Text;
            mmAuditReport.AuditResults = cboOverallAuditResult.SelectedItem.ToString();
            mmAuditReport.Auditor = WindowsIdentity.GetCurrent().Name;

            //execute the audit report write
            MMauditReportController.WriteMMAuditReport(mmAuditReport, user.Server, user.Database, user.UserName, user.Password);
            MessageBox.Show("Mattermost audit was successfully submitted under Audit ID: " + mmAuditReport.auditID);
            DialogResult result = MessageBox.Show("");

            if (result == DialogResult.Yes)
            {
                this.Controls.Clear();
                this.InitializeComponent();
                txtMessageID.Focus();
            }
            else
            {
                frmAuditNavigator frmAuditNavigator = new frmAuditNavigator(user);
                frmAuditNavigator.Show();
                this.Close();
            }
        }

        private void dtAuditDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboOverallAuditResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOverallAuditResult.SelectedItem != null && cboOverallAuditResult.SelectedItem.ToString() == "FAIL")
            {
                //enable the groups for the audit reults
                grpAttachments.Enabled = true;
                grpCreatedTime.Enabled = true;
                grpEmail.Enabled = true;
                grpMessageText.Enabled = true;
                grpUpdateTime.Enabled = true;
                grpUserName.Enabled = true;
                //set the groups to blank for data entry
                cboAttachmentsResult.SelectedItem = null;
                cboCreatedTimeResult.SelectedItem = null;
                cboEmailAuditResult.SelectedItem = null;
                cboMessageTextAuditResult.SelectedItem = null;
                cboUpdatedTimeResult.SelectedItem = null;
                cboUsernameResult.SelectedItem = null;

            }
            else
            {
                //disable all the groups since the audit results are passing
                grpAttachments.Enabled = false;
                grpCreatedTime.Enabled = false;
                grpEmail.Enabled = false;
                grpMessageText.Enabled = false;
                grpUpdateTime.Enabled = false;
                grpUserName.Enabled = false;

                //mark all of the audit results as passing
                cboUsernameResult.SelectedItem = "PASS";
                cboUpdatedTimeResult.SelectedItem = "PASS";
                cboMessageTextAuditResult.SelectedItem = "PASS";
                cboEmailAuditResult.SelectedItem = "PASS";
                cboCreatedTimeResult.SelectedItem = "PASS";
                cboAttachmentsResult.SelectedItem = "PASS";
            }
        }

        private void cboCreatedTimeResult_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboCreatedTimeResult.SelectedItem != null && cboCreatedTimeResult.SelectedItem.ToString() == "FAIL")
            {
                dtMMCreatedTime.Enabled = true;
                dtOBSCreatedTime.Enabled = true;
            }
            else
            {
                dtMMCreatedTime.Enabled = false;
                dtOBSCreatedTime.Enabled = false;
            }
        }

        private void cboUpdatedTimeResult_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboUpdatedTimeResult.SelectedItem != null && cboUpdatedTimeResult.SelectedItem.ToString() == "FAIL")
            {
                dtMMUpdatedTime.Enabled = true;
                dtOBSUpdatedTime.Enabled = true;
            }
            else
            {
                dtMMUpdatedTime.Enabled = false;
                dtOBSUpdatedTime.Enabled = false;
            }
        }

        private void cboMessageTextAuditResult_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboMessageTextAuditResult.SelectedItem != null && cboMessageTextAuditResult.SelectedItem.ToString() == "FAIL")
            {
                txtMMMessageTextResult.Enabled = true;
                txtOBSMessageTextResult.Enabled = true;
            }
            else
            {
                txtMMMessageTextResult.Enabled = false;
                txtOBSMessageTextResult.Enabled = false;
            }
        }

        private void cboAttachmentsResult_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboAttachmentsResult.SelectedItem != null && cboAttachmentsResult.SelectedItem.ToString() == "FAIL")
            {
                txtMMAttachmentsResult.Enabled = true;
                txtOBSAttachmentsResult.Enabled = true;
            }
            else
            {
                txtMMAttachmentsResult.Enabled = false;
                txtOBSAttachmentsResult.Enabled = false;
            }
        }

        private void cboEmailAuditResult_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboEmailAuditResult.SelectedItem != null && cboEmailAuditResult.SelectedItem.ToString() == "FAIL")
            {
                txtMMEmailResult.Enabled = true;
                txtOBSEmailResult.Enabled = true;
            }
            else
            {
                txtMMEmailResult.Enabled = false;
                txtOBSEmailResult.Enabled = false;
            }
        }

        private void cboUsernameResult_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboUsernameResult.SelectedItem != null && cboUsernameResult.SelectedItem.ToString() == "FAIL")
            {
                txtMMUsernameResult.Enabled = true;
                txtOBSUsernameResult.Enabled = true;
            }
            else
            {
                txtMMUsernameResult.Enabled = false;
                txtOBSUsernameResult.Enabled = false;
            }
        }

        private void dtOBSUpdatedTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
