using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Windows.Forms;
using static AuditReportWriter.AuditReportController;


namespace AuditReportWriter
{
    public partial class frmMattermostChatCorrections : Form
    {
        private userInfo MMUser;

        public frmMattermostChatCorrections(userInfo navuser)
        {
            InitializeComponent();
            MMUser = navuser;
        }

        private void bttnReplace_Click(object sender, EventArgs e)
        {
            //check that the mandatory fields are not null
            if (
                txtMessageID.Text != null &&
                txtOBSObject.Text != null &&
                txtChannelID.Text != null &&
                //dtAuditDate. != null &&
                cboOverallAuditResult.SelectedItem != null &&
                cboAttachmentsResult.SelectedItem != null &&
                cboCreatedTimeResult.SelectedItem != null &&
                cboEmailAuditResult.SelectedItem != null &&
                cboMessageTextAuditResult.SelectedItem != null &&
                cboUpdatedTimeResult.SelectedItem != null &&
                cboUsernameResult.SelectedItem != null
                /*                cboOverallAuditResult.ValueMember.ToString() != null &&
                                cboAttachmentsResult.ValueMember.ToString() != null &&
                                cboCreatedTimeResult.ValueMember.ToString() != null &&
                                cboEmailAuditResult.ValueMember.ToString() != null &&
                                cboMessageTextAuditResult.ValueMember.ToString() != null &&
                                cboUpdatedTimeResult.ValueMember.ToString() != null &&
                                cboUsernameResult.ValueMember.ToString() != null*/
                )
            {
                bttnReplace.Enabled = true;
                //else messagebox = there is a fialuer - and it can be done either at individaul if else statemetns, or do it in one long sting
                //init a new email audit report object
                MMAuditReport mmAuditReport = new MMAuditReport();

                //init a new controller to write the audit report
                AuditReportController MMauditReportController = new AuditReportController();

                //add the audit report data
                mmAuditReport.AuditDateTime = dtAuditDateTime.Value;
                mmAuditReport.ChannelID = txtChannelID.Text;
                mmAuditReport.PostID = txtMessageID.Text;
                mmAuditReport.ProcessID = txtOBSObject.Text;
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
                MMauditReportController.WriteMMAuditReport(mmAuditReport, MMUser.Server, MMUser.Database, MMUser.UserName, MMUser.Password);
                MessageBox.Show("Mattermost audit was successfully submitted under Audit ID: " + mmAuditReport.auditID);
                DialogResult result = MessageBox.Show("Do you want to enter another audit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Controls.Clear();
                    this.InitializeComponent();
                    txtMessageID.Focus();
                }
                else
                {
                    frmAuditNavigator frmAuditNavigator = new frmAuditNavigator(MMUser);
                    frmAuditNavigator.Show();
                    this.Close();
                }
            }
            //else the form isn't filled out the right way - what to do next?
            //allow the user to close out the message box and fill in the form again
            else
            {
                MessageBox.Show("The audit form is not filled out properly. At least one of the fields is blank.");
                //do not let the submit occur until resolved
            }
        }
        /*            if (txtEnterAuditID.Text != "")
                    {
                        MMAuditReport mmAuditReportDelete = new MMAuditReport();
                        AuditReportController auditReportController = new AuditReportController();
                        //execute the audit reader
                        int auditID = Convert.ToInt32(txtEnterAuditID.Text);
                        mmAuditReportDelete = auditReportController.DeleteMMAuditByID(auditID, MMUser.Server, MMUser.Database, MMUser.UserName, MMUser.Password);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Audit ID.");
                    }*/


