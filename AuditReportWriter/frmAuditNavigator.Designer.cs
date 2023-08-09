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
            bttnEmailAudit.Location = new Point(45, 78);
            bttnEmailAudit.Margin = new Padding(3, 2, 3, 2);
            bttnEmailAudit.Name = "bttnEmailAudit";
            bttnEmailAudit.Size = new Size(122, 52);
            bttnEmailAudit.TabIndex = 0;
            bttnEmailAudit.Text = "Email Audit";
            bttnEmailAudit.UseVisualStyleBackColor = true;
            bttnEmailAudit.Click += bttnEmailAudit_Click;
            // 
            // bttnMattermost
            // 
            bttnMattermost.Location = new Point(276, 78);
            bttnMattermost.Margin = new Padding(3, 2, 3, 2);
            bttnMattermost.Name = "bttnMattermost";
            bttnMattermost.Size = new Size(117, 52);
            bttnMattermost.TabIndex = 1;
            bttnMattermost.Text = "Mattermost Audit";
            bttnMattermost.UseVisualStyleBackColor = true;
            bttnMattermost.Click += bttnMattermost_Click_1;
            // 
            // lblSelectAudit
            // 
            lblSelectAudit.AutoSize = true;
            lblSelectAudit.Location = new Point(10, 20);
            lblSelectAudit.Name = "lblSelectAudit";
            lblSelectAudit.Size = new Size(289, 15);
            lblSelectAudit.TabIndex = 2;
            lblSelectAudit.Text = "Select which type of audit you would like to perform. ";
            lblSelectAudit.Click += label1_Click;
            // 
            // frmAuditNavigator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lblSelectAudit);
            Controls.Add(bttnMattermost);
            Controls.Add(bttnEmailAudit);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAuditNavigator";
            Text = "frmAuditNavirgator";
            Load += frmAuditNavigator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnEmailAudit;
        private Button bttnMattermost;
        private Label lblSelectAudit;
    }
}