using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramDataAccessLayer;

namespace TelegramBusinessLayer
{
    public class clsContact
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;
        public int ContactID { set; get; }
        public int FirstUserID { set; get; }
        public int SecondUserID { set; get; }

        public clsContact()
        {
            this.ContactID = -1;
            this.FirstUserID = -1;
            this.SecondUserID = -1;
            _Mode = enMode.AddNew;
        }
        private clsContact(int ContactID,int FirstUserID,int SecondUserID)
        {
            this.ContactID = ContactID;
            this.FirstUserID = FirstUserID;
            this.SecondUserID = SecondUserID;
            _Mode = enMode.Update;
        }
        private bool _AddNew()
        {
            this.ContactID = clsContactData.AddNewContact(this.FirstUserID,this.SecondUserID);
            return this.ContactID != -1;
        }
        private bool _Update()
        {
            return clsContactData.UpdateContact(this.ContactID,this.FirstUserID,this.SecondUserID);
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
        public static bool DeleteContact(int FirstUserID,int SecondUserID)
        {
            return clsContactData.DeleteContactByID(FirstUserID,SecondUserID);
        }
        public static DataTable GetUserContactsByUserID(int UserID)
        {
            return clsContactData.GetUserContacts(UserID);
        }
        public static DataTable SearchInUserContactByFilterValue(int UserID,string FilterValue)
        {
            return clsContactData.SearchInUserContacts(UserID, FilterValue);
        }
    }
}
