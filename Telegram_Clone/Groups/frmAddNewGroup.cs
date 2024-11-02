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

namespace Telegram_Clone.Groups
{
    public partial class frmAddNewGroup : Form
    {
        private int _CreatedByuserID = -1;
        private string ImagePathSelected = "";
        public frmAddNewGroup(int UserID)
        {
            InitializeComponent();
            _CreatedByuserID = UserID;
          
        }
        public delegate void BackToMainFormEventHandler(object sender);
        public event BackToMainFormEventHandler DataBack;
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
                clsUtil.HandleUserImage("", ref pbGroupImagePath, clsUtil.GroupImagesFolder);
                if (pbGroupImagePath != null && pbGroupImagePath != ImagePathSelected)
                    ImagePathSelected = pbGroupImagePath;
                else
                    MessageBox.Show("Error Image Selected Was Not Loaded Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddMembers frmMembers = new frmAddMembers(txtGroupName.Text.Trim(),_CreatedByuserID,ImagePathSelected);
            frmMembers.DataBack += DataBack_OnClose;
            frmMembers.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGroupName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtGroupName.Text.ToString()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtGroupName, "Group Name Cannot Be Empty!!");
            }
            else
                errorProvider1.SetError(txtGroupName, null);
        }

        private void DataBack_OnClose(object sender)
        {
            DataBack?.Invoke(this);
            this.Close();
        }

    }
}
