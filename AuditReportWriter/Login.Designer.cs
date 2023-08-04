namespace AuditReportWriter
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            LoginLabel = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            LOGINBUTTON = new Button();
            label1 = new Label();
            label2 = new Label();
            USerName = new TextBox();
            Password = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            ServerName = new TextBox();
            DataBaseName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(92, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LoginLabel.Location = new Point(92, 113);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(94, 32);
            LoginLabel.TabIndex = 1;
            LoginLabel.Text = "LOG IN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 170);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(10, 202);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 2);
            panel1.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(10, 252);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(10, 284);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 2);
            panel2.TabIndex = 3;
            // 
            // LOGINBUTTON
            // 
            LOGINBUTTON.BackColor = Color.Gray;
            LOGINBUTTON.FlatStyle = FlatStyle.Flat;
            LOGINBUTTON.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LOGINBUTTON.ForeColor = Color.White;
            LOGINBUTTON.Location = new Point(8, 468);
            LOGINBUTTON.Margin = new Padding(3, 2, 3, 2);
            LOGINBUTTON.Name = "LOGINBUTTON";
            LOGINBUTTON.Size = new Size(295, 28);
            LOGINBUTTON.TabIndex = 4;
            LOGINBUTTON.Text = "LOG IN";
            LOGINBUTTON.UseVisualStyleBackColor = false;
            LOGINBUTTON.Click += LOGINBUTTON_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 451);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 5;
            label1.Text = "Clear Fields";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 509);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 6;
            label2.Text = "EXIT";
            label2.Click += label2_Click;
            // 
            // USerName
            // 
            USerName.Location = new Point(57, 172);
            USerName.Margin = new Padding(3, 2, 3, 2);
            USerName.Multiline = true;
            USerName.Name = "USerName";
            USerName.Size = new Size(246, 26);
            USerName.TabIndex = 7;
            // 
            // Password
            // 
            Password.Location = new Point(57, 254);
            Password.Margin = new Padding(3, 2, 3, 2);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.Size = new Size(246, 26);
            Password.TabIndex = 7;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(10, 318);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 28);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(10, 382);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 28);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            panel3.Location = new Point(10, 350);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(295, 2);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Location = new Point(10, 414);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(295, 2);
            panel4.TabIndex = 3;
            // 
            // ServerName
            // 
            ServerName.BackColor = SystemColors.InactiveCaption;
            ServerName.Location = new Point(57, 320);
            ServerName.Margin = new Padding(3, 2, 3, 2);
            ServerName.Multiline = true;
            ServerName.Name = "ServerName";
            ServerName.Size = new Size(246, 26);
            ServerName.TabIndex = 7;
            ServerName.Text = "74.235.100.158";
            ServerName.TextChanged += ServerName_TextChanged;
            // 
            // DataBaseName
            // 
            DataBaseName.BackColor = SystemColors.InactiveCaption;
            DataBaseName.Location = new Point(57, 384);
            DataBaseName.Margin = new Padding(3, 2, 3, 2);
            DataBaseName.Multiline = true;
            DataBaseName.Name = "DataBaseName";
            DataBaseName.Size = new Size(246, 26);
            DataBaseName.TabIndex = 7;
            DataBaseName.Text = "auditdemo";
            DataBaseName.TextChanged += DataBaseName_TextChanged;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(320, 562);
            Controls.Add(DataBaseName);
            Controls.Add(ServerName);
            Controls.Add(Password);
            Controls.Add(USerName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(LOGINBUTTON);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pictureBox5);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(LoginLabel);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LoginLabel;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Button LOGINBUTTON;
        private Label label1;
        private Label label2;
        private TextBox USerName;
        private TextBox Password;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Panel panel3;
        private Panel panel4;
        private TextBox ServerName;
        private TextBox DataBaseName;
    }
}