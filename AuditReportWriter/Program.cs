using System;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Windows.Forms;

namespace AuditReportWriter
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
    }

    public class userInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Server { get; set; }
        public string Database { get; set; }
    }

    public class EmailAuditReport
    {
        public int AuditId { get; set; }
        public DateTime AuditDateTime { get; set; }
        public string MessageId { get; set; }
        public string MessageReceivedTime { get; set; }
        public string MessageSender { get; set; }
        public string MessageTo { get; set; }
        public string MessageCC { get; set; }
        public string MessageBCC { get; set; }
        public string MessageSubject { get; set; }
        public string MessageBody { get; set; }
        public string MessageAttachments { get; set; }
        public string MessageAuditResult { get; set; }
        public string Mailbox { get; set; }
        public string MessageOther { get; set; }
        public string MessageRecordFound { get; set; }
        public string JournalEmailId { get; set; }
        public string ObsObject { get; set; }
        public DateTime MessageReceivedTimeValueExchange { get; set; }
        public DateTime MessageReceivedTimeValueOBS { get; set; }
        public string MessageSenderValueExchange { get; set; }
        public string MessageSenderValueOBS { get; set; }
        public string MessageTOValueExchange { get; set; }
        public string MessageTOValueOBS { get; set; }
        public string MessageCCValueExchange { get; set; }
        public string MessageCCValueOBS { get; set; }
        public string MessageBCCValueExchange { get; set; }
        public string MessageBCCValueOBS { get; set; }
        public string MessageSubjectValueExchange { get; set; }
        public string MessageSubjectValueOBS { get; set; }
        public string MessageBodyValueExchange { get; set; }
        public string MessageBodyValueOBS { get; set; }
        public string MessageAttachmentsValueExchange { get; set; }
        public string MessageAttachmentsValueOBS { get; set; }
        public int ProcessId { get; set; }
        public string Auditor { get; set; }
    }


    public class AuditReportController
    {
        private int CreateEmailAuditId(SqlCommand sqlCommand)
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
                    }
                }
            }
            catch (Exception ex)
            {
                //write admin logs to show what happened.
            }
        }
    }

    public class Utilities
        {
            public static void ResetAllControls (Control form)
            {
                foreach(Control control in form.Controls) 
                {
                    if (control is TextBox)
                    {
                        TextBox textbox = (TextBox)control;
                        textbox.Text = null;
                     }
                    if (control is ComboBox)
                    {
                        ComboBox combobox = (ComboBox)control;
                        if (combobox.Items.Count >0)
                            combobox.SelectedIndex = 0;
                    }

                    if (control is CheckBox)
                    {
                        CheckBox checkbox = (CheckBox)control;
                        checkbox.Checked = false;
                    }

                    if (control is ListBox)
                    {
                        ListBox listbox = (ListBox)control;
                        listbox.ClearSelected();
                    }
                }
            }
        
       
    }
}
