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


        }

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

        private void bttnGo_Click(object sender, EventArgs e)
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
                dtMMCreatedTime.Text = mmAuditReport.CreateTimeValueMM;
                dtOBSCreatedTime.Text = mmAuditReport.CreateTimeValueOBS;

                /*                    cboUpdatedTimeResult.DataSource = mmAuditReport.;
                                    dtMMUpdatedTime.Value = data[9];
                                    dtOBSUpdatedTime.Value = data[10];*/

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
        }

        private void frmMattermostChatCorrections_Load(object sender, EventArgs e)
        {

        }
    }
}
