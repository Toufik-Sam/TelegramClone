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
using Telegram_Clone.Properties;
using TelegramBusinessLayer;

namespace Telegram_Clone.Main_Form_Controls
{
    public partial class FrmSettings : Form
    {
        private string ImagePathSelected = "",pbUserImage="";
        private bool _IsImageChanged = false;
        public FrmSettings()
        {
            InitializeComponent();
        }
        private void FrmSettings_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = clsGlobal.CurrentUser.FirstName;
            txtLastName.Text = clsGlobal.CurrentUser.LastName;
            txtPhone.Text = clsGlobal.CurrentUser.Phone;
            if (clsGlobal.CurrentUser.ImagePath != null && clsGlobal.CurrentUser.ImagePath != "")
                pbUserImagePath.ImageLocation = clsGlobal.CurrentUser.ImagePath;
            else
                pbUserImagePath.Image = Resources.man_512;
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
                clsGlobal.CurrentUser.ImagePath = ImagePathSelected;
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
             if(!_SaveImage() && _IsImageChanged==true)
             { 
                MessageBox.Show("Image Was Not SAVED!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
             }
            clsGlobal.CurrentUser.FirstName = txtFirstName.Text.Trim(); ;
            clsGlobal.CurrentUser.LastName = txtLastName.Text.Trim();
            clsGlobal.CurrentUser.Phone = txtPhone.Text.Trim();
            if (!clsGlobal.CurrentUser.Save())
                MessageBox.Show("User Info Were Not Saved!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("User Info Were Updated!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void TextValidate(object sender,CancelEventArgs e)
        {
            TextBox Text = (TextBox)sender;
            if(string.IsNullOrEmpty(Text.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Text, "This Filed is required!");
            }
            else
                errorProvider1.SetError(Text,null);
        }
    }
}
