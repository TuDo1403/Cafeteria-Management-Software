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
    public partial class FormAnnouncementNew : Form
    {
        public static event EventHandler<int> DialogueResultReturned;

        public FormAnnouncementNew()
        {
            InitializeComponent();
        }

        public void ShowMessage(string text, string caption, bool isYesNo = false)
        {
            labelIAnnoucement.Text = text;
            labelCaption.Text = caption;
            if (isYesNo)
            {
                buttonOk.Visible = false;
                buttonYes.Visible = true;
                buttonNo.Visible = true;
            }
            else
            {
                buttonOk.Visible = true;
                buttonYes.Visible = false;
                buttonNo.Visible = false;
            }
            ShowDialog();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            OnDialogueResultReturning(1);
            this.Close();
        }

        private void OnDialogueResultReturning(int v)
        {
            (DialogueResultReturned as EventHandler<int>)?.Invoke(this, v);
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            OnDialogueResultReturning(0);
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
