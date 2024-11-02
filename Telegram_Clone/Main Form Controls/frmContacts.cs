using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram_Clone.Global_Classes;
using TelegramBusinessLayer;

namespace Telegram_Clone.Main_Form_Controls
{
    public partial class frmContacts : Form
    {
        private static DataTable _dtGetCurrentUserContacts;
        private DataTable _dtContacts;
        public frmContacts()
        {
            InitializeComponent();
        }
        private bool _LoadData()
        {
            _dtGetCurrentUserContacts = clsContact.GetUserContactsByUserID(clsGlobal.CurrentUser.UserID);
            if (_dtGetCurrentUserContacts.Rows.Count > 0)
            {
                _dtContacts = _dtGetCurrentUserContacts.DefaultView.ToTable(false, "FullName", "Phone", "ImagePath", "UserContactsIDs");
                return true;
            }
            else
                return false;

        }
        private void _FillContactsFlow()
        {
            flyContacts.Controls.Clear();
            foreach(DataRow row in _dtContacts.Rows)
            {
                ctrlContactInfo Contact = new ctrlContactInfo();
                if (row["ImagePath"] != System.DBNull.Value)
                    Contact.LoadData((int)row["UserContactsIDs"],(string)row["FullName"], (string)row["ImagePath"]);
                else
                    Contact.LoadData((int)row["UserContactsIDs"],(string)row["FullName"], "");
                Contact.DeleteDataBack += OnDeleteContact;
                flyContacts.Controls.Add(Contact);
            }
        }
        private void frmContacts_Load(object sender, EventArgs e)
        {
            if (_LoadData())
                _FillContactsFlow();
        }
        private void OnDeleteContact(object sender,int UseerID)
        {
            if (!clsContact.DeleteContact(clsGlobal.CurrentUser.UserID, UseerID))
            {
                MessageBox.Show("Error:Contact Was Not Deleted Successfully!!", "Error", MessageBoxButtons.OK);
                return;
            }
            else
                frmContacts_Load(null, null);
        }
    }
}
