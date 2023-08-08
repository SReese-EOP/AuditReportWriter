using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Windows.Forms;

namespace AuditReportWriter
{
    public partial class frmEmailAuditReport : Form
    {
        private userInfo emailUser;

        public frmEmailAuditReport(userInfo navuser)
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //init a new email audit report object
            EmailAuditReport emailAuditReport = new EmailAuditReport();

            //init a new controller to write the audit report
            AuditReportController auditReportController = new AuditReportController();

            //add the audit report data
            emailAuditReport.AuditDateTime = dtAuditDateTime.Value;
            emailAuditReport.Mailbox = txtJournaledMailbox.Text;
            emailAuditReport.MessageBody = cboBodyValueResult.SelectedItem.ToString();
            emailAuditReport.MessageSubject = cboSubjectValueResult.SelectedItem.ToString();
            emailAuditReport.MessageTo = cboToAuditResult.SelectedItem.ToString();
            emailAuditReport.MessageSender = cboSenderResult.SelectedItem.ToString();
            emailAuditReport.MessageReceivedTime = cboReceivedTimeResult.SelectedItem.ToString();
            emailAuditReport.MessageReceivedTimeValueExchange = dtExchMessageRecievedTime.Value;
            emailAuditReport.MessageReceivedTimeValueOBS = dtOBSMessageReceivedTime.Value;
            emailAuditReport.MessageCC = cboCCAuditResult.SelectedItem.ToString();
            emailAuditReport.MessageBCC = cbobccAuditResult.SelectedItem.ToString();
            emailAuditReport.MessageAttachments = cboAttachementAuditResult.SelectedItem.ToString();
            emailAuditReport.MessageId = txtMessageID.Text;
            emailAuditReport.JournalEmailId = txtJounalEmailId.Text;
            emailAuditReport.MessageAuditResult = cboOverallAuditResult.SelectedItem.ToString();
            emailAuditReport.ObsObject = txtOBSObject.Text;

            //execute the audit report write
            auditReportController.WriteEmailAuditReport(emailAuditReport, emailUser.Server, emailUser.Database, emailUser.UserName, emailUser.Password);
            MessageBox.Show("Email audit was successfully submitted under Audit ID: " + emailAuditReport.AuditId);
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

        private void bttnReturnNav_Click(object sender, EventArgs e)
        {
            frmAuditNavigator frmAuditNavigator = new frmAuditNavigator(emailUser);
            frmAuditNavigator.Show();
            this.Hide();
        }

        private void cboSubjectValueResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSubjectValueResult.SelectedItem != null && cboSubjectValueResult.SelectedItem == "FAIL")
            {
                txtSubjectExchangeResult.Enabled = true;
                txtSubjectOBSResult.Enabled = true;
            }
            else
            {
                txtSubjectExchangeResult.Enabled = false;
                txtSubjectOBSResult.Enabled = false;

            }
        }

        private void cbobccAuditResult_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbobccAuditResult.SelectedItem != null && cbobccAuditResult.SelectedItem == "FAIL")
            {
                txtbccExchangeResult.Enabled = true;
                txtbccOBSResult.Enabled = true;
            }
            else
            {
                txtbccExchangeResult.Enabled = false;
                txtbccOBSResult.Enabled = false;
            }
        }

        private void cboBodyValueResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBodyValueResult.SelectedItem != null && cboBodyValueResult.SelectedItem == "FAIL")
            {
                txtBodyExchangeResult.Enabled = true;
                txtBodyOBSResult.Enabled = true;
            }
            else
            {
                txtBodyExchangeResult.Enabled = false;
                txtBodyOBSResult.Enabled = false;
            }
        }

        private void cboAttachementAuditResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAttachementAuditResult.SelectedItem != null && cboAttachementAuditResult.SelectedItem == "FAIL")
            {
                txtAttachmentExchangeResult.Enabled = true;
                txtAttachmentOBSResult.Enabled = true;
            }
            else
            {
                txtAttachmentExchangeResult.Enabled = false;
                txtAttachmentOBSResult.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMessageID.Text = null;
        }

        private void txtMessageID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}