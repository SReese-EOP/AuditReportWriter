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

        private void bttnGo_Click(string sqlServer, string sqlDatabase, string sqlUsername, string sqlPassword)
        {
            if (txtEnterAuditID.Text != "")
            {
                //string auditID = txtEnterAuditID.Text;

                //sqlcomand.CommandText = "SELECT postid from auditdemo.dbo.MMauditdata where auditID = @auditID";
                //string MessageID = sqlCommand.ExecuteScalar();

                string connectionString = $"Server=tcp:{sqlServer},1433;Database={sqlDatabase};User ID={sqlUsername};Password={sqlPassword};Encrypt=false;";
                //SqlConnection con = new SqlConnection(" ");
                connectionString.Open();


                SqlCommand command = new SqlCommand("Select * from MMauditdata where auditID = @auditID", connectionString);
                command.Parameters.AddWithValue("@auditID", txtEnterAuditID.Text);//potentially other info here

                SqlDataReader data = command.ExecuteReader();
                while (data.Read())
                {
                    txtMessageID.Text = data.GetValue(4).ToString();
                    txtOBSObject.Text = data.GetValue(25).ToString();
                    txtChannelID.Text = data.GetValue(3).ToString();
                    cboOverallAuditResult.DataSource = data[23];
                    /*
                                    cboCreatedTimeResult.DataSource = data[5];
                                    dtMMCreatedTime.Value = data[6].Value;
                                    dtOBSCreatedTime.Value = data[7];

                                    cboUpdatedTimeResult.DataSource = data[8];
                                    dtMMUpdatedTime.Value = data[9];
                                    dtOBSUpdatedTime.Value = data[10];*/

                    cboMessageTextAuditResult.DataSource = data[11];
                    txtMMMessageTextResult.Text = data.GetValue(12).ToString();
                    txtOBSMessageTextResult.Text = data.GetValue(13).ToString();

                    cboAttachmentsResult.DataSource = data[14];
                    txtMMAttachmentsResult.Text = data.GetValue(15).ToString();
                    txtOBSAttachmentsResult.Text = data.GetValue(16).ToString();

                    cboEmailAuditResult.DataSource = data[17];
                    txtMMEmailResult.Text = data.GetValue(18).ToString();
                    txtOBSEmailResult.Text = data.GetValue(19).ToString();

                    cboUsernameResult.DataSource = data[20];
                    txtMMUsernameResult.Text = data.GetValue(21).ToString();
                    txtOBSUsernameResult.Text = data.GetValue(22).ToString();

                }
                connectionString.Close();
            }
        }

      }
}
