namespace GUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblHeader = new Label();
            picLogin = new PictureBox();
            lblEmail = new Label();
            lblPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogin).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Book Antiqua", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(50, 75);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(385, 51);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Book Management";
            // 
            // picLogin
            // 
            picLogin.BackgroundImage = (Image)resources.GetObject("picLogin.BackgroundImage");
            picLogin.BackgroundImageLayout = ImageLayout.Stretch;
            picLogin.Location = new Point(489, -1);
            picLogin.Name = "picLogin";
            picLogin.Size = new Size(491, 456);
            picLogin.TabIndex = 1;
            picLogin.TabStop = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(109, 172);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 24);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(109, 254);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(96, 24);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(109, 199);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(239, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(109, 281);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(239, 27);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(162, 344);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(121, 40);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(979, 455);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(picLogin);
            Controls.Add(lblHeader);
            Name = "LoginForm";
            Text = "Welcome";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)picLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private PictureBox picLogin;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}