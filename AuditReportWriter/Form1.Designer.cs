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
            lblTOOBSResult = new Label();
            lblTOExchangeResult = new Label();
            lblTOAuditResult = new Label();
            cboToAuditResult = new ComboBox();
            grpCCresults = new GroupBox();
            txtCCobsresult = new TextBox();
            txtCCExchResult = new TextBox();
            cboCCAuditResult = new ComboBox();
            lblCCOBSResult = new Label();
            lblCCExchangeResult = new Label();
            lblCCAuditResult = new Label();
            grpBCCResults = new GroupBox();
            txtbccOBSResult = new TextBox();
            lblbccOBSResult = new Label();
            txtbccExchangeResult = new TextBox();
            lblExchangeResult = new Label();
            cbobccAuditResult = new ComboBox();
            lblAuditResult = new Label();
            grpSubjectValue = new GroupBox();
            textBox1 = new TextBox();
            lblSubjectOBSResult = new Label();
            textBox2 = new TextBox();
            lblSubjectExchangeResult = new Label();
            cboSubjectValueResult = new ComboBox();
            label17 = new Label();
            grpAttachementResult = new GroupBox();
            textBox3 = new TextBox();
            lblAttachementOBSResult = new Label();
            textBox4 = new TextBox();
            lblAttachementExchangeResult = new Label();
            cboAttachementAuditResult = new ComboBox();
            lblAttachementAuditResult = new Label();
            grpBodyValue = new GroupBox();
            textBox5 = new TextBox();
            lblBodyValueOBSResult = new Label();
            textBox6 = new TextBox();
            lblBodyExchangeResult = new Label();
            cboBodyValueResult = new ComboBox();
            lblBodyValueAuditResult = new Label();
            bttnReturnNav = new Button();
            grpSenderResults.SuspendLayout();
            grpMessageReceivedTIme.SuspendLayout();
            grpOverallAudit.SuspendLayout();
            grpTOResults.SuspendLayout();
            grpCCresults.SuspendLayout();
            grpBCCResults.SuspendLayout();
            grpSubjectValue.SuspendLayout();
            grpAttachementResult.SuspendLayout();
            grpBodyValue.SuspendLayout();
            SuspendLayout();
            // 
            // lblMessageID
            // 
            lblMessageID.AutoSize = true;
<<<<<<< HEAD
            lblMessageID.Location = new Point(17, 30);
            lblMessageID.Name = "lblMessageID";
            lblMessageID.Size = new Size(70, 15);
=======
            lblMessageID.Location = new Point(19, 40);
            lblMessageID.Name = "lblMessageID";
            lblMessageID.Size = new Size(89, 20);
>>>>>>> Kayla
            lblMessageID.TabIndex = 0;
            lblMessageID.Text = "Message ID:";
            // 
            // txtMessageID
            // 
<<<<<<< HEAD
            txtMessageID.Location = new Point(100, 22);
            txtMessageID.Name = "txtMessageID";
            txtMessageID.Size = new Size(323, 23);
=======
            txtMessageID.Location = new Point(114, 30);
            txtMessageID.Margin = new Padding(3, 4, 3, 4);
            txtMessageID.Name = "txtMessageID";
            txtMessageID.Size = new Size(369, 27);
>>>>>>> Kayla
            txtMessageID.TabIndex = 1;
            // 
            // btnSubmit
            // 
<<<<<<< HEAD
            btnSubmit.Location = new Point(1559, 923);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(172, 23);
=======
            btnSubmit.Location = new Point(1782, 1230);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(197, 30);
>>>>>>> Kayla
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "&Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // dtAuditDate
            // 
            dtAuditDate.AutoSize = true;
<<<<<<< HEAD
            dtAuditDate.Location = new Point(16, 112);
            dtAuditDate.Name = "dtAuditDate";
            dtAuditDate.Size = new Size(97, 15);
=======
            dtAuditDate.Location = new Point(18, 150);
            dtAuditDate.Name = "dtAuditDate";
            dtAuditDate.Size = new Size(123, 20);
>>>>>>> Kayla
            dtAuditDate.TabIndex = 3;
            dtAuditDate.Text = "Audit Date/TIme:";
            // 
            // dtAuditDateTime
            // 
            dtAuditDateTime.CustomFormat = "MM-dd-yyyy HH:mm";
            dtAuditDateTime.Format = DateTimePickerFormat.Custom;
<<<<<<< HEAD
            dtAuditDateTime.Location = new Point(120, 101);
            dtAuditDateTime.Name = "dtAuditDateTime";
            dtAuditDateTime.Size = new Size(303, 23);
=======
            dtAuditDateTime.Location = new Point(137, 134);
            dtAuditDateTime.Margin = new Padding(3, 4, 3, 4);
            dtAuditDateTime.Name = "dtAuditDateTime";
            dtAuditDateTime.Size = new Size(346, 27);
>>>>>>> Kayla
            dtAuditDateTime.TabIndex = 4;
            dtAuditDateTime.Value = new DateTime(2023, 8, 2, 15, 53, 51, 0);
            dtAuditDateTime.ValueChanged += dtAuditDateTime_ValueChanged;
            // 
            // lblMessageSenderResult
            // 
            lblMessageSenderResult.AutoSize = true;
<<<<<<< HEAD
            lblMessageSenderResult.Location = new Point(17, 29);
            lblMessageSenderResult.Name = "lblMessageSenderResult";
            lblMessageSenderResult.Size = new Size(77, 15);
=======
            lblMessageSenderResult.Location = new Point(19, 38);
            lblMessageSenderResult.Name = "lblMessageSenderResult";
            lblMessageSenderResult.Size = new Size(96, 20);
>>>>>>> Kayla
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
<<<<<<< HEAD
            grpSenderResults.Location = new Point(24, 371);
            grpSenderResults.Name = "grpSenderResults";
            grpSenderResults.Size = new Size(692, 171);
=======
            grpSenderResults.Location = new Point(27, 494);
            grpSenderResults.Margin = new Padding(3, 4, 3, 4);
            grpSenderResults.Name = "grpSenderResults";
            grpSenderResults.Padding = new Padding(3, 4, 3, 4);
            grpSenderResults.Size = new Size(791, 228);
>>>>>>> Kayla
            grpSenderResults.TabIndex = 9;
            grpSenderResults.TabStop = false;
            grpSenderResults.Text = "Sender Results";
            grpSenderResults.Enter += grpSenderResults_Enter;
            // 
            // txtOBSSenderResult
            // 
            txtOBSSenderResult.Enabled = false;
<<<<<<< HEAD
            txtOBSSenderResult.Location = new Point(17, 124);
            txtOBSSenderResult.Name = "txtOBSSenderResult";
            txtOBSSenderResult.Size = new Size(660, 23);
=======
            txtOBSSenderResult.Location = new Point(19, 166);
            txtOBSSenderResult.Margin = new Padding(3, 4, 3, 4);
            txtOBSSenderResult.Name = "txtOBSSenderResult";
            txtOBSSenderResult.Size = new Size(754, 27);
