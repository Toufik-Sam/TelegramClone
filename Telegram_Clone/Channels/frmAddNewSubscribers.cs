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

namespace Telegram_Clone.Channels
{
    public partial class frmAddNewSubscribers : Form
    {
        private string _ChannelName = "";
        private string _ChannelDescription = "";
        private string _ChannelImagePath = "";
        private bool Public = true, Private = false;
        private int _UserID = -1;
        private static DataTable _dtCurrentUserContacts;
        private DataTable _dtContacts;
        private HashSet<int> SetMemberIDs = new HashSet<int>();
        int Counter = 1;
        public frmAddNewSubscribers(string ChannelName,string ChannelDescription, int UserID, string ImagePathSelected)
        {
            InitializeComponent();
            _ChannelName = ChannelName;
            _ChannelDescription = ChannelDescription;
            _UserID = UserID;
            _ChannelImagePath = ImagePathSelected;
        }
        public delegate void DataBackEventHandler(object sender);
        public event DataBackEventHandler DataBack;
        private bool _LoadCurrentUserContacts()
        {
            _dtCurrentUserContacts = clsContact.GetUserContactsByUserID(_UserID);
            if (_dtCurrentUserContacts.Rows.Count > 0)
            {
                flyContacts.Visible = true;
                _dtContacts = _dtCurrentUserContacts.DefaultView.ToTable(false, "FullName", "Phone", "ImagePath", "UserContactsIDs");
                return true;
            }
            else
            {
                flyContacts.Visible = false;
                return false;
            }
        }
        private void _FillContactsFlowLayout()
        {
            flyContacts.Controls.Clear();
            foreach (DataRow row in _dtContacts.Rows)
            {
                ctrlAddMemberContact MemberContact = new ctrlAddMemberContact();
                MemberContact.LoadData(row);
                MemberContact.OnAddMember += OnAddMemberEvent;
                MemberContact.OnRemoveMember += OnRemoveMemberEvent;
                flyContacts.Controls.Add(MemberContact);
            }
        }
        private void OnAddMemberEvent(object sender, ctrlAddMemberContact.AddRemoveMemberEventBag e)
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

        private void rtxContactsSearch_TextChanged(object sender, EventArgs e)
        {
            _dtContacts = clsContact.SearchInUserContactByFilterValue(_UserID, rtxContactsSearch.Text);
            _FillContactsFlowLayout();
        }
        private void rtxContactsSearch_Enter(object sender, EventArgs e)
        {
            rtxContactsSearch.Clear();
        }

        private void frmAddNewSubscribers_Load(object sender, EventArgs e)
        {
            if (_LoadCurrentUserContacts())
                _FillContactsFlowLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsChannel NewChannel = new clsChannel();
            NewChannel.CreatedByUserID = _UserID;
            NewChannel.ChannelName = _ChannelName;
            NewChannel.ChannelDescription = _ChannelDescription;
            NewChannel.ChannelType = Public;
            NewChannel.ChannelImagePath = _ChannelImagePath;
            if (NewChannel.Save())
            {
                SetMemberIDs.Add(_UserID);
                foreach (var ID in SetMemberIDs)
                {
                    clsChannelSubscriber ChannelMember = new clsChannelSubscriber();
                    ChannelMember.UserID = ID;
                    ChannelMember.ChannelID = NewChannel.ChannelID;
                    if (ID == _UserID)
                        ChannelMember.IsAdmin = true;
                    else
                        ChannelMember.IsAdmin = false;
                    if (!ChannelMember.Save())
                    {
                        MessageBox.Show("Error:Member With ID: " + ID + " Was Not Added To The Group With ID: " + ChannelMember.ChannelID + "!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
