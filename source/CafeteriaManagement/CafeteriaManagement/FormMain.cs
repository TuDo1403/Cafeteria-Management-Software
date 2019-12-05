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
    public partial class FormMain : Form
    {
        public static event EventHandler<UserControl> FormMainLoaded;


        public FormMain()
        {
            InitializeComponent();
            FormLogin.LoginSucceeded += FormLogin_LoginSucceededHandler;
        }

        private void FormLogin_LoginSucceededHandler(object sender, string e)
        {
            labelLoggedInId.Text = $"Logged in as: {e}";
        }

        private void ButtonMusic_Click(object sender, EventArgs e) => ucMusicDownloader.BringToFront();

        private void FormMain_Load(object sender, EventArgs e) => OnFormLoading(ucQueueBox);

        private void OnFormLoading(UCQueueBox ucQueueBox) => (FormMainLoaded as EventHandler<UserControl>)?.Invoke(this, ucQueueBox);

        private void ButtonOrderManager_Click(object sender, EventArgs e) => ucOrderNew1.BringToFront();

        private void ButtonAdmin_Click(object sender, EventArgs e) => ucEditMenuNew1.BringToFront();

        private void ButtonHome_Click(object sender, EventArgs e) => ucHome.BringToFront();

        private void ButtonUserInfo_Click(object sender, EventArgs e) => ucEmployeeNew1.BringToFront();
    }
}
