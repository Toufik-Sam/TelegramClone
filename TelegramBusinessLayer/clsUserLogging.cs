using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramDataAccessLayer;

namespace TelegramBusinessLayer
{
    public class clsUserLogging
    {
        private enum enMode { AddNew=0,Update=1 }
        private enMode _Mode = enMode.AddNew;
        public int LogID { set; get; }
        public int UserID { set; get; }
        public int EntityID { set; get; }
        public DateTime LogOutDate { set; get; }
        public bool IsGroup { set; get; }
        public bool IsChannel { set; get; }
        public clsUserLogging()
        {
            this.LogID = -1;
            this.UserID = -1;
            this.EntityID = -1;
            this.LogOutDate = DateTime.Now;
            this.IsGroup = false;
            this.IsChannel = false;
            _Mode = enMode.AddNew;
        }
        private clsUserLogging(int LogID,int UserID,int EntityID,DateTime LogInDate,DateTime LogOutDate,bool IsGroup,bool IsChannel)
        {
            this.LogID = LogID;
            this.UserID = UserID;
            this.EntityID = EntityID;
            this.LogOutDate = DateTime.Now;
            this.IsGroup = false;
            this.IsChannel = false;
            _Mode = enMode.Update;
        }
        private bool _AddNew()
        {
            this.LogID = clsUserLoggingData.AddNewLogID(this.UserID, this.EntityID, this.LogOutDate, this.IsGroup,this.IsChannel);
            return this.LogID != -1;
        }
        private bool _Update()
        {
            return clsUserLoggingData.UpdateLogID(this.LogID, this.UserID, this.EntityID, this.LogOutDate, this.IsGroup,this.IsChannel);
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
    }
}
