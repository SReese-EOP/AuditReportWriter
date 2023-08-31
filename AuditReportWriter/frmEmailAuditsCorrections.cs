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

        private void bttnGo_Click(object sender, EventArgs e)
        {
            if
               (txtMessageID.Text != null &&
               txtOBSObject.Text != null &&
               txtJournaledMailbox.Text != null &&
               txtJounalEmailId.Text != null &&
               cboOverallAuditResult.SelectedItem != null &&
               cboReceivedTimeResult.SelectedItem != null &&
               cbobccAuditResult.SelectedItem != null &&
               cboSenderResult.SelectedItem != null &&
               cboSubjectValueResult.SelectedItem != null &&
               cboToAuditResult.SelectedItem != null &&
               cboBodyValueResult.SelectedItem != null &&
               cboCCAuditResult.SelectedItem != null &&
               cboAttachementAuditResult.SelectedItem != null)
            {
                //init a new email audit report object
                EmailAuditReport emailAuditReport = new EmailAuditReport();

                //init a new controller to write the audit report
                AuditReportController auditReportController = new AuditReportController();

                //add the audit report data
                emailAuditReport.AuditDateTime = dtAuditDateTime.Value;
                emailAuditReport.Mailbox = txtJournaledMailbox.Text;
                emailAuditReport.MessageBody = cboBodyValueResult.SelectedItem.ToString();
                emailAuditReport.MessageBodyValueExchange = txtBodyExchangeResult.Text;
                emailAuditReport.MessageBodyValueOBS = txtBodyOBSResult.Text;
                emailAuditReport.MessageSubject = cboSubjectValueResult.SelectedItem.ToString();
                emailAuditReport.MessageSubjectValueExchange = txtSubjectExchangeResult.Text;
                emailAuditReport.MessageSubjectValueOBS = txtSubjectOBSResult.Text;
                emailAuditReport.MessageTo = cboToAuditResult.SelectedItem.ToString();
                emailAuditReport.MessageTOValueExchange = txtExchToResult.Text;
                emailAuditReport.MessageTOValueOBS = txtOBSToResult.Text;
                emailAuditReport.MessageSender = cboSenderResult.SelectedItem.ToString();
                emailAuditReport.MessageSenderValueExchange = txtExchSenderResult.Text;
                emailAuditReport.MessageSenderValueOBS = txtOBSSenderResult.Text;
                emailAuditReport.MessageReceivedTime = cboReceivedTimeResult.SelectedItem.ToString();
                emailAuditReport.MessageReceivedTimeValueExchange = dtExchMessageRecievedTime.Value;
                emailAuditReport.MessageReceivedTimeValueOBS = dtOBSMessageReceivedTime.Value;
                emailAuditReport.MessageCC = cboCCAuditResult.SelectedItem.ToString();
                emailAuditReport.MessageCCValueExchange = txtCCExchResult.Text;
                emailAuditReport.MessageCCValueOBS = txtCCobsresult.Text;
                emailAuditReport.MessageBCC = cbobccAuditResult.SelectedItem.ToString();
                emailAuditReport.MessageBCCValueExchange = txtbccExchangeResult.Text;
                emailAuditReport.MessageBCCValueOBS = txtbccOBSResult.Text;
                emailAuditReport.MessageAttachments = cboAttachementAuditResult.SelectedItem.ToString();
                emailAuditReport.MessageAttachmentsValueExchange = txtAttachmentExchangeResult.Text;
                emailAuditReport.MessageAttachmentsValueOBS = txtAttachmentOBSResult.Text;
                emailAuditReport.MessageId = txtMessageID.Text;
                emailAuditReport.JournalEmailId = txtJounalEmailId.Text;
                emailAuditReport.MessageAuditResult = cboOverallAuditResult.SelectedItem.ToString();
                emailAuditReport.ObsObject = txtOBSObject.Text;
                emailAuditReport.Auditor = WindowsIdentity.GetCurrent().Name;

                //execute the audit report write
                auditReportController.WriteEmailAuditReport(emailAuditReport, emailUser.Server, emailUser.Database, emailUser.UserName, emailUser.Password);
                MessageBox.Show("Email audit was successfully submitted under Audit ID: " + emailAuditReport.AuditId);
                DialogResult result = MessageBox.Show("Do you want to enter another audit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    txtMessageID.Text = null;
                    txtOBSObject.Text = null;
                    txtJournaledMailbox.Text = null;
                    txtJounalEmailId.Text = null;
                    cboOverallAuditResult.Text = null;
                    cboReceivedTimeResult.Text = null;
                    cbobccAuditResult.Text = null;
                    txtbccExchangeResult.Text = null;
                    txtbccOBSResult.Text = null;
                    cboSenderResult.Text = null;
                    txtExchSenderResult.Text = null;
                    txtOBSSenderResult.Text = null;
                    cboSubjectValueResult.Text = null;
                    txtSubjectExchangeResult.Text = null;
                    txtSubjectOBSResult.Text = null;
                    cboToAuditResult.Text = null;
                    txtExchToResult.Text = null;
                    txtOBSToResult.Text = null;
                    cboBodyValueResult.Text = null;
                    txtBodyExchangeResult.Text = null;
                    txtBodyOBSResult.Text = null;
                    cboCCAuditResult.Text = null;
                    txtCCExchResult.Text = null;
                    cboAttachementAuditResult.Text = null;
                    txtAttachmentExchangeResult.Text = null;
                    txtAttachmentOBSResult.Text = null;
                    txtMessageID.Focus();
                }
                else
                {
                    frmAuditNavigator frmAuditNavigator = new frmAuditNavigator(emailUser);
                    frmAuditNavigator.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("The Audit form is not filled out properly");
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
    }
}
