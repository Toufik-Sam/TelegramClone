using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram_Clone.Groups.Controls;
using TelegramBusinessLayer;

namespace Telegram_Clone.Groups
{
    public partial class frmAddMembers : Form
    {
        private string _GroupName = "";
        private string _GroupImagePath = "";
        private bool Public = true, Private = false;
        private int _UserID = -1;
        private static DataTable _dtCurrentUserContacts;
        private DataTable _dtContacts;
        private HashSet<int> SetMemberIDs=new HashSet<int>();
        int Counter = 1;
        public frmAddMembers(string GroupName,int UserID,string ImagePathSelected)
        {
            InitializeComponent();
            _GroupName = GroupName;
            _UserID = UserID;
            _GroupImagePath = ImagePathSelected;
        }
        public delegate void DataBackEventHandler(object sender);
        public event DataBackEventHandler DataBack;
        private bool _LoadCurrentUserContacts()
        {
            _dtCurrentUserContacts = clsContact.GetUserContactsByUserID(_UserID);
            if (_dtCurrentUserContacts.Rows.Count > 0)
            {
                flyUserContacts.Visible = true;
                _dtContacts = _dtCurrentUserContacts.DefaultView.ToTable(false, "FullName","Phone","ImagePath","UserContactsIDs");
                return true;
            }
            else
            {
                flyUserContacts.Visible = false;
                return false;
            }
        }
        private void _FillContactsFlowLayout()
        {
            flyUserContacts.Controls.Clear();
            foreach(DataRow row in _dtContacts.Rows)
            {
                ctrlAddMemberContact MemberContact = new ctrlAddMemberContact();
                MemberContact.LoadData(row);
                MemberContact.OnAddMember += OnAddMemberEvent;
                MemberContact.OnRemoveMember += OnRemoveMemberEvent;
                flyUserContacts.Controls.Add(MemberContact);
            }
        }
        private void OnAddMemberEvent(object sender,ctrlAddMemberContact.AddRemoveMemberEventBag e)
        {
            SetMemberIDs.Add(e.MemberID);
            Counter++;
            lblGroupMembers.Text = Counter + "/200000";
        }
        private void OnRemoveMemberEvent(object sender, ctrlAddMemberContact.AddRemoveMemberEventBag e)
        {
            SetMemberIDs.Remove(e.MemberID);
            Counter--;
            lblGroupMembers.Text = Counter + "/200000";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmAddMembers_Load(object sender, EventArgs e)
        {
            if (_LoadCurrentUserContacts())
                _FillContactsFlowLayout();
        }
        private void rtxContactsSearch_TextChanged(object sender, EventArgs e)
        {
            _dtContacts = clsContact.SearchInUserContactByFilterValue(_UserID, rtxContactsSearch.Text);
            _FillContactsFlowLayout();
        }
        private void rtxContactsSearch_Enter(object sender, EventArgs e)
        {
            rtxContactsSearch.Clear();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            clsGroup NewGroup = new clsGroup();
            NewGroup.CreatedByUserID = _UserID;
            NewGroup.GroupName = _GroupName;
            NewGroup.GroupType = Private;
            NewGroup.GroupImagePath = _GroupImagePath;
            if (NewGroup.Save())
            {
                SetMemberIDs.Add(_UserID);
                foreach (var ID in SetMemberIDs)
                {
                    clsGroupMember GroupMember = new clsGroupMember();
                    GroupMember.UserID = ID;
                    GroupMember.GroupID = NewGroup.GroupID;
                    GroupMember.IsAdmin = false;
                    if(!GroupMember.Save())
                    {
                        MessageBox.Show("Error:Member With ID: " + ID + " Was Not Added To The Group With ID: " + NewGroup.GroupID + "!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                
                DataBack?.Invoke(this);
                this.Close();
            }
            else
                MessageBox.Show("Error:Group Was Not Created Successfully!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
