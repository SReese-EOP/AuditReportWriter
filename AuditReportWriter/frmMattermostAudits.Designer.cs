namespace AuditReportWriter
{
    partial class frmMattermostAudits
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
            lblMattermosthome = new Label();
            bttnChat = new Button();
            SuspendLayout();
            // 
            // lblMattermosthome
            // 
            lblMattermosthome.AutoSize = true;
            lblMattermosthome.Location = new Point(0, 0);
            lblMattermosthome.Name = "lblMattermosthome";
            lblMattermosthome.Size = new Size(283, 20);
            lblMattermosthome.TabIndex = 0;
            lblMattermosthome.Text = "Select the section of Mattermost to audit.";
            lblMattermosthome.Click += label1_Click;
            // 
            // bttnChat
            // 
            bttnChat.Location = new Point(12, 76);
            bttnChat.Name = "bttnChat";
            bttnChat.Size = new Size(126, 44);
            bttnChat.TabIndex = 1;
            bttnChat.Text = "Chat Audit";
            bttnChat.UseVisualStyleBackColor = true;
            bttnChat.Click += bttnChat_Click;
            // 
            // frmMattermostAudits
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bttnChat);
            Controls.Add(lblMattermosthome);
            Name = "frmMattermostAudits";
            Text = "Mattermost Audit Overview";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMattermosthome;
        private Button bttnChat;
    }
}