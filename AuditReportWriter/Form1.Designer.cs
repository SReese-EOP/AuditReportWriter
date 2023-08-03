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
            cboOverallAuditResult = new ComboBox();
            label4 = new Label();
            grpTOResults = new GroupBox();
            txtOBSToResult = new TextBox();
            txtExchToResult = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cboToAuditResult = new ComboBox();
            label8 = new Label();
            txtOBSObject = new TextBox();
            label9 = new Label();
            txtJournaledMailbox = new TextBox();
            label10 = new Label();
            txtJounalEmailId = new TextBox();
            label11 = new Label();
            txtOriginMailbox = new TextBox();
            grpSenderResults.SuspendLayout();
            grpMessageReceivedTIme.SuspendLayout();
            grpOverallAudit.SuspendLayout();
            grpTOResults.SuspendLayout();
            SuspendLayout();
            // 
            // lblMessageID
            // 
            lblMessageID.AutoSize = true;
            lblMessageID.Location = new Point(17, 30);
            lblMessageID.Name = "lblMessageID";
            lblMessageID.Size = new Size(70, 15);
            lblMessageID.TabIndex = 0;
            lblMessageID.Text = "Message ID:";
            // 
            // txtMessageID
            // 
            txtMessageID.Location = new Point(100, 22);
            txtMessageID.Name = "txtMessageID";
            txtMessageID.Size = new Size(323, 23);
            txtMessageID.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Enabled = false;
            btnSubmit.Location = new Point(1335, 809);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(172, 23);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "&Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // dtAuditDate
            // 
            dtAuditDate.AutoSize = true;
            dtAuditDate.Location = new Point(16, 112);
            dtAuditDate.Name = "dtAuditDate";
            dtAuditDate.Size = new Size(97, 15);
            dtAuditDate.TabIndex = 3;
            dtAuditDate.Text = "Audit Date/TIme:";
            // 
            // dtAuditDateTime
            // 
            dtAuditDateTime.CustomFormat = "MM-dd-yyyy HH:mm";
            dtAuditDateTime.Format = DateTimePickerFormat.Custom;
            dtAuditDateTime.Location = new Point(120, 101);
            dtAuditDateTime.Name = "dtAuditDateTime";
            dtAuditDateTime.Size = new Size(303, 23);
            dtAuditDateTime.TabIndex = 4;
            dtAuditDateTime.Value = new DateTime(2023, 8, 2, 15, 53, 51, 0);
            // 
            // lblMessageSenderResult
            // 
            lblMessageSenderResult.AutoSize = true;
            lblMessageSenderResult.Location = new Point(17, 29);
            lblMessageSenderResult.Name = "lblMessageSenderResult";
            lblMessageSenderResult.Size = new Size(77, 15);
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
            grpSenderResults.Location = new Point(24, 371);
            grpSenderResults.Name = "grpSenderResults";
            grpSenderResults.Size = new Size(692, 171);
            grpSenderResults.TabIndex = 9;
            grpSenderResults.TabStop = false;
            grpSenderResults.Text = "Sender Results";
            grpSenderResults.Enter += grpSenderResults_Enter;
            // 
            // txtOBSSenderResult
            // 
            txtOBSSenderResult.Enabled = false;
            txtOBSSenderResult.Location = new Point(17, 124);
            txtOBSSenderResult.Name = "txtOBSSenderResult";
            txtOBSSenderResult.Size = new Size(660, 23);
            txtOBSSenderResult.TabIndex = 3;
            // 
            // txtExchSenderResult
            // 
            txtExchSenderResult.Enabled = false;
            txtExchSenderResult.Location = new Point(17, 81);
            txtExchSenderResult.Name = "txtExchSenderResult";
            txtExchSenderResult.Size = new Size(660, 23);
            txtExchSenderResult.TabIndex = 2;
            // 
            // lblOBSresult
            // 
            lblOBSresult.AutoSize = true;
            lblOBSresult.Location = new Point(17, 106);
            lblOBSresult.Name = "lblOBSresult";
            lblOBSresult.Size = new Size(67, 15);
            lblOBSresult.TabIndex = 1;
            lblOBSresult.Text = "OBS Result:";
            // 
            // lblExchangeSender
            // 
            lblExchangeSender.AutoSize = true;
            lblExchangeSender.Location = new Point(17, 62);
            lblExchangeSender.Name = "lblExchangeSender";
            lblExchangeSender.Size = new Size(96, 15);
            lblExchangeSender.TabIndex = 0;
            lblExchangeSender.Text = "Exchange Result:";
            // 
            // cboSenderResult
            // 
            cboSenderResult.FormattingEnabled = true;
            cboSenderResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboSenderResult.Location = new Point(100, 22);
            cboSenderResult.Name = "cboSenderResult";
            cboSenderResult.Size = new Size(142, 23);
            cboSenderResult.TabIndex = 10;
            cboSenderResult.SelectedIndexChanged += cboSenderResult_SelectedIndexChanged;
            // 
            // dtExchMessageRecievedTime
            // 
            dtExchMessageRecievedTime.CustomFormat = "MM-dd-yyyy HH:mm";
            dtExchMessageRecievedTime.Enabled = false;
            dtExchMessageRecievedTime.Format = DateTimePickerFormat.Custom;
            dtExchMessageRecievedTime.Location = new Point(17, 80);
            dtExchMessageRecievedTime.Name = "dtExchMessageRecievedTime";
            dtExchMessageRecievedTime.Size = new Size(248, 23);
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
            grpMessageReceivedTIme.Location = new Point(24, 194);
            grpMessageReceivedTIme.Name = "grpMessageReceivedTIme";
            grpMessageReceivedTIme.Size = new Size(692, 171);
            grpMessageReceivedTIme.TabIndex = 11;
            grpMessageReceivedTIme.TabStop = false;
            grpMessageReceivedTIme.Text = "Received Time Results";
            // 
            // dtOBSMessageReceivedTime
            // 
            dtOBSMessageReceivedTime.CustomFormat = "MM-dd-yyyy HH:mm";
            dtOBSMessageReceivedTime.Enabled = false;
            dtOBSMessageReceivedTime.Format = DateTimePickerFormat.Custom;
            dtOBSMessageReceivedTime.Location = new Point(17, 124);
            dtOBSMessageReceivedTime.Name = "dtOBSMessageReceivedTime";
            dtOBSMessageReceivedTime.Size = new Size(248, 23);
            dtOBSMessageReceivedTime.TabIndex = 14;
            dtOBSMessageReceivedTime.Value = new DateTime(2023, 8, 2, 15, 53, 51, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 106);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "OBS Result:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 62);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 0;
            label2.Text = "Exchange Result:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 29);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 6;
            label3.Text = "Audit Result: ";
            label3.Click += label3_Click;
            // 
            // cboReceivedTimeResult
            // 
            cboReceivedTimeResult.FormattingEnabled = true;
            cboReceivedTimeResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboReceivedTimeResult.Location = new Point(100, 22);
            cboReceivedTimeResult.Name = "cboReceivedTimeResult";
            cboReceivedTimeResult.Size = new Size(142, 23);
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
            grpOverallAudit.Location = new Point(24, 42);
            grpOverallAudit.Name = "grpOverallAudit";
            grpOverallAudit.Size = new Size(1513, 146);
            grpOverallAudit.TabIndex = 12;
            grpOverallAudit.TabStop = false;
            grpOverallAudit.Text = "Audit Information";
            // 
            // cboOverallAuditResult
            // 
            cboOverallAuditResult.FormattingEnabled = true;
            cboOverallAuditResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboOverallAuditResult.Location = new Point(936, 107);
            cboOverallAuditResult.Name = "cboOverallAuditResult";
            cboOverallAuditResult.Size = new Size(142, 23);
            cboOverallAuditResult.TabIndex = 12;
            cboOverallAuditResult.SelectedIndexChanged += cboOverallAuditResult_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(853, 112);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
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
            grpTOResults.Location = new Point(24, 557);
            grpTOResults.Name = "grpTOResults";
            grpTOResults.Size = new Size(692, 171);
            grpTOResults.TabIndex = 11;
            grpTOResults.TabStop = false;
            grpTOResults.Text = "To Results";
            // 
            // txtOBSToResult
            // 
            txtOBSToResult.Enabled = false;
            txtOBSToResult.Location = new Point(17, 124);
            txtOBSToResult.Name = "txtOBSToResult";
            txtOBSToResult.Size = new Size(660, 23);
            txtOBSToResult.TabIndex = 3;
            // 
            // txtExchToResult
            // 
            txtExchToResult.Enabled = false;
            txtExchToResult.Location = new Point(17, 81);
            txtExchToResult.Name = "txtExchToResult";
            txtExchToResult.Size = new Size(660, 23);
            txtExchToResult.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 106);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 1;
            label5.Text = "OBS Result:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 62);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 0;
            label6.Text = "Exchange Result:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 29);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 6;
            label7.Text = "Audit Result: ";
            // 
            // cboToAuditResult
            // 
            cboToAuditResult.FormattingEnabled = true;
            cboToAuditResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboToAuditResult.Location = new Point(100, 22);
            cboToAuditResult.Name = "cboToAuditResult";
            cboToAuditResult.Size = new Size(142, 23);
            cboToAuditResult.TabIndex = 10;
            cboToAuditResult.SelectedIndexChanged += cboToAuditResult_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(520, 24);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 13;
            label8.Text = "OBS Object URL:";
            // 
            // txtOBSObject
            // 
            txtOBSObject.Location = new Point(620, 16);
            txtOBSObject.Name = "txtOBSObject";
            txtOBSObject.Size = new Size(756, 23);
            txtOBSObject.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 65);
            label9.Name = "label9";
            label9.Size = new Size(103, 15);
            label9.TabIndex = 15;
            label9.Text = "Jounaled Mailbox:";
            // 
            // txtJournaledMailbox
            // 
            txtJournaledMailbox.Location = new Point(120, 57);
            txtJournaledMailbox.Name = "txtJournaledMailbox";
            txtJournaledMailbox.Size = new Size(323, 23);
            txtJournaledMailbox.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(469, 60);
            label10.Name = "label10";
            label10.Size = new Size(94, 15);
            label10.TabIndex = 17;
            label10.Text = "Journal Email ID:";
            // 
            // txtJounalEmailId
            // 
            txtJounalEmailId.Location = new Point(569, 52);
            txtJounalEmailId.Name = "txtJounalEmailId";
            txtJounalEmailId.Size = new Size(323, 23);
            txtJounalEmailId.TabIndex = 18;
            txtJounalEmailId.TextChanged += textBox2_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(936, 60);
            label11.Name = "label11";
            label11.Size = new Size(89, 15);
            label11.TabIndex = 19;
            label11.Text = "Origin Mailbox:";
            // 
            // txtOriginMailbox
            // 
            txtOriginMailbox.Location = new Point(1036, 52);
            txtOriginMailbox.Name = "txtOriginMailbox";
            txtOriginMailbox.Size = new Size(323, 23);
            txtOriginMailbox.TabIndex = 20;
            // 
            // frmEmailAuditReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1549, 844);
            Controls.Add(grpTOResults);
            Controls.Add(grpOverallAudit);
            Controls.Add(grpMessageReceivedTIme);
            Controls.Add(grpSenderResults);
            Controls.Add(btnSubmit);
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
    }
}