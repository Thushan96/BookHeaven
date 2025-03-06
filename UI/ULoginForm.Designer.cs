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
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(458, 177);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(391, 27);
            txtUsername.TabIndex = 0;
            txtUsername.Text = "Username";
            txtUsername.TextChanged += txtEmail_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(458, 247);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(391, 27);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(458, 320);
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
            lblError.Location = new Point(100, 180);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 6;
            // 
            // lblwlcome
            // 
            lblwlcome.AutoSize = true;
            lblwlcome.LinkColor = Color.Black;
            lblwlcome.Location = new Point(586, 62);
            lblwlcome.Name = "lblwlcome";
            lblwlcome.Size = new Size(97, 20);
            lblwlcome.TabIndex = 4;
            lblwlcome.TabStop = true;
            lblwlcome.Text = "Book Heaven";
            lblwlcome.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblwelcme2
            // 
            lblwelcme2.AutoSize = true;
            lblwelcme2.Location = new Point(537, 118);
            lblwelcme2.Name = "lblwelcme2";
            lblwelcme2.Size = new Size(211, 20);
            lblwelcme2.TabIndex = 5;
            lblwelcme2.Text = "Wel come to the  book heaven";
            lblwelcme2.Click += lblwelcme2_Click;
            // 
            // ULoginForm
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1204, 471);
            Controls.Add(lblwelcme2);
            Controls.Add(lblwlcome);
            Controls.Add(lblError);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "ULoginForm";
            Text = "Login";
            Load += ULoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private LinkLabel lblwlcome;
        private Label lblwelcme2;
    }
}
