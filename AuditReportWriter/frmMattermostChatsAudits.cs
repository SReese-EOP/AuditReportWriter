﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuditReportWriter
{
    public partial class frmMattermostChatsAudits : Form
    {
        public userInfo user;

        public frmMattermostChatsAudits()
        {
            InitializeComponent();

        }
        /*       private void dtAuditDateTime_ValueChanged(object sender, EventArgs e) 
               {

               }*/
        private void cboCreatedTimeResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCreatedTimeResult.SelectedItem != null && cboCreatedTimeResult.SelectedItem.ToString() == "FAIL")
            {
                dtMMCreatedTime.Enabled = true;
                dtOBSCreatedTime.Enabled = true;
            }
            else
            {
                dtMMCreatedTime.Enabled = false;
                dtOBSCreatedTime.Enabled = false;
            }
        }

        private void cboUpdatedTimeResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUpdatedTimeResult.SelectedItem != null && cboUpdatedTimeResult.SelectedItem.ToString() == "FAIL")
            {
                dtMMUpdatedTime.Enabled = true;
                dtOBSUpdatedTime.Enabled = true;
            }
            else
            {
                dtMMUpdatedTime.Enabled = false;
                dtOBSUpdatedTime.Enabled = false;
            }
        }

        private void cboMessageTextAuditResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMessageTextAuditResult.SelectedItem != null && cboMessageTextAuditResult.SelectedItem.ToString() == "FAIL")
            {
                txtMMMessageTextResult.Enabled = true;
                txtOBSMessageTextResult.Enabled = true;
            }
            else
            {
                txtMMMessageTextResult.Enabled = false;
                txtOBSMessageTextResult.Enabled = false;
            }
        }

        private void cboAttachmentsResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAttachmentsResult.SelectedItem != null && cboAttachmentsResult.SelectedItem.ToString() == "FAIL")
            {
                txtMMAttachmentsResult.Enabled = true;
                txtOBSAttachmentsResult.Enabled = true;
            }
            else
            {
                txtMMAttachmentsResult.Enabled = false;
                txtOBSAttachmentsResult.Enabled = false;
            }
        }

        private void cboEmailAuditResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEmailAuditResult.SelectedItem != null && cboEmailAuditResult.SelectedItem.ToString() == "FAIL")
            {
                txtMMEmailResult.Enabled = true;
                txtOBSEmailResult.Enabled = true;
            }
            else
            {
                txtMMEmailResult.Enabled = false;
                txtOBSEmailResult.Enabled = false;
            }
        }

        private void cboUsernameResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUsernameResult.SelectedItem != null && cboUsernameResult.SelectedItem.ToString() == "FAIL")
            {
                txtMMUsernameResult.Enabled = true;
                txtOBSUsernameResult.Enabled = true;
            }
            else
            {
                txtMMUsernameResult.Enabled = false;
                txtOBSUsernameResult.Enabled = false;
            }
        }

        private void bttnReturntoNav_Click(object sender, EventArgs e)
        {
            frmAuditNavigator frmAuditNavigator = new frmAuditNavigator(user);
            frmAuditNavigator.Show();
            this.Close();
        }

        private void bttnReset_Click(object sender, EventArgs e)
        {
            frmMattermostChatsAudits frmMattermostChatsAudits = new frmMattermostChatsAudits();
            frmMattermostChatsAudits.Show();
            frmMattermostChatsAudits.Close();
        }

        private void bttnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void dtAuditDateTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