        private void txtEnterAuditID_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnGo_Click(MMAuditReport mmAuditReport)
        {
            if (txtEnterAuditID.Text != "")
            {
                //execute the audit reader?
                //mmAuditReport.GetMMAuditByID(auditID, navUser.Server, navUser.Database, navUser.UserName, navUser.Password);
                //txtMessageID.Text = mmAuditReport.MessageText;
                txtOBSObject.Text = mmAuditReport.OBSobject;
                txtChannelID.Text = mmAuditReport.ChannelID;

                cboOverallAuditResult.DataSource = mmAuditReport.AuditResults;

                cboCreatedTimeResult.DataSource = mmAuditReport.CreateTime;
                dtMMCreatedTime.Value = mmAuditReport.CreateTimeValueMM;
                dtOBSCreatedTime.Value = mmAuditReport.CreateTimeValueOBS;

                /*                    cboUpdatedTimeResult.DataSource = mmAuditReport.;
                                    dtMMUpdatedTime.Value = data[9];
                                    dtOBSUpdatedTime.Value = data[10];*/

                cboMessageTextAuditResult.DataSource = mmAuditReport.MessageText;
                txtMMMessageTextResult.Text = mmAuditReport.MessageTextValueMM;
                txtOBSMessageTextResult.Text = mmAuditReport.MessageTextValueOBS;

                cboAttachmentsResult.DataSource = mmAuditReport.Attachments;
                txtMMAttachmentsResult.Text = mmAuditReport.AttachmentsValueMM;
                txtOBSAttachmentsResult.Text = mmAuditReport.AttachmentsValueOBS;

                cboEmailAuditResult.DataSource = mmAuditReport.Email;
                txtMMEmailResult.Text = mmAuditReport.EmailValueMM;
                txtOBSEmailResult.Text = mmAuditReport.EmailValueOBS;

                cboUsernameResult.DataSource = mmAuditReport.UserName;
                txtMMUsernameResult.Text = mmAuditReport.UserNameValueMM;
                txtOBSUsernameResult.Text = mmAuditReport.UserNameValueOBS;
            }
        }

        private void txtOBSObject_TextChanged(object sender, EventArgs e)
        {

        }

        /*        private void bttnGo_Click(object sender, EventArgs e)
                {
                    if (txtEnterAuditID.Text != "")
                    {
                        MMAuditReport mmAuditReport = new MMAuditReport();
                        AuditReportController auditReportController = new AuditReportController();
                        //execute the audit reader
                        int auditID = Convert.ToInt32(txtEnterAuditID.Text);
                        mmAuditReport = auditReportController.GetMMAuditByID(auditID, MMUser.Server, MMUser.Database, MMUser.UserName, MMUser.Password);

                        txtMessageID.Text = mmAuditReport.PostID;
                        txtOBSObject.Text = mmAuditReport.OBSobject;
                        txtChannelID.Text = mmAuditReport.ChannelID;


                        cboOverallAuditResult.Text = mmAuditReport.AuditResults;

                        cboCreatedTimeResult.Text = mmAuditReport.CreateTime;
                        // dtMMCreatedTime.Text = mmAuditReport.CreateTimeValueMM;
                        // dtOBSCreatedTime.Text = mmAuditReport.CreateTimeValueOBS;

                        *//*                    cboUpdatedTimeResult.DataSource = mmAuditReport.;
                                            dtMMUpdatedTime.Value = data[9];
                                            dtOBSUpdatedTime.Value = data[10];*//*

                        cboMessageTextAuditResult.Text = mmAuditReport.MessageText;
                        txtMMMessageTextResult.Text = mmAuditReport.MessageTextValueMM;
                        txtOBSMessageTextResult.Text = mmAuditReport.MessageTextValueOBS;

                        cboAttachmentsResult.Text = mmAuditReport.Attachments;
                        txtMMAttachmentsResult.Text = mmAuditReport.AttachmentsValueMM;
                        txtOBSAttachmentsResult.Text = mmAuditReport.AttachmentsValueOBS;

                        cboEmailAuditResult.Text = mmAuditReport.Email;
                        txtMMEmailResult.Text = mmAuditReport.EmailValueMM;
                        txtOBSEmailResult.Text = mmAuditReport.EmailValueOBS;

                        cboUsernameResult.Text = mmAuditReport.UserName;
                        txtMMUsernameResult.Text = mmAuditReport.UserNameValueMM;
                        txtOBSUsernameResult.Text = mmAuditReport.UserNameValueOBS;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Audit ID.");
                    }
                }*/

        private void frmMattermostChatCorrections_Load(object sender, EventArgs e)
        {

        }

