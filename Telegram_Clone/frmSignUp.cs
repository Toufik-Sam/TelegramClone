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
    public partial class frmSignUp : Form
    {
        private bool _IsImageChanged = false;
        private string ImagePathSelected = "", pbUserImage = "";
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            clsUser NewUser = new clsUser();
            NewUser.FirstName = txtFirstName.Text.Trim();
            NewUser.LastName = txtLastName.Text.Trim();
            NewUser.Phone = txtPhone.Text.Trim();
            if (!_SaveImage() && _IsImageChanged)
            {
                MessageBox.Show("Your Image was Not Loaded!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NewUser.ImagePath = ImagePathSelected;
            if (!NewUser.Save())
                MessageBox.Show("Failed To Sign Up!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else 
                MessageBox.Show("You Sign Up Successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
        private void lblChangePicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpeg;*.png;*.gif;*.bmp;*.jpg";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //process the selected file
                ImagePathSelected = openFileDialog1.FileName;
                pbUserImagePath.Load(ImagePathSelected);
                pbUserImage = ImagePathSelected;
                _IsImageChanged = true;
            }
        }
        private bool _SaveImage()
        {
            clsUtil.HandleUserImage("", ref pbUserImage, clsUtil.UsersImagesFolder);
            if (pbUserImage != null && pbUserImage != ImagePathSelected)
            {
                ImagePathSelected = pbUserImage;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
