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
            label10 = new Label();
            txtJounalEmailId = new TextBox();
            label9 = new Label();
            txtJournaledMailbox = new TextBox();
            txtOBSObject = new TextBox();
            label8 = new Label();
            cboOverallAuditResult = new ComboBox();
            label4 = new Label();
            lblMessageID = new Label();
            txtMessageID = new TextBox();
            dtAuditDate = new Label();
            dtAuditDateTime = new DateTimePicker();
            grpOverallAudit.SuspendLayout();
            SuspendLayout();
            // 
            // bttnReturntoNav
            // 
            bttnReturntoNav.Location = new Point(595, 409);
            bttnReturntoNav.Name = "bttnReturntoNav";
            bttnReturntoNav.Size = new Size(193, 29);
            bttnReturntoNav.TabIndex = 0;
            bttnReturntoNav.Text = "Return to Navigation";
            bttnReturntoNav.UseVisualStyleBackColor = true;
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
            grpOverallAudit.Location = new Point(12, 13);
            grpOverallAudit.Margin = new Padding(3, 4, 3, 4);
            grpOverallAudit.Name = "grpOverallAudit";
            grpOverallAudit.Padding = new Padding(3, 4, 3, 4);
            grpOverallAudit.Size = new Size(1729, 195);
            grpOverallAudit.TabIndex = 13;
            grpOverallAudit.TabStop = false;
            grpOverallAudit.Text = "Audit Information";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(536, 81);
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
            label9.Location = new Point(2, 83);
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
            txtOBSObject.Location = new Point(708, 28);
            txtOBSObject.Margin = new Padding(3, 4, 3, 4);
            txtOBSObject.Name = "txtOBSObject";
            txtOBSObject.Size = new Size(863, 27);
            txtOBSObject.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(594, 33);
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
            // lblMessageID
            // 
            lblMessageID.AutoSize = true;
            lblMessageID.Location = new Point(19, 41);
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
            // dtAuditDate
            // 
            dtAuditDate.AutoSize = true;
            dtAuditDate.Location = new Point(18, 150);
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
            // frmMattermostChatsAudits
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1772, 698);
            Controls.Add(grpOverallAudit);
            Controls.Add(bttnReturntoNav);
            Name = "frmMattermostChatsAudits";
            Text = "Mattermost Chat Audits";
            grpOverallAudit.ResumeLayout(false);
            grpOverallAudit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button bttnReturntoNav;
        private GroupBox grpOverallAudit;
        private Label label10;
        private TextBox txtJounalEmailId;
        private Label label9;
        private TextBox txtJournaledMailbox;
        private TextBox txtOBSObject;
        private Label label8;
        private ComboBox cboOverallAuditResult;
        private Label label4;
        private Label lblMessageID;
        private TextBox txtMessageID;
        private Label dtAuditDate;
        private DateTimePicker dtAuditDateTime;
    }
}