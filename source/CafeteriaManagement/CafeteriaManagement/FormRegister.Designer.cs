namespace CafeteriaManagement
{
    partial class FormRegister
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSignIn = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSignIn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxReenterPassword = new System.Windows.Forms.TextBox();
            this.textBoxRegisterPassword = new System.Windows.Forms.TextBox();
            this.textBoxRegisterUsername = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.timerSignIn = new System.Windows.Forms.Timer(this.components);
            this.timerRegister = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuFormFadeTransitionFormRegister = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.btnKichHoat = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CafeteriaManagement.Properties.Resources.brigitte_tohm_EAay7Aj4jbc_unsplash;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelSignIn
            // 
            this.panelSignIn.Controls.Add(this.textBoxPassword);
            this.panelSignIn.Controls.Add(this.textBoxUsername);
            this.panelSignIn.Controls.Add(this.panel3);
            this.panelSignIn.Controls.Add(this.panel2);
            this.panelSignIn.Controls.Add(this.buttonSignIn);
            this.panelSignIn.Location = new System.Drawing.Point(320, 193);
            this.panelSignIn.Name = "panelSignIn";
            this.panelSignIn.Size = new System.Drawing.Size(253, 211);
            this.panelSignIn.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxPassword.Location = new System.Drawing.Point(12, 57);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(227, 19);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPassword_KeyDown);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            this.textBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPassword_Validating);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.White;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxUsername.Location = new System.Drawing.Point(12, 8);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(227, 19);
            this.textBoxUsername.TabIndex = 3;
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            this.textBoxUsername.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUsername_Validating);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Location = new System.Drawing.Point(11, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 2);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(12, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 2);
            this.panel2.TabIndex = 0;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.AutoSize = true;
            this.buttonSignIn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(88)))), ((int)(((byte)(169)))));
            this.buttonSignIn.Location = new System.Drawing.Point(7, 103);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(75, 25);
            this.buttonSignIn.TabIndex = 2;
            this.buttonSignIn.Text = "Sign In";
            this.buttonSignIn.Click += new System.EventHandler(this.ButtonSignIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(88)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(313, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(134)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(335, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 90);
            this.label2.TabIndex = 7;
            this.label2.Text = "Coffee\r\n    Management";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CafeteriaManagement.Properties.Resources.icons8_delete_32;
            this.pictureBox2.Location = new System.Drawing.Point(573, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.panel1);
            this.panelRegister.Controls.Add(this.textBoxCode);
            this.panelRegister.Controls.Add(this.panel7);
            this.panelRegister.Controls.Add(this.textBoxReenterPassword);
            this.panelRegister.Controls.Add(this.textBoxRegisterPassword);
            this.panelRegister.Controls.Add(this.textBoxRegisterUsername);
            this.panelRegister.Controls.Add(this.buttonRegister);
            this.panelRegister.Controls.Add(this.panel5);
            this.panelRegister.Controls.Add(this.panel6);
            this.panelRegister.Location = new System.Drawing.Point(596, 193);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(253, 211);
            this.panelRegister.TabIndex = 27;
            this.panelRegister.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(13, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 2);
            this.panel1.TabIndex = 6;
            // 
            // textBoxCode
            // 
            this.textBoxCode.BackColor = System.Drawing.Color.White;
            this.textBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCode.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxCode.Location = new System.Drawing.Point(12, 143);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(227, 19);
            this.textBoxCode.TabIndex = 7;
            this.textBoxCode.Text = "Code";
            this.textBoxCode.Enter += new System.EventHandler(this.TextBoxCode_Enter);
            this.textBoxCode.Leave += new System.EventHandler(this.TextBoxCode_Leave);
            this.textBoxCode.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxCode_Validating);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkGray;
            this.panel7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel7.Location = new System.Drawing.Point(12, 130);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(228, 2);
            this.panel7.TabIndex = 2;
            // 
            // textBoxReenterPassword
            // 
            this.textBoxReenterPassword.BackColor = System.Drawing.Color.White;
            this.textBoxReenterPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxReenterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReenterPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxReenterPassword.Location = new System.Drawing.Point(11, 103);
            this.textBoxReenterPassword.Name = "textBoxReenterPassword";
            this.textBoxReenterPassword.Size = new System.Drawing.Size(227, 19);
            this.textBoxReenterPassword.TabIndex = 5;
            this.textBoxReenterPassword.Text = "Re-enter Password";
            this.textBoxReenterPassword.Enter += new System.EventHandler(this.textBoxReenterPassword_Enter);
            this.textBoxReenterPassword.Leave += new System.EventHandler(this.textBoxReenterPassword_Leave);
            this.textBoxReenterPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxReenterPassword_Validating);
            // 
            // textBoxRegisterPassword
            // 
            this.textBoxRegisterPassword.BackColor = System.Drawing.Color.White;
            this.textBoxRegisterPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxRegisterPassword.Location = new System.Drawing.Point(12, 57);
            this.textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            this.textBoxRegisterPassword.Size = new System.Drawing.Size(227, 19);
            this.textBoxRegisterPassword.TabIndex = 4;
            this.textBoxRegisterPassword.Text = "Password";
            this.textBoxRegisterPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxRegisterPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            this.textBoxRegisterPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPassword_Validating);
            // 
            // textBoxRegisterUsername
            // 
            this.textBoxRegisterUsername.BackColor = System.Drawing.Color.White;
            this.textBoxRegisterUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegisterUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxRegisterUsername.Location = new System.Drawing.Point(13, 8);
            this.textBoxRegisterUsername.Name = "textBoxRegisterUsername";
            this.textBoxRegisterUsername.Size = new System.Drawing.Size(227, 19);
            this.textBoxRegisterUsername.TabIndex = 3;
            this.textBoxRegisterUsername.Text = "Username";
            this.textBoxRegisterUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            this.textBoxRegisterUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            this.textBoxRegisterUsername.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUsername_Validating);
            // 
            // buttonRegister
            // 
            this.buttonRegister.AutoSize = true;
            this.buttonRegister.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(134)))), ((int)(((byte)(89)))));
            this.buttonRegister.Location = new System.Drawing.Point(8, 175);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(84, 25);
            this.buttonRegister.TabIndex = 2;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Location = new System.Drawing.Point(11, 87);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(228, 2);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.Location = new System.Drawing.Point(12, 37);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(227, 2);
            this.panel6.TabIndex = 0;
            // 
            // timerSignIn
            // 
            this.timerSignIn.Interval = 1;
            this.timerSignIn.Tick += new System.EventHandler(this.timerSignIn_Tick);
            // 
            // timerRegister
            // 
            this.timerRegister.Interval = 1;
            this.timerRegister.Tick += new System.EventHandler(this.timerRegister_Tick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // bunifuFormFadeTransitionFormRegister
            // 
            this.bunifuFormFadeTransitionFormRegister.Delay = 1;
            // 
            // btnKichHoat
            // 
            this.btnKichHoat.AutoSize = true;
            this.btnKichHoat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKichHoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(134)))), ((int)(((byte)(89)))));
            this.btnKichHoat.Location = new System.Drawing.Point(491, 421);
            this.btnKichHoat.Name = "btnKichHoat";
            this.btnKichHoat.Size = new System.Drawing.Size(84, 25);
            this.btnKichHoat.TabIndex = 27;
            this.btnKichHoat.Text = "Register";
            this.btnKichHoat.Click += new System.EventHandler(this.btnKichHoat_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Location = new System.Drawing.Point(314, 419);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(269, 1);
            this.panel4.TabIndex = 28;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 453);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnKichHoat);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelSignIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "testRegisterForm";
            this.Load += new System.EventHandler(this.TestRegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSignIn.ResumeLayout(false);
            this.panelSignIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSignIn;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label buttonSignIn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxReenterPassword;
        private System.Windows.Forms.TextBox textBoxRegisterPassword;
        private System.Windows.Forms.TextBox textBoxRegisterUsername;
        private System.Windows.Forms.Label buttonRegister;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Timer timerSignIn;
        private System.Windows.Forms.Timer timerRegister;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCode;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransitionFormRegister;
        private System.Windows.Forms.Label btnKichHoat;
        private System.Windows.Forms.Panel panel4;
    }
}