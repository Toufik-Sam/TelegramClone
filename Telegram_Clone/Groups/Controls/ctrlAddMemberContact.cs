using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram_Clone.Properties;

namespace Telegram_Clone.Groups.Controls
{
    public partial class ctrlAddMemberContact : UserControl
    {
        //This Bag Is For Add Remove Member Events
        public class AddRemoveMemberEventBag:EventArgs
        {
            public int MemberID { get; }
            public AddRemoveMemberEventBag(int MemberID)
            {
                this.MemberID = MemberID;
            }
        }
        //This Delegate For Adding Member
        public delegate void OnAddMemberEventHandler(object sender, AddRemoveMemberEventBag e);
        public event EventHandler<AddRemoveMemberEventBag> OnAddMember;
        //public event OnAddMemberEventHandler OnAddMember;
        //This Delegate For Removing Memeber
        public delegate void OnRemoveMemberEventHandler(object sender, AddRemoveMemberEventBag e);
        public event EventHandler<AddRemoveMemberEventBag> OnRemoveMember;
        //public event OnRemoveMemberEventHandler OnRemoveMember;
        private DataRow _RowContactInfo;
        public ctrlAddMemberContact()
        {
            InitializeComponent();
            btnRemove.Enabled = false;
        }
        public void LoadData(DataRow row)
        {
            _RowContactInfo = row;
            lblMemberName.Text = (string)_RowContactInfo["FullName"];
            object value = _RowContactInfo["ImagePath"];
            if (value != DBNull.Value)
                pbMember.ImageLocation = (string)_RowContactInfo["ImagePath"];
            else
                pbMember.Image = Resources.man_512;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
            btnAdd.Enabled = false;
            btnAdd.BackColor = Color.Silver;
            btnRemove.BackColor = Color.CornflowerBlue;
            OnAddMember?.Invoke(this, new AddRemoveMemberEventBag((int)_RowContactInfo["UserContactsIDs"]));
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnRemove.Enabled = false;
            btnRemove.BackColor = Color.Silver;
            btnAdd.BackColor = Color.CornflowerBlue;
            OnRemoveMember?.Invoke(this, new AddRemoveMemberEventBag((int)_RowContactInfo["UserContactsIDs"]));
        }
    }
}
