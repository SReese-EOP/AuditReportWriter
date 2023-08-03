namespace AuditReportWriter
{
    public partial class frmEmailAuditReport : Form
    {
        public frmEmailAuditReport()
        {
            InitializeComponent();
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
                grpMessageReceivedTIme.Enabled = true;
                grpTOResults.Enabled = true;
                //set the groups to blank for data entry
                cboReceivedTimeResult.SelectedItem = null;
                cboSenderResult.SelectedItem = null;
                cboToAuditResult.SelectedItem = null;
            }
            else
            {
                //disable all the groups since the audit results are passing
                grpSenderResults.Enabled = false;
                grpMessageReceivedTIme.Enabled = false;
                grpTOResults.Enabled = false;

                //mark all of the audit results as passing
                cboReceivedTimeResult.SelectedItem = "PASS";
                cboSenderResult.SelectedItem = "PASS";
                cboToAuditResult.SelectedItem = "PASS";
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

        }

        private void dtAuditDateTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}