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
        public string AuditResults { get; set; }
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

    public class MMAuditReport
    {
        public int auditID { get; set; }

        public string Auditor { get; set; }

        public DateTime AuditDateTime { get; set; }

        public string ProcessID { get; set; }


        public string ChannelID { get; set; }

        public string PostID { get; set; }

        public string CreateTime { get; set; }

        public DateTime CreateTimeValueMM { get; set; }

        public DateTime CreateTimeValueOBS { get; set; }

        public string UpdateTime { get; set; }

        public DateTime UpdateTimeValueMM { get; set; }

        public DateTime UpdateTimeValueOBS { get; set; }

        public string MessageText { get; set; }

        public string MessageTextValueMM { get; set; }

        public string MessageTextValueOBS { get; set; }

        public string Attachments { get; set; }

        public string AttachmentsValueMM { get; set; }

        public string AttachmentsValueOBS { get; set; }

        public string Email { get; set; }

        public string EmailValueMM { get; set; }

        public string EmailValueOBS { get;set; }

        public string UserName { get; set; }

        public string UserNameValueMM { get; set; }

        public string UserNameValueOBS { get; set ; }

        public string AuditResults { get; set; }

        public string OBSobject { get; set; }
        
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
                        //connection.Close();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                //write admin logs to show what happened.
            }
        }


        private int CreateMMAuditId(SqlCommand sqlCommand)
        {
            sqlCommand.CommandText = "SELECT MAX(auditID) FROM dbo.MMauditdata";
            int auditId = Convert.ToInt32(sqlCommand.ExecuteScalar()) + 1;
            return auditId;
        }

        public void WriteMMAuditReport(MMAuditReport auditReport, string sqlServer, string sqlDatabase, string sqlUsername, string sqlPassword)
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
                        int auditId = CreateMMAuditId(command);
                        auditReport.auditID = auditId;
                    }

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"INSERT INTO [dbo].[MMauditdata] (
                        [auditID], [processID], [channelid], [postid], [createtime], [createtimevalueMM], [createtimevalueOBS], [updatetime], [updatetimevalueMM],
                        [updatetimevalueOBS], [messagetext], [messagetextvalueMM], [messagetextvalueOBS], [attachments], 
                        [attachmentsvalueMM], [attachmentsvalueOBS], [email], [emailvalueMM],
                        [emailvalueOBS], [username], [usernamevalueMM], [usernamevalueOBS],
                        [auditresults], [AuditDateTime], [Auditor])
                    VALUES (
                        @auditID, @processID, @channelid, @postid, @createtime, @createtimevalueMM, @createtimevalueOBS, @updatetime, @updatetimevalueMM,
                        @updatetimevalueOBS, @messagetext, @messagetextvalueMM, @messagetextvalueOBS, @attachments, 
                        @attachmentsvalueMM, @attachmentsvalueOBS, @email, @emailvalueMM,
                        @emailvalueOBS, @username, @usernamevalueMM, @usernamevalueOBS,
                        @auditresults, @AuditDateTime, @Auditor)";

                        command.Parameters.AddWithValue("@auditID", auditReport.auditID);
                        command.Parameters.AddWithValue("@processID", auditReport.ProcessID); //testing to add these values 
                        command.Parameters.AddWithValue("@channelid", auditReport.ChannelID);
                        command.Parameters.AddWithValue("@postid", auditReport.PostID);
                        command.Parameters.AddWithValue("@createtime", auditReport.CreateTime);
                        command.Parameters.AddWithValue("@updatetime", auditReport.UpdateTime);
                        command.Parameters.AddWithValue("@messagetext", auditReport.MessageText);
                        command.Parameters.AddWithValue("@attachments", auditReport.Attachments);
                        command.Parameters.AddWithValue("@email", auditReport.Email);
                        command.Parameters.AddWithValue("@username", auditReport.UserName);
                        command.Parameters.AddWithValue("@auditresults", auditReport.AuditResults);
                        command.Parameters.AddWithValue("@createtimevalueMM", (object)auditReport.CreateTimeValueMM ?? DBNull.Value);
                        command.Parameters.AddWithValue("@createtimevalueOBS", (object)auditReport.CreateTimeValueOBS ?? DBNull.Value);
                        command.Parameters.AddWithValue("@updatetimevalueMM", (object)auditReport.UpdateTimeValueMM ?? DBNull.Value);
                        command.Parameters.AddWithValue("@updatetimevalueOBS", (object)auditReport.UpdateTimeValueOBS ?? DBNull.Value);
                        command.Parameters.AddWithValue("@messagetextvalueMM", (object)auditReport.MessageTextValueMM ?? DBNull.Value);
                        command.Parameters.AddWithValue("@messagetextvalueOBS", (object)auditReport.MessageTextValueOBS ?? DBNull.Value);
                        command.Parameters.AddWithValue("@attachmentsvalueMM", (object)auditReport.AttachmentsValueMM ?? DBNull.Value);
                        command.Parameters.AddWithValue("@attachmentsvalueOBS", (object)auditReport.AttachmentsValueOBS ?? DBNull.Value);
                        command.Parameters.AddWithValue("@emailvalueMM", (object)auditReport.EmailValueMM ?? DBNull.Value);
                        command.Parameters.AddWithValue("@emailvalueOBS", (object)auditReport.EmailValueOBS ?? DBNull.Value);
                        command.Parameters.AddWithValue("@usernamevalueMM", (object)auditReport.UserNameValueMM ?? DBNull.Value);
                        command.Parameters.AddWithValue("@usernamevalueOBS", (object)auditReport.UserNameValueOBS ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AuditDateTime", (object)auditReport.AuditDateTime ?? DBNull.Value);
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
        }
        public EmailAuditReport GetEmailAuditByID(int auditID, string sqlServer, string sqlDatabase, string sqlUsername, string sqlPassword)
        {
            EmailAuditReport emailAuditReport = new EmailAuditReport();
            // run SQL query and add data to report
            string connectionString = $"Server=tcp:{sqlServer},1433;Database={sqlDatabase};User ID={sqlUsername};Password={sqlPassword};Encrypt=false;";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"Select * FROM dbo.Emailauditdata WHERE auditID = @auditID";

                        command.Parameters.AddWithValue("@auditID", auditID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                emailAuditReport.MessageId = reader["messageID"].ToString();
                                emailAuditReport.ObsObject = reader["ObsObjectid"].ToString();
                                emailAuditReport.Mailbox = reader["mailbox"].ToString();
                                emailAuditReport.JournalEmailId = reader["journalemailId"].ToString();
                                emailAuditReport.AuditResults = reader["auditresults"].ToString();
                                emailAuditReport.MessageReceivedTime = reader["messagereceivedTime"].ToString();
                                emailAuditReport.MessageSender = reader["messagesender"].ToString();
                                emailAuditReport.MessageSenderValueExchange = reader["messagesendervalueexchange"].ToString();
                                emailAuditReport.MessageSenderValueOBS = reader["messagesenderValueobs"].ToString();
                                emailAuditReport.MessageTo = reader["messageto"].ToString();
                                emailAuditReport.MessageTOValueExchange = reader["messagetovalueexchange"].ToString();
                                emailAuditReport.MessageTOValueOBS = reader["MessageTOValueobs"].ToString();
                                emailAuditReport.MessageCC = reader["messagecc"].ToString();
                                emailAuditReport.MessageCCValueExchange = reader["Messageccvalueexchange"].ToString();
                                emailAuditReport.MessageCCValueOBS = reader["messageccvalueobs"].ToString();
                                emailAuditReport.MessageBCC = reader["messagebcc"].ToString();
                                emailAuditReport.MessageBCCValueExchange = reader["messagebccvalueexchange"].ToString();
                                emailAuditReport.MessageBCCValueOBS = reader["messagebccvalueobs"].ToString();
                                emailAuditReport.MessageSubject = reader["messagesubject"].ToString();
                                emailAuditReport.MessageSubjectValueExchange = reader["messagesubjectvalueexchange"].ToString();
                                emailAuditReport.MessageSubjectValueOBS = reader["messagesubjectvalueobs"].ToString();
                                emailAuditReport.MessageBody = reader["messagebody"].ToString();
                                emailAuditReport.MessageBodyValueExchange = reader["messagebodyvalueexchange"].ToString();
                                emailAuditReport.Auditor = reader["Auditor"].ToString();
                                emailAuditReport.MessageBodyValueOBS = reader["messagebodyvalueobs"].ToString();
                                emailAuditReport.MessageAttachments = reader["messageattachments"].ToString();
                                emailAuditReport.MessageAttachmentsValueExchange = reader["messageattachmentsvalueexchange"].ToString();
                                emailAuditReport.MessageAttachmentsValueOBS = reader["messageattachmentsvalueobs"].ToString();
                            }
                        }
                        //connection.Close();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            { 
                // admin log
            }
            return emailAuditReport;
        }
