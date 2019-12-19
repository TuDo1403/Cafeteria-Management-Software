namespace CafeteriaManagement.CustomUserControl
{
    partial class UCSetting
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipseAvata = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBoxPasswordCurrent = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.textBoxReenterPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuElipseDate = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.labelChangeImage = new MaterialSkin.Controls.MaterialLabel();
            this.panelChangePassword = new System.Windows.Forms.Panel();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxCurrentPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.radioButtonFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.labelGender = new System.Windows.Forms.Label();
            this.radioButtonMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonNone = new MaterialSkin.Controls.MaterialRadioButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxDisplayName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelDisplayName = new System.Windows.Forms.Label();
            this.panelEditProfile = new System.Windows.Forms.Panel();
            this.buttonChangePassword = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonSave = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelChangePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panelEditProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.labelEmail.Location = new System.Drawing.Point(11, 208);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 21);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxEmail.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxEmail.HintText = "";
            this.textBoxEmail.isPassword = false;
            this.textBoxEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(117)))), ((int)(((byte)(39)))));
            this.textBoxEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.textBoxEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(117)))), ((int)(((byte)(39)))));
            this.textBoxEmail.LineThickness = 4;
            this.textBoxEmail.Location = new System.Drawing.Point(160, 200);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(305, 29);
            this.textBoxEmail.TabIndex = 16;
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxEmail_Validating);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxUsername.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxUsername.HintText = "";
            this.textBoxUsername.isPassword = false;
            this.textBoxUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(117)))), ((int)(((byte)(39)))));
            this.textBoxUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.textBoxUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(117)))), ((int)(((byte)(39)))));
            this.textBoxUsername.LineThickness = 4;
            this.textBoxUsername.Location = new System.Drawing.Point(160, 83);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(305, 29);
            this.textBoxUsername.TabIndex = 16;
            this.textBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxUsername.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.labelUsername.Location = new System.Drawing.Point(11, 91);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(87, 21);
            this.labelUsername.TabIndex = 9;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPhone.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxPhone.HintText = "";
            this.textBoxPhone.isPassword = false;
            this.textBoxPhone.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(117)))), ((int)(((byte)(39)))));
            this.textBoxPhone.LineIdleColor = System.Drawing.Color.Gray;
            this.textBoxPhone.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(117)))), ((int)(((byte)(39)))));
            this.textBoxPhone.LineThickness = 4;
            this.textBoxPhone.Location = new System.Drawing.Point(160, 161);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(305, 29);
            this.textBoxPhone.TabIndex = 16;
            this.textBoxPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxPhone.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxPhone_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(11, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Phone:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CafeteriaManagement.Properties.Resources.ohlala;
            this.pictureBox1.Location = new System.Drawing.Point(56, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // bunifuElipseAvata
            // 
            this.bunifuElipseAvata.ElipseRadius = 200;
            this.bunifuElipseAvata.TargetControl = this.pictureBox1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CafeteriaManagement.Properties.Resources.pen_48;
            this.pictureBox2.Location = new System.Drawing.Point(163, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label3.Location = new System.Drawing.Point(201, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Edit Profile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label4.Location = new System.Drawing.Point(195, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Change Password";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CafeteriaManagement.Properties.Resources.icons8_lock_48;
            this.pictureBox3.Location = new System.Drawing.Point(157, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // textBoxPasswordCurrent
            // 
            this.textBoxPasswordCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPasswordCurrent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPasswordCurrent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPasswordCurrent.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxPasswordCurrent.HintText = "";
            this.textBoxPasswordCurrent.isPassword = false;
            this.textBoxPasswordCurrent.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(117)))), ((int)(((byte)(39)))));
            this.textBoxPasswordCurrent.LineIdleColor = System.Drawing.Color.Gray;
            this.textBoxPasswordCurrent.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(117)))), ((int)(((byte)(39)))));
            this.textBoxPasswordCurrent.LineThickness = 4;
            this.textBoxPasswordCurrent.Location = new System.Drawing.Point(160, 82);
            this.textBoxPasswordCurrent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPasswordCurrent.Name = "textBoxPasswordCurrent";
            this.textBoxPasswordCurrent.Size = new System.Drawing.Size(297, 29);
            this.textBoxPasswordCurrent.TabIndex = 23;
            this.textBoxPasswordCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxPasswordCurrent.OnValueChanged += new System.EventHandler(this.TextBoxCurrentPassword_OnValueChanged);
            this.textBoxPasswordCurrent.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.labelCurrent.Location = new System.Drawing.Point(14, 90);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(142, 21);
            this.labelCurrent.TabIndex = 22;
            this.labelCurrent.Text = "Current Password:";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNewPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxNewPassword.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxNewPassword.HintText = "";
            this.textBoxNewPassword.isPassword = false;
            this.textBoxNewPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(117)))), ((int)(((byte)(39)))));
            this.textBoxNewPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.textBoxNewPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(117)))), ((int)(((byte)(39)))));
            this.textBoxNewPassword.LineThickness = 4;
            this.textBoxNewPassword.Location = new System.Drawing.Point(160, 130);
            this.textBoxNewPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(297, 29);
            this.textBoxNewPassword.TabIndex = 25;
            this.textBoxNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxNewPassword.OnValueChanged += new System.EventHandler(this.TextBoxCurrentPassword_OnValueChanged);
            this.textBoxNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.labelNewPassword.Location = new System.Drawing.Point(14, 141);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(120, 21);
            this.labelNewPassword.TabIndex = 24;
            this.labelNewPassword.Text = "New Password:";
            this.labelNewPassword.Click += new System.EventHandler(this.Label6_Click);
            // 
            // textBoxReenterPassword
            // 
            this.textBoxReenterPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReenterPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxReenterPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReenterPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxReenterPassword.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxReenterPassword.HintText = "";
            this.textBoxReenterPassword.isPassword = false;
            this.textBoxReenterPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(117)))), ((int)(((byte)(39)))));
            this.textBoxReenterPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.textBoxReenterPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(117)))), ((int)(((byte)(39)))));
            this.textBoxReenterPassword.LineThickness = 4;
            this.textBoxReenterPassword.Location = new System.Drawing.Point(160, 178);
            this.textBoxReenterPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxReenterPassword.Name = "textBoxReenterPassword";
            this.textBoxReenterPassword.Size = new System.Drawing.Size(297, 29);
            this.textBoxReenterPassword.TabIndex = 27;
            this.textBoxReenterPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxReenterPassword.OnValueChanged += new System.EventHandler(this.TextBoxCurrentPassword_OnValueChanged);
            this.textBoxReenterPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label7.Location = new System.Drawing.Point(14, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 21);
            this.label7.TabIndex = 26;
            this.label7.Text = "Re-enter Password:";
            // 
            // bunifuElipseDate
            // 
            this.bunifuElipseDate.ElipseRadius = 5;
            this.bunifuElipseDate.TargetControl = this;
            // 
            // labelChangeImage
            // 
            this.labelChangeImage.AutoSize = true;
            this.labelChangeImage.Depth = 0;
            this.labelChangeImage.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelChangeImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelChangeImage.Location = new System.Drawing.Point(100, 354);
            this.labelChangeImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelChangeImage.Name = "labelChangeImage";
            this.labelChangeImage.Size = new System.Drawing.Size(106, 19);
            this.labelChangeImage.TabIndex = 33;
            this.labelChangeImage.Text = "Change Avatar";
            this.labelChangeImage.Click += new System.EventHandler(this.LabelChangeImage_Click);
            // 
            // panelChangePassword
            // 
            this.panelChangePassword.Controls.Add(this.pictureBox3);
            this.panelChangePassword.Controls.Add(this.label4);
            this.panelChangePassword.Controls.Add(this.textBoxReenterPassword);
            this.panelChangePassword.Controls.Add(this.labelCurrent);
            this.panelChangePassword.Controls.Add(this.label7);
            this.panelChangePassword.Controls.Add(this.textBoxPasswordCurrent);
            this.panelChangePassword.Controls.Add(this.textBoxNewPassword);
            this.panelChangePassword.Controls.Add(this.labelNewPassword);
            this.panelChangePassword.Location = new System.Drawing.Point(296, 84);
            this.panelChangePassword.Name = "panelChangePassword";
            this.panelChangePassword.Size = new System.Drawing.Size(486, 315);
            this.panelChangePassword.TabIndex = 34;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.labelPassword.Location = new System.Drawing.Point(11, 287);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(142, 21);
            this.labelPassword.TabIndex = 35;
            this.labelPassword.Text = "Current Password:";
            // 
            // textBoxCurrentPassword
            // 
            this.textBoxCurrentPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCurrentPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCurrentPassword.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxCurrentPassword.HintText = "";
            this.textBoxCurrentPassword.isPassword = true;
            this.textBoxCurrentPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(117)))), ((int)(((byte)(39)))));
            this.textBoxCurrentPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.textBoxCurrentPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(117)))), ((int)(((byte)(39)))));
            this.textBoxCurrentPassword.LineThickness = 4;
            this.textBoxCurrentPassword.Location = new System.Drawing.Point(160, 279);
            this.textBoxCurrentPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCurrentPassword.Name = "textBoxCurrentPassword";
            this.textBoxCurrentPassword.Size = new System.Drawing.Size(305, 29);
            this.textBoxCurrentPassword.TabIndex = 36;
            this.textBoxCurrentPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxCurrentPassword.OnValueChanged += new System.EventHandler(this.TextBoxCurrentPassword_OnValueChanged);
            this.textBoxCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxCurrentPassword_Validating);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Depth = 0;
            this.radioButtonFemale.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonFemale.Location = new System.Drawing.Point(273, 244);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Ripple = true;
            this.radioButtonFemale.Size = new System.Drawing.Size(74, 30);
            this.radioButtonFemale.TabIndex = 40;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.labelGender.Location = new System.Drawing.Point(11, 247);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(69, 21);
            this.labelGender.TabIndex = 38;
            this.labelGender.Text = "Gender:";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Depth = 0;
            this.radioButtonMale.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonMale.Location = new System.Drawing.Point(160, 244);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Ripple = true;
            this.radioButtonMale.Size = new System.Drawing.Size(59, 30);
            this.radioButtonMale.TabIndex = 39;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonNone
            // 
            this.radioButtonNone.AutoSize = true;
            this.radioButtonNone.Depth = 0;
            this.radioButtonNone.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonNone.Location = new System.Drawing.Point(403, 244);
            this.radioButtonNone.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonNone.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonNone.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonNone.Name = "radioButtonNone";
            this.radioButtonNone.Ripple = true;
            this.radioButtonNone.Size = new System.Drawing.Size(62, 30);
            this.radioButtonNone.TabIndex = 37;
            this.radioButtonNone.TabStop = true;
            this.radioButtonNone.Text = "None";
            this.radioButtonNone.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // textBoxDisplayName
            // 
            this.textBoxDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDisplayName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDisplayName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisplayName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxDisplayName.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxDisplayName.HintText = "";
            this.textBoxDisplayName.isPassword = false;
            this.textBoxDisplayName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(117)))), ((int)(((byte)(39)))));
            this.textBoxDisplayName.LineIdleColor = System.Drawing.Color.Gray;
            this.textBoxDisplayName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(117)))), ((int)(((byte)(39)))));
            this.textBoxDisplayName.LineThickness = 4;
            this.textBoxDisplayName.Location = new System.Drawing.Point(160, 122);
            this.textBoxDisplayName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDisplayName.Name = "textBoxDisplayName";
            this.textBoxDisplayName.Size = new System.Drawing.Size(305, 29);
            this.textBoxDisplayName.TabIndex = 43;
            this.textBoxDisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelDisplayName
            // 
            this.labelDisplayName.AutoSize = true;
            this.labelDisplayName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelDisplayName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.labelDisplayName.Location = new System.Drawing.Point(11, 130);
            this.labelDisplayName.Name = "labelDisplayName";
            this.labelDisplayName.Size = new System.Drawing.Size(113, 21);
            this.labelDisplayName.TabIndex = 42;
            this.labelDisplayName.Text = "Display Name:";
            // 
            // panelEditProfile
            // 
            this.panelEditProfile.Controls.Add(this.pictureBox2);
            this.panelEditProfile.Controls.Add(this.textBoxDisplayName);
            this.panelEditProfile.Controls.Add(this.textBoxPhone);
            this.panelEditProfile.Controls.Add(this.labelDisplayName);
            this.panelEditProfile.Controls.Add(this.label1);
            this.panelEditProfile.Controls.Add(this.labelUsername);
            this.panelEditProfile.Controls.Add(this.radioButtonFemale);
            this.panelEditProfile.Controls.Add(this.textBoxEmail);
            this.panelEditProfile.Controls.Add(this.labelGender);
            this.panelEditProfile.Controls.Add(this.textBoxUsername);
            this.panelEditProfile.Controls.Add(this.radioButtonMale);
            this.panelEditProfile.Controls.Add(this.labelEmail);
            this.panelEditProfile.Controls.Add(this.radioButtonNone);
            this.panelEditProfile.Controls.Add(this.label3);
            this.panelEditProfile.Controls.Add(this.labelPassword);
            this.panelEditProfile.Controls.Add(this.textBoxCurrentPassword);
            this.panelEditProfile.Location = new System.Drawing.Point(296, 84);
            this.panelEditProfile.Name = "panelEditProfile";
            this.panelEditProfile.Size = new System.Drawing.Size(492, 354);
            this.panelEditProfile.TabIndex = 44;
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonChangePassword.BorderRadius = 2;
            this.buttonChangePassword.ButtonText = "Save";
            this.buttonChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangePassword.DisabledColor = System.Drawing.Color.Gray;
            this.buttonChangePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonChangePassword.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonChangePassword.Iconimage = null;
            this.buttonChangePassword.Iconimage_right = null;
            this.buttonChangePassword.Iconimage_right_Selected = null;
            this.buttonChangePassword.Iconimage_Selected = null;
            this.buttonChangePassword.IconMarginLeft = 0;
            this.buttonChangePassword.IconMarginRight = 0;
            this.buttonChangePassword.IconRightVisible = true;
            this.buttonChangePassword.IconRightZoom = 0D;
            this.buttonChangePassword.IconVisible = true;
            this.buttonChangePassword.IconZoom = 90D;
            this.buttonChangePassword.IsTab = false;
            this.buttonChangePassword.Location = new System.Drawing.Point(708, 466);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonChangePassword.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonChangePassword.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonChangePassword.selected = false;
            this.buttonChangePassword.Size = new System.Drawing.Size(80, 27);
            this.buttonChangePassword.TabIndex = 46;
            this.buttonChangePassword.Text = "Save";
            this.buttonChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonChangePassword.Textcolor = System.Drawing.Color.White;
            this.buttonChangePassword.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave.BorderRadius = 2;
            this.buttonSave.ButtonText = "Save";
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.DisabledColor = System.Drawing.Color.Gray;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonSave.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonSave.Iconimage = null;
            this.buttonSave.Iconimage_right = null;
            this.buttonSave.Iconimage_right_Selected = null;
            this.buttonSave.Iconimage_Selected = null;
            this.buttonSave.IconMarginLeft = 0;
            this.buttonSave.IconMarginRight = 0;
            this.buttonSave.IconRightVisible = true;
            this.buttonSave.IconRightZoom = 0D;
            this.buttonSave.IconVisible = true;
            this.buttonSave.IconZoom = 90D;
            this.buttonSave.IsTab = false;
            this.buttonSave.Location = new System.Drawing.Point(708, 466);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonSave.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonSave.selected = false;
            this.buttonSave.Size = new System.Drawing.Size(80, 27);
            this.buttonSave.TabIndex = 47;
            this.buttonSave.Text = "Save";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSave.Textcolor = System.Drawing.Color.White;
            this.buttonSave.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // UCSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelChangeImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelEditProfile);
            this.Controls.Add(this.panelChangePassword);
            this.Controls.Add(this.buttonChangePassword);
            this.Name = "UCSetting";
            this.Size = new System.Drawing.Size(837, 510);
            this.Load += new System.EventHandler(this.UCSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelChangePassword.ResumeLayout(false);
            this.panelChangePassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panelEditProfile.ResumeLayout(false);
            this.panelEditProfile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseAvata;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxPasswordCurrent;
        private System.Windows.Forms.Label labelCurrent;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxNewPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxReenterPassword;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseDate;
        private MaterialSkin.Controls.MaterialLabel labelChangeImage;
        private System.Windows.Forms.Panel panelChangePassword;
        private System.Windows.Forms.Label labelPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxCurrentPassword;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonFemale;
        private System.Windows.Forms.Label labelGender;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonMale;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonNone;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxDisplayName;
        private System.Windows.Forms.Label labelDisplayName;
        private System.Windows.Forms.Panel panelEditProfile;
        private Bunifu.Framework.UI.BunifuFlatButton buttonChangePassword;
        private Bunifu.Framework.UI.BunifuFlatButton buttonSave;
    }
}
