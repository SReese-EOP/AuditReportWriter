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
            tabcAuditNav = new TabControl();
            tbcExchange = new TabPage();
            bttnEmail = new Button();
            tbcMattermost = new TabPage();
            bttnChat = new Button();
            button1 = new Button();
            lblAuditText = new Label();
            tabcAuditNav.SuspendLayout();
            tbcExchange.SuspendLayout();
            tbcMattermost.SuspendLayout();
            SuspendLayout();
            // 
            // tabcAuditNav
            // 
<<<<<<< HEAD
            tabcAuditNav.Controls.Add(tbcExchange);
            tabcAuditNav.Controls.Add(tbcMattermost);
            tabcAuditNav.Location = new Point(12, 82);
            tabcAuditNav.Name = "tabcAuditNav";
            tabcAuditNav.SelectedIndex = 0;
            tabcAuditNav.Size = new Size(523, 288);
            tabcAuditNav.TabIndex = 3;
=======
            bttnEmailAudit.Location = new Point(45, 78);
            bttnEmailAudit.Margin = new Padding(3, 2, 3, 2);
            bttnEmailAudit.Name = "bttnEmailAudit";
            bttnEmailAudit.Size = new Size(122, 52);
            bttnEmailAudit.TabIndex = 0;
            bttnEmailAudit.Text = "Email Audit";
            bttnEmailAudit.UseVisualStyleBackColor = true;
            bttnEmailAudit.Click += bttnEmailAudit_Click;
>>>>>>> main
            // 
            // tbcExchange
            // 
<<<<<<< HEAD
            tbcExchange.BackColor = Color.Transparent;
            tbcExchange.Controls.Add(bttnEmail);
            tbcExchange.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbcExchange.Location = new Point(4, 29);
            tbcExchange.Name = "tbcExchange";
            tbcExchange.Padding = new Padding(3);
            tbcExchange.Size = new Size(515, 255);
            tbcExchange.TabIndex = 0;
            tbcExchange.Text = "Exchange";
            tbcExchange.UseVisualStyleBackColor = true;
            tbcExchange.Click += tabPage1_Click;
=======
            bttnMattermost.Location = new Point(276, 78);
            bttnMattermost.Margin = new Padding(3, 2, 3, 2);
            bttnMattermost.Name = "bttnMattermost";
            bttnMattermost.Size = new Size(117, 52);
            bttnMattermost.TabIndex = 1;
            bttnMattermost.Text = "Mattermost Audit";
            bttnMattermost.UseVisualStyleBackColor = true;
            bttnMattermost.Click += bttnMattermost_Click_1;
>>>>>>> main
            // 
            // bttnEmail
            // 
<<<<<<< HEAD
            bttnEmail.Location = new Point(26, 29);
            bttnEmail.Name = "bttnEmail";
            bttnEmail.Size = new Size(94, 29);
            bttnEmail.TabIndex = 1;
            bttnEmail.Text = "Email";
            bttnEmail.UseVisualStyleBackColor = true;
            bttnEmail.Click += bttnEmail_Click;
            // 
            // tbcMattermost
            // 
            tbcMattermost.Controls.Add(bttnChat);
            tbcMattermost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbcMattermost.Location = new Point(4, 29);
            tbcMattermost.Name = "tbcMattermost";
            tbcMattermost.Padding = new Padding(3);
            tbcMattermost.Size = new Size(515, 255);
            tbcMattermost.TabIndex = 1;
            tbcMattermost.Text = "Mattermost";
            tbcMattermost.UseVisualStyleBackColor = true;
            // 
            // bttnChat
            // 
            bttnChat.Location = new Point(23, 28);
            bttnChat.Name = "bttnChat";
            bttnChat.Size = new Size(94, 29);
            bttnChat.TabIndex = 1;
            bttnChat.Text = "Chat";
            bttnChat.UseVisualStyleBackColor = true;
            bttnChat.Click += bttnChat_Click;
            // 
            // button1
            // 
            button1.Location = new Point(478, -2);
            button1.Name = "button1";
            button1.Size = new Size(8, 10);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblAuditText
            // 
            lblAuditText.AutoSize = true;
            lblAuditText.Location = new Point(12, 29);
            lblAuditText.Name = "lblAuditText";
            lblAuditText.Size = new Size(287, 20);
            lblAuditText.TabIndex = 5;
            lblAuditText.Text = "Select the audit process to be performed. ";
=======
            lblSelectAudit.AutoSize = true;
            lblSelectAudit.Location = new Point(10, 20);
            lblSelectAudit.Name = "lblSelectAudit";
            lblSelectAudit.Size = new Size(289, 15);
            lblSelectAudit.TabIndex = 2;
            lblSelectAudit.Text = "Select which type of audit you would like to perform. ";
            lblSelectAudit.Click += label1_Click;
>>>>>>> main
            // 
            // frmAuditNavigator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            ClientSize = new Size(570, 421);
            Controls.Add(lblAuditText);
            Controls.Add(button1);
            Controls.Add(tabcAuditNav);
            Name = "frmAuditNavigator";
            Text = "Audit Navigation";
            tabcAuditNav.ResumeLayout(false);
            tbcExchange.ResumeLayout(false);
            tbcMattermost.ResumeLayout(false);
=======
            ClientSize = new Size(700, 338);
            Controls.Add(lblSelectAudit);
            Controls.Add(bttnMattermost);
            Controls.Add(bttnEmailAudit);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAuditNavigator";
            Text = "frmAuditNavirgator";
            Load += frmAuditNavigator_Load;
>>>>>>> main
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label lblSelectAudit;
        private TabControl tabcAuditNav;
        private TabPage tbcExchange;
        private TabPage tbcMattermost;
        private Button bttnEmail;
        private Button bttnChat;
        private Button button1;
        private Label lblAuditText;
    }
}