>>>>>>> Kayla
            txtOBSSenderResult.TabIndex = 3;
            // 
            // txtExchSenderResult
            // 
            txtExchSenderResult.Enabled = false;
<<<<<<< HEAD
            txtExchSenderResult.Location = new Point(17, 81);
            txtExchSenderResult.Name = "txtExchSenderResult";
            txtExchSenderResult.Size = new Size(660, 23);
=======
            txtExchSenderResult.Location = new Point(19, 108);
            txtExchSenderResult.Margin = new Padding(3, 4, 3, 4);
            txtExchSenderResult.Name = "txtExchSenderResult";
            txtExchSenderResult.Size = new Size(754, 27);
>>>>>>> Kayla
            txtExchSenderResult.TabIndex = 2;
            // 
            // lblOBSresult
            // 
            lblOBSresult.AutoSize = true;
<<<<<<< HEAD
            lblOBSresult.Location = new Point(17, 106);
            lblOBSresult.Name = "lblOBSresult";
            lblOBSresult.Size = new Size(67, 15);
=======
            lblOBSresult.Location = new Point(19, 142);
            lblOBSresult.Name = "lblOBSresult";
            lblOBSresult.Size = new Size(84, 20);
>>>>>>> Kayla
            lblOBSresult.TabIndex = 1;
            lblOBSresult.Text = "OBS Result:";
            // 
            // lblExchangeSender
            // 
            lblExchangeSender.AutoSize = true;
<<<<<<< HEAD
            lblExchangeSender.Location = new Point(17, 62);
            lblExchangeSender.Name = "lblExchangeSender";
            lblExchangeSender.Size = new Size(96, 15);
=======
            lblExchangeSender.Location = new Point(19, 82);
            lblExchangeSender.Name = "lblExchangeSender";
            lblExchangeSender.Size = new Size(119, 20);
>>>>>>> Kayla
            lblExchangeSender.TabIndex = 0;
            lblExchangeSender.Text = "Exchange Result:";
            // 
            // cboSenderResult
            // 
            cboSenderResult.FormattingEnabled = true;
            cboSenderResult.Items.AddRange(new object[] { "PASS", "FAIL" });
<<<<<<< HEAD
            cboSenderResult.Location = new Point(100, 22);
            cboSenderResult.Name = "cboSenderResult";
            cboSenderResult.Size = new Size(142, 23);
=======
            cboSenderResult.Location = new Point(114, 30);
            cboSenderResult.Margin = new Padding(3, 4, 3, 4);
            cboSenderResult.Name = "cboSenderResult";
            cboSenderResult.Size = new Size(162, 28);
>>>>>>> Kayla
            cboSenderResult.TabIndex = 10;
            cboSenderResult.SelectedIndexChanged += cboSenderResult_SelectedIndexChanged;
            // 
            // dtExchMessageRecievedTime
            // 
            dtExchMessageRecievedTime.CustomFormat = "MM-dd-yyyy HH:mm";
            dtExchMessageRecievedTime.Enabled = false;
            dtExchMessageRecievedTime.Format = DateTimePickerFormat.Custom;
<<<<<<< HEAD
            dtExchMessageRecievedTime.Location = new Point(17, 80);
            dtExchMessageRecievedTime.Name = "dtExchMessageRecievedTime";
            dtExchMessageRecievedTime.Size = new Size(248, 23);
=======
            dtExchMessageRecievedTime.Location = new Point(19, 106);
            dtExchMessageRecievedTime.Margin = new Padding(3, 4, 3, 4);
            dtExchMessageRecievedTime.Name = "dtExchMessageRecievedTime";
            dtExchMessageRecievedTime.Size = new Size(283, 27);
>>>>>>> Kayla
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
<<<<<<< HEAD
            grpMessageReceivedTIme.Location = new Point(24, 194);
            grpMessageReceivedTIme.Name = "grpMessageReceivedTIme";
            grpMessageReceivedTIme.Size = new Size(692, 171);
=======
            grpMessageReceivedTIme.Location = new Point(27, 258);
            grpMessageReceivedTIme.Margin = new Padding(3, 4, 3, 4);
            grpMessageReceivedTIme.Name = "grpMessageReceivedTIme";
            grpMessageReceivedTIme.Padding = new Padding(3, 4, 3, 4);
            grpMessageReceivedTIme.Size = new Size(791, 228);
>>>>>>> Kayla
            grpMessageReceivedTIme.TabIndex = 11;
            grpMessageReceivedTIme.TabStop = false;
            grpMessageReceivedTIme.Text = "Received Time Results";
            // 
            // dtOBSMessageReceivedTime
            // 
            dtOBSMessageReceivedTime.CustomFormat = "MM-dd-yyyy HH:mm";
            dtOBSMessageReceivedTime.Enabled = false;
            dtOBSMessageReceivedTime.Format = DateTimePickerFormat.Custom;
<<<<<<< HEAD
            dtOBSMessageReceivedTime.Location = new Point(17, 124);
            dtOBSMessageReceivedTime.Name = "dtOBSMessageReceivedTime";
            dtOBSMessageReceivedTime.Size = new Size(248, 23);
=======
            dtOBSMessageReceivedTime.Location = new Point(19, 166);
            dtOBSMessageReceivedTime.Margin = new Padding(3, 4, 3, 4);
            dtOBSMessageReceivedTime.Name = "dtOBSMessageReceivedTime";
            dtOBSMessageReceivedTime.Size = new Size(283, 27);
