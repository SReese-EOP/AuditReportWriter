﻿using System;
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
    public partial class frmMattermostAudits : Form
    {
        public frmMattermostAudits()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttnChat_Click(object sender, EventArgs e)
        {
            frmMattermostChatAudit frmMattermostChatAudit = new frmMattermostChatAudit();
            frmMattermostChatAudit.Show();
            this.Hide();
        }
    }
}