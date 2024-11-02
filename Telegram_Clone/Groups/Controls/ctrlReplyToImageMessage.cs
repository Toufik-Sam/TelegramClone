using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram_Clone.Properties;
using TelegramBusinessLayer;

namespace Telegram_Clone.Groups.Controls
{
    public partial class ctrlReplyToImageMessage : UserControl
    {
        private int _MessageID = -1;
        public ctrlReplyToImageMessage()
        {
            InitializeComponent();
        }
        public delegate void DataBackEventHandler(object sender, int MessageID);
        public event DataBackEventHandler ReplyMessageDataBack;
        public void LoadData(int MessageID,int SentByMemberID,string Message,int ReplyToMessageID,string MessageImage,string MemberImagePath)
        {
            //Main member
            
            if (!clsGroupMember.IsMemberDeleted(MessageID))
                lblMainMember.Text = clsGroupMember.GetMemberNameByID(SentByMemberID);
            else
                lblMainMember.Text = "Member Was Deleted";
            if (MemberImagePath != "" && MemberImagePath != null)
                pbMainMemberImage.ImageLocation = MemberImagePath;
            else
                pbMainMemberImage.Image = Resources.man_512;
            if (Message != "" && Message != null)
                rtxMainMessage.Text = Message;
            else
            {
                rtxMainMessage.Text = "";
                rtxMainMessage.Visible = false;
            }
            if (MessageImage != null && MessageImage != "")
                pbMainMember.ImageLocation = MessageImage;
            else
                pbMainMember.Visible = false;

            //Reply To Member
            clsGroupMessage ReplyMessage =clsGroupMessage.Find(ReplyToMessageID);
            if (!clsGroupMember.IsMemberDeleted(ReplyMessage.SentByMemberID))
                lblReplyMemberName.Text = clsGroupMember.GetMemberNameByID(ReplyMessage.SentByMemberID);
            else
                lblReplyMemberName.Text = "Member Was Deleted";
            string ReplyToMemberImage = clsGroupMember.GetMemberImagePathByID(ReplyMessage.SentByMemberID);
            if (ReplyToMemberImage != null && ReplyToMemberImage != "")
                pbReplyMember.ImageLocation = ReplyToMemberImage;
            else
                pbReplyMember.Image = Resources.man_512;
            if (ReplyMessage.Message != "" && ReplyMessage.Message != null)
                rtxReplyToMessage.Text = ReplyMessage.Message;
            else
            {
                rtxReplyToMessage.Text = "";
                rtxReplyToMessage.Visible = false;
            }
            if (ReplyMessage.ImagePath != null && ReplyMessage.ImagePath != "")
            {
                pbReplyToMember.Visible = true;
                pbReplyToMember.ImageLocation = ReplyMessage.ImagePath;
            }
            else
                pbReplyToMember.Visible = false;

            _MessageID = MessageID;
        }

        private void btnReplyToMessage_Click(object sender, EventArgs e)
        {
            ReplyMessageDataBack?.Invoke(this, _MessageID);
        }
    }
}
