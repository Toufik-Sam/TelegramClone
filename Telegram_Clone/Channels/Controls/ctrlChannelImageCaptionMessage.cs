using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram_Clone.Global_Classes;
using Telegram_Clone.Properties;
using TelegramBusinessLayer;

namespace Telegram_Clone.Channels.Controls
{
    public partial class ctrlChannelImageCaptionMessage : UserControl
    {
        private int _MessageID=-1;
        private bool Private = false;
        public delegate void DataBackShareEventHandler(object sender, int MessageID);
        public event DataBackShareEventHandler SharePostEvent;
        public ctrlChannelImageCaptionMessage()
        {
            InitializeComponent();
        }
        public void LoadData(int MessageID,int ChannelID,string Message,string ImagePath,bool ChannelType)
        {
            if (ChannelType == Private)
                btnShare.Visible = false;
            if (Message != "" && Message != null)
                rtxText.Text = Message;
            else
                rtxText.Text = "";
            pbMessageImage.ImageLocation = ImagePath;
            string ChannelImage = clsChannel.GetImagePath(ChannelID);
            if (ChannelImage != null && ChannelImage != "")
                pbChannel.ImageLocation = ChannelImage;
            else
                pbChannel.Image = Resources.icons8_chat_group_35;
            _MessageID = MessageID;
        }
        private void btnShare_Click(object sender, EventArgs e)
        {
            SharePostEvent?.Invoke(this, _MessageID);
        }
    }
}
