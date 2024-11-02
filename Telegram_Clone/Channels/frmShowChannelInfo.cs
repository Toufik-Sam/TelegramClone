using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram_Clone.Channels.Controls;
using Telegram_Clone.Global_Classes;
using Telegram_Clone.Properties;
using TelegramBusinessLayer;

namespace Telegram_Clone.Channels
{
    public partial class frmShowChannelInfo : Form
    {
        private clsChannel _CurrenChannel;
        private int _AdminToViewDetails = -1;
        private bool _ShowDeleteIconToAdmin = true;
        private string ImagePathSelected = "", pbChannelmagePath = "";
        private static DataTable _dtChannelSubscribers;
        private DataTable _dtSubscribers;
        public frmShowChannelInfo(int ChannelID,int AdminToViewDetails)
        {
            InitializeComponent();
            _CurrenChannel = clsChannel.Find(ChannelID);
            _AdminToViewDetails = AdminToViewDetails;
            if (_CurrenChannel.CreatedByUserID != AdminToViewDetails)
                _ShowDeleteIconToAdmin = false;
        }
        public delegate void DeleteSubscriberEventHandler(object sender,string ChannelName);
        public event DeleteSubscriberEventHandler SubsriberDeleted;
        public event DeleteSubscriberEventHandler ChannelInfoSaved;
        private void frmShowChannelInfo_Load(object sender, EventArgs e)
        {
            if(!_ShowDeleteIconToAdmin)
            {
                btnSave.Visible = false;
                lblChangePicture.Visible = false;
                txtChannelName.ReadOnly = true;
                if (_CurrenChannel.ChannelType == false)
                {
                    rdbPrivate.Checked = true;
                    rdbPublic.Visible = false;
                }
                else
                {
                    rdbPublic.Checked = true;
                    rdbPrivate.Visible = false;
                }
                
            }
            if (_LoadData())
                _FillChannelSubscribers();
        }
        private bool _LoadData()
        {
            if (_CurrenChannel.ChannelImagePath != null && _CurrenChannel.ChannelImagePath != "")
                pbChannelImage.ImageLocation = _CurrenChannel.ChannelImagePath;
            else
                pbChannelImage.Image = Resources.icons8_chat_group_35;
            txtChannelName.Text = _CurrenChannel.ChannelName;
            lblMemberName.Text = clsChannelSubscriber.GetSubscriberNameByID(clsChannelSubscriber.GetSubscriberID(_CurrenChannel.CreatedByUserID, _CurrenChannel.ChannelID));
            if (_CurrenChannel.ChannelType == false)
                rdbPrivate.Checked = true;
            else
                rdbPublic.Checked = true;
            _dtChannelSubscribers = clsChannelSubscriber.GetChannelSubscribersByChannelID(_CurrenChannel.ChannelID);
            if (_dtChannelSubscribers.Rows.Count > 0)
            {
                _dtSubscribers = _dtChannelSubscribers.DefaultView.ToTable(false, "SubscriberID", "FullName", "ImagePath");
                return true;
            }
            else
                return false;
        }
        private void _FillChannelSubscribers()
        {
            flySubscribers.Controls.Clear();
            foreach(DataRow row in _dtSubscribers.Rows)
            {
                ctrlSubscriber Subscriber = new ctrlSubscriber();
                Subscriber.DeleteSubscriberEvent += OnDeleteSubscriber;
                if (row["ImagePath"] != System.DBNull.Value)
                    Subscriber.LoadData((int)row["SubscriberID"], (string)row["FullName"], (string)row["ImagePath"], _ShowDeleteIconToAdmin);
                else
                    Subscriber.LoadData((int)row["SubscriberID"], (string)row["FullName"], "", _ShowDeleteIconToAdmin);
                flySubscribers.Controls.Add(Subscriber);
            }
        }
        private void OnDeleteSubscriber(object sender,int SubscriberID)
        {
            if (MessageBox.Show("Are You Sure That You Want To Delete Member With ID: " + SubscriberID, "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsChannelSubscriber.DeleteSubscriberByID(SubscriberID))
                {
                    frmShowChannelInfo_Load(null, null);
                    SubsriberDeleted?.Invoke(this,"");
                }
                else
                    MessageBox.Show("Error:Member Was Not Deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                pbChannelImage.Load(ImagePathSelected);
                pbChannelmagePath = ImagePathSelected;
                if (!_SaveImage())
                    MessageBox.Show("Error Image Selected Was Not Loaded Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    _CurrenChannel.ChannelImagePath = ImagePathSelected;
            }
        }
        private bool _SaveImage()
        {
            clsUtil.HandleUserImage("", ref pbChannelmagePath, clsUtil.ChannelImagesFolder);
            if (pbChannelmagePath != null && pbChannelmagePath != ImagePathSelected)
            {
                ImagePathSelected = pbChannelmagePath;
                return true;
            }
            else
                return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _CurrenChannel.ChannelName = txtChannelName.Text;
            if (rdbPublic.Checked)
                _CurrenChannel.ChannelType = true;
            else
                _CurrenChannel.ChannelType = false;
            if (!_CurrenChannel.Save())
                MessageBox.Show("Data Was Not Saved!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                ChannelInfoSaved?.Invoke(this,_CurrenChannel.ChannelName);
            this.Close();
        }
    }
}