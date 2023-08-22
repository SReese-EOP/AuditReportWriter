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
using System.Windows.Forms;

namespace AuditReportWriter
{
    public partial class frmMattermostChatCorrections : Form
    {
        private userInfo navUser;

        public frmMattermostChatCorrections()
        {
            InitializeComponent();
        }

        private void bttnReplace_Click(object sender, EventArgs e)
        {

        }

        private void txtEnterAuditID_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnGo_Click(object sender, EventArgs e)
        {
/*            string auditID = txtEnterAuditID.Text;
            *//*            
                        sqlcomand.CommandText = "SELECT postid from auditdemo.dbo.MMauditdata where auditID = @auditID";
                        string MessageID = sqlCommand.ExecuteScalar();*//*

            SqlConnection con = new SqlConnection(" ");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from MMauditdata where auditID = @auditID", con);
            cmd.Parameters.AddWithValue(auditID"@auditID")*/
        }


        /* private int CreateEmailAuditId(SqlCommand sqlCommand)
                {
                    sqlCommand.CommandText = "SELECT MAX(auditID) FROM dbo.emailauditdata";
                    int auditId = Convert.ToInt32(sqlCommand.ExecuteScalar()) + 1;
                    return auditId;
                }

                public void WriteEmailAuditReport(EmailAuditReport auditReport, string sqlServer, string sqlDatabase, string sqlUsername, string sqlPassword)
                {
                    string connectionString = $"Server=tcp:{sqlServer},1433;Database={sqlDatabase};User ID={sqlUsername};Password={sqlPassword};Encrypt=false;";
                    string userName = WindowsIdentity.GetCurrent().Name;
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            using (SqlCommand command = connection.CreateCommand())
                            {
                                int auditId = CreateEmailAuditId(command);
                                auditReport.AuditId = auditId;
                            }

                            using (SqlCommand command = connection.CreateCommand())
                            {
                                command.CommandText = @"INSERT INTO [dbo].[emailauditdata] (
                                [AuditID], [AuditDateTime], [MessageID], [MessageReceivedTime], [MessageSender], [MessageTO], [MessageCC], [MessageBCC],
                                [MessageSubject], [MessageBody], [MessageAttachments], [MessageAuditResult], [Mailbox], 
                                [JournalEmailID], [OBSobject], [MessageReceivedTimeValueExchange], [MessageReceivedTimeValueOBS],
                                [MessageSenderValueExchange], [MessageSenderValueOBS], [MessageTOValueExchange], [MessageTOValueOBS],
                                [MessageCCValueExchange], [MessageCCValueOBS], [MessageBCCValueExchange], [MessageBCCValueOBS],
                                [MessageSubjectValueExchange], [MessageSubjectValueOBS], [MessageBodyValueExchange], [MessageBodyValueOBS],
                                [MessageAttachmentsValueExchange], [MessageAttachmentsValueOBS], [Auditor])
                            VALUES (
                                @AuditID, @AuditDateTime, @MessageID, @MessageReceivedTime, @MessageSender, @MessageTO, @MessageCC, @MessageBCC,
                                @MessageSubject, @MessageBody, @MessageAttachments, @MessageAuditResult, @Mailbox, 
                                @JournalEmailID, @OBSobject, @MessageReceivedTimeValueExchange, @MessageReceivedTimeValueOBS,
                                @MessageSenderValueExchange, @MessageSenderValueOBS, @MessageTOValueExchange, @MessageTOValueOBS,
                                @MessageCCValueExchange, @MessageCCValueOBS, @MessageBCCValueExchange, @MessageBCCValueOBS,
                                @MessageSubjectValueExchange, @MessageSubjectValueOBS, @MessageBodyValueExchange, @MessageBodyValueOBS,
                                @MessageAttachmentsValueExchange, @MessageAttachmentsValueOBS, @Auditor)";

                                command.Parameters.AddWithValue("@AuditID", auditReport.AuditId);
                                command.Parameters.AddWithValue("@AuditDateTime", auditReport.AuditDateTime);
                                command.Parameters.AddWithValue("@MessageID", auditReport.MessageId);
                                command.Parameters.AddWithValue("@MessageReceivedTime", auditReport.MessageReceivedTime);
                                command.Parameters.AddWithValue("@MessageSender", auditReport.MessageSender);
                                command.Parameters.AddWithValue("@MessageTO", auditReport.MessageTo);
                                command.Parameters.AddWithValue("@MessageCC", auditReport.MessageCC);
                                command.Parameters.AddWithValue("@MessageBCC", auditReport.MessageBCC);
                                command.Parameters.AddWithValue("@MessageSubject", auditReport.MessageSubject);
                                command.Parameters.AddWithValue("@MessageBody", auditReport.MessageBody);
                                command.Parameters.AddWithValue("@MessageAttachments", auditReport.MessageAttachments);
                                command.Parameters.AddWithValue("@MessageAuditResult", auditReport.MessageAuditResult);
                                command.Parameters.AddWithValue("@Mailbox", auditReport.Mailbox);
                                command.Parameters.AddWithValue("@JournalEmailID", auditReport.JournalEmailId);
                                command.Parameters.AddWithValue("@OBSobject", auditReport.ObsObject);
                                command.Parameters.AddWithValue("@MessageReceivedTimeValueExchange", auditReport.MessageReceivedTimeValueExchange);
                                command.Parameters.AddWithValue("@MessageReceivedTimeValueOBS", (object)auditReport.MessageReceivedTimeValueOBS ?? DBNull.Value);
                                command.Parameters.AddWithValue("@MessageSenderValueExchange", (object)auditReport.MessageSenderValueExchange ?? DBNull.Value);
                                command.Parameters.AddWithValue("@MessageSenderValueOBS", (object)auditReport.MessageSenderValueOBS ?? DBNull.Value);
                                command.Parameters.AddWithValue("@MessageTOValueExchange", (object)auditReport.MessageTOValueExchange ?? DBNull.Value);
                                command.Parameters.AddWithValue("@MessageTOValueOBS", (object)auditReport.MessageTOValueOBS ?? DBNull.Value);
                                command.Parameters.AddWithValue("@MessageCCValueExchange", (object)auditReport.MessageCCValueExchange ?? DBNull.Value);
                                command.Parameters.AddWithValue("@MessageCCValueOBS", (object)auditReport.MessageCCValueOBS ?? DBNull.Value);
                                command.Parameters.AddWithValue("@MessageBCCValueExchange", (object)auditReport.MessageBCCValueExchange ?? DBNull.Value);
                                command.Parameters.AddWithValue("@MessageBCCValueOBS", (object)auditReport.MessageBCCValueOBS ?? DBNull.Value);
                                command.Parameters.AddWithValue("@MessageSubjectValueExchange", (object)auditReport.MessageSubjectValueExchange ?? DBNull.Value);
                                command.Parameters.AddWithValue("@MessageSubjectValueOBS", (object)auditReport.MessageSubjectValueOBS ?? DBNull.Value);
                                command.Parameters.AddWithValue("@MessageBodyValueExchange", (object)auditReport.MessageBodyValueExchange ?? DBNull.Value);
                                command.Parameters.AddWithValue("@MessageBodyValueOBS", (object)auditReport.MessageBodyValueOBS ?? DBNull.Value);
                                command.Parameters.AddWithValue("@MessageAttachmentsValueExchange", (object)auditReport.MessageAttachmentsValueExchange ?? DBNull.Value);
                                command.Parameters.AddWithValue("@MessageAttachmentsValueOBS", (object)auditReport.MessageAttachmentsValueOBS ?? DBNull.Value);
                                command.Parameters.AddWithValue("@Auditor", (object)auditReport.Auditor ?? DBNull.Value);
                                command.ExecuteNonQuery();
                                //connection.Close();
                            }
                            connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        //write admin logs to show what happened.
                    }
                }*/
    }
}
