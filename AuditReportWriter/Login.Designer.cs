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
            txtDesktopName = new TextBox();
            Password = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            ServerName = new TextBox();
            DataBaseName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox6 = new PictureBox();
            panel5 = new Panel();
            USerName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(107, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LoginLabel.Location = new Point(24, 85);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(300, 31);
            LoginLabel.TabIndex = 1;
            LoginLabel.Text = "Verification and Validation\r\n";
            LoginLabel.Click += LoginLabel_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(11, 227);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(11, 269);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 3);
            panel1.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(11, 336);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(11, 379);
            panel2.Name = "panel2";
            panel2.Size = new Size(337, 3);
            panel2.TabIndex = 3;
            // 
            // LOGINBUTTON
            // 
            LOGINBUTTON.BackColor = Color.Gray;
            LOGINBUTTON.FlatStyle = FlatStyle.Flat;
            LOGINBUTTON.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LOGINBUTTON.ForeColor = Color.White;
            LOGINBUTTON.Location = new Point(9, 624);
            LOGINBUTTON.Name = "LOGINBUTTON";
            LOGINBUTTON.Size = new Size(337, 52);
            LOGINBUTTON.TabIndex = 3;
            LOGINBUTTON.Text = "LOG IN";
            LOGINBUTTON.UseVisualStyleBackColor = false;
            LOGINBUTTON.Click += LOGINBUTTON_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 601);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 6;
            label1.Text = "Clear Fields";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 679);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 7;
            label2.Text = "EXIT";
            label2.Click += label2_Click;
            // 
            // txtDesktopName
            // 
            txtDesktopName.AcceptsTab = true;
            txtDesktopName.AllowDrop = true;
            txtDesktopName.Location = new Point(65, 733);
            txtDesktopName.Name = "txtDesktopName";
            txtDesktopName.Size = new Size(278, 27);
            txtDesktopName.TabIndex = 10;
            txtDesktopName.TextChanged += USerName_TextChanged;
            // 
            // Password
            // 
            Password.AcceptsTab = true;
            Password.Location = new Point(65, 339);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(281, 27);
            Password.TabIndex = 2;
            Password.UseSystemPasswordChar = true;
            Password.TextChanged += Password_TextChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(11, 424);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 37);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(11, 509);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(47, 37);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            panel3.Location = new Point(11, 467);
            panel3.Name = "panel3";
            panel3.Size = new Size(337, 3);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Location = new Point(11, 552);
            panel4.Name = "panel4";
            panel4.Size = new Size(337, 3);
            panel4.TabIndex = 3;
            // 
            // ServerName
            // 
            ServerName.AcceptsTab = true;
            ServerName.BackColor = SystemColors.InactiveCaption;
            ServerName.Location = new Point(65, 427);
            ServerName.Multiline = true;
            ServerName.Name = "ServerName";
            ServerName.Size = new Size(281, 33);
            ServerName.TabIndex = 4;
            ServerName.Text = "74.235.100.158";
            ServerName.TextChanged += ServerName_TextChanged;
            // 
            // DataBaseName
            // 
            DataBaseName.AcceptsTab = true;
            DataBaseName.BackColor = SystemColors.InactiveCaption;
            DataBaseName.Location = new Point(65, 512);
            DataBaseName.Multiline = true;
            DataBaseName.Name = "DataBaseName";
            DataBaseName.Size = new Size(281, 33);
            DataBaseName.TabIndex = 5;
            DataBaseName.Text = "auditdemo";
            DataBaseName.TextChanged += DataBaseName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(119, 156);
            label3.Name = "label3";
            label3.Size = new Size(81, 31);
            label3.TabIndex = 8;
            label3.Text = "Log In";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(50, 116);
            label4.Name = "label4";
            label4.Size = new Size(247, 31);
            label4.TabIndex = 8;
            label4.Text = "Manual Audit Process";
            label4.Click += label4_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(11, 727);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(47, 37);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // panel5
            // 
            panel5.Location = new Point(11, 769);
            panel5.Name = "panel5";
            panel5.Size = new Size(337, 3);
            panel5.TabIndex = 3;
            // 
            // USerName
            // 
            USerName.AcceptsTab = true;
            USerName.AllowDrop = true;
            USerName.Location = new Point(67, 227);
            USerName.Name = "USerName";
            USerName.Size = new Size(281, 27);
            USerName.TabIndex = 1;
            USerName.TextChanged += USerName_TextChanged;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(366, 811);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(DataBaseName);
            Controls.Add(ServerName);
            Controls.Add(Password);
            Controls.Add(USerName);
            Controls.Add(txtDesktopName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(LOGINBUTTON);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pictureBox5);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox2);
            Controls.Add(LoginLabel);
            Controls.Add(pictureBox1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
        private TextBox txtDesktopName;
        private TextBox Password;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Panel panel3;
        private Panel panel4;
        private TextBox ServerName;
        private TextBox DataBaseName;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox6;
        private Panel panel5;
        private TextBox USerName;
    }
}