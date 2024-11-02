using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram_Clone.Channels.Controls;
using Telegram_Clone.Global_Classes;
using TelegramBusinessLayer;

namespace Telegram_Clone.Channels
{
    public partial class frmShareChannelPost : Form
    {
        private int _PostID = -1;
        public frmShareChannelPost(int PostID)
        {
            InitializeComponent();
            _PostID = PostID;
        }
        public delegate void PostSharedEventhandler(object sender);
        public event PostSharedEventhandler PostSharedEvent;
        private void OnSharePostToGroup(object sender,int GroupID)
        {
            if(MessageBox.Show("Do you Want To Share This Post To Group With ID:"+GroupID,"InforMation",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)==DialogResult.OK)
            {
                clsGroupMessage GroupMessage = new clsGroupMessage();
                GroupMessage.SentByMemberID = clsGroupMember.GetMemberID(clsGlobal.CurrentUser.UserID, GroupID);
                GroupMessage.Message = "";
                GroupMessage.GroupID = GroupID;
                GroupMessage.DateOfCreation = DateTime.Now;
                GroupMessage.ReplyToMessageID = -1;
                GroupMessage.ImagePath = "";
                GroupMessage.SharedPostID =_PostID;
                if (GroupMessage.Save())
                {
                    MessageBox.Show("Your post Has Been Shared Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PostSharedEvent?.Invoke(this);
                    this.Close();
                }
                else
                    MessageBox.Show("Your post Wasn't Shared Successfully!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void _FillGroupsFlow()
        {
            flyYourGroups.Controls.Clear();
            foreach(DataRow row in clsGlobal.CurrentUserGroupsAndChannels.Rows)
            {
                if ((bool)row["IsGroup"]==true)
                {
                    ctrlGroupToShare Group = new ctrlGroupToShare();
                    Group.LoadData((int)row["EntityID"], (string)row["EntityName"], (string)row["EntityImagePath"]);
                    Group.SharePostGroupEvent += OnSharePostToGroup;
                    flyYourGroups.Controls.Add(Group);
                }
            }
        }
        private void frmShareChannelPost_Load(object sender, EventArgs e)
        {
            _FillGroupsFlow();
        }
    }
}
