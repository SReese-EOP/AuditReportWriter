namespace AuditReportWriter
{
    partial class frmExchangeAudits
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
            bttnEmail = new Button();
            SuspendLayout();
            // 
            // bttnEmail
            // 
            bttnEmail.Location = new Point(12, 70);
            bttnEmail.Name = "bttnEmail";
            bttnEmail.Size = new Size(165, 37);
            bttnEmail.TabIndex = 0;
            bttnEmail.Text = "Email Audit";
            bttnEmail.UseVisualStyleBackColor = true;
            bttnEmail.Click += bttnEmail_Click;
            // 
            // frmExchangeAudits
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bttnEmail);
            Name = "frmExchangeAudits";
            Text = "frmExchangeAudits";
            ResumeLayout(false);
        }

        #endregion

        private Button bttnEmail;
    }
}