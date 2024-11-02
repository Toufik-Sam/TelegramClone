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
using Telegram_Clone.Groups.Controls;
using TelegramBusinessLayer;

namespace Telegram_Clone.Groups
{
    public partial class frmShowGroupDetails : Form
    {
        private clsGroup _CurrentGroup;
        private bool _ShowDeleteIconToAdmin = true;
        private int _UserToViewDetails = -1;
        private static DataTable _dtGroupMembers;
        private DataTable _dtMembers;
        private string ImagePathSelected = "", pbGroupImagePath="";

        public frmShowGroupDetails(int GroupID,int UserToViewDetails)
        {
            InitializeComponent();
            _CurrentGroup = clsGroup.Find(GroupID);
            _UserToViewDetails = UserToViewDetails;
            if (_CurrentGroup.CreatedByUserID != UserToViewDetails)
                _ShowDeleteIconToAdmin = false;
        }
        public delegate void DeleteMemberEventHandler(object sender,string GroupName);
        public event DeleteMemberEventHandler MemberDataSaved;
        public event DeleteMemberEventHandler MemberDeleted;
        private bool _LoadData()
        {
            if (_CurrentGroup.GroupImagePath != null && _CurrentGroup.GroupImagePath != "")
                pbGroupImage.ImageLocation = _CurrentGroup.GroupImagePath;
           
            txtGroupName.Text = _CurrentGroup.GroupName;
            lblMemberName.Text = clsGroupMember.GetMemberNameByID(clsGroupMember.GetMemberID(_CurrentGroup.CreatedByUserID, _CurrentGroup.GroupID));
            if (_CurrentGroup.GroupType == false)
                rdbPrivate.Checked = true;
            else
                rdbPublic.Checked = true;
            _dtGroupMembers = clsGroupMember.GetGroupMembersByGroupID(_CurrentGroup.GroupID);
            if (_dtGroupMembers.Rows.Count > 0)
            {
                _dtMembers = _dtGroupMembers.DefaultView.ToTable(false,"MemberID","FullName", "ImagePath");
                return true;
            }
            else
                return false;
        }
        private void OnDeletemember(object sender,int MemberID)
        {
            if(MessageBox.Show("Are You Sure That You Want To Delete Member With ID: "+MemberID,"Information",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                if (clsGroupMember.DeleteMemberByID(MemberID))
                {
                    frmShowGroupDetails_Load(null, null);
                    MemberDeleted?.Invoke(this,"");
                }
                else
                    MessageBox.Show("Error:Member Was Not Deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void _FillGroupMembers()
        {
            flyMembers.Controls.Clear();
            foreach(DataRow row in _dtMembers.Rows)
            {
                ctrlMember Member = new ctrlMember();
                Member.DeleteMemberEvent += OnDeletemember;
                if (row["ImagePath"] == System.DBNull.Value)
                    Member.LoadData((int)row["MemberID"],(string)row["FullName"], "", _ShowDeleteIconToAdmin);
                else
                    Member.LoadData((int)row["MemberID"],(string)row["FullName"], (string)row["ImagePath"], _ShowDeleteIconToAdmin);
                flyMembers.Controls.Add(Member);
            }
        }
        private void frmShowGroupDetails_Load(object sender, EventArgs e)
        {
            if (!_ShowDeleteIconToAdmin)
            {
                btnSave.Visible = false;
                lblChangePicture.Visible = false;
                txtGroupName.ReadOnly = true;
                if (_CurrentGroup.GroupType == false)
                {
                    rdbPrivate.Checked = true;
                    rdbPublic.Visible = false;
                }
                else
                {
                    rdbPublic.Checked = true;
                    rdbPrivate.Visible = false;
                }
            }
            if (_LoadData())
                _FillGroupMembers();
        }
        private void lblChangePicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpeg;*.png;*.gif;*.bmp;*.jpg";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //process the selected file
                ImagePathSelected = openFileDialog1.FileName;
                pbGroupImage.Load(ImagePathSelected);
                pbGroupImagePath = ImagePathSelected;
                if (!_SaveImage())
                    MessageBox.Show("Error Image Selected Was Not Loaded Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    _CurrentGroup.GroupImagePath = ImagePathSelected;
            }
        }
        private bool _SaveImage()
        {
            clsUtil.HandleUserImage("", ref pbGroupImagePath, clsUtil.GroupImagesFolder);
            if (pbGroupImagePath != null && pbGroupImagePath != ImagePathSelected)
            {
                ImagePathSelected = pbGroupImagePath;
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _CurrentGroup.GroupName = txtGroupName.Text;
            if (rdbPublic.Checked)
                _CurrentGroup.GroupType = true;
            else
                _CurrentGroup.GroupType = false;
            if (!_CurrentGroup.Save())
                MessageBox.Show("Data Was Not Saved!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MemberDataSaved?.Invoke(this, _CurrentGroup.GroupName);
            
            this.Close();
        }
    }
}
