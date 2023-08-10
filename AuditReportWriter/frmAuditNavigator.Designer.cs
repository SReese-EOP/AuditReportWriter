namespace AuditReportWriter
{
    partial class frmAuditNavigator
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
            lblSelectAudit = new Label();
            tabControl1 = new TabControl();
            tbcExchange = new TabPage();
            bttnEmailAudit = new Button();
            tbcMattermost = new TabPage();
            bttnChatAudit = new Button();
            cboSourceApplication = new ComboBox();
            cboTypeofAudit = new ComboBox();
            lblSourceApp = new Label();
            lblTypeAudit = new Label();
            tabControl1.SuspendLayout();
            tbcExchange.SuspendLayout();
            tbcMattermost.SuspendLayout();
            SuspendLayout();
            // 
            // lblSelectAudit
            // 
            lblSelectAudit.AutoSize = true;
            lblSelectAudit.Location = new Point(11, 27);
            lblSelectAudit.Name = "lblSelectAudit";
            lblSelectAudit.Size = new Size(363, 20);
            lblSelectAudit.TabIndex = 2;
            lblSelectAudit.Text = "Select which type of audit you would like to perform. ";
            lblSelectAudit.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbcExchange);
            tabControl1.Controls.Add(tbcMattermost);
            tabControl1.Location = new Point(11, 71);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(519, 274);
            tabControl1.TabIndex = 3;
            // 
            // tbcExchange
            // 
            tbcExchange.Controls.Add(bttnEmailAudit);
            tbcExchange.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbcExchange.Location = new Point(4, 29);
            tbcExchange.Name = "tbcExchange";
            tbcExchange.Padding = new Padding(3);
            tbcExchange.Size = new Size(511, 241);
            tbcExchange.TabIndex = 0;
            tbcExchange.Text = "Exchange Audits";
            tbcExchange.UseVisualStyleBackColor = true;
            // 
            // bttnEmailAudit
            // 
            bttnEmailAudit.Location = new Point(6, 23);
            bttnEmailAudit.Name = "bttnEmailAudit";
            bttnEmailAudit.Size = new Size(94, 29);
            bttnEmailAudit.TabIndex = 1;
            bttnEmailAudit.Text = "Email Audit";
            bttnEmailAudit.UseVisualStyleBackColor = true;
            bttnEmailAudit.Click += bttnEmailAudit_Click_1;
            // 
            // tbcMattermost
            // 
            tbcMattermost.Controls.Add(bttnChatAudit);
            tbcMattermost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbcMattermost.Location = new Point(4, 29);
            tbcMattermost.Name = "tbcMattermost";
            tbcMattermost.Padding = new Padding(3);
            tbcMattermost.Size = new Size(511, 241);
            tbcMattermost.TabIndex = 1;
            tbcMattermost.Text = "Mattermost Audits";
            tbcMattermost.UseVisualStyleBackColor = true;
            // 
            // bttnChatAudit
            // 
            bttnChatAudit.Location = new Point(6, 19);
            bttnChatAudit.Name = "bttnChatAudit";
            bttnChatAudit.Size = new Size(94, 29);
            bttnChatAudit.TabIndex = 1;
            bttnChatAudit.Text = "Chat Audit";
            bttnChatAudit.UseVisualStyleBackColor = true;
            bttnChatAudit.Click += bttnChatAudit_Click;
            // 
            // cboSourceApplication
            // 
            cboSourceApplication.FormattingEnabled = true;
            cboSourceApplication.Items.AddRange(new object[] { "Exchange", "Mattermost" });
            cboSourceApplication.Location = new Point(795, 100);
            cboSourceApplication.Name = "cboSourceApplication";
            cboSourceApplication.Size = new Size(151, 28);
            cboSourceApplication.TabIndex = 4;
            // 
            // cboTypeofAudit
            // 
            cboTypeofAudit.FormattingEnabled = true;
            cboTypeofAudit.Items.AddRange(new object[] { "Email", "Cakendar", "", "Other", "Chat" });
            cboTypeofAudit.Location = new Point(1131, 100);
            cboTypeofAudit.Name = "cboTypeofAudit";
            cboTypeofAudit.Size = new Size(151, 28);
            cboTypeofAudit.TabIndex = 4;
            // 
            // lblSourceApp
            // 
            lblSourceApp.AutoSize = true;
            lblSourceApp.Location = new Point(641, 108);
            lblSourceApp.Name = "lblSourceApp";
            lblSourceApp.Size = new Size(138, 20);
            lblSourceApp.TabIndex = 5;
            lblSourceApp.Text = "Source Application:";
            lblSourceApp.Click += label1_Click_1;
            // 
            // lblTypeAudit
            // 
            lblTypeAudit.AutoSize = true;
            lblTypeAudit.Location = new Point(1009, 108);
            lblTypeAudit.Name = "lblTypeAudit";
            lblTypeAudit.Size = new Size(101, 20);
            lblTypeAudit.TabIndex = 5;
            lblTypeAudit.Text = "Type of Audit:";
            // 
            // frmAuditNavigator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1488, 417);
            Controls.Add(lblTypeAudit);
            Controls.Add(lblSourceApp);
            Controls.Add(cboTypeofAudit);
            Controls.Add(cboSourceApplication);
            Controls.Add(tabControl1);
            Controls.Add(lblSelectAudit);
            Name = "frmAuditNavigator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Audit Navigation";
            Load += frmAuditNavigator_Load;
            tabControl1.ResumeLayout(false);
            tbcExchange.ResumeLayout(false);
            tbcMattermost.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSelectAudit;
        private TabControl tabControl1;
        private TabPage tbcExchange;
        private Button bttnEmailAudit;
        private TabPage tbcMattermost;
        private Button bttnChatAudit;
        private ComboBox cboSourceApplication;
        private ComboBox cboTypeofAudit;
        private Label lblSourceApp;
        private Label lblTypeAudit;
    }
}