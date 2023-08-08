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
            SuspendLayout();
            // 
            // bttnReturntoNav
            // 
            bttnReturntoNav.Location = new Point(469, 394);
            bttnReturntoNav.Name = "bttnReturntoNav";
            bttnReturntoNav.Size = new Size(193, 29);
            bttnReturntoNav.TabIndex = 0;
            bttnReturntoNav.Text = "Return to Navigation";
            bttnReturntoNav.UseVisualStyleBackColor = true;
            // 
            // frmMattermostChatsAudits
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bttnReturntoNav);
            Name = "frmMattermostChatsAudits";
            Text = "Mattermost Chat Audits";
            ResumeLayout(false);
        }

        #endregion

        private Button bttnReturntoNav;
    }
}