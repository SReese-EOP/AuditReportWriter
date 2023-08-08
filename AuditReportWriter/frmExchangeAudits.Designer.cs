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
            bttnEmail.Location = new Point(10, 52);
            bttnEmail.Margin = new Padding(3, 2, 3, 2);
            bttnEmail.Name = "bttnEmail";
            bttnEmail.Size = new Size(144, 28);
            bttnEmail.TabIndex = 0;
            bttnEmail.Text = "Email Audit";
            bttnEmail.UseVisualStyleBackColor = true;
            bttnEmail.Click += bttnEmail_Click;
            // 
            // frmExchangeAudits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(bttnEmail);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmExchangeAudits";
            Text = "frmExchangeAudits";
            Load += frmExchangeAudits_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button bttnEmail;
    }
}