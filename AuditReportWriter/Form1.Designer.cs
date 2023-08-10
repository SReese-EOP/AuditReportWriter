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
            grpReceivedTImeResults = new GroupBox();
            dtOBSMessageReceivedTime = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cboReceivedTimeResult = new ComboBox();
            grpOverallAudit = new GroupBox();
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
            grpSubjectResults = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            txtSubjectOBSResult = new TextBox();
            lblSubjectOBSResult = new Label();
            txtSubjectExchangeResult = new TextBox();
            lblSubjectExchangeResult = new Label();
            cboSubjectValueResult = new ComboBox();
            label17 = new Label();
            grpAttachementResult = new GroupBox();
            txtAttachmentOBSResult = new TextBox();
            lblAttachementOBSResult = new Label();
            txtAttachmentExchangeResult = new TextBox();
            lblAttachementExchangeResult = new Label();
            cboAttachementAuditResult = new ComboBox();
            lblAttachementAuditResult = new Label();
            grpBodyResults = new GroupBox();
            txtBodyOBSResult = new TextBox();
            lblBodyValueOBSResult = new Label();
            txtBodyExchangeResult = new TextBox();
            lblBodyExchangeResult = new Label();
            cboBodyValueResult = new ComboBox();
            lblBodyValueAuditResult = new Label();
            btnReset = new Button();
            bttnReturntoNav = new Button();
            grpSenderResults.SuspendLayout();
            grpReceivedTImeResults.SuspendLayout();
            grpOverallAudit.SuspendLayout();
            grpTOResults.SuspendLayout();
            grpCCresults.SuspendLayout();
            grpBCCResults.SuspendLayout();
            grpSubjectResults.SuspendLayout();
            tabControl1.SuspendLayout();
            grpAttachementResult.SuspendLayout();
            grpBodyResults.SuspendLayout();
            SuspendLayout();
            // 
            // lblMessageID
            // 
            lblMessageID.AutoSize = true;
            lblMessageID.Location = new Point(24, 50);
            lblMessageID.Margin = new Padding(4, 0, 4, 0);
            lblMessageID.Name = "lblMessageID";
            lblMessageID.Size = new Size(109, 25);
            lblMessageID.TabIndex = 0;
            lblMessageID.Text = "Message ID:";
            // 
            // txtMessageID
            // 
            txtMessageID.Location = new Point(142, 36);
            txtMessageID.Margin = new Padding(4, 5, 4, 5);
            txtMessageID.Name = "txtMessageID";
            txtMessageID.Size = new Size(460, 31);
            txtMessageID.TabIndex = 1;
            txtMessageID.TextChanged += txtMessageID_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(1950, 1530);
            btnSubmit.Margin = new Padding(4, 5, 4, 5);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(246, 39);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "&Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // dtAuditDate
            // 
            dtAuditDate.AutoSize = true;
            dtAuditDate.Location = new Point(22, 186);
            dtAuditDate.Margin = new Padding(4, 0, 4, 0);
            dtAuditDate.Name = "dtAuditDate";
            dtAuditDate.Size = new Size(147, 25);
            dtAuditDate.TabIndex = 3;
            dtAuditDate.Text = "Audit Date/TIme:";
            // 
            // dtAuditDateTime
            // 
            dtAuditDateTime.CustomFormat = "MM-dd-yyyy HH:mm";
            dtAuditDateTime.Format = DateTimePickerFormat.Custom;
            dtAuditDateTime.Location = new Point(184, 186);
            dtAuditDateTime.Margin = new Padding(4, 5, 4, 5);
            dtAuditDateTime.Name = "dtAuditDateTime";
            dtAuditDateTime.Size = new Size(432, 31);
            dtAuditDateTime.TabIndex = 4;
            dtAuditDateTime.Value = new DateTime(2023, 8, 2, 15, 53, 51, 0);
            dtAuditDateTime.ValueChanged += dtAuditDateTime_ValueChanged;
            // 
            // lblMessageSenderResult
            // 
            lblMessageSenderResult.AutoSize = true;
            lblMessageSenderResult.Location = new Point(24, 49);
            lblMessageSenderResult.Margin = new Padding(4, 0, 4, 0);
            lblMessageSenderResult.Name = "lblMessageSenderResult";
            lblMessageSenderResult.Size = new Size(116, 25);
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
            grpSenderResults.Location = new Point(34, 619);
            grpSenderResults.Margin = new Padding(4, 5, 4, 5);
            grpSenderResults.Name = "grpSenderResults";
            grpSenderResults.Padding = new Padding(4, 5, 4, 5);
            grpSenderResults.Size = new Size(989, 285);
            grpSenderResults.TabIndex = 9;
            grpSenderResults.TabStop = false;
            grpSenderResults.Text = "Sender Results";
            grpSenderResults.Enter += grpSenderResults_Enter;
            // 
            // txtOBSSenderResult
            // 
            txtOBSSenderResult.Enabled = false;
            txtOBSSenderResult.Location = new Point(24, 206);
            txtOBSSenderResult.Margin = new Padding(4, 5, 4, 5);
            txtOBSSenderResult.Name = "txtOBSSenderResult";
            txtOBSSenderResult.Size = new Size(942, 31);
            txtOBSSenderResult.TabIndex = 3;
            // 
            // txtExchSenderResult
            // 
            txtExchSenderResult.Enabled = false;
            txtExchSenderResult.Location = new Point(24, 135);
            txtExchSenderResult.Margin = new Padding(4, 5, 4, 5);
            txtExchSenderResult.Name = "txtExchSenderResult";
            txtExchSenderResult.Size = new Size(942, 31);
            txtExchSenderResult.TabIndex = 2;
            // 
            // lblOBSresult
            // 
            lblOBSresult.AutoSize = true;
            lblOBSresult.Location = new Point(24, 176);
            lblOBSresult.Margin = new Padding(4, 0, 4, 0);
            lblOBSresult.Name = "lblOBSresult";
            lblOBSresult.Size = new Size(102, 25);
            lblOBSresult.TabIndex = 1;
            lblOBSresult.Text = "OBS Result:";
            // 
            // lblExchangeSender
            // 
            lblExchangeSender.AutoSize = true;
            lblExchangeSender.Location = new Point(24, 104);
            lblExchangeSender.Margin = new Padding(4, 0, 4, 0);
            lblExchangeSender.Name = "lblExchangeSender";
            lblExchangeSender.Size = new Size(142, 25);
            lblExchangeSender.TabIndex = 0;
            lblExchangeSender.Text = "Exchange Result:";
            // 
            // cboSenderResult
            // 
            cboSenderResult.FormattingEnabled = true;
            cboSenderResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboSenderResult.Location = new Point(142, 36);
            cboSenderResult.Margin = new Padding(4, 5, 4, 5);
            cboSenderResult.Name = "cboSenderResult";
            cboSenderResult.Size = new Size(202, 33);
            cboSenderResult.TabIndex = 10;
            cboSenderResult.SelectedIndexChanged += cboSenderResult_SelectedIndexChanged;
            // 
            // dtExchMessageRecievedTime
            // 
            dtExchMessageRecievedTime.CustomFormat = "MM-dd-yyyy HH:mm";
            dtExchMessageRecievedTime.Enabled = false;
            dtExchMessageRecievedTime.Format = DateTimePickerFormat.Custom;
            dtExchMessageRecievedTime.Location = new Point(24, 134);
            dtExchMessageRecievedTime.Margin = new Padding(4, 5, 4, 5);
            dtExchMessageRecievedTime.Name = "dtExchMessageRecievedTime";
            dtExchMessageRecievedTime.Size = new Size(353, 31);
            dtExchMessageRecievedTime.TabIndex = 13;
            dtExchMessageRecievedTime.Value = new DateTime(2023, 8, 2, 15, 53, 51, 0);
            dtExchMessageRecievedTime.ValueChanged += dtExchMessageRecievedTime_ValueChanged;
            // 
            // grpReceivedTImeResults
            // 
            grpReceivedTImeResults.Controls.Add(dtOBSMessageReceivedTime);
            grpReceivedTImeResults.Controls.Add(label1);
            grpReceivedTImeResults.Controls.Add(dtExchMessageRecievedTime);
            grpReceivedTImeResults.Controls.Add(label2);
            grpReceivedTImeResults.Controls.Add(label3);
            grpReceivedTImeResults.Controls.Add(cboReceivedTimeResult);
            grpReceivedTImeResults.Enabled = false;
            grpReceivedTImeResults.Location = new Point(34, 324);
            grpReceivedTImeResults.Margin = new Padding(4, 5, 4, 5);
            grpReceivedTImeResults.Name = "grpReceivedTImeResults";
            grpReceivedTImeResults.Padding = new Padding(4, 5, 4, 5);
            grpReceivedTImeResults.Size = new Size(989, 285);
            grpReceivedTImeResults.TabIndex = 11;
            grpReceivedTImeResults.TabStop = false;
            grpReceivedTImeResults.Text = "Received Time Results";
            // 
            // dtOBSMessageReceivedTime
            // 
            dtOBSMessageReceivedTime.CustomFormat = "MM-dd-yyyy HH:mm";
            dtOBSMessageReceivedTime.Enabled = false;
            dtOBSMessageReceivedTime.Format = DateTimePickerFormat.Custom;
            dtOBSMessageReceivedTime.Location = new Point(24, 206);
            dtOBSMessageReceivedTime.Margin = new Padding(4, 5, 4, 5);
            dtOBSMessageReceivedTime.Name = "dtOBSMessageReceivedTime";
            dtOBSMessageReceivedTime.Size = new Size(353, 31);
            dtOBSMessageReceivedTime.TabIndex = 14;
            dtOBSMessageReceivedTime.Value = new DateTime(2023, 8, 2, 15, 53, 51, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 176);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 1;
            label1.Text = "OBS Result:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 104);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 0;
            label2.Text = "Exchange Result:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 49);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 6;
            label3.Text = "Audit Result: ";
            label3.Click += label3_Click;
            // 
            // cboReceivedTimeResult
            // 
            cboReceivedTimeResult.FormattingEnabled = true;
            cboReceivedTimeResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboReceivedTimeResult.Location = new Point(142, 36);
            cboReceivedTimeResult.Margin = new Padding(4, 5, 4, 5);
            cboReceivedTimeResult.Name = "cboReceivedTimeResult";
            cboReceivedTimeResult.Size = new Size(202, 33);
            cboReceivedTimeResult.TabIndex = 10;
            cboReceivedTimeResult.SelectedIndexChanged += cboReceivedTimeResult_SelectedIndexChanged;
            // 
            // grpOverallAudit
            // 
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
            grpOverallAudit.Location = new Point(34, 70);
            grpOverallAudit.Margin = new Padding(4, 5, 4, 5);
            grpOverallAudit.Name = "grpOverallAudit";
            grpOverallAudit.Padding = new Padding(4, 5, 4, 5);
            grpOverallAudit.Size = new Size(2161, 244);
            grpOverallAudit.TabIndex = 12;
            grpOverallAudit.TabStop = false;
            grpOverallAudit.Text = "Audit Information";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(670, 100);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(142, 25);
            label10.TabIndex = 17;
            label10.Text = "Journal Email ID:";
            // 
            // txtJounalEmailId
            // 
            txtJounalEmailId.Location = new Point(812, 86);
            txtJounalEmailId.Margin = new Padding(4, 5, 4, 5);
            txtJounalEmailId.Name = "txtJounalEmailId";
            txtJounalEmailId.Size = new Size(460, 31);
            txtJounalEmailId.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 109);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(154, 25);
            label9.TabIndex = 15;
            label9.Text = "Jounaled Mailbox:";
            // 
            // txtJournaledMailbox
            // 
            txtJournaledMailbox.Location = new Point(171, 95);
            txtJournaledMailbox.Margin = new Padding(4, 5, 4, 5);
            txtJournaledMailbox.Name = "txtJournaledMailbox";
            txtJournaledMailbox.Size = new Size(460, 31);
            txtJournaledMailbox.TabIndex = 16;
            // 
            // txtOBSObject
            // 
            txtOBSObject.Location = new Point(886, 26);
            txtOBSObject.Margin = new Padding(4, 5, 4, 5);
            txtOBSObject.Name = "txtOBSObject";
            txtOBSObject.Size = new Size(1078, 31);
            txtOBSObject.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(742, 40);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(143, 25);
            label8.TabIndex = 13;
            label8.Text = "OBS Object URL:";
            // 
            // cboOverallAuditResult
            // 
            cboOverallAuditResult.FormattingEnabled = true;
            cboOverallAuditResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboOverallAuditResult.Location = new Point(1338, 179);
            cboOverallAuditResult.Margin = new Padding(4, 5, 4, 5);
            cboOverallAuditResult.Name = "cboOverallAuditResult";
            cboOverallAuditResult.Size = new Size(202, 33);
            cboOverallAuditResult.TabIndex = 12;
            cboOverallAuditResult.SelectedIndexChanged += cboOverallAuditResult_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1219, 186);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 25);
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
            grpTOResults.Location = new Point(34, 930);
            grpTOResults.Margin = new Padding(4, 5, 4, 5);
            grpTOResults.Name = "grpTOResults";
            grpTOResults.Padding = new Padding(4, 5, 4, 5);
            grpTOResults.Size = new Size(989, 285);
            grpTOResults.TabIndex = 11;
            grpTOResults.TabStop = false;
            grpTOResults.Text = "To Results";
            // 
            // txtOBSToResult
            // 
            txtOBSToResult.Enabled = false;
            txtOBSToResult.Location = new Point(24, 206);
            txtOBSToResult.Margin = new Padding(4, 5, 4, 5);
            txtOBSToResult.Name = "txtOBSToResult";
            txtOBSToResult.Size = new Size(942, 31);
            txtOBSToResult.TabIndex = 3;
            // 
            // txtExchToResult
            // 
            txtExchToResult.Enabled = false;
            txtExchToResult.Location = new Point(24, 135);
            txtExchToResult.Margin = new Padding(4, 5, 4, 5);
            txtExchToResult.Name = "txtExchToResult";
            txtExchToResult.Size = new Size(942, 31);
            txtExchToResult.TabIndex = 2;
            // 
            // lblTOOBSResult
            // 
            lblTOOBSResult.AutoSize = true;
            lblTOOBSResult.Location = new Point(24, 176);
            lblTOOBSResult.Margin = new Padding(4, 0, 4, 0);
            lblTOOBSResult.Name = "lblTOOBSResult";
            lblTOOBSResult.Size = new Size(102, 25);
            lblTOOBSResult.TabIndex = 1;
            lblTOOBSResult.Text = "OBS Result:";
            // 
            // lblTOExchangeResult
            // 
            lblTOExchangeResult.AutoSize = true;
            lblTOExchangeResult.Location = new Point(24, 104);
            lblTOExchangeResult.Margin = new Padding(4, 0, 4, 0);
            lblTOExchangeResult.Name = "lblTOExchangeResult";
            lblTOExchangeResult.Size = new Size(142, 25);
            lblTOExchangeResult.TabIndex = 0;
            lblTOExchangeResult.Text = "Exchange Result:";
            // 
            // lblTOAuditResult
            // 
            lblTOAuditResult.AutoSize = true;
            lblTOAuditResult.Location = new Point(24, 49);
            lblTOAuditResult.Margin = new Padding(4, 0, 4, 0);
            lblTOAuditResult.Name = "lblTOAuditResult";
            lblTOAuditResult.Size = new Size(116, 25);
            lblTOAuditResult.TabIndex = 6;
            lblTOAuditResult.Text = "Audit Result: ";
            // 
            // cboToAuditResult
            // 
            cboToAuditResult.FormattingEnabled = true;
            cboToAuditResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboToAuditResult.Location = new Point(142, 36);
            cboToAuditResult.Margin = new Padding(4, 5, 4, 5);
            cboToAuditResult.Name = "cboToAuditResult";
            cboToAuditResult.Size = new Size(202, 33);
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
            grpCCresults.Location = new Point(42, 1244);
            grpCCresults.Margin = new Padding(4, 5, 4, 5);
            grpCCresults.Name = "grpCCresults";
            grpCCresults.Padding = new Padding(4, 5, 4, 5);
            grpCCresults.Size = new Size(980, 265);
            grpCCresults.TabIndex = 13;
            grpCCresults.TabStop = false;
            grpCCresults.Text = "CC Results";
            grpCCresults.Enter += grpCCresults_Enter;
            // 
            // txtCCobsresult
            // 
            txtCCobsresult.Enabled = false;
            txtCCobsresult.Location = new Point(38, 215);
            txtCCobsresult.Margin = new Padding(4, 5, 4, 5);
            txtCCobsresult.Name = "txtCCobsresult";
            txtCCobsresult.Size = new Size(884, 31);
            txtCCobsresult.TabIndex = 5;
            // 
            // txtCCExchResult
            // 
            txtCCExchResult.Enabled = false;
            txtCCExchResult.Location = new Point(31, 140);
            txtCCExchResult.Margin = new Padding(4, 5, 4, 5);
            txtCCExchResult.Name = "txtCCExchResult";
            txtCCExchResult.Size = new Size(890, 31);
            txtCCExchResult.TabIndex = 4;
            // 
            // cboCCAuditResult
            // 
            cboCCAuditResult.FormattingEnabled = true;
            cboCCAuditResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboCCAuditResult.Location = new Point(142, 40);
            cboCCAuditResult.Margin = new Padding(4, 5, 4, 5);
            cboCCAuditResult.Name = "cboCCAuditResult";
            cboCCAuditResult.Size = new Size(214, 33);
            cboCCAuditResult.TabIndex = 3;
            cboCCAuditResult.SelectedIndexChanged += cboCCAuditResult_SelectedIndexChanged;
            // 
            // lblCCOBSResult
            // 
            lblCCOBSResult.AutoSize = true;
            lblCCOBSResult.Location = new Point(28, 184);
            lblCCOBSResult.Margin = new Padding(4, 0, 4, 0);
            lblCCOBSResult.Name = "lblCCOBSResult";
            lblCCOBSResult.Size = new Size(102, 25);
            lblCCOBSResult.TabIndex = 2;
            lblCCOBSResult.Text = "OBS Result:";
            // 
            // lblCCExchangeResult
            // 
            lblCCExchangeResult.AutoSize = true;
            lblCCExchangeResult.Location = new Point(31, 100);
            lblCCExchangeResult.Margin = new Padding(4, 0, 4, 0);
            lblCCExchangeResult.Name = "lblCCExchangeResult";
            lblCCExchangeResult.Size = new Size(142, 25);
            lblCCExchangeResult.TabIndex = 1;
            lblCCExchangeResult.Text = "Exchange Result:";
            // 
            // lblCCAuditResult
            // 
            lblCCAuditResult.AutoSize = true;
            lblCCAuditResult.Location = new Point(28, 45);
            lblCCAuditResult.Margin = new Padding(4, 0, 4, 0);
            lblCCAuditResult.Name = "lblCCAuditResult";
            lblCCAuditResult.Size = new Size(111, 25);
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
            grpBCCResults.Enabled = false;
            grpBCCResults.Location = new Point(1074, 324);
            grpBCCResults.Margin = new Padding(2, 4, 2, 4);
            grpBCCResults.Name = "grpBCCResults";
            grpBCCResults.Padding = new Padding(2, 4, 2, 4);
            grpBCCResults.Size = new Size(1121, 285);
            grpBCCResults.TabIndex = 14;
            grpBCCResults.TabStop = false;
            grpBCCResults.Text = "BCC Results";
            grpBCCResults.UseCompatibleTextRendering = true;
            grpBCCResults.Enter += groupBox1_Enter;
            // 
            // txtbccOBSResult
            // 
            txtbccOBSResult.Enabled = false;
            txtbccOBSResult.Location = new Point(82, 206);
            txtbccOBSResult.Margin = new Padding(2, 4, 2, 4);
            txtbccOBSResult.Name = "txtbccOBSResult";
            txtbccOBSResult.Size = new Size(842, 31);
            txtbccOBSResult.TabIndex = 5;
            // 
            // lblbccOBSResult
            // 
            lblbccOBSResult.AutoSize = true;
            lblbccOBSResult.Location = new Point(79, 179);
            lblbccOBSResult.Margin = new Padding(2, 0, 2, 0);
            lblbccOBSResult.Name = "lblbccOBSResult";
            lblbccOBSResult.Size = new Size(102, 25);
            lblbccOBSResult.TabIndex = 4;
            lblbccOBSResult.Text = "OBS Result:";
            lblbccOBSResult.Click += lblbccOBSResult_Click;
            // 
            // txtbccExchangeResult
            // 
            txtbccExchangeResult.Enabled = false;
            txtbccExchangeResult.Location = new Point(79, 136);
            txtbccExchangeResult.Margin = new Padding(2, 4, 2, 4);
            txtbccExchangeResult.Name = "txtbccExchangeResult";
            txtbccExchangeResult.Size = new Size(845, 31);
            txtbccExchangeResult.TabIndex = 3;
            // 
            // lblExchangeResult
            // 
            lblExchangeResult.AutoSize = true;
            lblExchangeResult.Location = new Point(79, 99);
            lblExchangeResult.Margin = new Padding(2, 0, 2, 0);
            lblExchangeResult.Name = "lblExchangeResult";
            lblExchangeResult.Size = new Size(142, 25);
            lblExchangeResult.TabIndex = 2;
            lblExchangeResult.Text = "Exchange Result:";
            // 
            // cbobccAuditResult
            // 
            cbobccAuditResult.FormattingEnabled = true;
            cbobccAuditResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cbobccAuditResult.Location = new Point(194, 39);
            cbobccAuditResult.Margin = new Padding(2, 4, 2, 4);
            cbobccAuditResult.Name = "cbobccAuditResult";
            cbobccAuditResult.Size = new Size(183, 33);
            cbobccAuditResult.TabIndex = 1;
            cbobccAuditResult.SelectedIndexChanged += cbobccAuditResult_SelectedIndexChanged_1;
            // 
            // lblAuditResult
            // 
            lblAuditResult.AutoSize = true;
            lblAuditResult.Location = new Point(79, 41);
            lblAuditResult.Margin = new Padding(2, 0, 2, 0);
            lblAuditResult.Name = "lblAuditResult";
            lblAuditResult.Size = new Size(111, 25);
            lblAuditResult.TabIndex = 0;
            lblAuditResult.Text = "Audit Result:";
            // 
            // grpSubjectResults
            // 
            grpSubjectResults.Controls.Add(tabControl1);
            grpSubjectResults.Controls.Add(txtSubjectOBSResult);
            grpSubjectResults.Controls.Add(lblSubjectOBSResult);
            grpSubjectResults.Controls.Add(txtSubjectExchangeResult);
            grpSubjectResults.Controls.Add(lblSubjectExchangeResult);
            grpSubjectResults.Controls.Add(cboSubjectValueResult);
            grpSubjectResults.Controls.Add(label17);
            grpSubjectResults.Enabled = false;
            grpSubjectResults.Location = new Point(1074, 629);
            grpSubjectResults.Margin = new Padding(2, 4, 2, 4);
            grpSubjectResults.Name = "grpSubjectResults";
            grpSubjectResults.Padding = new Padding(2, 4, 2, 4);
            grpSubjectResults.Size = new Size(1121, 274);
            grpSubjectResults.TabIndex = 16;
            grpSubjectResults.TabStop = false;
            grpSubjectResults.Text = "Subject Value Result";
            grpSubjectResults.UseCompatibleTextRendering = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(738, 114);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(11, 14);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(3, 0);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 5, 4, 5);
            tabPage2.Size = new Size(3, 0);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSubjectOBSResult
            // 
            txtSubjectOBSResult.Enabled = false;
            txtSubjectOBSResult.Location = new Point(82, 206);
            txtSubjectOBSResult.Margin = new Padding(2, 4, 2, 4);
            txtSubjectOBSResult.Name = "txtSubjectOBSResult";
            txtSubjectOBSResult.Size = new Size(842, 31);
            txtSubjectOBSResult.TabIndex = 5;
            // 
            // lblSubjectOBSResult
            // 
            lblSubjectOBSResult.AutoSize = true;
            lblSubjectOBSResult.Location = new Point(79, 179);
            lblSubjectOBSResult.Margin = new Padding(2, 0, 2, 0);
            lblSubjectOBSResult.Name = "lblSubjectOBSResult";
            lblSubjectOBSResult.Size = new Size(102, 25);
            lblSubjectOBSResult.TabIndex = 4;
            lblSubjectOBSResult.Text = "OBS Result:";
            // 
            // txtSubjectExchangeResult
            // 
            txtSubjectExchangeResult.Enabled = false;
            txtSubjectExchangeResult.Location = new Point(79, 136);
            txtSubjectExchangeResult.Margin = new Padding(2, 4, 2, 4);
            txtSubjectExchangeResult.Name = "txtSubjectExchangeResult";
            txtSubjectExchangeResult.Size = new Size(845, 31);
            txtSubjectExchangeResult.TabIndex = 3;
            // 
            // lblSubjectExchangeResult
            // 
            lblSubjectExchangeResult.AutoSize = true;
            lblSubjectExchangeResult.Location = new Point(79, 99);
            lblSubjectExchangeResult.Margin = new Padding(2, 0, 2, 0);
            lblSubjectExchangeResult.Name = "lblSubjectExchangeResult";
            lblSubjectExchangeResult.Size = new Size(142, 25);
            lblSubjectExchangeResult.TabIndex = 2;
            lblSubjectExchangeResult.Text = "Exchange Result:";
            // 
            // cboSubjectValueResult
            // 
            cboSubjectValueResult.FormattingEnabled = true;
            cboSubjectValueResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboSubjectValueResult.Location = new Point(194, 39);
            cboSubjectValueResult.Margin = new Padding(2, 4, 2, 4);
            cboSubjectValueResult.Name = "cboSubjectValueResult";
            cboSubjectValueResult.Size = new Size(183, 33);
            cboSubjectValueResult.TabIndex = 1;
            cboSubjectValueResult.SelectedIndexChanged += cboSubjectValueResult_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(79, 41);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(111, 25);
            label17.TabIndex = 0;
            label17.Text = "Audit Result:";
            // 
            // grpAttachementResult
            // 
            grpAttachementResult.Controls.Add(txtAttachmentOBSResult);
            grpAttachementResult.Controls.Add(lblAttachementOBSResult);
            grpAttachementResult.Controls.Add(txtAttachmentExchangeResult);
            grpAttachementResult.Controls.Add(lblAttachementExchangeResult);
            grpAttachementResult.Controls.Add(cboAttachementAuditResult);
            grpAttachementResult.Controls.Add(lblAttachementAuditResult);
            grpAttachementResult.Enabled = false;
            grpAttachementResult.Location = new Point(1074, 1244);
            grpAttachementResult.Margin = new Padding(2, 4, 2, 4);
            grpAttachementResult.Name = "grpAttachementResult";
            grpAttachementResult.Padding = new Padding(2, 4, 2, 4);
            grpAttachementResult.Size = new Size(1121, 274);
            grpAttachementResult.TabIndex = 18;
            grpAttachementResult.TabStop = false;
            grpAttachementResult.Text = "Attachement Result";
            grpAttachementResult.UseCompatibleTextRendering = true;
            // 
            // txtAttachmentOBSResult
            // 
            txtAttachmentOBSResult.Enabled = false;
            txtAttachmentOBSResult.Location = new Point(82, 206);
            txtAttachmentOBSResult.Margin = new Padding(2, 4, 2, 4);
            txtAttachmentOBSResult.Name = "txtAttachmentOBSResult";
            txtAttachmentOBSResult.Size = new Size(842, 31);
            txtAttachmentOBSResult.TabIndex = 5;
            // 
            // lblAttachementOBSResult
            // 
            lblAttachementOBSResult.AutoSize = true;
            lblAttachementOBSResult.Location = new Point(79, 179);
            lblAttachementOBSResult.Margin = new Padding(2, 0, 2, 0);
            lblAttachementOBSResult.Name = "lblAttachementOBSResult";
            lblAttachementOBSResult.Size = new Size(102, 25);
            lblAttachementOBSResult.TabIndex = 4;
            lblAttachementOBSResult.Text = "OBS Result:";
            // 
            // txtAttachmentExchangeResult
            // 
            txtAttachmentExchangeResult.Enabled = false;
            txtAttachmentExchangeResult.Location = new Point(79, 136);
            txtAttachmentExchangeResult.Margin = new Padding(2, 4, 2, 4);
            txtAttachmentExchangeResult.Name = "txtAttachmentExchangeResult";
            txtAttachmentExchangeResult.Size = new Size(845, 31);
            txtAttachmentExchangeResult.TabIndex = 3;
            // 
            // lblAttachementExchangeResult
            // 
            lblAttachementExchangeResult.AutoSize = true;
            lblAttachementExchangeResult.Location = new Point(79, 99);
            lblAttachementExchangeResult.Margin = new Padding(2, 0, 2, 0);
            lblAttachementExchangeResult.Name = "lblAttachementExchangeResult";
            lblAttachementExchangeResult.Size = new Size(142, 25);
            lblAttachementExchangeResult.TabIndex = 2;
            lblAttachementExchangeResult.Text = "Exchange Result:";
            // 
            // cboAttachementAuditResult
            // 
            cboAttachementAuditResult.FormattingEnabled = true;
            cboAttachementAuditResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboAttachementAuditResult.Location = new Point(194, 39);
            cboAttachementAuditResult.Margin = new Padding(2, 4, 2, 4);
            cboAttachementAuditResult.Name = "cboAttachementAuditResult";
            cboAttachementAuditResult.Size = new Size(183, 33);
            cboAttachementAuditResult.TabIndex = 1;
            cboAttachementAuditResult.SelectedIndexChanged += cboAttachementAuditResult_SelectedIndexChanged;
            // 
            // lblAttachementAuditResult
            // 
            lblAttachementAuditResult.AutoSize = true;
            lblAttachementAuditResult.Location = new Point(79, 41);
            lblAttachementAuditResult.Margin = new Padding(2, 0, 2, 0);
            lblAttachementAuditResult.Name = "lblAttachementAuditResult";
            lblAttachementAuditResult.Size = new Size(111, 25);
            lblAttachementAuditResult.TabIndex = 0;
            lblAttachementAuditResult.Text = "Audit Result:";
            // 
            // grpBodyResults
            // 
            grpBodyResults.Controls.Add(txtBodyOBSResult);
            grpBodyResults.Controls.Add(lblBodyValueOBSResult);
            grpBodyResults.Controls.Add(txtBodyExchangeResult);
            grpBodyResults.Controls.Add(lblBodyExchangeResult);
            grpBodyResults.Controls.Add(cboBodyValueResult);
            grpBodyResults.Controls.Add(lblBodyValueAuditResult);
            grpBodyResults.Enabled = false;
            grpBodyResults.Location = new Point(1074, 930);
            grpBodyResults.Margin = new Padding(2, 4, 2, 4);
            grpBodyResults.Name = "grpBodyResults";
            grpBodyResults.Padding = new Padding(2, 4, 2, 4);
            grpBodyResults.Size = new Size(1121, 285);
            grpBodyResults.TabIndex = 17;
            grpBodyResults.TabStop = false;
            grpBodyResults.Text = "Body Value Result";
            grpBodyResults.UseCompatibleTextRendering = true;
            // 
            // txtBodyOBSResult
            // 
            txtBodyOBSResult.Enabled = false;
            txtBodyOBSResult.Location = new Point(82, 206);
            txtBodyOBSResult.Margin = new Padding(2, 4, 2, 4);
            txtBodyOBSResult.Name = "txtBodyOBSResult";
            txtBodyOBSResult.Size = new Size(842, 31);
            txtBodyOBSResult.TabIndex = 5;
            // 
            // lblBodyValueOBSResult
            // 
            lblBodyValueOBSResult.AutoSize = true;
            lblBodyValueOBSResult.Location = new Point(79, 179);
            lblBodyValueOBSResult.Margin = new Padding(2, 0, 2, 0);
            lblBodyValueOBSResult.Name = "lblBodyValueOBSResult";
            lblBodyValueOBSResult.Size = new Size(102, 25);
            lblBodyValueOBSResult.TabIndex = 4;
            lblBodyValueOBSResult.Text = "OBS Result:";
            // 
            // txtBodyExchangeResult
            // 
            txtBodyExchangeResult.Enabled = false;
            txtBodyExchangeResult.Location = new Point(79, 136);
            txtBodyExchangeResult.Margin = new Padding(2, 4, 2, 4);
            txtBodyExchangeResult.Name = "txtBodyExchangeResult";
            txtBodyExchangeResult.Size = new Size(845, 31);
            txtBodyExchangeResult.TabIndex = 3;
            // 
            // lblBodyExchangeResult
            // 
            lblBodyExchangeResult.AutoSize = true;
            lblBodyExchangeResult.Location = new Point(79, 99);
            lblBodyExchangeResult.Margin = new Padding(2, 0, 2, 0);
            lblBodyExchangeResult.Name = "lblBodyExchangeResult";
            lblBodyExchangeResult.Size = new Size(142, 25);
            lblBodyExchangeResult.TabIndex = 2;
            lblBodyExchangeResult.Text = "Exchange Result:";
            // 
            // cboBodyValueResult
            // 
            cboBodyValueResult.FormattingEnabled = true;
            cboBodyValueResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboBodyValueResult.Location = new Point(194, 39);
            cboBodyValueResult.Margin = new Padding(2, 4, 2, 4);
            cboBodyValueResult.Name = "cboBodyValueResult";
            cboBodyValueResult.Size = new Size(183, 33);
            cboBodyValueResult.TabIndex = 1;
            cboBodyValueResult.SelectedIndexChanged += cboBodyValueResult_SelectedIndexChanged;
            // 
            // lblBodyValueAuditResult
            // 
            lblBodyValueAuditResult.AutoSize = true;
            lblBodyValueAuditResult.Location = new Point(79, 41);
            lblBodyValueAuditResult.Margin = new Padding(2, 0, 2, 0);
            lblBodyValueAuditResult.Name = "lblBodyValueAuditResult";
            lblBodyValueAuditResult.Size = new Size(111, 25);
            lblBodyValueAuditResult.TabIndex = 0;
            lblBodyValueAuditResult.Text = "Audit Result:";
            lblBodyValueAuditResult.Click += label18_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(1699, 1530);
            btnReset.Margin = new Padding(4, 5, 4, 5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(220, 39);
            btnReset.TabIndex = 19;
            btnReset.Text = "&Reset Form";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += button1_Click;
            // 
            // bttnReturntoNav
            // 
            bttnReturntoNav.Location = new Point(1145, 1224);
            bttnReturntoNav.Name = "bttnReturntoNav";
            bttnReturntoNav.Size = new Size(193, 29);
            bttnReturntoNav.TabIndex = 20;
            bttnReturntoNav.Text = "Return to Navigation";
            bttnReturntoNav.UseVisualStyleBackColor = true;
            bttnReturntoNav.Click += bttnReturntoNav_Click;
            // 
            // frmEmailAuditReport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1774, 1271);
            Controls.Add(bttnReturntoNav);
            Controls.Add(btnReset);
            Controls.Add(grpAttachementResult);
            Controls.Add(grpBodyResults);
            Controls.Add(grpSubjectResults);
            Controls.Add(grpBCCResults);
            Controls.Add(grpCCresults);
            Controls.Add(grpTOResults);
            Controls.Add(grpOverallAudit);
            Controls.Add(grpReceivedTImeResults);
            Controls.Add(grpSenderResults);
            Controls.Add(btnSubmit);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmEmailAuditReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Email Audit Report";
            Load += frmEmailAuditReport_Load;
            grpSenderResults.ResumeLayout(false);
            grpSenderResults.PerformLayout();
            grpReceivedTImeResults.ResumeLayout(false);
            grpReceivedTImeResults.PerformLayout();
            grpOverallAudit.ResumeLayout(false);
            grpOverallAudit.PerformLayout();
            grpTOResults.ResumeLayout(false);
            grpTOResults.PerformLayout();
            grpCCresults.ResumeLayout(false);
            grpCCresults.PerformLayout();
            grpBCCResults.ResumeLayout(false);
            grpBCCResults.PerformLayout();
            grpSubjectResults.ResumeLayout(false);
            grpSubjectResults.PerformLayout();
            tabControl1.ResumeLayout(false);
            grpAttachementResult.ResumeLayout(false);
            grpAttachementResult.PerformLayout();
            grpBodyResults.ResumeLayout(false);
            grpBodyResults.PerformLayout();
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
        private GroupBox grpReceivedTImeResults;
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
        private GroupBox grpSubjectResults;
        private TextBox txtSubjectOBSResult;
        private Label lblSubjectOBSResult;
        private TextBox txtSubjectExchangeResult;
        private Label lblSubjectExchangeResult;
        private ComboBox cboSubjectValueResult;
        private Label label17;
        private GroupBox grpAttachementResult;
        private TextBox txtAttachmentOBSResult;
        private Label lblAttachementOBSResult;
        private TextBox txtAttachmentExchangeResult;
        private Label lblAttachementExchangeResult;
        private ComboBox cboAttachementAuditResult;
        private Label lblAttachementAuditResult;
        private GroupBox grpBodyResults;
        private TextBox txtBodyOBSResult;
        private Label lblBodyValueOBSResult;
        private TextBox txtBodyExchangeResult;
        private Label lblBodyExchangeResult;
        private ComboBox cboBodyValueResult;
        private Label lblBodyValueAuditResult;
        private Button btnReset;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button bttnReturntoNav;
    }
}