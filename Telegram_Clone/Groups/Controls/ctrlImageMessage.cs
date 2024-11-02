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
    public partial class ctrlImageMessage : UserControl
    {
        private int _MessageID = -1;
        public ctrlImageMessage()
        {
            InitializeComponent();
        }
        public delegate void DataBackIlmageMessage(object sender, int MessageID);
        public event DataBackIlmageMessage DataReplyImageMessage;
        public void LoadData(int MessageID,int MemberID,string Message,string ImagePath,string MemberImagePath)
        {
            pbMessageImage.ImageLocation = ImagePath;
            if (Message != null && Message != "")
                rtxMessage.Text = Message;
            else
            {
                rtxMessage.Visible = false;
                this.Height = 130;
            }
            if (!clsGroupMember.IsMemberDeleted(MemberID))
                lblMembeName.Text = clsGroupMember.GetMemberNameByID(MemberID);
            else
                lblMembeName.Text = "Member Was Deleted!";
            if (MemberImagePath != null && MemberImagePath != "")
                pbMemberImage.ImageLocation = MemberImagePath;
            else
                pbMemberImage.Image = Resources.man_512;

            _MessageID = MessageID;
        }

        private void btnReplyToMessage_Click(object sender, EventArgs e)
        {
            DataReplyImageMessage?.Invoke(this, _MessageID);
        }
    }
}
