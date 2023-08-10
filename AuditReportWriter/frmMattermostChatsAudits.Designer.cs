namespace AuditReportWriter
{
    partial class frmMattermostChatsAudits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bttnReturntoNav = new Button();
            grpOverallAudit = new GroupBox();
            rbManualAudit = new RadioButton();
            lblChannelID = new Label();
            txtChannelID = new TextBox();
            txtOBSObject = new TextBox();
            label8 = new Label();
            cboOverallAuditResult = new ComboBox();
            label4 = new Label();
            lblPostID = new Label();
            txtMessageID = new TextBox();
            dtAuditDate = new Label();
            dtAuditDateTime = new DateTimePicker();
            grpCreatedTime = new GroupBox();
            dtOBSCreatedTime = new DateTimePicker();
            lblCreatedTimeOBS = new Label();
            dtMMCreatedTime = new DateTimePicker();
            lblCreatedTimeMM = new Label();
            lblCreatedTime = new Label();
            cboCreatedTimeResult = new ComboBox();
            grpUpdateTime = new GroupBox();
            dtOBSUpdatedTime = new DateTimePicker();
            lblUpdatedTimeOBS = new Label();
            dtMMUpdatedTime = new DateTimePicker();
            lblUpdatedTimeMM = new Label();
            lblUpdatedTime = new Label();
            cboUpdatedTimeResult = new ComboBox();
            grpMessageText = new GroupBox();
            txtOBSMessageTextResult = new TextBox();
            txtMMMessageTextResult = new TextBox();
            lblMessageTextOBS = new Label();
            lblMessageTextMM = new Label();
            lblMessageTextAuditResult = new Label();
            cboMessageTextAuditResult = new ComboBox();
            grpAttachments = new GroupBox();
            txtOBSAttachmentsResult = new TextBox();
            txtMMAttachmentsResult = new TextBox();
            lblAttachmentsOBSResult = new Label();
            lblAttachmentsMMResult = new Label();
            lblAttachmentsAuditResult = new Label();
            cboAttachmentsResult = new ComboBox();
            grpEmail = new GroupBox();
            txtOBSEmailResult = new TextBox();
            txtMMEmailResult = new TextBox();
            label15 = new Label();
            lblMMEmailResult = new Label();
            lblEmailAuditResult = new Label();
            cboEmailAuditResult = new ComboBox();
            grpUserName = new GroupBox();
            txtOBSUsernameResult = new TextBox();
            txtMMUsernameResult = new TextBox();
            lblOBSUsernameResult = new Label();
            lblMMUsernameResult = new Label();
            lblUsernameAuditResult = new Label();
            cboUsernameResult = new ComboBox();
            btnReset = new Button();
            btnSubmit = new Button();
            grpOverallAudit.SuspendLayout();
            grpCreatedTime.SuspendLayout();
            grpUpdateTime.SuspendLayout();
            grpMessageText.SuspendLayout();
            grpAttachments.SuspendLayout();
            grpEmail.SuspendLayout();
            grpUserName.SuspendLayout();
            SuspendLayout();
            // 
            // bttnReturntoNav
            // 
            bttnReturntoNav.Location = new Point(1167, 1060);
            bttnReturntoNav.Name = "bttnReturntoNav";
            bttnReturntoNav.Size = new Size(193, 29);
            bttnReturntoNav.TabIndex = 0;
            bttnReturntoNav.Text = "Return to Navigation";
            bttnReturntoNav.UseVisualStyleBackColor = true;
            bttnReturntoNav.Click += bttnReturntoNav_Click;
            // 
            // grpOverallAudit
            // 
            grpOverallAudit.Controls.Add(rbManualAudit);
            grpOverallAudit.Controls.Add(lblChannelID);
            grpOverallAudit.Controls.Add(txtChannelID);
            grpOverallAudit.Controls.Add(txtOBSObject);
            grpOverallAudit.Controls.Add(label8);
            grpOverallAudit.Controls.Add(cboOverallAuditResult);
            grpOverallAudit.Controls.Add(label4);
            grpOverallAudit.Controls.Add(lblPostID);
            grpOverallAudit.Controls.Add(txtMessageID);
            grpOverallAudit.Controls.Add(dtAuditDate);
            grpOverallAudit.Controls.Add(dtAuditDateTime);
            grpOverallAudit.Location = new Point(12, 13);
            grpOverallAudit.Margin = new Padding(3, 4, 3, 4);
            grpOverallAudit.Name = "grpOverallAudit";
            grpOverallAudit.Padding = new Padding(3, 4, 3, 4);
            grpOverallAudit.Size = new Size(1729, 195);
            grpOverallAudit.TabIndex = 13;
            grpOverallAudit.TabStop = false;
            grpOverallAudit.Text = "Audit Information";
            // 
            // rbManualAudit
            // 
            rbManualAudit.AutoSize = true;
            rbManualAudit.Checked = true;
            rbManualAudit.Location = new Point(423, 134);
            rbManualAudit.Name = "rbManualAudit";
            rbManualAudit.Size = new Size(119, 24);
            rbManualAudit.TabIndex = 5;
            rbManualAudit.TabStop = true;
            rbManualAudit.Text = "Manual Audit";
            rbManualAudit.UseVisualStyleBackColor = true;
            // 
            // lblChannelID
            // 
            lblChannelID.AutoSize = true;
            lblChannelID.Location = new Point(19, 85);
            lblChannelID.Name = "lblChannelID";
            lblChannelID.Size = new Size(84, 20);
            lblChannelID.TabIndex = 15;
            lblChannelID.Text = "Channel ID:";
            // 
            // txtChannelID
            // 
            txtChannelID.Location = new Point(114, 78);
            txtChannelID.Margin = new Padding(3, 4, 3, 4);
            txtChannelID.Name = "txtChannelID";
            txtChannelID.Size = new Size(369, 27);
            txtChannelID.TabIndex = 3;
            // 
            // txtOBSObject
            // 
            txtOBSObject.Location = new Point(660, 29);
            txtOBSObject.Margin = new Padding(3, 4, 3, 4);
            txtOBSObject.Name = "txtOBSObject";
            txtOBSObject.Size = new Size(863, 27);
            txtOBSObject.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(536, 32);
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
            cboOverallAuditResult.TabIndex = 6;
            cboOverallAuditResult.SelectedIndexChanged += cboOverallAuditResult_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(975, 150);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 11;
            label4.Text = "Audit Result: ";
            // 
            // lblPostID
            // 
            lblPostID.AutoSize = true;
            lblPostID.Location = new Point(19, 36);
            lblPostID.Name = "lblPostID";
            lblPostID.Size = new Size(58, 20);
            lblPostID.TabIndex = 0;
            lblPostID.Text = "Post ID:";
            // 
            // txtMessageID
            // 
            txtMessageID.Location = new Point(114, 29);
            txtMessageID.Margin = new Padding(3, 4, 3, 4);
            txtMessageID.Name = "txtMessageID";
            txtMessageID.Size = new Size(369, 27);
            txtMessageID.TabIndex = 1;
            // 
            // dtAuditDate
            // 
            dtAuditDate.AutoSize = true;
            dtAuditDate.Location = new Point(19, 141);
            dtAuditDate.Name = "dtAuditDate";
            dtAuditDate.Size = new Size(123, 20);
            dtAuditDate.TabIndex = 3;
            dtAuditDate.Text = "Audit Date/TIme:";
            // 
            // dtAuditDateTime
            // 
            dtAuditDateTime.CustomFormat = "MM-dd-yyyy HH:mm";
            dtAuditDateTime.Format = DateTimePickerFormat.Custom;
            dtAuditDateTime.Location = new Point(158, 134);
            dtAuditDateTime.Margin = new Padding(3, 4, 3, 4);
            dtAuditDateTime.Name = "dtAuditDateTime";
            dtAuditDateTime.Size = new Size(199, 27);
            dtAuditDateTime.TabIndex = 4;
            dtAuditDateTime.Value = new DateTime(2023, 8, 2, 15, 53, 51, 0);
            dtAuditDateTime.ValueChanged += dtAuditDateTime_ValueChanged;
            // 
            // grpCreatedTime
            // 
            grpCreatedTime.Controls.Add(dtOBSCreatedTime);
            grpCreatedTime.Controls.Add(lblCreatedTimeOBS);
            grpCreatedTime.Controls.Add(dtMMCreatedTime);
            grpCreatedTime.Controls.Add(lblCreatedTimeMM);
            grpCreatedTime.Controls.Add(lblCreatedTime);
            grpCreatedTime.Controls.Add(cboCreatedTimeResult);
            grpCreatedTime.Enabled = false;
            grpCreatedTime.Location = new Point(12, 241);
            grpCreatedTime.Margin = new Padding(3, 4, 3, 4);
            grpCreatedTime.Name = "grpCreatedTime";
            grpCreatedTime.Padding = new Padding(3, 4, 3, 4);
            grpCreatedTime.Size = new Size(791, 228);
            grpCreatedTime.TabIndex = 14;
            grpCreatedTime.TabStop = false;
            grpCreatedTime.Text = "Created Time";
            // 
            // dtOBSCreatedTime
            // 
            dtOBSCreatedTime.CustomFormat = "MM-dd-yyyy HH:mm";
            dtOBSCreatedTime.Enabled = false;
            dtOBSCreatedTime.Format = DateTimePickerFormat.Custom;
            dtOBSCreatedTime.Location = new Point(19, 165);
            dtOBSCreatedTime.Margin = new Padding(3, 4, 3, 4);
            dtOBSCreatedTime.Name = "dtOBSCreatedTime";
            dtOBSCreatedTime.Size = new Size(283, 27);
            dtOBSCreatedTime.TabIndex = 9;
            dtOBSCreatedTime.Value = new DateTime(2023, 8, 2, 15, 53, 51, 0);
            // 
            // lblCreatedTimeOBS
            // 
            lblCreatedTimeOBS.AutoSize = true;
            lblCreatedTimeOBS.Location = new Point(19, 142);
            lblCreatedTimeOBS.Name = "lblCreatedTimeOBS";
            lblCreatedTimeOBS.Size = new Size(84, 20);
            lblCreatedTimeOBS.TabIndex = 1;
            lblCreatedTimeOBS.Text = "OBS Result:";
            // 
            // dtMMCreatedTime
            // 
            dtMMCreatedTime.CustomFormat = "MM-dd-yyyy HH:mm";
            dtMMCreatedTime.Enabled = false;
            dtMMCreatedTime.Format = DateTimePickerFormat.Custom;
            dtMMCreatedTime.Location = new Point(19, 107);
            dtMMCreatedTime.Margin = new Padding(3, 4, 3, 4);
            dtMMCreatedTime.Name = "dtMMCreatedTime";
            dtMMCreatedTime.Size = new Size(283, 27);
            dtMMCreatedTime.TabIndex = 8;
            dtMMCreatedTime.Value = new DateTime(2023, 8, 2, 15, 53, 51, 0);
            // 
            // lblCreatedTimeMM
            // 
            lblCreatedTimeMM.AutoSize = true;
            lblCreatedTimeMM.Location = new Point(19, 84);
            lblCreatedTimeMM.Name = "lblCreatedTimeMM";
            lblCreatedTimeMM.Size = new Size(133, 20);
            lblCreatedTimeMM.TabIndex = 0;
            lblCreatedTimeMM.Text = "Mattermost Result:";
            // 
            // lblCreatedTime
            // 
            lblCreatedTime.AutoSize = true;
            lblCreatedTime.Location = new Point(19, 40);
            lblCreatedTime.Name = "lblCreatedTime";
            lblCreatedTime.Size = new Size(96, 20);
            lblCreatedTime.TabIndex = 6;
            lblCreatedTime.Text = "Audit Result: ";
            // 
            // cboCreatedTimeResult
            // 
            cboCreatedTimeResult.FormattingEnabled = true;
            cboCreatedTimeResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboCreatedTimeResult.Location = new Point(121, 32);
            cboCreatedTimeResult.Margin = new Padding(3, 4, 3, 4);
            cboCreatedTimeResult.Name = "cboCreatedTimeResult";
            cboCreatedTimeResult.Size = new Size(162, 28);
            cboCreatedTimeResult.TabIndex = 7;
            // 
            // grpUpdateTime
            // 
            grpUpdateTime.Controls.Add(dtOBSUpdatedTime);
            grpUpdateTime.Controls.Add(lblUpdatedTimeOBS);
            grpUpdateTime.Controls.Add(dtMMUpdatedTime);
            grpUpdateTime.Controls.Add(lblUpdatedTimeMM);
            grpUpdateTime.Controls.Add(lblUpdatedTime);
            grpUpdateTime.Controls.Add(cboUpdatedTimeResult);
            grpUpdateTime.Enabled = false;
            grpUpdateTime.Location = new Point(12, 492);
            grpUpdateTime.Margin = new Padding(3, 4, 3, 4);
            grpUpdateTime.Name = "grpUpdateTime";
            grpUpdateTime.Padding = new Padding(3, 4, 3, 4);
            grpUpdateTime.Size = new Size(791, 228);
            grpUpdateTime.TabIndex = 15;
            grpUpdateTime.TabStop = false;
            grpUpdateTime.Text = "Updated Time";
            // 
            // dtOBSUpdatedTime
            // 
            dtOBSUpdatedTime.CustomFormat = "MM-dd-yyyy HH:mm";
            dtOBSUpdatedTime.Enabled = false;
            dtOBSUpdatedTime.Format = DateTimePickerFormat.Custom;
            dtOBSUpdatedTime.Location = new Point(19, 165);
            dtOBSUpdatedTime.Margin = new Padding(3, 4, 3, 4);
            dtOBSUpdatedTime.Name = "dtOBSUpdatedTime";
            dtOBSUpdatedTime.Size = new Size(283, 27);
            dtOBSUpdatedTime.TabIndex = 12;
            dtOBSUpdatedTime.Value = new DateTime(2023, 8, 2, 15, 53, 51, 0);
            // 
            // lblUpdatedTimeOBS
            // 
            lblUpdatedTimeOBS.AutoSize = true;
            lblUpdatedTimeOBS.Location = new Point(19, 142);
            lblUpdatedTimeOBS.Name = "lblUpdatedTimeOBS";
            lblUpdatedTimeOBS.Size = new Size(84, 20);
            lblUpdatedTimeOBS.TabIndex = 1;
            lblUpdatedTimeOBS.Text = "OBS Result:";
            // 
            // dtMMUpdatedTime
            // 
            dtMMUpdatedTime.CustomFormat = "MM-dd-yyyy HH:mm";
            dtMMUpdatedTime.Enabled = false;
            dtMMUpdatedTime.Format = DateTimePickerFormat.Custom;
            dtMMUpdatedTime.Location = new Point(19, 107);
            dtMMUpdatedTime.Margin = new Padding(3, 4, 3, 4);
            dtMMUpdatedTime.Name = "dtMMUpdatedTime";
            dtMMUpdatedTime.Size = new Size(283, 27);
            dtMMUpdatedTime.TabIndex = 11;
            dtMMUpdatedTime.Value = new DateTime(2023, 8, 2, 15, 53, 51, 0);
            // 
            // lblUpdatedTimeMM
            // 
            lblUpdatedTimeMM.AutoSize = true;
            lblUpdatedTimeMM.Location = new Point(19, 84);
            lblUpdatedTimeMM.Name = "lblUpdatedTimeMM";
            lblUpdatedTimeMM.Size = new Size(133, 20);
            lblUpdatedTimeMM.TabIndex = 0;
            lblUpdatedTimeMM.Text = "Mattermost Result:";
            // 
            // lblUpdatedTime
            // 
            lblUpdatedTime.AutoSize = true;
            lblUpdatedTime.Location = new Point(19, 40);
            lblUpdatedTime.Name = "lblUpdatedTime";
            lblUpdatedTime.Size = new Size(96, 20);
            lblUpdatedTime.TabIndex = 6;
            lblUpdatedTime.Text = "Audit Result: ";
            // 
            // cboUpdatedTimeResult
            // 
            cboUpdatedTimeResult.FormattingEnabled = true;
            cboUpdatedTimeResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboUpdatedTimeResult.Location = new Point(121, 32);
            cboUpdatedTimeResult.Margin = new Padding(3, 4, 3, 4);
            cboUpdatedTimeResult.Name = "cboUpdatedTimeResult";
            cboUpdatedTimeResult.Size = new Size(162, 28);
            cboUpdatedTimeResult.TabIndex = 10;
            // 
            // grpMessageText
            // 
            grpMessageText.Controls.Add(txtOBSMessageTextResult);
            grpMessageText.Controls.Add(txtMMMessageTextResult);
            grpMessageText.Controls.Add(lblMessageTextOBS);
            grpMessageText.Controls.Add(lblMessageTextMM);
            grpMessageText.Controls.Add(lblMessageTextAuditResult);
            grpMessageText.Controls.Add(cboMessageTextAuditResult);
            grpMessageText.Enabled = false;
            grpMessageText.Location = new Point(12, 750);
            grpMessageText.Margin = new Padding(3, 4, 3, 4);
            grpMessageText.Name = "grpMessageText";
            grpMessageText.Padding = new Padding(3, 4, 3, 4);
            grpMessageText.Size = new Size(791, 228);
            grpMessageText.TabIndex = 16;
            grpMessageText.TabStop = false;
            grpMessageText.Text = "Message Text";
            // 
            // txtOBSMessageTextResult
            // 
            txtOBSMessageTextResult.Enabled = false;
            txtOBSMessageTextResult.Location = new Point(19, 165);
            txtOBSMessageTextResult.Margin = new Padding(3, 4, 3, 4);
            txtOBSMessageTextResult.Name = "txtOBSMessageTextResult";
            txtOBSMessageTextResult.Size = new Size(754, 27);
            txtOBSMessageTextResult.TabIndex = 16;
            // 
            // txtMMMessageTextResult
            // 
            txtMMMessageTextResult.Enabled = false;
            txtMMMessageTextResult.Location = new Point(19, 107);
            txtMMMessageTextResult.Margin = new Padding(3, 4, 3, 4);
            txtMMMessageTextResult.Name = "txtMMMessageTextResult";
            txtMMMessageTextResult.Size = new Size(754, 27);
            txtMMMessageTextResult.TabIndex = 15;
            // 
            // lblMessageTextOBS
            // 
            lblMessageTextOBS.AutoSize = true;
            lblMessageTextOBS.Location = new Point(19, 142);
            lblMessageTextOBS.Name = "lblMessageTextOBS";
            lblMessageTextOBS.Size = new Size(84, 20);
            lblMessageTextOBS.TabIndex = 1;
            lblMessageTextOBS.Text = "OBS Result:";
            // 
            // lblMessageTextMM
            // 
            lblMessageTextMM.AutoSize = true;
            lblMessageTextMM.Location = new Point(19, 84);
            lblMessageTextMM.Name = "lblMessageTextMM";
            lblMessageTextMM.Size = new Size(133, 20);
            lblMessageTextMM.TabIndex = 0;
            lblMessageTextMM.Text = "Mattermost Result:";
            // 
            // lblMessageTextAuditResult
            // 
            lblMessageTextAuditResult.AutoSize = true;
            lblMessageTextAuditResult.Location = new Point(19, 40);
            lblMessageTextAuditResult.Name = "lblMessageTextAuditResult";
            lblMessageTextAuditResult.Size = new Size(96, 20);
            lblMessageTextAuditResult.TabIndex = 6;
            lblMessageTextAuditResult.Text = "Audit Result: ";
            // 
            // cboMessageTextAuditResult
            // 
            cboMessageTextAuditResult.FormattingEnabled = true;
            cboMessageTextAuditResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboMessageTextAuditResult.Location = new Point(121, 32);
            cboMessageTextAuditResult.Margin = new Padding(3, 4, 3, 4);
            cboMessageTextAuditResult.Name = "cboMessageTextAuditResult";
            cboMessageTextAuditResult.Size = new Size(162, 28);
            cboMessageTextAuditResult.TabIndex = 14;
            // 
            // grpAttachments
            // 
            grpAttachments.Controls.Add(txtOBSAttachmentsResult);
            grpAttachments.Controls.Add(txtMMAttachmentsResult);
            grpAttachments.Controls.Add(lblAttachmentsOBSResult);
            grpAttachments.Controls.Add(lblAttachmentsMMResult);
            grpAttachments.Controls.Add(lblAttachmentsAuditResult);
            grpAttachments.Controls.Add(cboAttachmentsResult);
            grpAttachments.Enabled = false;
            grpAttachments.Location = new Point(841, 241);
            grpAttachments.Margin = new Padding(3, 4, 3, 4);
            grpAttachments.Name = "grpAttachments";
            grpAttachments.Padding = new Padding(3, 4, 3, 4);
            grpAttachments.Size = new Size(791, 228);
            grpAttachments.TabIndex = 17;
            grpAttachments.TabStop = false;
            grpAttachments.Text = "Attachments";
            // 
            // txtOBSAttachmentsResult
            // 
            txtOBSAttachmentsResult.Enabled = false;
            txtOBSAttachmentsResult.Location = new Point(19, 167);
            txtOBSAttachmentsResult.Margin = new Padding(3, 4, 3, 4);
            txtOBSAttachmentsResult.Name = "txtOBSAttachmentsResult";
            txtOBSAttachmentsResult.Size = new Size(754, 27);
            txtOBSAttachmentsResult.TabIndex = 19;
            // 
            // txtMMAttachmentsResult
            // 
            txtMMAttachmentsResult.Enabled = false;
            txtMMAttachmentsResult.Location = new Point(19, 107);
            txtMMAttachmentsResult.Margin = new Padding(3, 4, 3, 4);
            txtMMAttachmentsResult.Name = "txtMMAttachmentsResult";
            txtMMAttachmentsResult.Size = new Size(754, 27);
            txtMMAttachmentsResult.TabIndex = 18;
            // 
            // lblAttachmentsOBSResult
            // 
            lblAttachmentsOBSResult.AutoSize = true;
            lblAttachmentsOBSResult.Location = new Point(19, 142);
            lblAttachmentsOBSResult.Name = "lblAttachmentsOBSResult";
            lblAttachmentsOBSResult.Size = new Size(84, 20);
            lblAttachmentsOBSResult.TabIndex = 1;
            lblAttachmentsOBSResult.Text = "OBS Result:";
            // 
            // lblAttachmentsMMResult
            // 
            lblAttachmentsMMResult.AutoSize = true;
            lblAttachmentsMMResult.Location = new Point(19, 84);
            lblAttachmentsMMResult.Name = "lblAttachmentsMMResult";
            lblAttachmentsMMResult.Size = new Size(133, 20);
            lblAttachmentsMMResult.TabIndex = 0;
            lblAttachmentsMMResult.Text = "Mattermost Result:";
            // 
            // lblAttachmentsAuditResult
            // 
            lblAttachmentsAuditResult.AutoSize = true;
            lblAttachmentsAuditResult.Location = new Point(19, 40);
            lblAttachmentsAuditResult.Name = "lblAttachmentsAuditResult";
            lblAttachmentsAuditResult.Size = new Size(96, 20);
            lblAttachmentsAuditResult.TabIndex = 6;
            lblAttachmentsAuditResult.Text = "Audit Result: ";
            // 
            // cboAttachmentsResult
            // 
            cboAttachmentsResult.FormattingEnabled = true;
            cboAttachmentsResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboAttachmentsResult.Location = new Point(121, 32);
            cboAttachmentsResult.Margin = new Padding(3, 4, 3, 4);
            cboAttachmentsResult.Name = "cboAttachmentsResult";
            cboAttachmentsResult.Size = new Size(162, 28);
            cboAttachmentsResult.TabIndex = 17;
            // 
            // grpEmail
            // 
            grpEmail.Controls.Add(txtOBSEmailResult);
            grpEmail.Controls.Add(txtMMEmailResult);
            grpEmail.Controls.Add(label15);
            grpEmail.Controls.Add(lblMMEmailResult);
            grpEmail.Controls.Add(lblEmailAuditResult);
            grpEmail.Controls.Add(cboEmailAuditResult);
            grpEmail.Enabled = false;
            grpEmail.Location = new Point(841, 492);
            grpEmail.Margin = new Padding(3, 4, 3, 4);
            grpEmail.Name = "grpEmail";
            grpEmail.Padding = new Padding(3, 4, 3, 4);
            grpEmail.Size = new Size(791, 228);
            grpEmail.TabIndex = 18;
            grpEmail.TabStop = false;
            grpEmail.Text = "Email";
            // 
            // txtOBSEmailResult
            // 
            txtOBSEmailResult.Enabled = false;
            txtOBSEmailResult.Location = new Point(18, 167);
            txtOBSEmailResult.Margin = new Padding(3, 4, 3, 4);
            txtOBSEmailResult.Name = "txtOBSEmailResult";
            txtOBSEmailResult.Size = new Size(754, 27);
            txtOBSEmailResult.TabIndex = 22;
            // 
            // txtMMEmailResult
            // 
            txtMMEmailResult.Enabled = false;
            txtMMEmailResult.Location = new Point(18, 107);
            txtMMEmailResult.Margin = new Padding(3, 4, 3, 4);
            txtMMEmailResult.Name = "txtMMEmailResult";
            txtMMEmailResult.Size = new Size(754, 27);
            txtMMEmailResult.TabIndex = 21;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(19, 142);
            label15.Name = "label15";
            label15.Size = new Size(84, 20);
            label15.TabIndex = 1;
            label15.Text = "OBS Result:";
            // 
            // lblMMEmailResult
            // 
            lblMMEmailResult.AutoSize = true;
            lblMMEmailResult.Location = new Point(19, 84);
            lblMMEmailResult.Name = "lblMMEmailResult";
            lblMMEmailResult.Size = new Size(133, 20);
            lblMMEmailResult.TabIndex = 0;
            lblMMEmailResult.Text = "Mattermost Result:";
            // 
            // lblEmailAuditResult
            // 
            lblEmailAuditResult.AutoSize = true;
            lblEmailAuditResult.Location = new Point(19, 40);
            lblEmailAuditResult.Name = "lblEmailAuditResult";
            lblEmailAuditResult.Size = new Size(96, 20);
            lblEmailAuditResult.TabIndex = 6;
            lblEmailAuditResult.Text = "Audit Result: ";
            // 
            // cboEmailAuditResult
            // 
            cboEmailAuditResult.FormattingEnabled = true;
            cboEmailAuditResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboEmailAuditResult.Location = new Point(121, 32);
            cboEmailAuditResult.Margin = new Padding(3, 4, 3, 4);
            cboEmailAuditResult.Name = "cboEmailAuditResult";
            cboEmailAuditResult.Size = new Size(162, 28);
            cboEmailAuditResult.TabIndex = 20;
            // 
            // grpUserName
            // 
            grpUserName.Controls.Add(txtOBSUsernameResult);
            grpUserName.Controls.Add(txtMMUsernameResult);
            grpUserName.Controls.Add(lblOBSUsernameResult);
            grpUserName.Controls.Add(lblMMUsernameResult);
            grpUserName.Controls.Add(lblUsernameAuditResult);
            grpUserName.Controls.Add(cboUsernameResult);
            grpUserName.Enabled = false;
            grpUserName.Location = new Point(841, 750);
            grpUserName.Margin = new Padding(3, 4, 3, 4);
            grpUserName.Name = "grpUserName";
            grpUserName.Padding = new Padding(3, 4, 3, 4);
            grpUserName.Size = new Size(791, 228);
            grpUserName.TabIndex = 19;
            grpUserName.TabStop = false;
            grpUserName.Text = "Username";
            // 
            // txtOBSUsernameResult
            // 
            txtOBSUsernameResult.Enabled = false;
            txtOBSUsernameResult.Location = new Point(19, 166);
            txtOBSUsernameResult.Margin = new Padding(3, 4, 3, 4);
            txtOBSUsernameResult.Name = "txtOBSUsernameResult";
            txtOBSUsernameResult.Size = new Size(754, 27);
            txtOBSUsernameResult.TabIndex = 25;
            // 
            // txtMMUsernameResult
            // 
            txtMMUsernameResult.Enabled = false;
            txtMMUsernameResult.Location = new Point(18, 107);
            txtMMUsernameResult.Margin = new Padding(3, 4, 3, 4);
            txtMMUsernameResult.Name = "txtMMUsernameResult";
            txtMMUsernameResult.Size = new Size(754, 27);
            txtMMUsernameResult.TabIndex = 24;
            // 
            // lblOBSUsernameResult
            // 
            lblOBSUsernameResult.AutoSize = true;
            lblOBSUsernameResult.Location = new Point(19, 142);
            lblOBSUsernameResult.Name = "lblOBSUsernameResult";
            lblOBSUsernameResult.Size = new Size(84, 20);
            lblOBSUsernameResult.TabIndex = 1;
            lblOBSUsernameResult.Text = "OBS Result:";
            // 
            // lblMMUsernameResult
            // 
            lblMMUsernameResult.AutoSize = true;
            lblMMUsernameResult.Location = new Point(19, 84);
            lblMMUsernameResult.Name = "lblMMUsernameResult";
            lblMMUsernameResult.Size = new Size(133, 20);
            lblMMUsernameResult.TabIndex = 0;
            lblMMUsernameResult.Text = "Mattermost Result:";
            // 
            // lblUsernameAuditResult
            // 
            lblUsernameAuditResult.AutoSize = true;
            lblUsernameAuditResult.Location = new Point(19, 40);
            lblUsernameAuditResult.Name = "lblUsernameAuditResult";
            lblUsernameAuditResult.Size = new Size(96, 20);
            lblUsernameAuditResult.TabIndex = 6;
            lblUsernameAuditResult.Text = "Audit Result: ";
            // 
            // cboUsernameResult
            // 
            cboUsernameResult.FormattingEnabled = true;
            cboUsernameResult.Items.AddRange(new object[] { "PASS", "FAIL" });
            cboUsernameResult.Location = new Point(121, 37);
            cboUsernameResult.Margin = new Padding(3, 4, 3, 4);
            cboUsernameResult.Name = "cboUsernameResult";
            cboUsernameResult.Size = new Size(162, 28);
            cboUsernameResult.TabIndex = 23;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(1381, 1058);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(176, 31);
            btnReset.TabIndex = 20;
            btnReset.Text = "&Reset Form";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(1563, 1058);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(197, 31);
            btnSubmit.TabIndex = 21;
            btnSubmit.Text = "&Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // frmMattermostChatsAudits
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1772, 1099);
            Controls.Add(btnSubmit);
            Controls.Add(btnReset);
            Controls.Add(grpUserName);
            Controls.Add(grpEmail);
            Controls.Add(grpAttachments);
            Controls.Add(grpMessageText);
            Controls.Add(grpUpdateTime);
            Controls.Add(grpCreatedTime);
            Controls.Add(grpOverallAudit);
            Controls.Add(bttnReturntoNav);
            Name = "frmMattermostChatsAudits";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mattermost Chat Audits";
            grpOverallAudit.ResumeLayout(false);
            grpOverallAudit.PerformLayout();
            grpCreatedTime.ResumeLayout(false);
            grpCreatedTime.PerformLayout();
            grpUpdateTime.ResumeLayout(false);
            grpUpdateTime.PerformLayout();
            grpMessageText.ResumeLayout(false);
            grpMessageText.PerformLayout();
            grpAttachments.ResumeLayout(false);
            grpAttachments.PerformLayout();
            grpEmail.ResumeLayout(false);
            grpEmail.PerformLayout();
            grpUserName.ResumeLayout(false);
            grpUserName.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button bttnReturntoNav;
        private GroupBox grpOverallAudit;
        private TextBox txtJounalEmailId;
        private Label lblChannelID;
        private TextBox txtChannelID;
        private TextBox txtOBSObject;
        private Label label8;
        private ComboBox cboOverallAuditResult;
        private Label label4;
        private Label lblPostID;
        private TextBox txtMessageID;
        private Label dtAuditDate;
        private DateTimePicker dtAuditDateTime;
        private GroupBox groupBox1;
        private RadioButton rbManualAudit;
        private GroupBox grpCreatedTime;
        private DateTimePicker dtOBSCreatedTime;
        private Label lblCreatedTimeOBS;
        private DateTimePicker dtMMCreatedTime;
        private Label lblCreatedTimeMM;
        private Label lblCreatedTime;
        private ComboBox cboCreatedTimeResult;
        private GroupBox grpUpdateTime;
        private DateTimePicker dtOBSUpdatedTime;
        private Label lblUpdatedTimeOBS;
        private DateTimePicker dtMMUpdatedTime;
        private Label lblUpdatedTimeMM;
        private Label lblUpdatedTime;
        private ComboBox cboUpdatedTimeResult;
        private GroupBox grpMessageText;
        private Label lblMessageTextOBS;
        private Label lblMessageTextMM;
        private Label lblMessageTextAuditResult;
        private ComboBox cboMessageTextAuditResult;
        private GroupBox grpAttachments;
        private DateTimePicker dateTimePicker5;
        private Label lblAttachmentsOBSResult;
        private DateTimePicker dateTimePicker6;
        private Label lblAttachmentsMMResult;
        private Label lblAttachmentsAuditResult;
        private ComboBox cboAttachmentsResult;
        private GroupBox grpEmail;
        private DateTimePicker dateTimePicker7;
        private Label label15;
        private DateTimePicker dateTimePicker8;
        private Label label16;
        private Label label17;
        private ComboBox cboEmailAuditResult;
        private GroupBox grpUserName;
        private Label lblOBSUsernameResult;
        private DateTimePicker dateTimePicker10;
        private Label label19;
        private Label label20;
        private ComboBox cboUsernameResult;
        private TextBox txtOBSMessageTextResult;
        private TextBox txtMMMessageTextResult;
        private TextBox txtOBSAttachmentsResult;
        private TextBox txtMMAttachmentsResult;
        private TextBox txtOBSEmailResult;
        private TextBox txtMMEmailResult;
        private TextBox txtMMUsernameResult;
        private TextBox txtOBSUsernameResult;
        private Label lblMMEmailResult;
        private Label lblEmailAuditResult;
        private Label lblMMUsernameResult;
        private Label lblUsernameAuditResult;
        private Button btnReset;
        private Button btnSubmit;
    }
}