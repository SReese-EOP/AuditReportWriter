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
            bttnEmailAudit = new Button();
            bttnMattermost = new Button();
            lblSelectAudit = new Label();
            SuspendLayout();
            // 
            // bttnEmailAudit
            // 
            bttnEmailAudit.Location = new Point(51, 104);
            bttnEmailAudit.Name = "bttnEmailAudit";
            bttnEmailAudit.Size = new Size(139, 69);
            bttnEmailAudit.TabIndex = 0;
            bttnEmailAudit.Text = "Email Audit";
            bttnEmailAudit.UseVisualStyleBackColor = true;
            bttnEmailAudit.Click += bttnEmailAudit_Click;
            // 
            // bttnMattermost
            // 
            bttnMattermost.Location = new Point(315, 104);
            bttnMattermost.Name = "bttnMattermost";
            bttnMattermost.Size = new Size(134, 69);
            bttnMattermost.TabIndex = 1;
            bttnMattermost.Text = "Mattermost Audit";
            bttnMattermost.UseVisualStyleBackColor = true;
            // 
            // lblSelectAudit
            // 
            lblSelectAudit.AutoSize = true;
            lblSelectAudit.Location = new Point(12, 27);
            lblSelectAudit.Name = "lblSelectAudit";
            lblSelectAudit.Size = new Size(363, 20);
            lblSelectAudit.TabIndex = 2;
            lblSelectAudit.Text = "Select which type of audit you would like to perform. ";
            lblSelectAudit.Click += label1_Click;
            // 
            // frmAuditNavirgator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSelectAudit);
            Controls.Add(bttnMattermost);
            Controls.Add(bttnEmailAudit);
            Name = "frmAuditNavirgator";
            Text = "frmAuditNavirgator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnEmailAudit;
        private Button bttnMattermost;
        private Label lblSelectAudit;
    }
}