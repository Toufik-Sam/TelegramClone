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

namespace Telegram_Clone.Channels.Controls
{
    public partial class ctrlChannelMessage : UserControl
    {
        private int _MessageID = -1;
        private bool Private = false;
        public ctrlChannelMessage()
        {
            InitializeComponent();
        }
        public delegate void DataBackShareEventHandler(object sender, int MessageID);
        public event DataBackShareEventHandler SharePostEvent;
        public void LoadData(int MessageID,int ChannelID,string Message,bool ChannelType)
        {
            if (ChannelType == Private)
                btnShare.Visible = false;
            rtxMessage.Text = Message;
            string ImagePath = clsChannel.GetImagePath(ChannelID);
            if (ImagePath != "" && ImagePath != null)
                pbChannelImage.ImageLocation = ImagePath;
            else
                pbChannelImage.Image = Resources.icons8_chat_group_35;
            _MessageID = MessageID;
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            SharePostEvent?.Invoke(this, _MessageID);
        }
    }
}
