using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TelegramDataAccessLayer;

namespace TelegramBusinessLayer
{
    public class clsChannelSubscriber
    {
        private enum enMode { AddNew=0,Update }
        private enMode _Mode = enMode.AddNew;
        public int SubscriberID { set; get; }
        public int UserID { set; get; }
        public int ChannelID { set; get; }
        public bool IsAdmin { set; get; }
        public bool IsDeleted { set; get; }
        public clsChannelSubscriber()
        {
            this.SubscriberID = -1;
            this.UserID = -1;
            this.ChannelID = -1;
            this.IsAdmin = false;
            this.IsDeleted = false;
            _Mode = enMode.AddNew;
        }
        private clsChannelSubscriber(int SubscriberID,int UserID,int ChannelID,bool IsAdmin,bool IsDeleted)
        {
            this.SubscriberID = SubscriberID;
            this.UserID = UserID;
            this.ChannelID = ChannelID;
            this.IsAdmin = IsAdmin;
            this.IsDeleted = IsDeleted;
            _Mode = enMode.Update;
        }
        private bool _AddNew()
        {
            this.SubscriberID = clsChannelSubscribersData.AddNewChannelSubscriber(this.UserID, this.ChannelID, this.IsAdmin,this.IsDeleted);
            return this.SubscriberID != -1;
        }
        private bool _Update()
        {
            return clsChannelSubscribersData.UpdateChannelSubscriber(this.SubscriberID, this.UserID, this.ChannelID, this.IsAdmin,this.IsDeleted);
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
        public static clsChannelSubscriber Find(int SubscriberID)
        {
            int UserID = -1, ChannelID = -1;
            bool IsAdmin = false,IsDeleted=false;
            if (clsChannelSubscribersData.GetSubscriberInfoByID(SubscriberID, ref UserID, ref ChannelID, ref IsAdmin, ref IsDeleted))
                return new clsChannelSubscriber(SubscriberID, UserID, ChannelID, IsAdmin, IsDeleted);
            else
                return null;
        }
        public static bool DeleteSubscriberByID(int SubscriberID)
        {
            return clsChannelSubscribersData.DeleteSubscriberByID(SubscriberID);
        }
        public static int GetSubscriberIDByUserID(int UserID,int ChannelID)
        {

            return clsChannelSubscribersData.GetSubscriberIDByUserID(UserID,ChannelID);
            
        }
        public static bool IsCurrentUserAdminInChannel(int UserID,int ChannelID)
        {
            return clsChannelSubscribersData.IsCurrentUserAdmin(UserID, ChannelID);
        }
        public static bool IsCurrentUserSubscriberInChannel(int UserID,int ChannelID)
        {
            return clsChannelSubscribersData.IsCurrentUserSubscriber(UserID, ChannelID);
        }
        public static int GetChannelSubscribersCountByID(int ChannelID)
        {
            return clsChannelSubscribersData.GetChannelSubscribersCount(ChannelID);
        }
        public static int GetSubscriberID(int UserID,int ChannelID)
        {
            return clsChannelSubscribersData.GetSubscriberIDByUserID(UserID, ChannelID);
        }
        public static string GetSubscriberNameByID(int SubscriberID)
        {
            return clsChannelSubscribersData.GetSubscriberNameByID(SubscriberID);
        }
        public static DataTable GetChannelSubscribersByChannelID(int ChannelID)
        {
            return clsChannelSubscribersData.GetChannelSubscribersChannelID(ChannelID);
        }
    }
}
