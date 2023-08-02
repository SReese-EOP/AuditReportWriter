namespace AuditReportWriter
{
    partial class frmEmailAuditReport
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMessageID = new Label();
            txtMessageID = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblMessageID
            // 
            lblMessageID.AutoSize = true;
            lblMessageID.Location = new Point(56, 35);
            lblMessageID.Name = "lblMessageID";
            lblMessageID.Size = new Size(70, 15);
            lblMessageID.TabIndex = 0;
            lblMessageID.Text = "Message ID:";
            // 
            // txtMessageID
            // 
            txtMessageID.Location = new Point(148, 36);
            txtMessageID.Name = "txtMessageID";
            txtMessageID.Size = new Size(139, 23);
            txtMessageID.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Enabled = false;
            btnSubmit.Location = new Point(622, 385);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "&Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // frmEmailAuditReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(txtMessageID);
            Controls.Add(lblMessageID);
            Name = "frmEmailAuditReport";
            Text = "Email Audit Report";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessageID;
        private TextBox txtMessageID;
        private Button btnSubmit;
    }
}