        private void bttnGo_Click_1(object sender, EventArgs e)
        {
            if (txtEnterAuditID.Text != "")
            {
                MMAuditReport mmAuditReport = new MMAuditReport();
                AuditReportController auditReportController = new AuditReportController();
                //execute the audit reader
                int auditID = Convert.ToInt32(txtEnterAuditID.Text);
                mmAuditReport = auditReportController.GetMMAuditByID(auditID, MMUser.Server, MMUser.Database, MMUser.UserName, MMUser.Password);

                txtMessageID.Text = mmAuditReport.PostID;
                txtMessageID.Enabled = true;
                txtOBSObject.Text = mmAuditReport.OBSobject;
                txtOBSObject.Enabled = true;
                txtChannelID.Text = mmAuditReport.ChannelID;
                txtChannelID.Enabled = true;


                cboOverallAuditResult.Text = mmAuditReport.AuditResults;
                cboOverallAuditResult.Enabled = true;

                cboCreatedTimeResult.Text = mmAuditReport.CreateTime;
                cboCreatedTimeResult.Enabled = true;
                // dtMMCreatedTime.Text = mmAuditReport.CreateTimeValueMM;
                dtMMCreatedTime.Enabled = true;
                // dtOBSCreatedTime.Text = mmAuditReport.CreateTimeValueOBS;
                dtOBSCreatedTime.Enabled = true;

                /*                    cboUpdatedTimeResult.DataSource = mmAuditReport.;
                                    dtMMUpdatedTime.Value = data[9];
                                    dtOBSUpdatedTime.Value = data[10];*/

                cboMessageTextAuditResult.Text = mmAuditReport.MessageText;
                cboMessageTextAuditResult.Enabled = true;
                txtMMMessageTextResult.Text = mmAuditReport.MessageTextValueMM;
                txtMMMessageTextResult.Enabled = true;
                txtOBSMessageTextResult.Text = mmAuditReport.MessageTextValueOBS;
                txtOBSMessageTextResult.Enabled = true;

                cboAttachmentsResult.Text = mmAuditReport.Attachments;
                cboAttachmentsResult.Enabled = true;
                txtMMAttachmentsResult.Text = mmAuditReport.AttachmentsValueMM;
                txtMMAttachmentsResult.Enabled = true;
                txtOBSAttachmentsResult.Text = mmAuditReport.AttachmentsValueOBS;
                txtOBSAttachmentsResult.Enabled = true;

                cboEmailAuditResult.Text = mmAuditReport.Email;
                cboEmailAuditResult.Enabled = true;
                txtMMEmailResult.Text = mmAuditReport.EmailValueMM;
                txtMMEmailResult.Enabled = true;
                txtOBSEmailResult.Text = mmAuditReport.EmailValueOBS;
                txtOBSEmailResult.Enabled = true;

                cboUsernameResult.Text = mmAuditReport.UserName;
                cboUsernameResult.Enabled = true;
                txtMMUsernameResult.Text = mmAuditReport.UserNameValueMM;
                txtMMUsernameResult.Enabled = true;
                txtOBSUsernameResult.Text = mmAuditReport.UserNameValueOBS;
                txtOBSUsernameResult.Enabled = true;


            }
            else
            {
                MessageBox.Show("Please enter a valid Audit ID.");
            }
        }

        private void bttnReturntoNav_Click(object sender, EventArgs e)
        {
            frmAuditNavigator frmAuditNavigator = new frmAuditNavigator(MMUser);
            frmAuditNavigator.Show();
            this.Close();
        }

        private void bttnReset_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void txtMMAttachmentsResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (txtEnterAuditID.Text != "")
            {
                int auditID = Convert.ToInt32(txtEnterAuditID.Text);

                string connectionString = $"Server=tcp:{MMUser.Server},1433;Database={MMUser.Database};User ID={MMUser.UserName};Password={MMUser.Password};Encrypt=false;";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = connection.CreateCommand())
                        {
                            command.CommandText = @"DELETE FROM dbo.MMauditdata WHERE auditID =" + auditID;

                        }
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The record was not delted due to error.");
                    //write admin logs to show what happened.
                }

            }
        }

        private void cboCreatedTimeResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboOverallAuditResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboAttachmentsResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAttachmentsResult.SelectedItem != null)
            {
                txtMMAttachmentsResult.Enabled = true;
                txtOBSAttachmentsResult.Enabled = true;
            }
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
