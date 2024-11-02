using Microsoft.Win32;
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
using TelegramBusinessLayer;

namespace Telegram_Clone.Channels
{
    public partial class frmShowChannelMessaging : Form
    {
        private int _ChannelID = -1;
        private string _ChannelName = "";
        private bool _ChannelType = false;
        private int _ChannelSubscribers = -1;
        private DataTable _dtChannelMessages;
        private DataTable _dtChannels;
        private string ImagePathSelected = "", pbMessageImage = "";
        private bool _IsImageMessage = false;
        public frmShowChannelMessaging(int ChannelID,string ChannelName,bool ChannelType,int ChannelSubscribers)
        {
            InitializeComponent();
            _ChannelID = ChannelID;
            _ChannelName = ChannelName;
            _ChannelType = ChannelType;
            _ChannelSubscribers = ChannelSubscribers;
        }
        public delegate void DeleteDataBackEventHandler(object sender, int ChannelID);
        public delegate void RefreshEventHandler(object sender);
        public event RefreshEventHandler RefreshEvent;
        public event DeleteDataBackEventHandler ChannelInfoSaved;
        public event DeleteDataBackEventHandler DeletEventClick;
        public event DeleteDataBackEventHandler LeaveEventClick;
        private void frmShowChannelMessaging_Load(object sender, EventArgs e)
        {
            if(!clsChannelSubscriber.IsCurrentUserAdminInChannel(clsGlobal.CurrentUser.UserID,_ChannelID))
            {
                pnldown.BorderStyle = BorderStyle.None;
                pnldown.BackColor = Color.FromArgb(38, 40, 66);
                pnldown.Visible = false;
                rtxMessage.Visible = false;
                btnOpenFile.Visible = false;
                pbChannelImageMessage.Visible = false;
                btnSendMessage.Visible = false;
                flyChannelMessages.Width = 480;
                flyChannelMessages.Dock = DockStyle.Fill;
            }
            if (!clsChannelSubscriber.IsCurrentUserSubscriberInChannel(clsGlobal.CurrentUser.UserID, _ChannelID))
            {
                btnJoin.Visible = true;
                flyChannelMessages.Dock = DockStyle.Fill;
            }
            lblName.Text = _ChannelName;
            lblSubscribers.Text = _ChannelSubscribers.ToString()+" Subscribers";
            if (_LoadData())
                _FillChannelMessages();
        }
        private bool _LoadData()
        {
            _dtChannelMessages = clsChannel.GetChannelMessages(_ChannelID);
            if(_dtChannelMessages.Rows.Count>0)
            {
                _dtChannels = _dtChannelMessages.DefaultView.ToTable(false, "MessageID", "Message", "ChannelID", "DateOfCreation", "SentByAdminID", "ImagePath");
                return true;
            }
            return false;
        }
        private void _FillChannelMessages()
        {
            flyChannelMessages.Controls.Clear();
            foreach(DataRow row in _dtChannelMessages.Rows)
            {
                if (row["ImagePath"]!=System.DBNull.Value)
                {
                    ctrlChannelImageCaptionMessage ImageMessage = new ctrlChannelImageCaptionMessage();
                    if (row["Message"]!=System.DBNull.Value)
                        ImageMessage.LoadData((int)row["MessageID"], (int)row["ChannelID"], (string)row["Message"], (string)row["ImagePath"],_ChannelType);
                    else
                        ImageMessage.LoadData((int)row["MessageID"], (int)row["ChannelID"], "", (string)row["ImagePath"],_ChannelType);
                    ImageMessage.SharePostEvent += OnSharePost;
                    flyChannelMessages.Controls.Add(ImageMessage);
                }
                else
                {
                    ctrlChannelMessage Message = new ctrlChannelMessage();
                    if (row["Message"] != System.DBNull.Value)
                        Message.LoadData((int)row["MessageID"], (int)row["ChannelID"], (string)row["Message"], _ChannelType);
                    else
                        Message.LoadData((int)row["MessageID"], (int)row["ChannelID"], "", _ChannelType);
                    Message.SharePostEvent += OnSharePost;
                    flyChannelMessages.Controls.Add(Message);
                }
            }
        }
        private bool _SaveImage()
        {
            clsUtil.HandleUserImage("", ref pbMessageImage, clsUtil.ChannelImagesFolder);
            if (pbMessageImage != null && pbMessageImage != ImagePathSelected)
            {
                ImagePathSelected = pbMessageImage;
                pbChannelImageMessage.Image= null;
                return true;
            }
            else
            {
                MessageBox.Show("Error Image Selected Was Not Loaded Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        private void OnPostEventRefresh(object sender)
        {
            RefreshEvent?.Invoke(this);
        }
        private void OnSharePost(object sender,int PostID)
        {
            frmShareChannelPost frm = new frmShareChannelPost(PostID);
            frm.PostSharedEvent += OnPostEventRefresh;
            frm.ShowDialog();
        }
        private void _AddNewMessageToFlow()
        {
            clsChannelMessage NewMessage = new clsChannelMessage();
            NewMessage.Message = rtxMessage.Text;
            NewMessage.ChannelID = _ChannelID;
            NewMessage.DateOfCreation = DateTime.Now;
            NewMessage.ImagePath = "";
            NewMessage.SentByAdminID = clsChannelSubscriber.GetSubscriberIDByUserID(clsGlobal.CurrentUser.UserID, _ChannelID);
            if (!NewMessage.Save())
                MessageBox.Show("Error Message was not Passed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ctrlChannelMessage Message = new ctrlChannelMessage();
                Message.LoadData(NewMessage.MessageID, _ChannelID, NewMessage.Message,_ChannelType);
                Message.SharePostEvent += OnSharePost;
                flyChannelMessages.Controls.Add(Message);
                rtxMessage.Text = string.Empty;
                rtxMessage.Clear();
            }
        }
        private void _AddNewImageMessageToFlow()
        {
            clsChannelMessage NewMessage = new clsChannelMessage();
            if (rtxMessage.Text != "")
                NewMessage.Message = rtxMessage.Text;
            else
                NewMessage.Message = "";
            NewMessage.ChannelID = _ChannelID;
            NewMessage.DateOfCreation = DateTime.Now;
            NewMessage.ImagePath =ImagePathSelected;
            NewMessage.SentByAdminID= clsChannelSubscriber.GetSubscriberIDByUserID(clsGlobal.CurrentUser.UserID, _ChannelID);
            if (!_SaveImage())
                return;
            NewMessage.ImagePath = ImagePathSelected;
            if (!NewMessage.Save())
                MessageBox.Show("Error Message was not Passed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ctrlChannelImageCaptionMessage ImageMessage = new ctrlChannelImageCaptionMessage();
                ImageMessage.LoadData(NewMessage.MessageID, NewMessage.ChannelID, NewMessage.Message,NewMessage.ImagePath, _ChannelType);
                ImageMessage.SharePostEvent += OnSharePost;
                flyChannelMessages.Controls.Add(ImageMessage);
                rtxMessage.Text = string.Empty;
                pbChannelImageMessage.Image = null;
                pbChannelImageMessage.Visible = false;
                pbMessageImage = "";
                ImagePathSelected = "";
                _IsImageMessage = false;
            }

        }
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (rtxMessage.Text != "" && !_IsImageMessage)
                _AddNewMessageToFlow();
            else if(_IsImageMessage)
                _AddNewImageMessageToFlow();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmDropDownMenu frm = new frmDropDownMenu();
            frm.DetailGroupInfo += OnDetailChannelInfo;
            frm.leaveEvent += OnLeaveChannel;
            frm.DeleteEvent += OnDeleteChannel;
            frm.ShowDialog();
        }
        private void OnSubscriberDeleted(object sender,string ChannelName)
        {
            _ChannelSubscribers--;
        }
        private void OnChannelInfoSaved(object sender,string ChannelName)
        {
            _ChannelName = ChannelName;
            frmShowChannelMessaging_Load(null, null);
            ChannelInfoSaved?.Invoke(this, -1);
        }
        private void OnDetailChannelInfo(object sender)
        {
            frmShowChannelInfo frm = new frmShowChannelInfo(_ChannelID, clsGlobal.CurrentUser.UserID);
            frm.SubsriberDeleted += OnSubscriberDeleted;
            frm.ChannelInfoSaved += OnChannelInfoSaved;
            frm.ShowDialog();
            frmShowChannelMessaging_Load(null,null);
        }
        private void OnLeaveChannel(object sender)
        {
            LeaveEventClick?.Invoke(this, -1);
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Image Files|*.jpeg;*.png;*.gif;*.bmp;*.jpg";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //process the selected file
                ImagePathSelected = openFileDialog1.FileName;
                pbChannelImageMessage.Load(ImagePathSelected);
                pbChannelImageMessage.Visible = true;
                pbMessageImage = ImagePathSelected;
                _IsImageMessage = true;
            }
        }
        private void rtxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && rtxMessage.Text != "" && !_IsImageMessage)
                _AddNewMessageToFlow();
            else if (e.KeyCode == Keys.Enter && _IsImageMessage)
                _AddNewImageMessageToFlow();
        }
        private void rtxMessage_Enter(object sender, EventArgs e)
        {
            if (rtxMessage.Text == "Write a Message....")
            {
                rtxMessage.Text = "";
            }
        }
        private void rtxMessage_Leave(object sender, EventArgs e)
        {
            if (rtxMessage.Text == "")
                rtxMessage.Text = "Write a Message....";
        }
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbChannelImageMessage.Image = null;
            pbChannelImageMessage.Visible = false;
            _IsImageMessage = false;
            ImagePathSelected = "";
            pbMessageImage = "";
        }
        private void btnJoin_Click(object sender, EventArgs e)
        {
            clsChannelSubscriber Subscriber = new clsChannelSubscriber();
            Subscriber.UserID = clsGlobal.CurrentUser.UserID;
            Subscriber.ChannelID = _ChannelID;
            Subscriber.IsAdmin = false;
            Subscriber.IsDeleted = false;
            if(Subscriber.Save())
            {
                MessageBox.Show("You Joined Sucessfully!", "Information", MessageBoxButtons.OK);
                btnJoin.Visible = false;
                _ChannelSubscribers++;
                frmShowChannelMessaging_Load(null, null);
                RefreshEvent?.Invoke(this);
            }
            else
                MessageBox.Show("You have not Joined Sucessfully!", "Error", MessageBoxButtons.OK);

        }
        private void OnDeleteChannel(object sender)
        {
            if (clsChannel.DeleteChannel(_ChannelID))
                DeletEventClick?.Invoke(this, _ChannelID);
            else
                MessageBox.Show("Error:Channel Was Not Deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
