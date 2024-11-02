using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramDataAccessLayer;

namespace TelegramBusinessLayer
{
    public class clsGroupMember
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;
        public int MemberID { set; get; }
        public int UserID { set; get; }
        public int GroupID { set; get; }
        public bool IsAdmin { set; get; }
        public bool IsDeleted { set; get; }
        public clsGroupMember()
        {
            this.MemberID = -1;
            this.UserID = -1;
            this.GroupID = -1;
            this.IsAdmin = false;
            this.IsDeleted = false;
            _Mode = enMode.AddNew;
        }
        private clsGroupMember(int MemberID,int UserID,int GroupID,bool IsAdmin,bool IsDeleted)
        {
            this.MemberID = MemberID;
            this.UserID = UserID;
            this.GroupID = GroupID;
            this.IsAdmin = IsAdmin;
            this.IsDeleted = IsDeleted;
            _Mode = enMode.Update;
        }
        private bool _AddNew()
        {
            this.MemberID = clsGroupMemberData.AddNewGroupMember(this.UserID, this.GroupID,this.IsAdmin,this.IsDeleted);
            return this.MemberID != -1;
        }
        private bool _Update()
        {
            return clsGroupMemberData.UpdateGroupMember(this.MemberID, this.UserID, this.GroupID,this.IsAdmin,this.IsDeleted);
        }
        public static bool DeleteMemberByID(int MemberID)
        {
            return clsGroupMemberData.DeleteGroupMember(MemberID);
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
        public static int GetMemberID(int UserID,int GroupID)
        {
            return clsGroupMemberData.GetMemberIDByUserID(UserID,GroupID);
        }
        public static string GetMemberImagePathByID(int MemberID)
        {
            return clsGroupMemberData.GetMemberImageByID(MemberID);
        }
        public static string GetMemberNameByID(int MemberID)
        {
            return clsGroupMemberData.GetMemberNameByID(MemberID);
        }
        public static DataTable GetGroupMembersByGroupID(int GroupID)
        {
            return clsGroupMemberData.GetGroupMembersByGroupID(GroupID);
        }
        public static bool IsMemberDeleted(int MemberID)
        {
            return clsGroupMemberData.IsMemberDeleted(MemberID);
        }
    }
}
