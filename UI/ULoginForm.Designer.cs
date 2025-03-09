namespace BookHeaven2.UI
{
    partial class ULoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;

        // Dispose method to clean up any resources
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblError = new Label();
            lblwlcome = new LinkLabel();
            lblwelcme2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(672, 197);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(391, 27);
            txtUsername.TabIndex = 0;
            txtUsername.Text = "Username";
            txtUsername.TextChanged += txtEmail_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(672, 254);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(391, 27);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(672, 321);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(391, 35);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(675, 290);
            lblError.Name = "lblError";
            lblError.Size = new Size(2, 35);
            lblError.TabIndex = 6;
            // 
            // lblwlcome
            // 
            lblwlcome.AutoSize = true;
            lblwlcome.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblwlcome.LinkColor = Color.Black;
            lblwlcome.Location = new Point(800, 82);
            lblwlcome.Name = "lblwlcome";
            lblwlcome.Size = new Size(152, 31);
            lblwlcome.TabIndex = 4;
            lblwlcome.TabStop = true;
            lblwlcome.Text = "Book Haven";
            lblwlcome.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblwelcme2
            // 
            lblwelcme2.AutoSize = true;
            lblwelcme2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblwelcme2.ForeColor = SystemColors.Info;
            lblwelcme2.Location = new Point(725, 124);
            lblwelcme2.Name = "lblwelcme2";
            lblwelcme2.Size = new Size(313, 25);
            lblwelcme2.TabIndex = 5;
            lblwelcme2.Text = "Wel come to the  paradise of books";
            lblwelcme2.Click += lblwelcme2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.library_425730_1280;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(599, 447);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ULoginForm
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1204, 471);
            Controls.Add(pictureBox1);
            Controls.Add(lblwelcme2);
            Controls.Add(lblwlcome);
            Controls.Add(lblError);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "ULoginForm";
            Text = "Login";
            Load += ULoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private LinkLabel lblwlcome;
        private Label lblwelcme2;
        private PictureBox pictureBox1;
    }
}