/*
        public MMAuditReport DeleteMMAuditByID(int auditID, string sqlServer, string sqlDatabase, string sqlUsername, string sqlPassword)
        {
            MMAuditReport mmAuditReportDelete = new MMAuditReport();

            string connectionString = $"Server=tcp:{sqlServer},1433;Database={sqlDatabase};User ID={sqlUsername};Password={sqlPassword};Encrypt=false;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"DELETE FROM dbo.MMauditdata WHERE auditID = @auditID";

                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                //write admin logs to show what happened.
            }

        }*/

    public MMAuditReport GetMMAuditByID(int auditID, string sqlServer, string sqlDatabase, string sqlUsername, string sqlPassword)
        {
            MMAuditReport mmAuditReport = new MMAuditReport();
            //run the SQL query
            //add the sql data to the emailAuditReport

            string connectionString = $"Server=tcp:{sqlServer},1433;Database={sqlDatabase};User ID={sqlUsername};Password={sqlPassword};Encrypt=false;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"Select * FROM dbo.MMauditdata WHERE auditID = @auditID";

                        command.Parameters.AddWithValue("@auditID", auditID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                mmAuditReport.ProcessID = reader["processID"].ToString();
                                mmAuditReport.ChannelID = reader["channelid"].ToString();
                                mmAuditReport.PostID = reader["postid"].ToString();
                                mmAuditReport.CreateTime = reader["createtime"].ToString();
                                // mmAuditReport.UpdateTime = reader["update"].ToString();
                                mmAuditReport.MessageText = reader["messagetext"].ToString();
                                mmAuditReport.Attachments = reader["attachments"].ToString();
                                mmAuditReport.Email = reader["email"].ToString();
                                mmAuditReport.UserName = reader["username"].ToString();
                                mmAuditReport.AuditResults = reader["auditresults"].ToString();
                                //mmAuditReport.CreateTimeValueMM = reader["createtimevalueMM"].ToString();
                                //mmAuditReport.CreateTimeValueOBS = reader["createtimevalueOBS"].ToString();
                                //mmAuditReport.UpdateTimeValueMM = reader["postid"].ToString();
                                //mmAuditReport.UpdateTimeValueOBS = ;
                                mmAuditReport.MessageTextValueMM = reader["messagetextvalueMM"].ToString();
                                mmAuditReport.MessageTextValueOBS = reader["messagetextvalueOBS"].ToString();
                                mmAuditReport.AttachmentsValueMM = reader["attachmentsvalueMM"].ToString();
                                mmAuditReport.AttachmentsValueOBS = reader["attachmentsvalueOBS"].ToString();
                                mmAuditReport.EmailValueMM = reader["emailvalueMM"].ToString();
                                mmAuditReport.EmailValueOBS = reader["emailvalueOBS"].ToString();
                                mmAuditReport.UserNameValueMM = reader["usernamevalueMM"].ToString();
                                mmAuditReport.UserNameValueOBS = reader["usernamevalueOBS"].ToString();
                                //mmAuditReport.AuditDateTime = reader["AuditDateTime"].ToString();
                                mmAuditReport.Auditor = reader["Auditor"].ToString();
                                mmAuditReport.OBSobject = reader["OBSobject"].ToString();
                            }
                        }
                        //connection.Close();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                //write admin logs to show what happened.
            }

            return mmAuditReport;
        }
    }


 /*   public class MMAuditReportController
    {
        private int CreateMMAuditId(SqlCommand sqlCommand)
        {
            sqlCommand.CommandText = "SELECT MAX(auditID) FROM dbo.MMauditdata";
            int auditId = Convert.ToInt32(sqlCommand.ExecuteScalar()) + 1;
            return auditId;
        }

        public void WriteMMAuditReport(MMAuditReport auditReport, string sqlServer, string sqlDatabase, string sqlUsername, string sqlPassword)
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
                        int auditId = CreateMMAuditId(command);
                        auditReport.auditID = auditId;
                    }

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"INSERT INTO [dbo].[MMauditdata] (
                        [auditID], [processID], [channelid], [postid], [createtime], [createtimevalueMM], [createtimevalueOBS], [updatetime], [updatetimevalueMM],
                        [updatetimevalueOBS], [messagetext], [messagetextvalueMM], [messagetextvalueOBS], [attachments], 
                        [attachmentsvalueMM], [attachmentsvalueOBS], [email], [emailvalueMM],
                        [emailvalueOBS], [username], [usernamevalueMM], [usernamevalueOBS],
                        [auditresults], [AuditDateTime], [Auditor])
                    VALUES (
                        @auditID, @processID, @channelid, @postid, @createtime, @createtimevalueMM, @createtimevalueOBS, @updatetime, @updatetimevalueMM,
                        @updatetimevalueOBS, @messagetext, @messagetextvalueMM, @messagetextvalueOBS, @attachments, 
                        @attachmentsvalueMM, @attachmentsvalueOBS, @email, @emailvalueMM,
                        @emailvalueOBS, @username, @usernamevalueMM, @usernamevalueOBS,
                        @auditresults, @AuditDateTime, @Auditor)";

                        command.Parameters.AddWithValue("@auditID", auditReport.auditID);
                        command.Parameters.AddWithValue("@processID", auditReport.ProcessID); //testing to add these values 
                        command.Parameters.AddWithValue("@channelid", auditReport.ChannelID);
                        command.Parameters.AddWithValue("@postid", auditReport.PostID);
                        command.Parameters.AddWithValue("@createtime", auditReport.CreateTime);
                        command.Parameters.AddWithValue("@updatetime", auditReport.UpdateTime);
                        command.Parameters.AddWithValue("@messagetext", auditReport.MessageText);
                        command.Parameters.AddWithValue("@attachments", auditReport.Attachments);
                        command.Parameters.AddWithValue("@email", auditReport.Email);
                        command.Parameters.AddWithValue("@username", auditReport.UserName);
                        command.Parameters.AddWithValue("@auditresults", auditReport.AuditResults);
                        command.Parameters.AddWithValue("@createtimevalueMM", (object)auditReport.CreateTimeValueMM ?? DBNull.Value);
                        command.Parameters.AddWithValue("@createtimevalueOBS", (object)auditReport.CreateTimeValueOBS ?? DBNull.Value);
                        command.Parameters.AddWithValue("@updatetimevalueMM", (object)auditReport.UpdateTimeValueMM ?? DBNull.Value);
                        command.Parameters.AddWithValue("@updatetimevalueOBS", (object)auditReport.UpdateTimeValueOBS ?? DBNull.Value);
                        command.Parameters.AddWithValue("@messagetextvalueMM", (object)auditReport.MessageTextValueMM ?? DBNull.Value);
                        command.Parameters.AddWithValue("@messagetextvalueOBS", (object)auditReport.MessageTextValueOBS ?? DBNull.Value);
                        command.Parameters.AddWithValue("@attachmentsvalueMM", (object)auditReport.AttachmentsValueMM ?? DBNull.Value);
                        command.Parameters.AddWithValue("@attachmentsvalueOBS", (object)auditReport.AttachmentsValueOBS ?? DBNull.Value);
                        command.Parameters.AddWithValue("@emailvalueMM", (object)auditReport.EmailValueMM ?? DBNull.Value);
                        command.Parameters.AddWithValue("@emailvalueOBS", (object)auditReport.EmailValueOBS ?? DBNull.Value);
                        command.Parameters.AddWithValue("@usernamevalueMM", (object)auditReport.UserNameValueMM ?? DBNull.Value);
                        command.Parameters.AddWithValue("@usernamevalueOBS", (object)auditReport.UserNameValueOBS ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AuditDateTime", (object)auditReport.AuditDateTime ?? DBNull.Value);
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
        }

        public MMAuditReport GetMMAuditByID(int auditID, string sqlServer, string sqlDatabase, string sqlUsername, string sqlPassword)
        {
            MMAuditReport mmAuditReport = new MMAuditReport();
            //run the SQL query
            //add the sql data to the emailAuditReport

            string connectionString = $"Server=tcp:{sqlServer},1433;Database={sqlDatabase};User ID={sqlUsername};Password={sqlPassword};Encrypt=false;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"Select * FROM dbo.MMauditdata WHERE [auditID] VALUES (@auditID)";

                        command.Parameters.AddWithValue("@auditID", auditID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                mmAuditReport.ProcessID = reader["processID"].ToString();
                                mmAuditReport.ChannelID = reader["channelid"].ToString();
                                mmAuditReport.PostID = reader["postid"].ToString() ;
                                mmAuditReport.CreateTime = reader["createtime"].ToString();
                               // mmAuditReport.UpdateTime = reader["update"].ToString();
                                mmAuditReport.MessageText = reader["messagetext"].ToString();
                                mmAuditReport.Attachments = reader["attachments"].ToString();
                                mmAuditReport.Email = reader["email"].ToString();
                                mmAuditReport.UserName = reader["username"].ToString();
                                mmAuditReport.AuditResults = reader["auditresults"].ToString();
                                mmAuditReport.CreateTimeValueMM = reader["createtimevalueMM"].ToString();
                                mmAuditReport.CreateTimeValueOBS = reader["createtimevalueOBS"].ToString();
                                //mmAuditReport.UpdateTimeValueMM = reader["postid"].ToString();
                                //mmAuditReport.UpdateTimeValueOBS = ;
                                mmAuditReport.MessageTextValueMM = reader["messagetextvalueMM"].ToString();
                                mmAuditReport.MessageTextValueOBS = reader["messagetextvalueOBS"].ToString();
                                mmAuditReport.AttachmentsValueMM = reader["attachmentsvalueMM"].ToString();
                                mmAuditReport.AttachmentsValueOBS = reader["attachmentsvalueOBS"].ToString();
                                mmAuditReport.EmailValueMM = reader["emailvalueMM"].ToString();
                                mmAuditReport.EmailValueOBS = reader["emailvalueOBS"].ToString();
                                mmAuditReport.UserNameValueMM = reader["usernamevalueMM"].ToString();
                                mmAuditReport.UserNameValueOBS = reader["usernamevalueOBS"].ToString();
                                mmAuditReport.AuditDateTime = reader["AuditDateTime"].ToString();
                                mmAuditReport.Auditor = reader["Auditor"].ToString();
                                mmAuditReport.OBSobject = reader["OBSobject"].ToString() ;
                            }
                        }
                       //connection.Close();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                //write admin logs to show what happened.
            }

            return mmAuditReport;
        }
    }*/

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
