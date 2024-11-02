using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramDataAccessLayer;

namespace TelegramBusinessLayer
{
    public class clsGroupMessage
    {
        private enum enMode { AddNew=0,Update=1 };
        private enMode _Mode = enMode.AddNew;
        public int MessageID { set; get; }
        public int SentByMemberID { set; get; }
        public string Message { set; get; }
        public int GroupID { set; get; }
        public DateTime DateOfCreation { set; get; }
        public int ReplyToMessageID { set; get; }
        public string ImagePath { set; get; }
        public int SharedPostID { set; get; }
        public clsGroupMessage()
        {
            this.MessageID = -1;
            this.SentByMemberID = -1;
            this.Message = "";
            this.GroupID = -1;
            this.DateOfCreation = DateTime.Now;
            this.ReplyToMessageID = -1;
            this.ImagePath = "";
            this.SharedPostID = -1;
            _Mode = enMode.AddNew;
        }
        private clsGroupMessage(int MessageID,int SentByMemberID,string Message,int GroupID,DateTime DateOfCreation,
            int ReplyToMessageID,string ImagePath,int SharedPostID)
        {
            this.MessageID = MessageID;
            this.SentByMemberID = SentByMemberID;
            this.Message = Message;
            this.GroupID = GroupID;
            this.DateOfCreation = DateOfCreation;
            this.ReplyToMessageID = ReplyToMessageID;
            this.ImagePath = ImagePath;
            this.SharedPostID = SharedPostID;
            _Mode = enMode.Update;
        }
        private bool _AddNew()
        {
            this.MessageID = clsGroupMessageData.AddNewGroupMessage(this.SentByMemberID, this.Message, this.GroupID, this.DateOfCreation, this.ReplyToMessageID,this.ImagePath,this.SharedPostID);
            return this.MessageID != -1;
        }
        private bool _Update()
        {
            return clsGroupMessageData.UpdateGroupMessage(this.MessageID, this.SentByMemberID, this.Message, this.GroupID, this.DateOfCreation, this.ReplyToMessageID,this.ImagePath,this.SharedPostID);
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
        public static clsGroupMessage Find(int MessageID)
        {
            int SentByMemberID = -1,GroupID=-1,ReplyToMesageID=-1,SharedPostID=-1;
            string Message = "",ImagePath="";
            DateTime DateOfCreation = DateTime.Now;
            if (clsGroupMessageData.GetMessageByID(MessageID, ref SentByMemberID, ref Message, ref GroupID, ref DateOfCreation, ref ReplyToMesageID, ref ImagePath,ref SharedPostID))
                return new clsGroupMessage(MessageID, SentByMemberID, Message, GroupID, DateOfCreation, ReplyToMesageID,ImagePath,SharedPostID);
            else
                return null;
        }
    }
}
