namespace AuditReportWriter
{
    partial class frmEmailAuditReport
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMessageID = new Label();
            txtMessageID = new TextBox();
            btnSubmit = new Button();
            dtAuditDate = new Label();
            dtAuditDateTime = new DateTimePicker();
            lblMessageSenderResult = new Label();
            grpSenderResults = new GroupBox();
            txtOBSSenderResult = new TextBox();
            txtExchSenderResult = new TextBox();
            lblOBSresult = new Label();
            lblExchangeSender = new Label();
            cboSenderResult = new ComboBox();
            dtExchMessageRecievedTime = new DateTimePicker();
            grpMessageReceivedTIme = new GroupBox();
            dtOBSMessageReceivedTime = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cboReceivedTimeResult = new ComboBox();
            grpOverallAudit = new GroupBox();
            label11 = new Label();
            txtOriginMailbox = new TextBox();
            label10 = new Label();
            txtJounalEmailId = new TextBox();
            label9 = new Label();
            txtJournaledMailbox = new TextBox();
            txtOBSObject = new TextBox();
            label8 = new Label();
            cboOverallAuditResult = new ComboBox();
            label4 = new Label();
            grpTOResults = new GroupBox();
            txtOBSToResult = new TextBox();
            txtExchToResult = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cboToAuditResult = new ComboBox();
            grpCCresults = new GroupBox();
            txtCCobsresult = new TextBox();
            txtCCExchResult = new TextBox();
            cboCCAuditResult = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            lblCCAuditResult = new Label();
            grpSenderResults.SuspendLayout();
            grpMessageReceivedTIme.SuspendLayout();
            grpOverallAudit.SuspendLayout();
            grpTOResults.SuspendLayout();
            grpCCresults.SuspendLayout();
            SuspendLayout();
            // 
            // lblMessageID
            // 
            lblMessageID.AutoSize = true;
            lblMessageID.Location = new Point(19, 40);
            lblMessageID.Name = "lblMessageID";
            lblMessageID.Size = new Size(89, 20);
            lblMessageID.TabIndex = 0;
            lblMessageID.Text = "Message ID:";
            // 
            // txtMessageID
            // 
            txtMessageID.Location = new Point(114, 29);
            txtMessageID.Margin = new Padding(3, 4, 3, 4);
            txtMessageID.Name = "txtMessageID";
            txtMessageID.Size = new Size(369, 27);
            txtMessageID.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(1734, 1176);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(197, 31);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "&Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // dtAuditDate
            // 
            dtAuditDate.AutoSize = true;
            dtAuditDate.Location = new Point(18, 149);
            dtAuditDate.Name = "dtAuditDate";
            dtAuditDate.Size = new Size(123, 20);
            dtAuditDate.TabIndex = 3;
            dtAuditDate.Text = "Audit Date/TIme:";
            // 
            // dtAuditDateTime
            // 
            dtAuditDateTime.CustomFormat = "MM-dd-yyyy HH:mm";
            dtAuditDateTime.Format = DateTimePickerFormat.Custom;
            dtAuditDateTime.Location = new Point(137, 135);
            dtAuditDateTime.Margin = new Padding(3, 4, 3, 4);
            dtAuditDateTime.Name = "dtAuditDateTime";
            dtAuditDateTime.Size = new Size(346, 27);
            dtAuditDateTime.TabIndex = 4;
            dtAuditDateTime.Value = new DateTime(2023, 8, 2, 15, 53, 51, 0);
            dtAuditDateTime.ValueChanged += dtAuditDateTime_ValueChanged;
            // 
            // lblMessageSenderResult
            // 
            lblMessageSenderResult.AutoSize = true;
            lblMessageSenderResult.Location = new Point(19, 39);
            lblMessageSenderResult.Name = "lblMessageSenderResult";
            lblMessageSenderResult.Size = new Size(96, 20);
            lblMessageSenderResult.TabIndex = 6;
            lblMessageSenderResult.Text = "Audit Result: ";
            // 
            // grpSenderResults
            // 
            grpSenderResults.Controls.Add(txtOBSSenderResult);
            grpSenderResults.Controls.Add(txtExchSenderResult);
            grpSenderResults.Controls.Add(lblOBSresult);
            grpSenderResults.Controls.Add(lblExchangeSender);
            grpSenderResults.Controls.Add(lblMessageSenderResult);
            grpSenderResults.Controls.Add(cboSenderResult);
            grpSenderResults.Enabled = false;
            grpSenderResults.Location = new Point(27, 495);
            grpSenderResults.Margin = new Padding(3, 4, 3, 4);
            grpSenderResults.Name = "grpSenderResults";
            grpSenderResults.Padding = new Padding(3, 4, 3, 4);
            grpSenderResults.Size = new Size(791, 228);
            grpSenderResults.TabIndex = 9;
            grpSenderResults.TabStop = false;
            grpSenderResults.Text = "Sender Results";
            grpSenderResults.Enter += grpSenderResults_Enter;
            // 
            // txtOBSSenderResult
            // 
            txtOBSSenderResult.Enabled = false;
            txtOBSSenderResult.Location = new Point(19, 165);
            txtOBSSenderResult.Margin = new Padding(3, 4, 3, 4);
            txtOBSSenderResult.Name = "txtOBSSenderResult";
            txtOBSSenderResult.Size = new Size(754, 27);
            txtOBSSenderResult.TabIndex = 3;
            // 
            // txtExchSenderResult
            // 
            txtExchSenderResult.Enabled = false;
            txtExchSenderResult.Location = new Point(19, 108);
            txtExchSenderResult.Margin = new Padding(3, 4, 3, 4);
            txtExchSenderResult.Name = "txtExchSenderResult";
            txtExchSenderResult.Size = new Size(754, 27);
            txtExchSenderResult.TabIndex = 2;
            txtExchSenderResult.TextChanged += txtExchSenderResult_TextChanged;
            // 
            // lblOBSresult
            // 
            lblOBSresult.AutoSize = true;
            lblOBSresult.Location = new Point(19, 141);
            lblOBSresult.Name = "lblOBSresult";
            lblOBSresult.Size = new Size(84, 20);
            lblOBSresult.TabIndex = 1;
            lblOBSresult.Text = "OBS Result:";
            // 
            // lblExchangeSender
            // 
            lblExchangeSender.AutoSize = true;
            lblExchangeSender.Location = new Point(19, 83);
            lblExchangeSender.Name = "lblExchangeSender";
            lblExchangeSender.Size = new Size(119, 20);
            lblExchangeSender.TabIndex = 0;
            lblExchangeSender.Text = "Exchange Result:";
            // 
            // cboSenderResult
            // 
            cboSenderResult.FormattingEnabled = true;
            cboSenderResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboSenderResult.Location = new Point(114, 29);
            cboSenderResult.Margin = new Padding(3, 4, 3, 4);
            cboSenderResult.Name = "cboSenderResult";
            cboSenderResult.Size = new Size(162, 28);
            cboSenderResult.TabIndex = 10;
            cboSenderResult.SelectedIndexChanged += cboSenderResult_SelectedIndexChanged;
            // 
            // dtExchMessageRecievedTime
            // 
            dtExchMessageRecievedTime.CustomFormat = "MM-dd-yyyy HH:mm";
            dtExchMessageRecievedTime.Enabled = false;
            dtExchMessageRecievedTime.Format = DateTimePickerFormat.Custom;
            dtExchMessageRecievedTime.Location = new Point(19, 107);
            dtExchMessageRecievedTime.Margin = new Padding(3, 4, 3, 4);
            dtExchMessageRecievedTime.Name = "dtExchMessageRecievedTime";
            dtExchMessageRecievedTime.Size = new Size(283, 27);
            dtExchMessageRecievedTime.TabIndex = 13;
            dtExchMessageRecievedTime.Value = new DateTime(2023, 8, 2, 15, 53, 51, 0);
            // 
            // grpMessageReceivedTIme
            // 
            grpMessageReceivedTIme.Controls.Add(dtOBSMessageReceivedTime);
            grpMessageReceivedTIme.Controls.Add(label1);
            grpMessageReceivedTIme.Controls.Add(dtExchMessageRecievedTime);
            grpMessageReceivedTIme.Controls.Add(label2);
            grpMessageReceivedTIme.Controls.Add(label3);
            grpMessageReceivedTIme.Controls.Add(cboReceivedTimeResult);
            grpMessageReceivedTIme.Enabled = false;
            grpMessageReceivedTIme.Location = new Point(27, 259);
            grpMessageReceivedTIme.Margin = new Padding(3, 4, 3, 4);
            grpMessageReceivedTIme.Name = "grpMessageReceivedTIme";
            grpMessageReceivedTIme.Padding = new Padding(3, 4, 3, 4);
            grpMessageReceivedTIme.Size = new Size(791, 228);
            grpMessageReceivedTIme.TabIndex = 11;
            grpMessageReceivedTIme.TabStop = false;
            grpMessageReceivedTIme.Text = "Received Time Results";
            // 
            // dtOBSMessageReceivedTime
            // 
            dtOBSMessageReceivedTime.CustomFormat = "MM-dd-yyyy HH:mm";
            dtOBSMessageReceivedTime.Enabled = false;
            dtOBSMessageReceivedTime.Format = DateTimePickerFormat.Custom;
            dtOBSMessageReceivedTime.Location = new Point(19, 165);
            dtOBSMessageReceivedTime.Margin = new Padding(3, 4, 3, 4);
            dtOBSMessageReceivedTime.Name = "dtOBSMessageReceivedTime";
            dtOBSMessageReceivedTime.Size = new Size(283, 27);
            dtOBSMessageReceivedTime.TabIndex = 14;
            dtOBSMessageReceivedTime.Value = new DateTime(2023, 8, 2, 15, 53, 51, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 141);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 1;
            label1.Text = "OBS Result:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 83);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 0;
            label2.Text = "Exchange Result:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 39);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 6;
            label3.Text = "Audit Result: ";
            label3.Click += label3_Click;
            // 
            // cboReceivedTimeResult
            // 
            cboReceivedTimeResult.FormattingEnabled = true;
            cboReceivedTimeResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboReceivedTimeResult.Location = new Point(114, 29);
            cboReceivedTimeResult.Margin = new Padding(3, 4, 3, 4);
            cboReceivedTimeResult.Name = "cboReceivedTimeResult";
            cboReceivedTimeResult.Size = new Size(162, 28);
            cboReceivedTimeResult.TabIndex = 10;
            cboReceivedTimeResult.SelectedIndexChanged += cboReceivedTimeResult_SelectedIndexChanged;
            // 
            // grpOverallAudit
            // 
            grpOverallAudit.Controls.Add(label11);
            grpOverallAudit.Controls.Add(txtOriginMailbox);
            grpOverallAudit.Controls.Add(label10);
            grpOverallAudit.Controls.Add(txtJounalEmailId);
            grpOverallAudit.Controls.Add(label9);
            grpOverallAudit.Controls.Add(txtJournaledMailbox);
            grpOverallAudit.Controls.Add(txtOBSObject);
            grpOverallAudit.Controls.Add(label8);
            grpOverallAudit.Controls.Add(cboOverallAuditResult);
            grpOverallAudit.Controls.Add(label4);
            grpOverallAudit.Controls.Add(lblMessageID);
            grpOverallAudit.Controls.Add(txtMessageID);
            grpOverallAudit.Controls.Add(dtAuditDate);
            grpOverallAudit.Controls.Add(dtAuditDateTime);
            grpOverallAudit.Location = new Point(27, 56);
            grpOverallAudit.Margin = new Padding(3, 4, 3, 4);
            grpOverallAudit.Name = "grpOverallAudit";
            grpOverallAudit.Padding = new Padding(3, 4, 3, 4);
            grpOverallAudit.Size = new Size(1729, 195);
            grpOverallAudit.TabIndex = 12;
            grpOverallAudit.TabStop = false;
            grpOverallAudit.Text = "Audit Information";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1070, 80);
            label11.Name = "label11";
            label11.Size = new Size(111, 20);
            label11.TabIndex = 19;
            label11.Text = "Origin Mailbox:";
            // 
            // txtOriginMailbox
            // 
            txtOriginMailbox.Location = new Point(1184, 69);
            txtOriginMailbox.Margin = new Padding(3, 4, 3, 4);
            txtOriginMailbox.Name = "txtOriginMailbox";
            txtOriginMailbox.Size = new Size(369, 27);
            txtOriginMailbox.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(536, 80);
            label10.Name = "label10";
            label10.Size = new Size(119, 20);
            label10.TabIndex = 17;
            label10.Text = "Journal Email ID:";
            // 
            // txtJounalEmailId
            // 
            txtJounalEmailId.Location = new Point(650, 69);
            txtJounalEmailId.Margin = new Padding(3, 4, 3, 4);
            txtJounalEmailId.Name = "txtJounalEmailId";
            txtJounalEmailId.Size = new Size(369, 27);
            txtJounalEmailId.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 87);
            label9.Name = "label9";
            label9.Size = new Size(129, 20);
            label9.TabIndex = 15;
            label9.Text = "Jounaled Mailbox:";
            // 
            // txtJournaledMailbox
            // 
            txtJournaledMailbox.Location = new Point(137, 76);
            txtJournaledMailbox.Margin = new Padding(3, 4, 3, 4);
            txtJournaledMailbox.Name = "txtJournaledMailbox";
            txtJournaledMailbox.Size = new Size(369, 27);
            txtJournaledMailbox.TabIndex = 16;
            // 
            // txtOBSObject
            // 
            txtOBSObject.Location = new Point(709, 21);
            txtOBSObject.Margin = new Padding(3, 4, 3, 4);
            txtOBSObject.Name = "txtOBSObject";
            txtOBSObject.Size = new Size(863, 27);
            txtOBSObject.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(594, 32);
            label8.Name = "label8";
            label8.Size = new Size(118, 20);
            label8.TabIndex = 13;
            label8.Text = "OBS Object URL:";
            // 
            // cboOverallAuditResult
            // 
            cboOverallAuditResult.FormattingEnabled = true;
            cboOverallAuditResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboOverallAuditResult.Location = new Point(1070, 143);
            cboOverallAuditResult.Margin = new Padding(3, 4, 3, 4);
            cboOverallAuditResult.Name = "cboOverallAuditResult";
            cboOverallAuditResult.Size = new Size(162, 28);
            cboOverallAuditResult.TabIndex = 12;
            cboOverallAuditResult.SelectedIndexChanged += cboOverallAuditResult_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(975, 149);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 11;
            label4.Text = "Audit Result: ";
            // 
            // grpTOResults
            // 
            grpTOResults.Controls.Add(txtOBSToResult);
            grpTOResults.Controls.Add(txtExchToResult);
            grpTOResults.Controls.Add(label5);
            grpTOResults.Controls.Add(label6);
            grpTOResults.Controls.Add(label7);
            grpTOResults.Controls.Add(cboToAuditResult);
            grpTOResults.Enabled = false;
            grpTOResults.Location = new Point(27, 744);
            grpTOResults.Margin = new Padding(3, 4, 3, 4);
            grpTOResults.Name = "grpTOResults";
            grpTOResults.Padding = new Padding(3, 4, 3, 4);
            grpTOResults.Size = new Size(791, 228);
            grpTOResults.TabIndex = 11;
            grpTOResults.TabStop = false;
            grpTOResults.Text = "To Results";
            // 
            // txtOBSToResult
            // 
            txtOBSToResult.Enabled = false;
            txtOBSToResult.Location = new Point(19, 165);
            txtOBSToResult.Margin = new Padding(3, 4, 3, 4);
            txtOBSToResult.Name = "txtOBSToResult";
            txtOBSToResult.Size = new Size(754, 27);
            txtOBSToResult.TabIndex = 3;
            // 
            // txtExchToResult
            // 
            txtExchToResult.Enabled = false;
            txtExchToResult.Location = new Point(19, 108);
            txtExchToResult.Margin = new Padding(3, 4, 3, 4);
            txtExchToResult.Name = "txtExchToResult";
            txtExchToResult.Size = new Size(754, 27);
            txtExchToResult.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 141);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 1;
            label5.Text = "OBS Result:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 83);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 0;
            label6.Text = "Exchange Result:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 39);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 6;
            label7.Text = "Audit Result: ";
            // 
            // cboToAuditResult
            // 
            cboToAuditResult.FormattingEnabled = true;
            cboToAuditResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboToAuditResult.Location = new Point(114, 29);
            cboToAuditResult.Margin = new Padding(3, 4, 3, 4);
            cboToAuditResult.Name = "cboToAuditResult";
            cboToAuditResult.Size = new Size(162, 28);
            cboToAuditResult.TabIndex = 10;
            cboToAuditResult.SelectedIndexChanged += cboToAuditResult_SelectedIndexChanged;
            // 
            // grpCCresults
            // 
            grpCCresults.Controls.Add(txtCCobsresult);
            grpCCresults.Controls.Add(txtCCExchResult);
            grpCCresults.Controls.Add(cboCCAuditResult);
            grpCCresults.Controls.Add(label13);
            grpCCresults.Controls.Add(label12);
            grpCCresults.Controls.Add(lblCCAuditResult);
            grpCCresults.Enabled = false;
            grpCCresults.Location = new Point(34, 995);
            grpCCresults.Margin = new Padding(3, 4, 3, 4);
            grpCCresults.Name = "grpCCresults";
            grpCCresults.Padding = new Padding(3, 4, 3, 4);
            grpCCresults.Size = new Size(784, 212);
            grpCCresults.TabIndex = 13;
            grpCCresults.TabStop = false;
            grpCCresults.Text = "CC Results";
            // 
            // txtCCobsresult
            // 
            txtCCobsresult.Enabled = false;
            txtCCobsresult.Location = new Point(30, 172);
            txtCCobsresult.Margin = new Padding(3, 4, 3, 4);
            txtCCobsresult.Name = "txtCCobsresult";
            txtCCobsresult.Size = new Size(708, 27);
            txtCCobsresult.TabIndex = 5;
            // 
            // txtCCExchResult
            // 
            txtCCExchResult.Enabled = false;
            txtCCExchResult.Location = new Point(25, 112);
            txtCCExchResult.Margin = new Padding(3, 4, 3, 4);
            txtCCExchResult.Name = "txtCCExchResult";
            txtCCExchResult.Size = new Size(713, 27);
            txtCCExchResult.TabIndex = 4;
            // 
            // cboCCAuditResult
            // 
            cboCCAuditResult.FormattingEnabled = true;
            cboCCAuditResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboCCAuditResult.Location = new Point(114, 32);
            cboCCAuditResult.Margin = new Padding(3, 4, 3, 4);
            cboCCAuditResult.Name = "cboCCAuditResult";
            cboCCAuditResult.Size = new Size(172, 28);
            cboCCAuditResult.TabIndex = 3;
            cboCCAuditResult.SelectedIndexChanged += cboCCAuditResult_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(22, 147);
            label13.Name = "label13";
            label13.Size = new Size(84, 20);
            label13.TabIndex = 2;
            label13.Text = "OBS Result:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 80);
            label12.Name = "label12";
            label12.Size = new Size(119, 20);
            label12.TabIndex = 1;
            label12.Text = "Exchange Result:";
            // 
            // lblCCAuditResult
            // 
            lblCCAuditResult.AutoSize = true;
            lblCCAuditResult.Location = new Point(22, 36);
            lblCCAuditResult.Name = "lblCCAuditResult";
            lblCCAuditResult.Size = new Size(92, 20);
            lblCCAuditResult.TabIndex = 0;
            lblCCAuditResult.Text = "Audit Result:";
            // 
            // frmEmailAuditReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1979, 1244);
            Controls.Add(grpCCresults);
            Controls.Add(grpTOResults);
            Controls.Add(grpOverallAudit);
            Controls.Add(grpMessageReceivedTIme);
            Controls.Add(grpSenderResults);
            Controls.Add(btnSubmit);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmEmailAuditReport";
            Text = "Email Audit Report";
            grpSenderResults.ResumeLayout(false);
            grpSenderResults.PerformLayout();
            grpMessageReceivedTIme.ResumeLayout(false);
            grpMessageReceivedTIme.PerformLayout();
            grpOverallAudit.ResumeLayout(false);
            grpOverallAudit.PerformLayout();
            grpTOResults.ResumeLayout(false);
            grpTOResults.PerformLayout();
            grpCCresults.ResumeLayout(false);
            grpCCresults.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblMessageID;
        private TextBox txtMessageID;
        private Button btnSubmit;
        private Label dtAuditDate;
        private DateTimePicker dtAuditDateTime;
        private Label lblMessageSenderResult;
        private GroupBox grpSenderResults;
        private TextBox txtExchSenderResult;
        private Label lblOBSresult;
        private Label lblExchangeSender;
        private TextBox txtOBSSenderResult;
        private ComboBox cboSenderResult;
        private DateTimePicker dtExchMessageRecievedTime;
        private GroupBox grpMessageReceivedTIme;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboReceivedTimeResult;
        private DateTimePicker dtOBSMessageReceivedTime;
        private GroupBox grpOverallAudit;
        private ComboBox cboOverallAuditResult;
        private Label label4;
        private GroupBox grpTOResults;
        private TextBox txtOBSToResult;
        private TextBox txtExchToResult;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cboToAuditResult;
        private Label label9;
        private TextBox txtJournaledMailbox;
        private TextBox txtOBSObject;
        private Label label8;
        private Label label10;
        private TextBox txtJounalEmailId;
        private Label label11;
        private TextBox txtOriginMailbox;
        private GroupBox grpCCresults;
        private Label lblCCAuditResult;
        private TextBox txtCCExchResult;
        private ComboBox cboCCAuditResult;
        private Label label13;
        private Label label12;
        private TextBox txtCCobsresult;
    }
}