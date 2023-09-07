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

        private void bttnGo_Click(MMAuditReport mmAuditReport)
        {
            if (txtEnterAuditID.Text != "")
            {
                //execute the audit reader?
                MMAuditReport.GetMMAuditByID(mmAuditReport, navUser.Server, navUser.Database, navUser.UserName, navUser.Password);
                txtMessageID.Text = mmAuditReport.MessageText;
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
    }
}
