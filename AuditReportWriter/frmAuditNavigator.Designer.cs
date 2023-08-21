﻿namespace AuditReportWriter
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
            cboSourceApplication = new ComboBox();
            cboTypeofAudit = new ComboBox();
            lblSourceApp = new Label();
            lblTypeAudit = new Label();
            btnGo = new Button();
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
            // cboSourceApplication
            // 
            cboSourceApplication.FormattingEnabled = true;
            cboSourceApplication.Items.AddRange(new object[] { "Exchange", "Mattermost" });
            cboSourceApplication.Location = new Point(12, 103);
            cboSourceApplication.Name = "cboSourceApplication";
            cboSourceApplication.Size = new Size(151, 28);
            cboSourceApplication.TabIndex = 4;
            cboSourceApplication.SelectedIndexChanged += cboSourceApplication_SelectedIndexChanged;
            // 
            // cboTypeofAudit
            // 
            cboTypeofAudit.FormattingEnabled = true;
            cboTypeofAudit.Location = new Point(205, 102);
            cboTypeofAudit.Name = "cboTypeofAudit";
            cboTypeofAudit.Size = new Size(151, 28);
            cboTypeofAudit.TabIndex = 4;
            // 
            // lblSourceApp
            // 
            lblSourceApp.AutoSize = true;
            lblSourceApp.Location = new Point(11, 70);
            lblSourceApp.Name = "lblSourceApp";
            lblSourceApp.Size = new Size(138, 20);
            lblSourceApp.TabIndex = 5;
            lblSourceApp.Text = "Source Application:";
            lblSourceApp.Click += label1_Click_1;
            // 
            // lblTypeAudit
            // 
            lblTypeAudit.AutoSize = true;
            lblTypeAudit.Location = new Point(205, 70);
            lblTypeAudit.Name = "lblTypeAudit";
            lblTypeAudit.Size = new Size(101, 20);
            lblTypeAudit.TabIndex = 5;
            lblTypeAudit.Text = "Type of Audit:";
            // 
            // btnGo
            // 
            btnGo.Location = new Point(428, 101);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(94, 29);
            btnGo.TabIndex = 6;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += button1_Click;
            // 
            // frmAuditNavigator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 253);
            Controls.Add(btnGo);
            Controls.Add(lblTypeAudit);
            Controls.Add(lblSourceApp);
            Controls.Add(cboTypeofAudit);
            Controls.Add(cboSourceApplication);
            Controls.Add(lblSelectAudit);
            Name = "frmAuditNavigator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Audit Navigation";
            Load += frmAuditNavigator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSelectAudit;
        private ComboBox cboSourceApplication;
        private ComboBox cboTypeofAudit;
        private Label lblSourceApp;
        private Label lblTypeAudit;
        private Button btnGo;
    }
}