>>>>>>> Kayla
            dtOBSMessageReceivedTime.TabIndex = 14;
            dtOBSMessageReceivedTime.Value = new DateTime(2023, 8, 2, 15, 53, 51, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
<<<<<<< HEAD
            label1.Location = new Point(17, 106);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
=======
            label1.Location = new Point(19, 142);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
>>>>>>> Kayla
            label1.TabIndex = 1;
            label1.Text = "OBS Result:";
            // 
            // label2
            // 
            label2.AutoSize = true;
<<<<<<< HEAD
            label2.Location = new Point(17, 62);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
=======
            label2.Location = new Point(19, 82);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
>>>>>>> Kayla
            label2.TabIndex = 0;
            label2.Text = "Exchange Result:";
            // 
            // label3
            // 
            label3.AutoSize = true;
<<<<<<< HEAD
            label3.Location = new Point(17, 29);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
=======
            label3.Location = new Point(19, 38);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
>>>>>>> Kayla
            label3.TabIndex = 6;
            label3.Text = "Audit Result: ";
            label3.Click += label3_Click;
            // 
            // cboReceivedTimeResult
            // 
            cboReceivedTimeResult.FormattingEnabled = true;
            cboReceivedTimeResult.Items.AddRange(new object[] { "PASS", "FAIL" });
<<<<<<< HEAD
            cboReceivedTimeResult.Location = new Point(100, 22);
            cboReceivedTimeResult.Name = "cboReceivedTimeResult";
            cboReceivedTimeResult.Size = new Size(142, 23);
=======
            cboReceivedTimeResult.Location = new Point(114, 30);
            cboReceivedTimeResult.Margin = new Padding(3, 4, 3, 4);
            cboReceivedTimeResult.Name = "cboReceivedTimeResult";
            cboReceivedTimeResult.Size = new Size(162, 28);
>>>>>>> Kayla
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
<<<<<<< HEAD
            grpOverallAudit.Location = new Point(24, 42);
            grpOverallAudit.Name = "grpOverallAudit";
            grpOverallAudit.Size = new Size(1513, 146);
=======
            grpOverallAudit.Location = new Point(27, 56);
            grpOverallAudit.Margin = new Padding(3, 4, 3, 4);
            grpOverallAudit.Name = "grpOverallAudit";
            grpOverallAudit.Padding = new Padding(3, 4, 3, 4);
            grpOverallAudit.Size = new Size(1729, 194);
>>>>>>> Kayla
            grpOverallAudit.TabIndex = 12;
            grpOverallAudit.TabStop = false;
            grpOverallAudit.Text = "Audit Information";
            // 
            // label11
            // 
            label11.AutoSize = true;
<<<<<<< HEAD
            label11.Location = new Point(936, 60);
            label11.Name = "label11";
            label11.Size = new Size(89, 15);
=======
            label11.Location = new Point(1070, 80);
            label11.Name = "label11";
            label11.Size = new Size(111, 20);
>>>>>>> Kayla
            label11.TabIndex = 19;
            label11.Text = "Origin Mailbox:";
            // 
            // txtOriginMailbox
            // 
<<<<<<< HEAD
            txtOriginMailbox.Location = new Point(1036, 52);
            txtOriginMailbox.Name = "txtOriginMailbox";
            txtOriginMailbox.Size = new Size(323, 23);
=======
            txtOriginMailbox.Location = new Point(1184, 70);
            txtOriginMailbox.Margin = new Padding(3, 4, 3, 4);
            txtOriginMailbox.Name = "txtOriginMailbox";
            txtOriginMailbox.Size = new Size(369, 27);
>>>>>>> Kayla
            txtOriginMailbox.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
<<<<<<< HEAD
            label10.Location = new Point(469, 60);
            label10.Name = "label10";
            label10.Size = new Size(94, 15);
=======
            label10.Location = new Point(536, 80);
            label10.Name = "label10";
            label10.Size = new Size(119, 20);
>>>>>>> Kayla
            label10.TabIndex = 17;
            label10.Text = "Journal Email ID:";
            // 
            // txtJounalEmailId
            // 
<<<<<<< HEAD
            txtJounalEmailId.Location = new Point(569, 52);
            txtJounalEmailId.Name = "txtJounalEmailId";
            txtJounalEmailId.Size = new Size(323, 23);
=======
            txtJounalEmailId.Location = new Point(650, 70);
            txtJounalEmailId.Margin = new Padding(3, 4, 3, 4);
            txtJounalEmailId.Name = "txtJounalEmailId";
            txtJounalEmailId.Size = new Size(369, 27);
>>>>>>> Kayla
            txtJounalEmailId.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
<<<<<<< HEAD
            label9.Location = new Point(17, 65);
            label9.Name = "label9";
            label9.Size = new Size(103, 15);
=======
            label9.Location = new Point(19, 86);
            label9.Name = "label9";
            label9.Size = new Size(129, 20);
>>>>>>> Kayla
            label9.TabIndex = 15;
            label9.Text = "Jounaled Mailbox:";
            // 
            // txtJournaledMailbox
            // 
<<<<<<< HEAD
            txtJournaledMailbox.Location = new Point(120, 57);
            txtJournaledMailbox.Name = "txtJournaledMailbox";
            txtJournaledMailbox.Size = new Size(323, 23);
=======
            txtJournaledMailbox.Location = new Point(137, 76);
            txtJournaledMailbox.Margin = new Padding(3, 4, 3, 4);
            txtJournaledMailbox.Name = "txtJournaledMailbox";
            txtJournaledMailbox.Size = new Size(369, 27);
>>>>>>> Kayla
            txtJournaledMailbox.TabIndex = 16;
            // 
            // txtOBSObject
            // 
<<<<<<< HEAD
            txtOBSObject.Location = new Point(620, 16);
            txtOBSObject.Name = "txtOBSObject";
            txtOBSObject.Size = new Size(756, 23);
=======
            txtOBSObject.Location = new Point(709, 22);
            txtOBSObject.Margin = new Padding(3, 4, 3, 4);
            txtOBSObject.Name = "txtOBSObject";
            txtOBSObject.Size = new Size(863, 27);
>>>>>>> Kayla
            txtOBSObject.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
<<<<<<< HEAD
            label8.Location = new Point(520, 24);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
=======
            label8.Location = new Point(594, 32);
            label8.Name = "label8";
            label8.Size = new Size(118, 20);
>>>>>>> Kayla
            label8.TabIndex = 13;
            label8.Text = "OBS Object URL:";
            // 
            // cboOverallAuditResult
            // 
            cboOverallAuditResult.FormattingEnabled = true;
            cboOverallAuditResult.Items.AddRange(new object[] { "PASS", "FAIL" });
<<<<<<< HEAD
            cboOverallAuditResult.Location = new Point(936, 107);
            cboOverallAuditResult.Name = "cboOverallAuditResult";
            cboOverallAuditResult.Size = new Size(142, 23);
=======
            cboOverallAuditResult.Location = new Point(1070, 142);
            cboOverallAuditResult.Margin = new Padding(3, 4, 3, 4);
            cboOverallAuditResult.Name = "cboOverallAuditResult";
            cboOverallAuditResult.Size = new Size(162, 28);
>>>>>>> Kayla
            cboOverallAuditResult.TabIndex = 12;
            cboOverallAuditResult.SelectedIndexChanged += cboOverallAuditResult_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
<<<<<<< HEAD
            label4.Location = new Point(853, 112);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
=======
            label4.Location = new Point(975, 150);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
>>>>>>> Kayla
            label4.TabIndex = 11;
            label4.Text = "Audit Result: ";
            // 
            // grpTOResults
            // 
            grpTOResults.Controls.Add(txtOBSToResult);
            grpTOResults.Controls.Add(txtExchToResult);
            grpTOResults.Controls.Add(lblTOOBSResult);
            grpTOResults.Controls.Add(lblTOExchangeResult);
            grpTOResults.Controls.Add(lblTOAuditResult);
            grpTOResults.Controls.Add(cboToAuditResult);
            grpTOResults.Enabled = false;
<<<<<<< HEAD
            grpTOResults.Location = new Point(24, 558);
            grpTOResults.Name = "grpTOResults";
            grpTOResults.Size = new Size(692, 171);
=======
            grpTOResults.Location = new Point(27, 744);
            grpTOResults.Margin = new Padding(3, 4, 3, 4);
            grpTOResults.Name = "grpTOResults";
            grpTOResults.Padding = new Padding(3, 4, 3, 4);
            grpTOResults.Size = new Size(791, 228);
>>>>>>> Kayla
            grpTOResults.TabIndex = 11;
            grpTOResults.TabStop = false;
            grpTOResults.Text = "To Results";
            // 
            // txtOBSToResult
            // 
            txtOBSToResult.Enabled = false;
<<<<<<< HEAD
            txtOBSToResult.Location = new Point(17, 124);
            txtOBSToResult.Name = "txtOBSToResult";
            txtOBSToResult.Size = new Size(660, 23);
=======
            txtOBSToResult.Location = new Point(19, 166);
            txtOBSToResult.Margin = new Padding(3, 4, 3, 4);
            txtOBSToResult.Name = "txtOBSToResult";
            txtOBSToResult.Size = new Size(754, 27);
>>>>>>> Kayla
            txtOBSToResult.TabIndex = 3;
            // 
            // txtExchToResult
            // 
            txtExchToResult.Enabled = false;
<<<<<<< HEAD
            txtExchToResult.Location = new Point(17, 81);
            txtExchToResult.Name = "txtExchToResult";
            txtExchToResult.Size = new Size(660, 23);
=======
            txtExchToResult.Location = new Point(19, 108);
            txtExchToResult.Margin = new Padding(3, 4, 3, 4);
            txtExchToResult.Name = "txtExchToResult";
            txtExchToResult.Size = new Size(754, 27);
>>>>>>> Kayla
            txtExchToResult.TabIndex = 2;
            // 
            // lblTOOBSResult
            // 
            lblTOOBSResult.AutoSize = true;
<<<<<<< HEAD
            lblTOOBSResult.Location = new Point(17, 106);
            lblTOOBSResult.Name = "lblTOOBSResult";
            lblTOOBSResult.Size = new Size(67, 15);
=======
            lblTOOBSResult.Location = new Point(19, 142);
            lblTOOBSResult.Name = "lblTOOBSResult";
            lblTOOBSResult.Size = new Size(84, 20);
>>>>>>> Kayla
            lblTOOBSResult.TabIndex = 1;
            lblTOOBSResult.Text = "OBS Result:";
            // 
            // lblTOExchangeResult
            // 
            lblTOExchangeResult.AutoSize = true;
<<<<<<< HEAD
            lblTOExchangeResult.Location = new Point(17, 62);
            lblTOExchangeResult.Name = "lblTOExchangeResult";
            lblTOExchangeResult.Size = new Size(96, 15);
=======
            lblTOExchangeResult.Location = new Point(19, 82);
            lblTOExchangeResult.Name = "lblTOExchangeResult";
            lblTOExchangeResult.Size = new Size(119, 20);
>>>>>>> Kayla
            lblTOExchangeResult.TabIndex = 0;
            lblTOExchangeResult.Text = "Exchange Result:";
            // 
            // lblTOAuditResult
            // 
            lblTOAuditResult.AutoSize = true;
<<<<<<< HEAD
            lblTOAuditResult.Location = new Point(17, 29);
            lblTOAuditResult.Name = "lblTOAuditResult";
            lblTOAuditResult.Size = new Size(77, 15);
=======
            lblTOAuditResult.Location = new Point(19, 38);
            lblTOAuditResult.Name = "lblTOAuditResult";
            lblTOAuditResult.Size = new Size(96, 20);
>>>>>>> Kayla
            lblTOAuditResult.TabIndex = 6;
            lblTOAuditResult.Text = "Audit Result: ";
            // 
            // cboToAuditResult
            // 
            cboToAuditResult.FormattingEnabled = true;
            cboToAuditResult.Items.AddRange(new object[] { "PASS", "FAIL" });
<<<<<<< HEAD
            cboToAuditResult.Location = new Point(100, 22);
            cboToAuditResult.Name = "cboToAuditResult";
            cboToAuditResult.Size = new Size(142, 23);
=======
            cboToAuditResult.Location = new Point(114, 30);
            cboToAuditResult.Margin = new Padding(3, 4, 3, 4);
            cboToAuditResult.Name = "cboToAuditResult";
            cboToAuditResult.Size = new Size(162, 28);
>>>>>>> Kayla
            cboToAuditResult.TabIndex = 10;
            cboToAuditResult.SelectedIndexChanged += cboToAuditResult_SelectedIndexChanged;
            // 
            // grpCCresults
            // 
            grpCCresults.Controls.Add(txtCCobsresult);
            grpCCresults.Controls.Add(txtCCExchResult);
            grpCCresults.Controls.Add(cboCCAuditResult);
            grpCCresults.Controls.Add(lblCCOBSResult);
            grpCCresults.Controls.Add(lblCCExchangeResult);
            grpCCresults.Controls.Add(lblCCAuditResult);
            grpCCresults.Enabled = false;
<<<<<<< HEAD
            grpCCresults.Location = new Point(30, 746);
            grpCCresults.Name = "grpCCresults";
            grpCCresults.Size = new Size(686, 159);
=======
            grpCCresults.Location = new Point(34, 994);
            grpCCresults.Margin = new Padding(3, 4, 3, 4);
            grpCCresults.Name = "grpCCresults";
            grpCCresults.Padding = new Padding(3, 4, 3, 4);
            grpCCresults.Size = new Size(784, 212);
>>>>>>> Kayla
            grpCCresults.TabIndex = 13;
            grpCCresults.TabStop = false;
            grpCCresults.Text = "CC Results";
            grpCCresults.Enter += grpCCresults_Enter;
            // 
            // txtCCobsresult
            // 
            txtCCobsresult.Enabled = false;
<<<<<<< HEAD
            txtCCobsresult.Location = new Point(26, 129);
            txtCCobsresult.Name = "txtCCobsresult";
            txtCCobsresult.Size = new Size(620, 23);
=======
            txtCCobsresult.Location = new Point(30, 172);
            txtCCobsresult.Margin = new Padding(3, 4, 3, 4);
            txtCCobsresult.Name = "txtCCobsresult";
            txtCCobsresult.Size = new Size(708, 27);
>>>>>>> Kayla
            txtCCobsresult.TabIndex = 5;
            // 
            // txtCCExchResult
            // 
            txtCCExchResult.Enabled = false;
<<<<<<< HEAD
            txtCCExchResult.Location = new Point(22, 84);
            txtCCExchResult.Name = "txtCCExchResult";
            txtCCExchResult.Size = new Size(624, 23);
=======
            txtCCExchResult.Location = new Point(25, 112);
            txtCCExchResult.Margin = new Padding(3, 4, 3, 4);
            txtCCExchResult.Name = "txtCCExchResult";
            txtCCExchResult.Size = new Size(713, 27);
>>>>>>> Kayla
            txtCCExchResult.TabIndex = 4;
            // 
            // cboCCAuditResult
            // 
            cboCCAuditResult.FormattingEnabled = true;
            cboCCAuditResult.Items.AddRange(new object[] { "PASS", "FAIL" });
<<<<<<< HEAD
            cboCCAuditResult.Location = new Point(100, 24);
            cboCCAuditResult.Name = "cboCCAuditResult";
            cboCCAuditResult.Size = new Size(151, 23);
=======
            cboCCAuditResult.Location = new Point(114, 32);
            cboCCAuditResult.Margin = new Padding(3, 4, 3, 4);
            cboCCAuditResult.Name = "cboCCAuditResult";
            cboCCAuditResult.Size = new Size(172, 28);
>>>>>>> Kayla
            cboCCAuditResult.TabIndex = 3;
            cboCCAuditResult.SelectedIndexChanged += cboCCAuditResult_SelectedIndexChanged;
            // 
            // lblCCOBSResult
            // 
            lblCCOBSResult.AutoSize = true;
<<<<<<< HEAD
            lblCCOBSResult.Location = new Point(19, 110);
            lblCCOBSResult.Name = "lblCCOBSResult";
            lblCCOBSResult.Size = new Size(67, 15);
=======
            lblCCOBSResult.Location = new Point(22, 146);
            lblCCOBSResult.Name = "lblCCOBSResult";
            lblCCOBSResult.Size = new Size(84, 20);
>>>>>>> Kayla
            lblCCOBSResult.TabIndex = 2;
            lblCCOBSResult.Text = "OBS Result:";
            // 
            // lblCCExchangeResult
            // 
            lblCCExchangeResult.AutoSize = true;
<<<<<<< HEAD
            lblCCExchangeResult.Location = new Point(22, 60);
            lblCCExchangeResult.Name = "lblCCExchangeResult";
            lblCCExchangeResult.Size = new Size(96, 15);
=======
            lblCCExchangeResult.Location = new Point(25, 80);
            lblCCExchangeResult.Name = "lblCCExchangeResult";
            lblCCExchangeResult.Size = new Size(119, 20);
>>>>>>> Kayla
            lblCCExchangeResult.TabIndex = 1;
            lblCCExchangeResult.Text = "Exchange Result:";
            // 
            // lblCCAuditResult
            // 
            lblCCAuditResult.AutoSize = true;
<<<<<<< HEAD
            lblCCAuditResult.Location = new Point(19, 27);
            lblCCAuditResult.Name = "lblCCAuditResult";
            lblCCAuditResult.Size = new Size(74, 15);
=======
            lblCCAuditResult.Location = new Point(22, 36);
            lblCCAuditResult.Name = "lblCCAuditResult";
            lblCCAuditResult.Size = new Size(92, 20);
>>>>>>> Kayla
            lblCCAuditResult.TabIndex = 0;
            lblCCAuditResult.Text = "Audit Result:";
            // 
            // grpBCCResults
            // 
            grpBCCResults.Controls.Add(txtbccOBSResult);
            grpBCCResults.Controls.Add(lblbccOBSResult);
            grpBCCResults.Controls.Add(txtbccExchangeResult);
            grpBCCResults.Controls.Add(lblExchangeResult);
            grpBCCResults.Controls.Add(cbobccAuditResult);
            grpBCCResults.Controls.Add(lblAuditResult);
<<<<<<< HEAD
            grpBCCResults.Enabled = false;
            grpBCCResults.Location = new Point(752, 194);
            grpBCCResults.Margin = new Padding(2);
            grpBCCResults.Name = "grpBCCResults";
            grpBCCResults.Padding = new Padding(2);
            grpBCCResults.Size = new Size(785, 171);
=======
            grpBCCResults.Location = new Point(859, 258);
            grpBCCResults.Margin = new Padding(2);
            grpBCCResults.Name = "grpBCCResults";
            grpBCCResults.Padding = new Padding(2);
            grpBCCResults.Size = new Size(897, 228);
>>>>>>> Kayla
            grpBCCResults.TabIndex = 14;
            grpBCCResults.TabStop = false;
            grpBCCResults.Text = "BCC Results";
            grpBCCResults.UseCompatibleTextRendering = true;
            grpBCCResults.Enter += groupBox1_Enter;
            // 
            // txtbccOBSResult
            // 
<<<<<<< HEAD
            txtbccOBSResult.Enabled = false;
            txtbccOBSResult.Location = new Point(58, 124);
            txtbccOBSResult.Margin = new Padding(2);
            txtbccOBSResult.Name = "txtbccOBSResult";
            txtbccOBSResult.Size = new Size(590, 23);
=======
            txtbccOBSResult.Location = new Point(66, 166);
            txtbccOBSResult.Margin = new Padding(2);
            txtbccOBSResult.Name = "txtbccOBSResult";
            txtbccOBSResult.Size = new Size(674, 27);
>>>>>>> Kayla
            txtbccOBSResult.TabIndex = 5;
            // 
            // lblbccOBSResult
            // 
            lblbccOBSResult.AutoSize = true;
<<<<<<< HEAD
            lblbccOBSResult.Location = new Point(55, 107);
            lblbccOBSResult.Margin = new Padding(2, 0, 2, 0);
            lblbccOBSResult.Name = "lblbccOBSResult";
            lblbccOBSResult.Size = new Size(67, 15);
=======
            lblbccOBSResult.Location = new Point(62, 143);
            lblbccOBSResult.Margin = new Padding(2, 0, 2, 0);
            lblbccOBSResult.Name = "lblbccOBSResult";
            lblbccOBSResult.Size = new Size(84, 20);
>>>>>>> Kayla
            lblbccOBSResult.TabIndex = 4;
            lblbccOBSResult.Text = "OBS Result:";
            lblbccOBSResult.Click += lblbccOBSResult_Click;
            // 
            // txtbccExchangeResult
            // 
<<<<<<< HEAD
            txtbccExchangeResult.Enabled = false;
            txtbccExchangeResult.Location = new Point(55, 82);
            txtbccExchangeResult.Margin = new Padding(2);
            txtbccExchangeResult.Name = "txtbccExchangeResult";
            txtbccExchangeResult.Size = new Size(593, 23);
=======
            txtbccExchangeResult.Location = new Point(62, 109);
            txtbccExchangeResult.Margin = new Padding(2);
            txtbccExchangeResult.Name = "txtbccExchangeResult";
            txtbccExchangeResult.Size = new Size(678, 27);
>>>>>>> Kayla
            txtbccExchangeResult.TabIndex = 3;
            // 
            // lblExchangeResult
            // 
            lblExchangeResult.AutoSize = true;
<<<<<<< HEAD
            lblExchangeResult.Location = new Point(55, 59);
            lblExchangeResult.Margin = new Padding(2, 0, 2, 0);
            lblExchangeResult.Name = "lblExchangeResult";
            lblExchangeResult.Size = new Size(96, 15);
=======
            lblExchangeResult.Location = new Point(62, 78);
            lblExchangeResult.Margin = new Padding(2, 0, 2, 0);
            lblExchangeResult.Name = "lblExchangeResult";
            lblExchangeResult.Size = new Size(119, 20);
>>>>>>> Kayla
            lblExchangeResult.TabIndex = 2;
            lblExchangeResult.Text = "Exchange Result:";
            // 
            // cbobccAuditResult
            // 
            cbobccAuditResult.FormattingEnabled = true;
            cbobccAuditResult.Items.AddRange(new object[] { "PASS", "FAIL" });
<<<<<<< HEAD
            cbobccAuditResult.Location = new Point(136, 23);
            cbobccAuditResult.Margin = new Padding(2);
            cbobccAuditResult.Name = "cbobccAuditResult";
            cbobccAuditResult.Size = new Size(129, 23);
=======
            cbobccAuditResult.Location = new Point(156, 30);
            cbobccAuditResult.Margin = new Padding(2);
            cbobccAuditResult.Name = "cbobccAuditResult";
            cbobccAuditResult.Size = new Size(146, 28);
>>>>>>> Kayla
            cbobccAuditResult.TabIndex = 1;
            cbobccAuditResult.SelectedIndexChanged += cbobccAuditResult_SelectedIndexChanged;
            // 
            // lblAuditResult
            // 
            lblAuditResult.AutoSize = true;
<<<<<<< HEAD
            lblAuditResult.Location = new Point(55, 25);
            lblAuditResult.Margin = new Padding(2, 0, 2, 0);
            lblAuditResult.Name = "lblAuditResult";
            lblAuditResult.Size = new Size(74, 15);
            lblAuditResult.TabIndex = 0;
            lblAuditResult.Text = "Audit Result:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(0, 0);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 15;
            label14.Text = "label14";
            // 
=======
            lblAuditResult.Location = new Point(62, 33);
            lblAuditResult.Margin = new Padding(2, 0, 2, 0);
            lblAuditResult.Name = "lblAuditResult";
            lblAuditResult.Size = new Size(92, 20);
            lblAuditResult.TabIndex = 0;
            lblAuditResult.Text = "Audit Result:";
            // 
>>>>>>> Kayla
            // grpSubjectValue
            // 
            grpSubjectValue.Controls.Add(textBox1);
            grpSubjectValue.Controls.Add(lblSubjectOBSResult);
            grpSubjectValue.Controls.Add(textBox2);
            grpSubjectValue.Controls.Add(lblSubjectExchangeResult);
            grpSubjectValue.Controls.Add(cboSubjectValueResult);
            grpSubjectValue.Controls.Add(label17);
<<<<<<< HEAD
            grpSubjectValue.Location = new Point(752, 377);
            grpSubjectValue.Margin = new Padding(2);
            grpSubjectValue.Name = "grpSubjectValue";
            grpSubjectValue.Padding = new Padding(2);
            grpSubjectValue.Size = new Size(785, 164);
=======
            grpSubjectValue.Location = new Point(859, 503);
            grpSubjectValue.Margin = new Padding(2);
            grpSubjectValue.Name = "grpSubjectValue";
            grpSubjectValue.Padding = new Padding(2);
            grpSubjectValue.Size = new Size(897, 219);
>>>>>>> Kayla
            grpSubjectValue.TabIndex = 16;
            grpSubjectValue.TabStop = false;
            grpSubjectValue.Text = "Subject Value Result";
            grpSubjectValue.UseCompatibleTextRendering = true;
            // 
            // textBox1
            // 
<<<<<<< HEAD
            textBox1.Location = new Point(58, 124);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(590, 23);
=======
            textBox1.Location = new Point(66, 166);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(674, 27);
>>>>>>> Kayla
            textBox1.TabIndex = 5;
            // 
            // lblSubjectOBSResult
            // 
            lblSubjectOBSResult.AutoSize = true;
<<<<<<< HEAD
            lblSubjectOBSResult.Location = new Point(55, 107);
            lblSubjectOBSResult.Margin = new Padding(2, 0, 2, 0);
            lblSubjectOBSResult.Name = "lblSubjectOBSResult";
            lblSubjectOBSResult.Size = new Size(67, 15);
=======
            lblSubjectOBSResult.Location = new Point(62, 143);
            lblSubjectOBSResult.Margin = new Padding(2, 0, 2, 0);
            lblSubjectOBSResult.Name = "lblSubjectOBSResult";
            lblSubjectOBSResult.Size = new Size(84, 20);
>>>>>>> Kayla
            lblSubjectOBSResult.TabIndex = 4;
            lblSubjectOBSResult.Text = "OBS Result:";
            // 
            // textBox2
            // 
<<<<<<< HEAD
            textBox2.Location = new Point(55, 82);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(593, 23);
=======
            textBox2.Location = new Point(62, 109);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(678, 27);
>>>>>>> Kayla
            textBox2.TabIndex = 3;
            // 
            // lblSubjectExchangeResult
            // 
            lblSubjectExchangeResult.AutoSize = true;
<<<<<<< HEAD
            lblSubjectExchangeResult.Location = new Point(55, 59);
            lblSubjectExchangeResult.Margin = new Padding(2, 0, 2, 0);
            lblSubjectExchangeResult.Name = "lblSubjectExchangeResult";
            lblSubjectExchangeResult.Size = new Size(96, 15);
=======
            lblSubjectExchangeResult.Location = new Point(62, 78);
            lblSubjectExchangeResult.Margin = new Padding(2, 0, 2, 0);
            lblSubjectExchangeResult.Name = "lblSubjectExchangeResult";
            lblSubjectExchangeResult.Size = new Size(119, 20);
>>>>>>> Kayla
            lblSubjectExchangeResult.TabIndex = 2;
            lblSubjectExchangeResult.Text = "Exchange Result:";
            // 
            // cboSubjectValueResult
            // 
            cboSubjectValueResult.FormattingEnabled = true;
            cboSubjectValueResult.Items.AddRange(new object[] { "PASS", "FAIL" });
<<<<<<< HEAD
            cboSubjectValueResult.Location = new Point(136, 23);
            cboSubjectValueResult.Margin = new Padding(2);
            cboSubjectValueResult.Name = "cboSubjectValueResult";
            cboSubjectValueResult.Size = new Size(129, 23);
=======
            cboSubjectValueResult.Location = new Point(156, 30);
            cboSubjectValueResult.Margin = new Padding(2);
            cboSubjectValueResult.Name = "cboSubjectValueResult";
            cboSubjectValueResult.Size = new Size(146, 28);
>>>>>>> Kayla
            cboSubjectValueResult.TabIndex = 1;
            // 
            // label17
            // 
            label17.AutoSize = true;
<<<<<<< HEAD
            label17.Location = new Point(55, 25);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(74, 15);
=======
            label17.Location = new Point(62, 33);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(92, 20);
>>>>>>> Kayla
            label17.TabIndex = 0;
            label17.Text = "Audit Result:";
            // 
            // grpAttachementResult
            // 
            grpAttachementResult.Controls.Add(textBox3);
            grpAttachementResult.Controls.Add(lblAttachementOBSResult);
            grpAttachementResult.Controls.Add(textBox4);
            grpAttachementResult.Controls.Add(lblAttachementExchangeResult);
            grpAttachementResult.Controls.Add(cboAttachementAuditResult);
            grpAttachementResult.Controls.Add(lblAttachementAuditResult);
<<<<<<< HEAD
            grpAttachementResult.Location = new Point(752, 746);
            grpAttachementResult.Margin = new Padding(2);
            grpAttachementResult.Name = "grpAttachementResult";
            grpAttachementResult.Padding = new Padding(2);
            grpAttachementResult.Size = new Size(785, 164);
=======
            grpAttachementResult.Location = new Point(859, 994);
            grpAttachementResult.Margin = new Padding(2);
            grpAttachementResult.Name = "grpAttachementResult";
            grpAttachementResult.Padding = new Padding(2);
            grpAttachementResult.Size = new Size(897, 219);
>>>>>>> Kayla
            grpAttachementResult.TabIndex = 18;
            grpAttachementResult.TabStop = false;
            grpAttachementResult.Text = "Attachement Result";
            grpAttachementResult.UseCompatibleTextRendering = true;
            // 
            // textBox3
            // 
<<<<<<< HEAD
            textBox3.Location = new Point(58, 124);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(590, 23);
=======
            textBox3.Location = new Point(66, 166);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(674, 27);
>>>>>>> Kayla
            textBox3.TabIndex = 5;
            // 
            // lblAttachementOBSResult
            // 
            lblAttachementOBSResult.AutoSize = true;
<<<<<<< HEAD
            lblAttachementOBSResult.Location = new Point(55, 107);
            lblAttachementOBSResult.Margin = new Padding(2, 0, 2, 0);
            lblAttachementOBSResult.Name = "lblAttachementOBSResult";
            lblAttachementOBSResult.Size = new Size(67, 15);
=======
            lblAttachementOBSResult.Location = new Point(62, 143);
            lblAttachementOBSResult.Margin = new Padding(2, 0, 2, 0);
            lblAttachementOBSResult.Name = "lblAttachementOBSResult";
            lblAttachementOBSResult.Size = new Size(84, 20);
>>>>>>> Kayla
            lblAttachementOBSResult.TabIndex = 4;
            lblAttachementOBSResult.Text = "OBS Result:";
            // 
            // textBox4
            // 
<<<<<<< HEAD
            textBox4.Location = new Point(55, 82);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(593, 23);
=======
            textBox4.Location = new Point(62, 109);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(678, 27);
>>>>>>> Kayla
            textBox4.TabIndex = 3;
            // 
            // lblAttachementExchangeResult
            // 
            lblAttachementExchangeResult.AutoSize = true;
<<<<<<< HEAD
            lblAttachementExchangeResult.Location = new Point(55, 59);
            lblAttachementExchangeResult.Margin = new Padding(2, 0, 2, 0);
            lblAttachementExchangeResult.Name = "lblAttachementExchangeResult";
            lblAttachementExchangeResult.Size = new Size(96, 15);
=======
            lblAttachementExchangeResult.Location = new Point(62, 78);
            lblAttachementExchangeResult.Margin = new Padding(2, 0, 2, 0);
            lblAttachementExchangeResult.Name = "lblAttachementExchangeResult";
            lblAttachementExchangeResult.Size = new Size(119, 20);
>>>>>>> Kayla
            lblAttachementExchangeResult.TabIndex = 2;
            lblAttachementExchangeResult.Text = "Exchange Result:";
            // 
            // cboAttachementAuditResult
            // 
            cboAttachementAuditResult.FormattingEnabled = true;
            cboAttachementAuditResult.Items.AddRange(new object[] { "PASS", "FAIL" });
<<<<<<< HEAD
            cboAttachementAuditResult.Location = new Point(136, 23);
            cboAttachementAuditResult.Margin = new Padding(2);
            cboAttachementAuditResult.Name = "cboAttachementAuditResult";
            cboAttachementAuditResult.Size = new Size(129, 23);
=======
            cboAttachementAuditResult.Location = new Point(156, 30);
            cboAttachementAuditResult.Margin = new Padding(2);
            cboAttachementAuditResult.Name = "cboAttachementAuditResult";
            cboAttachementAuditResult.Size = new Size(146, 28);
>>>>>>> Kayla
            cboAttachementAuditResult.TabIndex = 1;
            // 
            // lblAttachementAuditResult
            // 
            lblAttachementAuditResult.AutoSize = true;
<<<<<<< HEAD
            lblAttachementAuditResult.Location = new Point(55, 25);
            lblAttachementAuditResult.Margin = new Padding(2, 0, 2, 0);
            lblAttachementAuditResult.Name = "lblAttachementAuditResult";
            lblAttachementAuditResult.Size = new Size(74, 15);
=======
            lblAttachementAuditResult.Location = new Point(62, 33);
            lblAttachementAuditResult.Margin = new Padding(2, 0, 2, 0);
            lblAttachementAuditResult.Name = "lblAttachementAuditResult";
            lblAttachementAuditResult.Size = new Size(92, 20);
>>>>>>> Kayla
            lblAttachementAuditResult.TabIndex = 0;
            lblAttachementAuditResult.Text = "Audit Result:";
            // 
            // grpBodyValue
            // 
            grpBodyValue.Controls.Add(textBox5);
            grpBodyValue.Controls.Add(lblBodyValueOBSResult);
            grpBodyValue.Controls.Add(textBox6);
            grpBodyValue.Controls.Add(lblBodyExchangeResult);
            grpBodyValue.Controls.Add(cboBodyValueResult);
            grpBodyValue.Controls.Add(lblBodyValueAuditResult);
<<<<<<< HEAD
            grpBodyValue.Location = new Point(752, 558);
            grpBodyValue.Margin = new Padding(2);
            grpBodyValue.Name = "grpBodyValue";
            grpBodyValue.Padding = new Padding(2);
            grpBodyValue.Size = new Size(785, 171);
=======
            grpBodyValue.Location = new Point(859, 744);
            grpBodyValue.Margin = new Padding(2);
            grpBodyValue.Name = "grpBodyValue";
            grpBodyValue.Padding = new Padding(2);
            grpBodyValue.Size = new Size(897, 228);
>>>>>>> Kayla
            grpBodyValue.TabIndex = 17;
            grpBodyValue.TabStop = false;
            grpBodyValue.Text = "Body Value Result";
            grpBodyValue.UseCompatibleTextRendering = true;
            // 
            // textBox5
            // 
<<<<<<< HEAD
            textBox5.Location = new Point(58, 124);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(590, 23);
=======
            textBox5.Location = new Point(66, 166);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(674, 27);
>>>>>>> Kayla
            textBox5.TabIndex = 5;
            // 
            // lblBodyValueOBSResult
            // 
            lblBodyValueOBSResult.AutoSize = true;
<<<<<<< HEAD
            lblBodyValueOBSResult.Location = new Point(55, 107);
            lblBodyValueOBSResult.Margin = new Padding(2, 0, 2, 0);
            lblBodyValueOBSResult.Name = "lblBodyValueOBSResult";
            lblBodyValueOBSResult.Size = new Size(67, 15);
=======
            lblBodyValueOBSResult.Location = new Point(62, 143);
            lblBodyValueOBSResult.Margin = new Padding(2, 0, 2, 0);
            lblBodyValueOBSResult.Name = "lblBodyValueOBSResult";
            lblBodyValueOBSResult.Size = new Size(84, 20);
>>>>>>> Kayla
            lblBodyValueOBSResult.TabIndex = 4;
            lblBodyValueOBSResult.Text = "OBS Result:";
            // 
            // textBox6
            // 
<<<<<<< HEAD
            textBox6.Location = new Point(55, 82);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(593, 23);
=======
            textBox6.Location = new Point(62, 109);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(678, 27);
>>>>>>> Kayla
            textBox6.TabIndex = 3;
            // 
            // lblBodyExchangeResult
            // 
            lblBodyExchangeResult.AutoSize = true;
<<<<<<< HEAD
            lblBodyExchangeResult.Location = new Point(55, 59);
            lblBodyExchangeResult.Margin = new Padding(2, 0, 2, 0);
            lblBodyExchangeResult.Name = "lblBodyExchangeResult";
            lblBodyExchangeResult.Size = new Size(96, 15);
=======
            lblBodyExchangeResult.Location = new Point(62, 78);
            lblBodyExchangeResult.Margin = new Padding(2, 0, 2, 0);
            lblBodyExchangeResult.Name = "lblBodyExchangeResult";
            lblBodyExchangeResult.Size = new Size(119, 20);
>>>>>>> Kayla
            lblBodyExchangeResult.TabIndex = 2;
            lblBodyExchangeResult.Text = "Exchange Result:";
            // 
            // cboBodyValueResult
            // 
            cboBodyValueResult.FormattingEnabled = true;
            cboBodyValueResult.Items.AddRange(new object[] { "PASS", "FAIL" });
<<<<<<< HEAD
            cboBodyValueResult.Location = new Point(136, 23);
            cboBodyValueResult.Margin = new Padding(2);
            cboBodyValueResult.Name = "cboBodyValueResult";
            cboBodyValueResult.Size = new Size(129, 23);
=======
            cboBodyValueResult.Location = new Point(156, 30);
            cboBodyValueResult.Margin = new Padding(2);
            cboBodyValueResult.Name = "cboBodyValueResult";
            cboBodyValueResult.Size = new Size(146, 28);
>>>>>>> Kayla
            cboBodyValueResult.TabIndex = 1;
            // 
            // lblBodyValueAuditResult
            // 
            lblBodyValueAuditResult.AutoSize = true;
<<<<<<< HEAD
            lblBodyValueAuditResult.Location = new Point(55, 25);
            lblBodyValueAuditResult.Margin = new Padding(2, 0, 2, 0);
            lblBodyValueAuditResult.Name = "lblBodyValueAuditResult";
            lblBodyValueAuditResult.Size = new Size(74, 15);
=======
            lblBodyValueAuditResult.Location = new Point(62, 33);
            lblBodyValueAuditResult.Margin = new Padding(2, 0, 2, 0);
            lblBodyValueAuditResult.Name = "lblBodyValueAuditResult";
            lblBodyValueAuditResult.Size = new Size(92, 20);
>>>>>>> Kayla
            lblBodyValueAuditResult.TabIndex = 0;
            lblBodyValueAuditResult.Text = "Audit Result:";
            lblBodyValueAuditResult.Click += label18_Click;
            // 
            // bttnReturnNav
            // 
            bttnReturnNav.Location = new Point(1443, 11);
            bttnReturnNav.Name = "bttnReturnNav";
            bttnReturnNav.Size = new Size(202, 38);
            bttnReturnNav.TabIndex = 19;
            bttnReturnNav.Text = "Return to Navigation";
            bttnReturnNav.UseVisualStyleBackColor = true;
            bttnReturnNav.Click += bttnReturnNav_Click;
            // 
            // frmEmailAuditReport
            // 
<<<<<<< HEAD
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1993, 970);
=======
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1657, 1093);
            Controls.Add(bttnReturnNav);
