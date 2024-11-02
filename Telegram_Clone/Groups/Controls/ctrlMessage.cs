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
    public partial class ctrlMessage : UserControl
    {
        private int _MessageID = -1;
        public ctrlMessage()
        {
            InitializeComponent();
        }
        public delegate void DataBackEventHandler(object sender, int MessageID);
        public event DataBackEventHandler MessageDataBack;
        public void LoadData(string Message,string ImagePath,int MessageID,int MemberID)
        {
            rtxMessage.Text = Message;
            if (!clsGroupMember.IsMemberDeleted(MemberID))
                lblMemberName.Text = clsGroupMember.GetMemberNameByID(MemberID);
            else
                lblMemberName.Text = "Member was Deleted";
            if (ImagePath != null)
                pbMemberImage.ImageLocation = ImagePath;
            else
                pbMemberImage.Image = Resources.man_512;
            _MessageID = MessageID;
        }

        private void btnReplyToMessage_Click(object sender, EventArgs e)
        {
            MessageDataBack?.Invoke(this, _MessageID);
        }
    }
}
