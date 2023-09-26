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
            label1 = new Label();
            bttnChanges = new Button();
            btnGo = new Button();
            lblTypeAudit = new Label();
            lblSourceApp = new Label();
            cboTypeofAudit = new ComboBox();
            cboSourceApplication = new ComboBox();
            lblSelectAudit = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 146);
            label1.Name = "label1";
            label1.Size = new Size(432, 20);
            label1.TabIndex = 15;
            label1.Text = "Would you like to submit a new audit or edit an existing record?";
            // 
            // bttnChanges
            // 
            bttnChanges.Location = new Point(277, 178);
            bttnChanges.Name = "bttnChanges";
            bttnChanges.Size = new Size(151, 29);
            bttnChanges.TabIndex = 14;
            bttnChanges.Text = "Edit Existing Record";
            bttnChanges.UseVisualStyleBackColor = true;
            bttnChanges.Click += bttnChanges_Click_1;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(27, 178);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(151, 29);
            btnGo.TabIndex = 11;
            btnGo.Text = "New Audit";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // lblTypeAudit
            // 
            lblTypeAudit.AutoSize = true;
            lblTypeAudit.Location = new Point(277, 58);
            lblTypeAudit.Name = "lblTypeAudit";
            lblTypeAudit.Size = new Size(101, 20);
            lblTypeAudit.TabIndex = 12;
            lblTypeAudit.Text = "Type of Audit:";
            // 
            // lblSourceApp
            // 
            lblSourceApp.AutoSize = true;
            lblSourceApp.Location = new Point(26, 58);
            lblSourceApp.Name = "lblSourceApp";
            lblSourceApp.Size = new Size(138, 20);
            lblSourceApp.TabIndex = 13;
            lblSourceApp.Text = "Source Application:";
            // 
            // cboTypeofAudit
            // 
            cboTypeofAudit.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTypeofAudit.FormattingEnabled = true;
            cboTypeofAudit.Location = new Point(277, 81);
            cboTypeofAudit.Name = "cboTypeofAudit";
            cboTypeofAudit.Size = new Size(151, 28);
            cboTypeofAudit.TabIndex = 9;
            cboTypeofAudit.SelectedIndexChanged += cboTypeofAudit_SelectedIndexChanged_1;
            // 
            // cboSourceApplication
            // 
            cboSourceApplication.FormattingEnabled = true;
            cboSourceApplication.Items.AddRange(new object[] { "Exchange", "Mattermost" });
            cboSourceApplication.Location = new Point(26, 81);
            cboSourceApplication.Name = "cboSourceApplication";
            cboSourceApplication.Size = new Size(151, 28);
            cboSourceApplication.TabIndex = 8;
            cboSourceApplication.SelectedIndexChanged += cboSourceApplication_SelectedIndexChanged_1;
            // 
            // lblSelectAudit
            // 
            lblSelectAudit.AutoSize = true;
            lblSelectAudit.Location = new Point(26, 21);
            lblSelectAudit.Name = "lblSelectAudit";
            lblSelectAudit.Size = new Size(363, 20);
            lblSelectAudit.TabIndex = 10;
            lblSelectAudit.Text = "Select which type of audit you would like to perform. ";
            lblSelectAudit.Click += lblSelectAudit_Click;
            // 
            // frmAuditNavigator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 253);
            Controls.Add(label1);
            Controls.Add(bttnChanges);
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

        private Label label1;
        private Button bttnChanges;
        private Button btnGo;
        private Label lblTypeAudit;
        private Label lblSourceApp;
        private ComboBox cboTypeofAudit;
        private ComboBox cboSourceApplication;
        private Label lblSelectAudit;
    }
}