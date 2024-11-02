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

namespace Telegram_Clone.Channels
{
    public partial class frmAddNewChannel : Form
    {
        private int _CreatedByUserID = -1;
        private string ImagePathSelected = "";
        public frmAddNewChannel(int UserID)
        {
            InitializeComponent();
            _CreatedByUserID = UserID;
        }
        public delegate void BackToMainFormEventHandler(object sender);
        public event BackToMainFormEventHandler DataBack;
        private void btnCancel_Click(object sender, EventArgs e)
        {
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
                pbGroupImage.Load(ImagePathSelected);
                string pbGroupImagePath = ImagePathSelected;
                clsUtil.HandleUserImage("", ref pbGroupImagePath, clsUtil.ChannelImagesFolder);
                if (pbGroupImagePath != null && pbGroupImagePath != ImagePathSelected)
                    ImagePathSelected = pbGroupImagePath;
                else
                    MessageBox.Show("Error Image Selected Was Not Loaded Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtChannelName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtChannelName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtChannelName, "Enter a Channel Name!");
            }
            else
                errorProvider1.SetError(txtChannelName, null);
        }
        private void rtxChannelDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(rtxChannelDescription.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(rtxChannelDescription, "Enter you Channel Description !");
            }
            else
                errorProvider1.SetError(rtxChannelDescription, null);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddNewSubscribers Subscribers = new frmAddNewSubscribers(txtChannelName.Text,rtxChannelDescription.Text,_CreatedByUserID,ImagePathSelected);
            Subscribers.DataBack += DataBack_OnClose;
            Subscribers.ShowDialog();
        }
        private void DataBack_OnClose(object sender)
        {
            DataBack?.Invoke(this);
            this.Close();
        }

    }
}
