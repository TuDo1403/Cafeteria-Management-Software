namespace CafeteriaManagement
{
    partial class FormLogin
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
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.buttonLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.labelLostPass = new MaterialSkin.Controls.MaterialLabel();
            this.labelRegister = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Depth = 0;
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.GrayText;
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
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(22, 226);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(120, 30);
            this.materialCheckBox1.TabIndex = 2;
            this.materialCheckBox1.Text = "Remember me";
            this.materialCheckBox1.UseVisualStyleBackColor = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Depth = 0;
            this.buttonLogin.Location = new System.Drawing.Point(192, 280);
            this.buttonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Primary = true;
            this.buttonLogin.Size = new System.Drawing.Size(84, 29);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "LogIn";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
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
            // labelLostPass
            // 
            this.labelLostPass.AutoSize = true;
            this.labelLostPass.BackColor = System.Drawing.Color.Transparent;
            this.labelLostPass.Depth = 0;
            this.labelLostPass.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelLostPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelLostPass.Location = new System.Drawing.Point(27, 413);
            this.labelLostPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelLostPass.Name = "labelLostPass";
            this.labelLostPass.Size = new System.Drawing.Size(148, 19);
            this.labelLostPass.TabIndex = 5;
            this.labelLostPass.Text = "Lost your password?";
            this.labelLostPass.Click += new System.EventHandler(this.LabelLostPass_Click);
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.BackColor = System.Drawing.Color.Transparent;
            this.labelRegister.Depth = 0;
            this.labelRegister.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRegister.Location = new System.Drawing.Point(212, 413);
            this.labelRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(64, 19);
            this.labelRegister.TabIndex = 6;
            this.labelRegister.Text = "Register";
            this.labelRegister.Click += new System.EventHandler(this.LabelRegister_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Depth = 0;
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxPassword.Hint = "";
            this.textBoxPassword.Location = new System.Drawing.Point(22, 167);
            this.textBoxPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '\0';
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.SelectionLength = 0;
            this.textBoxPassword.SelectionStart = 0;
            this.textBoxPassword.Size = new System.Drawing.Size(254, 23);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.UseSystemPasswordChar = false;
            this.textBoxPassword.Enter += new System.EventHandler(this.TextBoxPassword_Enter);
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPassword_KeyDown);
            this.textBoxPassword.Leave += new System.EventHandler(this.TextBoxPassword_Leave);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.labelLostPass);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxUsername;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MaterialSkin.Controls.MaterialRaisedButton buttonLogin;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel labelLostPass;
        private MaterialSkin.Controls.MaterialLabel labelRegister;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPassword;
    }
}