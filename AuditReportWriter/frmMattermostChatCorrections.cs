using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //AUDITID = txtEnterAuditID.Text;
        }

        /*        private string txtMessageID_TextChanged(SqlCommand sqlcommand)
                {
                    sqlCommand.CommandText = "SELECT postid FROM dbo.MMauditdata WHERE auditID = @AUDITID";
                    string postid = postid;
                    return postid;
                }*/
    }
}
