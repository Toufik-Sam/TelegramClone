using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TelegramDataAccessLayer;

namespace TelegramBusinessLayer
{
    public class clsChannelMessage
    {
        private enum enMode { AddNew=0,Update=1};
        private enMode _Mode = enMode.AddNew;
        public int MessageID { set; get; }
        public string Message { set; get; }
        public int ChannelID { set; get; }
        public DateTime DateOfCreation { set; get; }
        public int SentByAdminID { set; get; }
        public string ImagePath { set; get; }
        public clsChannelMessage()
        {
            this.MessageID = -1;
            this.Message = "";
            this.ChannelID = -1;
            this.DateOfCreation = DateTime.Now;
            this.SentByAdminID = -1;
            this.ImagePath = "";
            _Mode = enMode.AddNew;
        }
        private clsChannelMessage(int MessageID,string Message,int ChannelID,DateTime DateOfCreation,int SentByAdminID,string ImagePath)
        {
            this.MessageID = MessageID;
            this.Message = Message;
            this.ChannelID = ChannelID;
            this.DateOfCreation = DateOfCreation;
            this.SentByAdminID = SentByAdminID;
            this.ImagePath = ImagePath;
            _Mode = enMode.Update;
        }
        private bool _AddNew()
        {
            this.MessageID = clsChannelMessageData.AddNewChannelMessage(this.Message, this.ChannelID, this.DateOfCreation, this.SentByAdminID, this.ImagePath);
            return this.MessageID != -1;
        }
        private bool _Update()
        {
            return clsChannelMessageData.UpdateChannelMessage(this.MessageID, this.Message, this.ChannelID, this.DateOfCreation, this.SentByAdminID, this.ImagePath);
        }
        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if (_AddNew())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _Update();
                default:
                    return false;
            }
        }
        public static clsChannelMessage Find(int MessageID)
        {
            int ChannelID = -1, SentByAdminID = -1;
            DateTime DateOfCreation = DateTime.Now;
            string ImagePath = "",Message="";
            if (clsChannelMessageData.GetChannelMessageInfoByID(MessageID, ref Message, ref ChannelID, ref DateOfCreation, ref SentByAdminID,
                ref ImagePath))
                return new clsChannelMessage(MessageID, Message, ChannelID, DateOfCreation, SentByAdminID, ImagePath);
            else
                return null;
    
        }
    }
}
