using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramDataAccessLayer;

namespace TelegramBusinessLayer
{
    public class clsChannel
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;
        public int ChannelID { set; get; }
        public int CreatedByUserID { set; get; }
        public string ChannelName { set; get; }
        public string ChannelDescription { set; get; }
        public bool ChannelType { set; get; }
        public string ChannelImagePath { set; get; }
        public clsChannel()
        {
            this.ChannelID = -1;
            this.CreatedByUserID = -1;
            this.ChannelName = "";
            this.ChannelDescription = "";
            this.ChannelType = false;
            this.ChannelImagePath = "";
            _Mode = enMode.AddNew;
        }
        private clsChannel(int ChannelID, int CreatedByUserID, string ChannelName, string ChannelDescription,bool ChannelType, string ChannelImagePath)
        {
            this.ChannelID = ChannelID;
            this.CreatedByUserID = CreatedByUserID;
            this.ChannelName = ChannelName;
            this.ChannelDescription = ChannelDescription;
            this.ChannelType = ChannelType;
            this.ChannelImagePath = ChannelImagePath;
            _Mode = enMode.Update;
        }
        private bool _AddNew()
        {
            this.ChannelID = clsChannelData.AddNewChannel(this.CreatedByUserID, this.ChannelName,this.ChannelDescription,this.ChannelType, this.ChannelImagePath);
            return this.ChannelID != -1;
        }
        private bool _Update()
        {
            return clsChannelData.UpdateChannel(this.ChannelID, this.CreatedByUserID, this.ChannelName,this.ChannelDescription,this.ChannelType, this.ChannelImagePath);
        }
        public bool Save()
        {
            switch (_Mode)
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
        public static DataTable GetChannelMessages(int ChannelID)
        {
            return clsChannelData.GetChannelMessages(ChannelID);
        }
        public static string GetImagePath(int ChannelID)
        {
            return clsChannelData.GetChannelImagePath(ChannelID);
        }
        public static clsChannel Find(int ChannelID)
        {
            int CreatedByUserID = -1;
            string ChannelName = "", ChannelImagePath = "",ChannelDescription="";
            bool ChannelType = false;
            if (clsChannelData.GetChanneInfoByID(ChannelID, ref CreatedByUserID, ref ChannelName, ref ChannelDescription, ref ChannelType, ref ChannelImagePath))
                return new clsChannel(ChannelID, CreatedByUserID, ChannelName, ChannelDescription, ChannelType, ChannelImagePath);
            else
                return null;
        }
        public static bool DeleteChannel(int ChannelID)
        {
            return clsChannelData.DeleteChannelByID(ChannelID);
        }
    }
}
