using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramDataAccessLayer;

namespace TelegramBusinessLayer
{
    public class clsUser
    {
        private enum enMode { AddNew=0,Update=1}
        private enMode _Mode = enMode.AddNew;
        public int UserID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Phone { set; get; }
        public string ImagePath { set; get; }
        public clsUser()
        {
            this.UserID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Phone = "";
            this.ImagePath = "";
            _Mode = enMode.AddNew;
        }
        private clsUser(int UserID,string FirstName,string LastName,string Phone,string ImagePath)
        {
            this.UserID = UserID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.ImagePath = ImagePath;
            _Mode = enMode.Update;
        }
        private bool _AddNew()
        {
            this.UserID = clsUserData.AddNewUser(this.FirstName, this.LastName, this.Phone,this.ImagePath);
            return this.UserID != -1;
        }
        private bool _Update()
        {
            return clsUserData.UpdateUser(UserID, FirstName, LastName, Phone,ImagePath);
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
        public static clsUser Find(int UserID)
        {
            string FirstName = "", LastName = "", Phone = "", ImagePath = "";
            if (clsUserData.GetUserInfoByID(UserID, ref FirstName, ref LastName, ref Phone, ref ImagePath))
                return new clsUser(UserID, FirstName, LastName, Phone, ImagePath);
            else
                return null;
        }
        public static clsUser Find(string Phone)
        {
            string FirstName = "", LastName = "", ImagePath = "";
            int UserID = 0;
            if (clsUserData.GetUserInfoByPhoneNum(Phone, ref UserID, ref FirstName, ref LastName, ref ImagePath))
                return new clsUser(UserID, FirstName, LastName, Phone, ImagePath);
            else
                return null;
        }
        public static DataTable SearchForPublicEntities(int UserID,string FilterValue)
        {
            return clsUserData.SearchForPublicEntities(UserID, FilterValue);
        }
    }
}
