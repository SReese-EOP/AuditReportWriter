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
    public partial class frmExchangeAudits : Form
    {
        public frmExchangeAudits()
        {
            InitializeComponent();
        }

        private void bttnEmail_Click(object sender, EventArgs e)
        {
            frmEmailAuditReport frmEmailAuditReport = new frmEmailAuditReport();
            frmEmailAuditReport.Show();
            this.Hide();
        }
    }
}