using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static AuditReportWriter.AuditReportController;

namespace AuditReportWriter
{
    public partial class frmEmailAuditsCorrections : Form
    {
        private userInfo emailUser;
        private userInfo user;

        public frmEmailAuditsCorrections(userInfo navuser)
        {
            InitializeComponent();
            emailUser = navuser;
        }
        private void lblMessageToResult_Click(object sender, EventArgs e)
        {

        }

        private void cboSenderResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSenderResult.SelectedItem != null && cboSenderResult.SelectedItem.ToString() == "FAIL")
            {
                txtExchSenderResult.Enabled = true;
                txtOBSSenderResult.Enabled = true;
            }
            else
            {
                txtExchSenderResult.Enabled = false;
                txtOBSSenderResult.Enabled = false;
            }

        }

        private void grpSenderResults_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cboReceivedTimeResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboReceivedTimeResult.SelectedItem != null && cboReceivedTimeResult.SelectedItem.ToString() == "FAIL")
            {
                dtExchMessageRecievedTime.Enabled = true;
                dtOBSMessageReceivedTime.Enabled = true;
            }
            else
            {
                dtExchMessageRecievedTime.Enabled = false;
                dtOBSMessageReceivedTime.Enabled = false;
            }
        }

        private void cboOverallAuditResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOverallAuditResult.SelectedItem != null && cboOverallAuditResult.SelectedItem.ToString() == "FAIL")
            {
                //enable the groups for the audit reults
                grpSenderResults.Enabled = true;
                grpReceivedTImeResults.Enabled = true;
                grpTOResults.Enabled = true;
                grpCCresults.Enabled = true;
                grpBCCResults.Enabled = true;
                grpSubjectResults.Enabled = true;
                grpBodyResults.Enabled = true;
                grpAttachementResult.Enabled = true;
                //set the groups to blank for data entry
                cboReceivedTimeResult.SelectedItem = null;
                cboSenderResult.SelectedItem = null;
                cboToAuditResult.SelectedItem = null;
                cboCCAuditResult.SelectedItem = null;
                cbobccAuditResult.SelectedItem = null;
                cboSubjectValueResult.SelectedItem = null;
                cboBodyValueResult.SelectedItem = null;
                cboAttachementAuditResult.SelectedItem = null;

            }
            else
            {
                //disable all the groups since the audit results are passing
                grpSenderResults.Enabled = false;
                grpReceivedTImeResults.Enabled = false;
                grpTOResults.Enabled = false;
                grpCCresults.Enabled = false;
                grpBCCResults.Enabled = false;
                grpSubjectResults.Enabled = false;
                grpBodyResults.Enabled = false;
                grpAttachementResult.Enabled = false;

                //mark all of the audit results as passing
                cboReceivedTimeResult.SelectedItem = "PASS";
                cboSenderResult.SelectedItem = "PASS";
                cboToAuditResult.SelectedItem = "PASS";
                cboCCAuditResult.SelectedItem = "PASS";
                cbobccAuditResult.SelectedItem = "PASS";
                cboSubjectValueResult.SelectedItem = "PASS";
                cboBodyValueResult.SelectedItem = "PASS";
                cboAttachementAuditResult.SelectedItem = "PASS";
            }
        }

        private void cboToAuditResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboToAuditResult.SelectedItem != null && cboToAuditResult.SelectedItem.ToString() == "FAIL")
            {
                txtExchToResult.Enabled = true;
                txtOBSToResult.Enabled = true;
            }
            else
            {
                txtExchToResult.Enabled = false;
                txtOBSToResult.Enabled = false;
            }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {

        }

        private void bttnReplace_Click(object sender, EventArgs e)
        {

        }

        private void bttnReset_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bttnGo_Click(EmailAuditReport emailAuditReport, AuditReportController auditReportController)
        {
            if (txtEnterAuditID.Text != "")
            {
                // execute the audit reader?
                int auditID = Convert.ToInt32(txtEnterAuditID.Text);
                emailAuditReport = auditReportController.GetEmailAuditByID(auditID, emailUser.Server, emailUser.Database, emailUser.UserName, emailUser.Password);
                txtMessageID.Text = emailAuditReport.MessageId;
                txtOBSObject.Text = emailAuditReport.ObsObject;
                txtJournaledMailbox.Text = emailAuditReport.Mailbox;
                txtJounalEmailId.Text = emailAuditReport.JournalEmailId;

                txtMessageID.Text = emailAuditReport.MessageId;
                cboOverallAuditResult.DataSource = emailAuditReport.AuditResults;

                cboReceivedTimeResult.DataSource = emailAuditReport.MessageReceivedTime;
                dtExchMessageRecievedTime.Value = emailAuditReport.MessageReceivedTimeValueExchange;
                dtOBSMessageReceivedTime.Value = emailAuditReport.MessageReceivedTimeValueOBS;


                cboSenderResult.DataSource = emailAuditReport.MessageSender;
                txtExchSenderResult.Text = emailAuditReport.MessageSenderValueExchange;
                txtOBSSenderResult.Text = emailAuditReport.MessageSenderValueOBS;

                cboToAuditResult.DataSource = emailAuditReport.MessageTo;
                txtExchToResult.Text = emailAuditReport.MessageTOValueExchange;
                txtOBSSenderResult.Text = emailAuditReport.MessageTOValueOBS;

                cboCCAuditResult.DataSource = emailAuditReport.MessageCC;
                txtCCExchResult.Text = emailAuditReport.MessageCCValueExchange;
                txtCCobsresult.Text = emailAuditReport.MessageCCValueOBS;

                cbobccAuditResult.DataSource = emailAuditReport.MessageBCC;
                txtbccExchangeResult.Text = emailAuditReport.MessageBCCValueExchange;
                txtbccOBSResult.Text = emailAuditReport.MessageBCCValueOBS;

                cboSubjectValueResult.DataSource = emailAuditReport.MessageSubject;
                txtSubjectExchangeResult.Text = emailAuditReport.MessageSubjectValueExchange;
                txtSubjectOBSResult.Text = emailAuditReport.MessageSubjectValueOBS;

                cboBodyValueResult.DataSource = emailAuditReport.MessageBody;
                txtBodyExchangeResult.Text = emailAuditReport.MessageBodyValueExchange;
                txtBodyOBSResult.Text = emailAuditReport.MessageBodyValueOBS;


                cboAttachementAuditResult.DataSource = emailAuditReport.MessageAttachments;
                txtAttachmentExchangeResult.Text = emailAuditReport.MessageAttachmentsValueExchange;
                txtAttachmentOBSResult.Text = emailAuditReport.MessageAttachmentsValueOBS;
            }
        }

        private void bttnGo_Click(object sender, EventArgs e)
        {
            if (txtEnterAuditID.Text != "")
            {
                EmailAuditReport emailAuditReport = new EmailAuditReport();
                AuditReportController AuditReportController = new AuditReportController();
                //execute the audit reader?
                int auditID = Convert.ToInt32(txtEnterAuditID.Text);
                emailAuditReport = AuditReportController.GetEmailAuditByID(auditID, emailUser.Server, emailUser.Database, emailUser.UserName, emailUser.Password);

                txtMessageID.Text = emailAuditReport.MessageId;
                txtOBSObject.Text = emailAuditReport.ObsObject;
                txtJournaledMailbox.Text = emailAuditReport.Mailbox;
                cboOverallAuditResult.Text = emailAuditReport.AuditResults;
                txtJounalEmailId.Text = emailAuditReport.JournalEmailId;

                cboReceivedTimeResult.Text = emailAuditReport.MessageReceivedTime;

                cboSenderResult.Text = emailAuditReport.MessageSender;
                txtExchSenderResult.Text = emailAuditReport.MessageSenderValueExchange;
                txtOBSSenderResult.Text = emailAuditReport.MessageSenderValueOBS;

                cboToAuditResult.Text = emailAuditReport.MessageTo;
                txtExchToResult.Text = emailAuditReport.MessageTOValueExchange;
                txtOBSSenderResult.Text = emailAuditReport.MessageTOValueOBS;

                cboCCAuditResult.Text = emailAuditReport.MessageCC;
                txtCCExchResult.Text = emailAuditReport.MessageCCValueExchange;
                txtCCobsresult.Text = emailAuditReport.MessageCCValueOBS;

                cbobccAuditResult.Text = emailAuditReport.MessageBCC;
                txtbccExchangeResult.Text = emailAuditReport.MessageBCCValueExchange;
                txtbccOBSResult.Text = emailAuditReport.MessageBCCValueOBS;

                cboSubjectValueResult.Text = emailAuditReport.MessageSubject;
                txtSubjectExchangeResult.Text = emailAuditReport.MessageSubjectValueExchange;
                txtSubjectOBSResult.Text = emailAuditReport.MessageSubjectValueOBS;

                cboBodyValueResult.Text = emailAuditReport.MessageBody;
                txtBodyExchangeResult.Text = emailAuditReport.MessageBodyValueExchange;
                txtBodyOBSResult.Text = emailAuditReport.MessageBodyValueOBS;

                cboAttachementAuditResult.Text = emailAuditReport.MessageAttachments;
                txtAttachmentExchangeResult.Text = emailAuditReport.MessageAttachmentsValueExchange;
                txtAttachmentOBSResult.Text = emailAuditReport.MessageAttachmentsValueOBS;

            }
            else
            {
                MessageBox.Show("Please enter a valid Audit ID.");
            }

        }

        private void dtAuditDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboCCAuditResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCCAuditResult.SelectedItem != null && cboCCAuditResult.SelectedItem.ToString() == "FAIL")
            {
                txtCCExchResult.Enabled = true;
                txtCCobsresult.Enabled = true;
            }
            else
            {
                txtCCExchResult.Text = null;
                txtCCobsresult.Text = null;
                txtCCExchResult.Enabled = false;
                txtCCobsresult.Enabled = false;
            }
        }

        private void frmEmailAuditReport_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblbccOBSResult_Click(object sender, EventArgs e)
        {

        }

        private void grpCCresults_Enter(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void grpMessageReceivedTIme_Enter(object sender, EventArgs e)
        {

        }

        private void cbobccAuditResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void txtExchSenderResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnReturntoNav_Click(object sender, EventArgs e)
        {
            frmAuditNavigator frmAuditNavigator = new frmAuditNavigator(emailUser);
            frmAuditNavigator.Show();
            this.Close();
        }

        private void lblEnterAuditID_Click(object sender, EventArgs e)
        {

        }

        private void txtEnterAuditID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMessageID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMessageID_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboOverallAuditResult_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }
    }
}
