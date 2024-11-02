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
    public partial class ctrlReplyMessage : UserControl
    {
        private int _MessageID = -1;
        public ctrlReplyMessage()
        {
            InitializeComponent();
        }
        public delegate void DataBackEventHandler(object sender, int MessageID);
        public event DataBackEventHandler MessageDataBack;
        public void LoadData(string Message,string ImagePath,int MessageID,int MemberID)
        {
            //Main Member
            rtxMainMessage.Text = Message;
            if (!clsGroupMember.IsMemberDeleted(MemberID))
                lblMainMemberName.Text = clsGroupMember.GetMemberNameByID(MemberID);
            else
                lblMainMemberName.Text = "Member Was Deleted";
            if (ImagePath != null)
                pbMainMember.ImageLocation = ImagePath;
            else
                pbMainMember.Image = Resources.man_512;
            _MessageID = MessageID;
            //Reply To Member
            clsGroupMessage ReplyMessage = clsGroupMessage.Find(clsGroupMessage.Find(MessageID).ReplyToMessageID);
            rtxReplyToMessage.Text = ReplyMessage.Message;
            if (!clsGroupMember.IsMemberDeleted(ReplyMessage.SentByMemberID))
            {
                lblReplyToMemberName.Text = clsGroupMember.GetMemberNameByID(ReplyMessage.SentByMemberID);
                string ReplyToMemberImage = clsGroupMember.GetMemberImagePathByID(ReplyMessage.SentByMemberID);
                if (ReplyToMemberImage != null && ReplyToMemberImage != "")
                    pbReplyToMember.ImageLocation = ImagePath;
                else
                    pbReplyToMember.Image = Resources.man_512;
            }
            else
            {
                lblReplyToMemberName.Text = "Member Was Deleted";
                pbReplyToMember.Image = Resources.man_512;
            }
            _MessageID = MessageID;
        }
        private void btnReplyToMessage_Click(object sender, EventArgs e)
        {
            MessageDataBack?.Invoke(this, _MessageID);
        }
    }
}
