namespace AuditReportWriter
{
    partial class frmMattermostChatAudit
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
            lblMattermostHome = new Label();
            bttnReturnNav = new Button();
            bttnReset = new Button();
            bttnSubmit = new Button();
            SuspendLayout();
            // 
            // lblMattermostHome
            // 
            lblMattermostHome.AutoSize = true;
            lblMattermostHome.Location = new Point(12, 22);
            lblMattermostHome.Name = "lblMattermostHome";
            lblMattermostHome.Size = new Size(160, 20);
            lblMattermostHome.TabIndex = 0;
            lblMattermostHome.Text = "Mattermost Chat Audit";
            lblMattermostHome.Click += lblMattermostHome_Click;
            // 
            // bttnReturnNav
            // 
            bttnReturnNav.Location = new Point(397, 486);
            bttnReturnNav.Name = "bttnReturnNav";
            bttnReturnNav.Size = new Size(185, 29);
            bttnReturnNav.TabIndex = 1;
            bttnReturnNav.Text = "Return to Navigation";
            bttnReturnNav.UseVisualStyleBackColor = true;
            bttnReturnNav.Click += bttnReturnNav_Click;
            // 
            // bttnReset
            // 
            bttnReset.Location = new Point(604, 486);
            bttnReset.Name = "bttnReset";
            bttnReset.Size = new Size(141, 29);
            bttnReset.TabIndex = 1;
            bttnReset.Text = "&Reset";
            bttnReset.UseVisualStyleBackColor = true;
            bttnReset.Click += bttnReturnNav_Click;
            // 
            // bttnSubmit
            // 
            bttnSubmit.Location = new Point(765, 486);
            bttnSubmit.Name = "bttnSubmit";
            bttnSubmit.Size = new Size(141, 29);
            bttnSubmit.TabIndex = 1;
            bttnSubmit.Text = "&Submit";
            bttnSubmit.UseVisualStyleBackColor = true;
            bttnSubmit.Click += bttnReturnNav_Click;
            // 
            // frmMattermostChatAudit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 527);
            Controls.Add(bttnSubmit);
            Controls.Add(bttnReset);
            Controls.Add(bttnReturnNav);
            Controls.Add(lblMattermostHome);
            Name = "frmMattermostChatAudit";
            Text = "Mattermost Chat Audit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMattermostHome;
        private Button bttnReturnNav;
        private Button bttnReset;
        private Button bttnSubmit;
    }
}