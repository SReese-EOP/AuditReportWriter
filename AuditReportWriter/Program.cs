using System;
using System.Data.SqlClient;
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
                        command.CommandText = "INSERT INTO [dbo].[emailauditdata] (/* ... */) VALUES (/* ... */)";
                        // Add parameters and execute the query
                    }
                }
            }
            catch (Exception ex)
            {
                //do something here to address any exceptions
            }
        }

       
    }
}