>>>>>>> Kayla
            Controls.Add(grpAttachementResult);
            Controls.Add(grpBodyValue);
            Controls.Add(grpSubjectValue);
            Controls.Add(grpBCCResults);
            Controls.Add(grpCCresults);
            Controls.Add(grpTOResults);
            Controls.Add(grpOverallAudit);
            Controls.Add(grpMessageReceivedTIme);
            Controls.Add(grpSenderResults);
            Controls.Add(btnSubmit);
<<<<<<< HEAD
=======
            Margin = new Padding(3, 4, 3, 4);
>>>>>>> Kayla
            Name = "frmEmailAuditReport";
            Text = "Email Audit Report";
            Load += frmEmailAuditReport_Load;
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
            grpBCCResults.ResumeLayout(false);
            grpBCCResults.PerformLayout();
            grpSubjectValue.ResumeLayout(false);
            grpSubjectValue.PerformLayout();
            grpAttachementResult.ResumeLayout(false);
            grpAttachementResult.PerformLayout();
            grpBodyValue.ResumeLayout(false);
            grpBodyValue.PerformLayout();
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
        private Label lblTOOBSResult;
        private Label lblTOExchangeResult;
        private Label lblTOAuditResult;
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
        private Label lblCCOBSResult;
        private Label lblCCExchangeResult;
        private TextBox txtCCobsresult;
        private GroupBox grpBCCResults;
        private Label lblAuditResult;
        private ComboBox cbobccAuditResult;
        private Label lblbccOBSResult;
        private TextBox txtbccExchangeResult;
        private Label lblExchangeResult;
        private TextBox txtbccOBSResult;
        private GroupBox grpSubjectValue;
        private TextBox textBox1;
        private Label lblSubjectOBSResult;
        private TextBox textBox2;
        private Label lblSubjectExchangeResult;
        private ComboBox cboSubjectValueResult;
        private Label label17;
        private GroupBox grpAttachementResult;
        private TextBox textBox3;
        private Label lblAttachementOBSResult;
        private TextBox textBox4;
        private Label lblAttachementExchangeResult;
        private ComboBox cboAttachementAuditResult;
        private Label lblAttachementAuditResult;
        private GroupBox grpBodyValue;
        private TextBox textBox5;
        private Label lblBodyValueOBSResult;
        private TextBox textBox6;
        private Label lblBodyExchangeResult;
        private ComboBox cboBodyValueResult;
        private Label lblBodyValueAuditResult;
        private Button bttnReturnNav;
    }
}