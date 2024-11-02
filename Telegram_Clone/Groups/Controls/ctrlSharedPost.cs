using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram_Clone.Properties;
using TelegramBusinessLayer;

namespace Telegram_Clone.Groups.Controls
{
    public partial class ctrlSharedPost : UserControl
    {
        private int _MessageID = -1,_ChannelID=-1;
        public ctrlSharedPost()
        {
            InitializeComponent();
        }
        public delegate void ChannelDataBackEventHandler(object sender, int ChannelID);
        public event ChannelDataBackEventHandler ChannelDataBack;
        private void linkPageName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChannelDataBack?.Invoke(this, _ChannelID);
        }
        public void LoadData(int MessageID,int SentByMemberID,int SharedPostID)
        {
            clsChannelMessage Post = clsChannelMessage.Find(SharedPostID);
            if (Post.Message != null && Post.Message != "")
                rtxMessage.Text = Post.Message;
            else
                rtxMessage.Visible = false;
            if (Post.ImagePath != null && Post.ImagePath != "")
                pbPagePostImage.ImageLocation = Post.ImagePath;
            else
                pbPagePostImage.Visible = false;
            string MemberImage = clsGroupMember.GetMemberImagePathByID(SentByMemberID);
            if (MemberImage != null && MemberImage != "")
                pbMemberImage.ImageLocation = MemberImage;
            else
                pbMemberImage.Image = Resources.man_512;
            linkPageName.Text = clsChannel.Find(Post.ChannelID).ChannelName;
            lblMemberName.Text = clsGroupMember.GetMemberNameByID(SentByMemberID);
            _MessageID = MessageID;
            _ChannelID = Post.ChannelID;
        }

    }
}
