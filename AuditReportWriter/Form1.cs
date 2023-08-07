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
                grpCCresults.Enabled = true;
                grpBCCResults.Enabled = true;
                //set the groups to blank for data entry
                cboReceivedTimeResult.SelectedItem = null;
                cboSenderResult.SelectedItem = null;
                cboToAuditResult.SelectedItem = null;
                cboCCAuditResult.SelectedItem = null;
                cbobccAuditResult.SelectedItem = null;
            }
            else
            {
                //disable all the groups since the audit results are passing
                grpSenderResults.Enabled = false;
                grpMessageReceivedTIme.Enabled = false;
                grpTOResults.Enabled = false;
                grpCCresults.Enabled = false;
                grpBCCResults.Enabled = false;

                //mark all of the audit results as passing
                cboReceivedTimeResult.SelectedItem = "PASS";
                cboSenderResult.SelectedItem = "PASS";
                cboToAuditResult.SelectedItem = "PASS";
                cboCCAuditResult.SelectedItem = "PASS";
                cbobccAuditResult.SelectedItem = "PASS";
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
            lblCCAuditResult.Text = "Hello World!";
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

        private void txtExchSenderResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnReturnNav_Click(object sender, EventArgs e)
        {
            frmAuditNavigator frmAuditNavigator = new frmAuditNavigator();
            frmAuditNavigator.Show();
            this.Hide();
        }

        private void cbobccAuditResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbobccAuditResult != null && cbobccAuditResult.SelectedItem == "FAIL")
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
    }
}