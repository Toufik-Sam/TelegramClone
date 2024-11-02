using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telegram_Clone.Global_Classes;
using Telegram_Clone.Groups.Controls;
using TelegramBusinessLayer;

namespace Telegram_Clone.Groups
{
    public partial class frmShowGroupMessaging : Form
    {
        private int _GroupID = -1;
        private string _GroupName = "",ImagePathSelected="", pbMessageImagePath = "";
        private bool _GroupType = false;
        private bool _Text=false,_Image = true,_ReplyType=false;
        private int _GroupMembers = -1;
        private bool _IsReplyMessage = false, _IsImageMessage = false;
        private int _ReplyToMessageID = -1;
        private static DataTable _dtGroupMessaging;
        private DataTable _dtMessages;
        public frmShowGroupMessaging(int GroupID,string GroupName,bool Grouptype,int GroupMembers)
        {
            InitializeComponent();
            _GroupID = GroupID;
            _GroupName = GroupName;
            _GroupType = Grouptype;
            _GroupMembers = GroupMembers;
        }
        public delegate void DeleteDataBackEventHandler(object sender,int GroupID);
        public delegate void ChannelLinkClicked(object sender, int ChannelID);
        public event ChannelLinkClicked OnChannelink;
        public event DeleteDataBackEventHandler GroupInfoSaved;
        public event DeleteDataBackEventHandler DeletEventClick;
        public event DeleteDataBackEventHandler LeaveEventClick;
        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.FromArgb(52, 62, 88);
        }
        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.FromArgb(38, 40, 66);
        }
        private void btnDownloadFile_MouseEnter(object sender, EventArgs e)
        {
            btnSendMessage.BackColor = Color.FromArgb(52, 62, 88);
        }
        private void btnDownloadFile_MouseLeave(object sender, EventArgs e)
        {
            btnSendMessage.BackColor = Color.FromArgb(38, 40, 66);
        }
        private bool _LoadData()
        {
            _dtGroupMessaging = clsGroup.GetGroupMessaging(_GroupID);
            if(_dtGroupMessaging.Rows.Count>0)
            {
                _dtMessages = _dtGroupMessaging.DefaultView.ToTable(false, "MessageID", "SentByMemberID", "ImagePath", "Message", "DateOfCreation", "ReplyToMessageID","MessageImage","SharedPostID");
                return true;
            }
            return false;
        }
        private void _LoadMessageToGroup(string MessageText,string MemberImagePath,int MessageID,int SentByMemberID)
        {
            ctrlMessage Message = new ctrlMessage();
            Message.LoadData(MessageText, MemberImagePath, MessageID, SentByMemberID);
            Message.MessageDataBack += ReplyToMessage;
            flyGroupMessages.Controls.Add(Message);
        }
        private void _LoadImageMessageToGroup(int MessageID,int SentByMemberID,string Message,string MessageImage,string MemberImage)
        {
            ctrlImageMessage ImageMessage = new ctrlImageMessage();
           
            ImageMessage.LoadData(MessageID, SentByMemberID, Message, MessageImage, MemberImage);
            ImageMessage.DataReplyImageMessage += ReplyToMessage;
            flyGroupMessages.Controls.Add(ImageMessage);
        }
        private void _LoadReplyImageMessageToGroup(int MessageID, int SentByMemberID, string Message, int ReplyToMessageID, string MessageImage, string MemberImage)
        {
            ctrlReplyToImageMessage ReplyImageMessage = new ctrlReplyToImageMessage();
            ReplyImageMessage.LoadData(MessageID, SentByMemberID, Message, ReplyToMessageID, MessageImage, MemberImage);
            ReplyImageMessage.ReplyMessageDataBack += ReplyToMessage;
            flyGroupMessages.Controls.Add(ReplyImageMessage);
        }
        private void _LoadSharedPost(int MessageID, int SentByMemberID,int SharedPostID)
        {
            ctrlSharedPost Post = new ctrlSharedPost();
            Post.LoadData(MessageID,SentByMemberID, SharedPostID);
            Post.ChannelDataBack += OnChannelLinkCliked;
            flyGroupMessages.Controls.Add(Post);
        }
        private void _FillGroupMessaging()
        {
            flyGroupMessages.Controls.Clear();
            foreach(DataRow row in _dtMessages.Rows)
            {
                if (row["SharedPostID"]!=System.DBNull.Value)
                {
                    _LoadSharedPost((int)row["MessageID"], (int)row["SentByMemberID"], (int)row["SharedPostID"]);
                }
                else if (row["ReplyToMessageID"] == System.DBNull.Value && row["MessageImage"] == System.DBNull.Value)
                {
                    string MemberImage = "";
                    if (row["ImagePath"] != System.DBNull.Value)
                        MemberImage = (string)row["ImagePath"];
                    _LoadMessageToGroup((string)row["Message"], MemberImage, (int)row["MessageID"], (int)row["SentByMemberID"]);
                }
                else if (row["ReplyToMessageID"] == System.DBNull.Value && row["MessageImage"] != System.DBNull.Value)
                {
                    string MemberImage = "", Message = "";
                    if (row["ImagePath"] != System.DBNull.Value)
                        MemberImage = (string)row["ImagePath"];
                    if (row["Message"] != System.DBNull.Value)
                        Message = (string)row["Message"];
                    _LoadImageMessageToGroup((int)row["MessageID"], (int)row["SentByMemberID"],Message, (string)row["MessageImage"],MemberImage);
                }
                else
                {
                    string MemberImage = "", MessageImage = "", Message = "";
                    if (row["ImagePath"] != System.DBNull.Value)
                        MemberImage = (string)row["ImagePath"];
                    else
                        MemberImage = "";
                    if (row["Message"] != System.DBNull.Value)
                        Message = (string)row["Message"];
                    else
                        Message = "";
                    if (row["MessageImage"] != System.DBNull.Value)
                        MessageImage = (string)row["MessageImage"];
                    else
                        MessageImage = "";
                    _LoadReplyImageMessageToGroup((int)row["MessageID"], (int)row["SentByMemberID"], Message, (int)row["ReplyToMessageID"],MessageImage,MemberImage);
                }
            }

        }
        private void OnChannelLinkCliked(object sender,int ChannelID)
        {
            OnChannelink?.Invoke(this, ChannelID);
        }
        private void ReplyToMessage(object sender,int MessageID)
        {
            clsGroupMessage CurrentMessage = clsGroupMessage.Find(MessageID);
            pnlReplyToMessage.Visible = true;
            if(!string.IsNullOrEmpty(CurrentMessage.Message))
            {
                rtxReplyToMessage.Visible = true;
                rtxReplyToMessage.Text = CurrentMessage.Message;
            }
            if (CurrentMessage.ImagePath!="" && CurrentMessage.ImagePath!=null)
            {
                pbReplyToImageMessage.Visible = true;
                pbReplyToImageMessage.ImageLocation = CurrentMessage.ImagePath;
            }
            _IsReplyMessage = true;
            _ReplyToMessageID=MessageID;
        }
        private void frmShowGroupMessaging_Load(object sender, EventArgs e)
        {
            lblGroupName.Text = _GroupName;
            lblMembers.Text = _GroupMembers + " members";
            if (_LoadData())
                _FillGroupMessaging();
        }
        private void _AddNewImageMessageToGroup()
        {
            clsGroupMessage NewMessage = new clsGroupMessage();
            NewMessage.SentByMemberID = clsGroupMember.GetMemberID(clsGlobal.CurrentUser.UserID, _GroupID);
            NewMessage.Message = rtxMessage.Text.Trim();
            NewMessage.GroupID = _GroupID;
            NewMessage.DateOfCreation = DateTime.Now;
            NewMessage.ReplyToMessageID = -1;
            if (!_SaveImage())
                return;
            NewMessage.ImagePath = ImagePathSelected;
            if (!NewMessage.Save())
                MessageBox.Show("Error Message was not Passed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                _LoadImageMessageToGroup(NewMessage.MessageID, NewMessage.SentByMemberID, NewMessage.Message, NewMessage.ImagePath, clsGroupMember.GetMemberImagePathByID(clsGlobal.CurrentUser.UserID));
        }
        private void _AddReplyImageMessageToGroup()
        {
            clsGroupMessage NewMessage = new clsGroupMessage();
            NewMessage.SentByMemberID = clsGroupMember.GetMemberID(clsGlobal.CurrentUser.UserID, _GroupID);
            if (rtxMessage.Text != "")
                NewMessage.Message = rtxMessage.Text.Trim();
            else
                NewMessage.Message = "";
            NewMessage.GroupID = _GroupID;
            NewMessage.DateOfCreation = DateTime.Now;
            NewMessage.ReplyToMessageID = _ReplyToMessageID;
            _IsReplyMessage = false;
            if (!_SaveImage() || ImagePathSelected != "" )
                return;
            NewMessage.ImagePath = ImagePathSelected;
            if (!NewMessage.Save())
                MessageBox.Show("Error Message was not Passed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ctrlReplyToImageMessage ImageMessage = new ctrlReplyToImageMessage();
                if (clsGlobal.CurrentUser.ImagePath != "" && clsGlobal.CurrentUser.ImagePath != null)
                    ImageMessage.LoadData(NewMessage.MessageID, NewMessage.SentByMemberID, NewMessage.Message, NewMessage.ReplyToMessageID, NewMessage.ImagePath, clsGlobal.CurrentUser.ImagePath);
                else
                    ImageMessage.LoadData(NewMessage.MessageID, NewMessage.SentByMemberID, NewMessage.Message, NewMessage.ReplyToMessageID, NewMessage.ImagePath, "");
                ImageMessage.ReplyMessageDataBack += ReplyToMessage;
                flyGroupMessages.Controls.Add(ImageMessage);
                pnlReplyToMessage.Visible = false;
                rtxReplyToMessage.Text = "";
                pbReplyToImageMessage.Image = null;
            }
        }
        private void _AddNewMessageToGroup()
        {
            clsGroupMessage NewMessage = new clsGroupMessage();
            NewMessage.SentByMemberID = clsGroupMember.GetMemberID(clsGlobal.CurrentUser.UserID,_GroupID);
            NewMessage.Message = rtxMessage.Text.Trim();
            NewMessage.GroupID = _GroupID;
            NewMessage.DateOfCreation = DateTime.Now;
            NewMessage.ReplyToMessageID = -1;
            NewMessage.ImagePath = "";
            if (!NewMessage.Save())
                MessageBox.Show("Error Message was not Passed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                _LoadMessageToGroup(NewMessage.Message, clsGroupMember.GetMemberImagePathByID(clsGlobal.CurrentUser.UserID), NewMessage.MessageID, NewMessage.SentByMemberID);
        }
        private void rtxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && rtxMessage.Text != "" && !_IsReplyMessage && !_IsImageMessage)
                _AddNewMessageToGroup();
            else if (e.KeyCode == Keys.Enter && !_IsReplyMessage && _IsImageMessage)
                _AddNewImageMessageToGroup();
            else if(e.KeyCode == Keys.Enter && _IsReplyMessage)
                _AddReplyImageMessageToGroup();
        }
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (rtxMessage.Text != "" && !_IsReplyMessage && !_IsImageMessage)
                _AddNewMessageToGroup();
            else if (!_IsReplyMessage && _IsImageMessage)
                _AddNewImageMessageToGroup();
            else
                _AddReplyImageMessageToGroup();
        }
        private void rtxMessage_Enter(object sender, EventArgs e)
        {
            if(rtxMessage.Text== "Write a Message....")
            {
                rtxMessage.Text = "";
            }
        }
        private void rtxMessage_Leave(object sender, EventArgs e)
        {
            if (rtxMessage.Text == "")
                rtxMessage.Text = "Write a Message....";
        }
        private void OnDeleteEvent(object sender)
        {
            if (!clsGroup.DeleteGroupByID(_GroupID))
                MessageBox.Show("Error:Group Was Not Deleted!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                DeletEventClick?.Invoke(this, _GroupID);
        }
        private void OnLeaveEvent(object sender)
        {
            LeaveEventClick?.Invoke(this,-1);
        }
        private void OnDetailGroupInfo(object sender)
        {
            frmShowGroupDetails frmDetails = new frmShowGroupDetails(_GroupID,clsGlobal.CurrentUser.UserID);
            frmDetails.MemberDeleted += OnMemberDeleted;
            frmDetails.MemberDataSaved += OnMemberDataSaved;
            frmDetails.ShowDialog();
            frmShowGroupMessaging_Load(null, null);
        }
        private void OnMemberDataSaved(object sender,string GroupName)
        {
            _GroupName = GroupName;
            frmShowGroupMessaging_Load(null, null);
            GroupInfoSaved?.Invoke(this, -1);
        }
        private void flyGroupMessages_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbCloseReplyMessage_Click(object sender, EventArgs e)
        {
            pnlReplyToMessage.Visible = false;
            pbReplyToImageMessage.Visible = false;
            rtxReplyToMessage.Visible = false;
            _IsReplyMessage = false;
            _ReplyToMessageID = -1;
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbMessageImage.Image = null;
            pbMessageImage.Visible = false;
            ImagePathSelected = "";
            pbMessageImagePath = "";
            _IsImageMessage = false;
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
                pbMessageImage.Load(ImagePathSelected);
                pbMessageImage.Visible = true;
                pbMessageImagePath = ImagePathSelected;
                _IsImageMessage = true;
            }
        }
        private bool _SaveImage()
        {
            clsUtil.HandleUserImage("", ref pbMessageImagePath, clsUtil.GroupImagesFolder);
            if (pbMessageImagePath != null && pbMessageImagePath != ImagePathSelected)
            {
                ImagePathSelected = pbMessageImagePath;
                pbMessageImage.Image = null;
                return true;
            }
            else
            {
                MessageBox.Show("Error Image Selected Was Not Loaded Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           
        }
        private void OnMemberDeleted(object sender,string GroupName)
        {
            _GroupMembers--;
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmDropDowMenu frmDopDown = new frmDropDowMenu();
            frmDopDown.DeletEvent += OnDeleteEvent;
            frmDopDown.LeaveEvent += OnLeaveEvent;
            frmDopDown.DetailGroupInfo += OnDetailGroupInfo;
            frmDopDown.ShowDialog();
        }

    }
}
