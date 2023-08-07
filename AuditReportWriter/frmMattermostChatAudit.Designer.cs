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
            bttnReturnNav.Location = new Point(592, 409);
            bttnReturnNav.Name = "bttnReturnNav";
            bttnReturnNav.Size = new Size(185, 29);
            bttnReturnNav.TabIndex = 1;
            bttnReturnNav.Text = "Return to Navigation";
            bttnReturnNav.UseVisualStyleBackColor = true;
            bttnReturnNav.Click += bttnReturnNav_Click;
            // 
            // frmMattermostChatAudit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}