using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram_Clone.Global_Classes;
using TelegramBusinessLayer;

namespace Telegram_Clone
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                clsUser User = clsUser.Find("0"+textBox1.Text.Trim());
                if (User != null)
                {                    
                    clsGlobal.CurrentUser = User;
                    this.Hide();
                    MainForm frmMain = new MainForm(this);
                    frmMain.ShowDialog();
                }
                else
                    MessageBox.Show("User Was Not Found Please Try Again!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "- - - - - - - - -")
                textBox1.Text = "";
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "- - - - - - - - -";
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp frm = new frmSignUp();
            frm.ShowDialog();
        }
    }
}
