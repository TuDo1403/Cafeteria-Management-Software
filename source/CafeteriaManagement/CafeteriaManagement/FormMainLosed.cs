using CM.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaManagement
{
    public partial class FormMainLosed : Form
    {
        public static event EventHandler<UserControl> FormMainLoaded;
        public static event EventHandler PasswordChangeNeeded;
        public static event EventHandler EditProfileNeeded;

        public FormMainLosed()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            FormRegister.LoginSucceeded += FormRegister_LoginSucceededHandler;
            ucHome1.BringToFront();
        }

        private void FormRegister_LoginSucceededHandler(object sender, string e)
        {
            var isAdmin = DataProvider.IsAccountIdAdmin(e);
            if (!isAdmin)
            {
                btnStatic.Visible = false;
                btnEmployee.Visible = false;
                btnMenu.Visible = false;
                btnEdit.Visible = false;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //bunifuFormFadeTransitionFormMain.ShowAsyc(this);
            OnFormLoading(ucQueueBox1);
        }


        private void OnFormLoading(UCQueueBox ucQueueBox1) => (FormMainLoaded as EventHandler<UserControl>)?.Invoke(this, ucQueueBox1);

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (slideMenu.Width == 50)
            {
                slideMenu.Visible = false;
                slideMenu.Width = 200;
                panelAnimater.ShowSync(slideMenu);

            }
            else
            {
                slideMenu.Visible = false;
                slideMenu.Width = 50;
                panelAnimater.ShowSync(slideMenu);
            }
        }

        private void PnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }





        private void BtnEdit_Click(object sender, EventArgs e)
        {
            panelButton.Height = btnEdit.Height;
            ucEditMenuNew1.BringToFront();
            panelButton.Top = btnEdit.Top;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            panelButton.Height = btnPayment.Height;
            panelButton.Top = btnPayment.Top;
          //  ucHome1.BringToFront();
            ucOrderNew1.BringToFront();
            
            //
            //  TestAnimation.ShowSync()
           // ucOrderNew1.Visible = false;
           // TestAnimation.ShowSync(ucOrderNew1);
            // panelAnimater.ShowSync(slideMenu);
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            panelButton.Height = btnMusic.Height;
            panelButton.Top = btnMusic.Top;
            ucDisplayMusicNew1.BringToFront();
        }

        private void Queue_Click(object sender, EventArgs e)
        {
            panelButton.Height = Queue.Height;
            panelButton.Top = Queue.Top;
            ucQueueBox1.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            panelButton.Height = btnEmployee.Height;
            panelButton.Top = btnEmployee.Top;
            ucEmployeeNew1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelButton.Height = btnHome.Height;
            panelButton.Top = btnHome.Top;
            ucHome1.BringToFront();
        }

        private void ucOrderNew1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxToSmallSize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            pictureBoxToBigSize.Visible = true;
            pictureBoxToSmallSize.Visible = false;
        }

        private void pictureBoxToBigSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBoxToBigSize.Visible = false;
            pictureBoxToSmallSize.Visible = true;
        }

        private void labelEditProfile_Click(object sender, EventArgs e)
        {
            ucSetting1.BringToFront();
            OnEditProfileNeeding();
        }

        private void OnEditProfileNeeding() => (EditProfileNeeded as EventHandler).Invoke(this, EventArgs.Empty);

        private void labelLogOut_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name != "FormRegister")
                {
                    form.Close();
                }
            }
        }

        private void labelChangePassword_Click(object sender, EventArgs e)
        {
            ucSetting1.BringToFront();
            OnPassWordChangeNeeding();
        }

        private void OnPassWordChangeNeeding() => (PasswordChangeNeeded as EventHandler).Invoke(this, EventArgs.Empty);

        private void btnStatic_Click(object sender, EventArgs e)
        {

            panelButton.Height = btnStatic.Height;
            panelButton.Top = btnStatic.Top;
            ucStaticNew1.BringToFront();
        }

        private void pictureBoxSetting_Click(object sender, EventArgs e)
        {
            if (pnlSetting.Top > 400)
            {
                timerSettingUp.Start();
            }
            else
            {
                timerSettingDown.Start();
            }
        }

        private void timerSettingUp_Tick(object sender, EventArgs e)
        {
            if (pnlSetting.Top > 400)
            {
                pnlSetting.Top -= 5;
            }
            else
                timerSettingUp.Stop();
        }

        private void timerSettingDown_Tick(object sender, EventArgs e)
        {
            if (pnlSetting.Top < 500)
                pnlSetting.Top += 5;
            else
                timerSettingDown.Stop();
        }

        private void pictureBoxSetting_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSetting.Size = new System.Drawing.Size(31, 31);
        }

        private void pictureBoxSetting_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxSetting.Size = new System.Drawing.Size(28, 28);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
