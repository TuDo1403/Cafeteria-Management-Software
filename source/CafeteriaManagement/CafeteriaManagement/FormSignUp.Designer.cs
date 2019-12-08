namespace CafeteriaManagement
{
    partial class FormSignUp
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
            this.textBoxUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxPasswordMatch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.labelAlreadyHaveAccount = new MaterialSkin.Controls.MaterialLabel();
            this.labelLogin = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Depth = 0;
            this.textBoxUsername.Hint = "";
            this.textBoxUsername.Location = new System.Drawing.Point(22, 111);
            this.textBoxUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PasswordChar = '\0';
            this.textBoxUsername.SelectedText = "";
            this.textBoxUsername.SelectionLength = 0;
            this.textBoxUsername.SelectionStart = 0;
            this.textBoxUsername.Size = new System.Drawing.Size(254, 23);
            this.textBoxUsername.TabIndex = 0;
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.UseSystemPasswordChar = false;
            this.textBoxUsername.Enter += new System.EventHandler(this.TextBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.TextBoxUsername_Leave);
            // 
            // textBoxPasswordMatch
            // 
            this.textBoxPasswordMatch.Depth = 0;
            this.textBoxPasswordMatch.Hint = "";
            this.textBoxPasswordMatch.Location = new System.Drawing.Point(22, 270);
            this.textBoxPasswordMatch.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPasswordMatch.Name = "textBoxPasswordMatch";
            this.textBoxPasswordMatch.PasswordChar = '\0';
            this.textBoxPasswordMatch.SelectedText = "";
            this.textBoxPasswordMatch.SelectionLength = 0;
            this.textBoxPasswordMatch.SelectionStart = 0;
            this.textBoxPasswordMatch.Size = new System.Drawing.Size(254, 23);
            this.textBoxPasswordMatch.TabIndex = 1;
            this.textBoxPasswordMatch.Text = "Re-enter Password";
            this.textBoxPasswordMatch.UseSystemPasswordChar = false;
            this.textBoxPasswordMatch.Enter += new System.EventHandler(this.TextBoxPasswordMatch_Enter);
            this.textBoxPasswordMatch.Leave += new System.EventHandler(this.TextBoxPasswordMatch_Leave);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(192, 319);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(84, 29);
            this.materialRaisedButton1.TabIndex = 3;
            this.materialRaisedButton1.Text = "REGISTER";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.Button_Register_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(22, 383);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(254, 1);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // labelAlreadyHaveAccount
            // 
            this.labelAlreadyHaveAccount.AutoSize = true;
            this.labelAlreadyHaveAccount.BackColor = System.Drawing.Color.Transparent;
            this.labelAlreadyHaveAccount.Depth = 0;
            this.labelAlreadyHaveAccount.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelAlreadyHaveAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelAlreadyHaveAccount.Location = new System.Drawing.Point(18, 413);
            this.labelAlreadyHaveAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAlreadyHaveAccount.Name = "labelAlreadyHaveAccount";
            this.labelAlreadyHaveAccount.Size = new System.Drawing.Size(179, 19);
            this.labelAlreadyHaveAccount.TabIndex = 5;
            this.labelAlreadyHaveAccount.Text = "Already have an account?";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Depth = 0;
            this.labelLogin.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelLogin.Location = new System.Drawing.Point(230, 413);
            this.labelLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(46, 19);
            this.labelLogin.TabIndex = 6;
            this.labelLogin.Text = "Login";
            this.labelLogin.Click += new System.EventHandler(this.Label_Login_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Depth = 0;
            this.textBoxEmail.Hint = "";
            this.textBoxEmail.Location = new System.Drawing.Point(22, 164);
            this.textBoxEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PasswordChar = '\0';
            this.textBoxEmail.SelectedText = "";
            this.textBoxEmail.SelectionLength = 0;
            this.textBoxEmail.SelectionStart = 0;
            this.textBoxEmail.Size = new System.Drawing.Size(254, 23);
            this.textBoxEmail.TabIndex = 7;
            this.textBoxEmail.Text = "Email";
            this.textBoxEmail.UseSystemPasswordChar = false;
            this.textBoxEmail.Enter += new System.EventHandler(this.TextBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.TextBoxEmail_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Depth = 0;
            this.textBoxPassword.Hint = "";
            this.textBoxPassword.Location = new System.Drawing.Point(22, 214);
            this.textBoxPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '\0';
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.SelectionLength = 0;
            this.textBoxPassword.SelectionStart = 0;
            this.textBoxPassword.Size = new System.Drawing.Size(254, 23);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.UseSystemPasswordChar = false;
            this.textBoxPassword.Enter += new System.EventHandler(this.TextBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.TextBoxPassword_Leave);
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 450);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelAlreadyHaveAccount);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.textBoxPasswordMatch);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "FormSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.LogIn3_SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPasswordMatch;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel labelAlreadyHaveAccount;
        private MaterialSkin.Controls.MaterialLabel labelLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPassword;
    }
}