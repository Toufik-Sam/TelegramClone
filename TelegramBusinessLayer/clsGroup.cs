using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TelegramDataAccessLayer;

namespace TelegramBusinessLayer
{
    public class clsGroup
    {
        private enum enMode { AddNew=0,Update=1}
        private enMode _Mode = enMode.AddNew;
        public int GroupID { set; get; }
        public int CreatedByUserID { set; get; }
        public string GroupName { set; get; }
        public bool GroupType { set; get; }
        public string GroupImagePath { set; get; }
        public clsGroup()
        {
            this.GroupID = -1;
            this.CreatedByUserID = -1;
            this.GroupName = "";
            this.GroupType = false;
            this.GroupImagePath = "";
            _Mode = enMode.AddNew;
        }
        private clsGroup(int GroupID,int CreatedByUserID,string GroupName,bool GroupType,string GroupImagePath)
        {
            this.GroupID = GroupID;
            this.CreatedByUserID = CreatedByUserID;
            this.GroupName = GroupName;
            this.GroupType = GroupType;
            this.GroupImagePath = GroupImagePath;
            _Mode = enMode.Update;
        }
        private bool _AddNew()
        {
            this.GroupID = clsGroupData.AddNewGroup(this.CreatedByUserID, this.GroupName, this.GroupType, this.GroupImagePath);
            return this.GroupID != -1;
        }
        private bool _Update()
        {
            return clsGroupData.UpdateGroup(this.GroupID, this.CreatedByUserID, this.GroupName, this.GroupType, this.GroupImagePath);
        }
        public static bool DeleteGroupByID(int GroupID)
        {
            return clsGroupData.DeleteGroup(GroupID);
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
        public static DataTable GetCurrentUserEntities(int UserID)
        {
            return clsGroupData.GetUserEntities(UserID);
        }
        public static DataTable GetGroupMessaging(int GroupID)
        {
            return clsGroupData.GetGroupMessages(GroupID);
        }
        public static clsGroup Find(int GroupID)
        {
            int CreatedByUserID = -1;
            string GroupName = "", GroupImagePath = "";
            bool GroupType = false;
            if (clsGroupData.GetGroupInfoByID(GroupID, ref CreatedByUserID, ref GroupName, ref GroupType, ref GroupImagePath))
                return new clsGroup(GroupID, CreatedByUserID, GroupName, GroupType, GroupImagePath);
            else
                return null;
        }
        public static int GetGroupMembersCount(int GroupID)
        {
            return clsGroupData.GetGroupMembersCount(GroupID);
        }
    }
}
