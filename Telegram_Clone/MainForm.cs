using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using TelegramBusinessLayer;
using Telegram_Clone.Groups;
using Telegram_Clone.Groups.Controls;
using Telegram_Clone.Main_Form_Controls;
using Telegram_Clone.Channels;
using Telegram_Clone.Global_Classes;
using System.Windows.Markup;

namespace Telegram_Clone
{
    public partial class MainForm : Form
    {
        private static DataTable _dtUserGroupsAndChannels;
        private DataTable _dtItems;
        private frmLogin _LoginForm;
        private bool Group = false;
        private bool Channel = true;
        public MainForm(frmLogin LoginForm)
        {
            InitializeComponent();
            _LoginForm = LoginForm;
        }
        //this part is used for moving the form from the top bar 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwd, int wmsg, int wparam, int lparam);
        //it is the same principle with deleget we invoke this function when the Mouse down Event is fired 
        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
 
        //When The User Clicks on The Main Panel and The User Menue Panel Is Shown it Will not be visibl and the Channels flowLayout Will Be Shown
        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (pnlUserSilder.Visible == true)
            {
                pnlUserSilder.Visible = false;
                flowlayoutChannelsandGroups.Visible = true;
            }
        }
 
        private void btnNewGroup_Click(object sender, EventArgs e)
        {
            frmAddNewGroup NewGroup = new frmAddNewGroup(clsGlobal.CurrentUser.UserID);
            NewGroup.DataBack += BackToMainEvent_OnRferesh;
            NewGroup.ShowDialog();
        }
        private void btnNewChannel_Click(object sender, EventArgs e)
        {
            frmAddNewChannel NewChannel = new frmAddNewChannel(clsGlobal.CurrentUser.UserID);
            NewChannel.DataBack += BackToMainEvent_OnRferesh;
            NewChannel.ShowDialog();
        }
        //When The User Clicks This Button the User Slid Will Deasappear 
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (pnlUserSilder.Visible == true)
            {
                pnlUserSilder.Visible = false;
                flowlayoutChannelsandGroups.Visible = true;
            }
        }
        //When The User Clicks On This Button The User Slid Will Appear To him
        private void btnSlidUserMenu_Click(object sender, EventArgs e)
        {
            if (pnlUserSilder.Visible == false)
            {
                flowlayoutChannelsandGroups.Visible = false;
                pnlUserSilder.Visible = true;
            }
        }
        //Close Form Button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Miximize Form
        private void btnMaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaxi.Visible = false;
            btnResize.Visible = true;
        }
        //Resizze Form To Normal Size
        private void btnResize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnResize.Visible = false;
            btnMaxi.Visible = true;
        }
        //Minimize Form
        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //this Event Will be Fired When The User Create a New group And Click on Create On The AddMember Form
        private void BackToMainEvent_OnRferesh(object sender)
        {
            MainForm_Load(null, null);
        }
        private bool _LoadUserGroupsAndChannels()
        {
            _dtUserGroupsAndChannels = clsGroup.GetCurrentUserEntities(clsGlobal.CurrentUser.UserID);
            clsGlobal.CurrentUserGroupsAndChannels = _dtUserGroupsAndChannels;
            if(_dtUserGroupsAndChannels.Rows.Count>0)
            {
                _dtItems=_dtUserGroupsAndChannels.DefaultView.ToTable(false, "EntityID", "EntityName", "EntityType", "EntityImagePath", "EntityMessagesCount", "EntityMembersCount", "IsGroup","IsChannel");
                return true;
            }
            return false;
        }
        private void _FillFlowLayoutOfUserGroupsAndChannels()
        {
            flowlayoutChannelsandGroups.Controls.Clear();
            foreach(DataRow row in _dtItems.Rows)
            {
                ctrlGroupChannel Entity = new ctrlGroupChannel();
                Entity.LoadData(row);
                Entity.OnReturnEntityInformation += OnGroupOrChannelClicked;
                flowlayoutChannelsandGroups.Controls.Add(Entity);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (_LoadUserGroupsAndChannels())
                _FillFlowLayoutOfUserGroupsAndChannels();

        }
        private void _ShowFormInTheMainPanel(object FormToShow)
        {
            //here we check if the mainPanel already has a form on it in this case we Remove it 
            if (this.pnlMain.Controls.Count > 0)
                this.pnlMain.Controls.RemoveAt(0);
            //here we create a new form that contains the Form that we want to display 
            Form frm = FormToShow as Form;
            //we set the TopLevel Propertiy to false because we dont want the FormToShow to be on top
            frm.TopLevel = false;
            //we set the dock propertiy to Dockstyle to fill
            frm.Dock = DockStyle.Fill;
            //here we Add the form to the mainPanel
            this.pnlMain.Controls.Add(frm);
            //sets the object that contains data about the control/ store data that is closely associated with the control.
            this.pnlMain.Tag = frm;
            frm.Show();
        }
        private void OnDeleteEvent(object sender,int GroupID)
        {
            pnlMain.Controls.Clear();
            MainForm_Load(null, null);
        }
        private void OnLeaveEvent(object sender,int GroupID)
        {
            pnlMain.Controls.Clear();
        }
        private void OnDeleteChannelEvent(object sender,int ChannelID)
        {
            pnlMain.Controls.Clear();
            MainForm_Load(null, null);
        }
        private void OnChannelInfoSaved(object sender,int ChannelID)
        {
            MainForm_Load(null, null);
        }
        private void OnGroupInfoSaved(object sender,int GroupID)
        {
            MainForm_Load(null, null);
        }
        private void OnRefresh(object sender)
        {
            MainForm_Load(null, null);
        }
        private void OnChannelLinkClicked(object sender,int ChannelID)
        {
            clsChannel Channel = clsChannel.Find(ChannelID);
            frmShowChannelMessaging frm = new frmShowChannelMessaging(Channel.ChannelID,Channel.ChannelName,Channel.ChannelType,clsChannelSubscriber.GetChannelSubscribersCountByID(Channel.ChannelID));
            frm.LeaveEventClick += OnLeaveEvent;
            frm.DeletEventClick += OnDeleteChannelEvent;
            frm.ChannelInfoSaved += OnChannelInfoSaved;
            frm.RefreshEvent += OnRefresh;
            _ShowFormInTheMainPanel(frm);
            clsUserLogging NewLog = new clsUserLogging();
            NewLog.UserID = clsGlobal.CurrentUser.UserID;
            NewLog.EntityID =Channel.ChannelID;
            NewLog.LogOutDate = DateTime.Now;
            NewLog.IsGroup = false;
            NewLog.IsChannel = true;
            NewLog.Save();
        }
        private void OnGroupOrChannelClicked(object sender,ctrlGroupChannel.ReturnEntityInformationBag e)
        {
            if (e.isGroup)
            {
                frmShowGroupMessaging frm = new frmShowGroupMessaging(e.EntityID, e.EntityName, e.EntityType, e.EntityMembers);
                frm.DeletEventClick += OnDeleteEvent;
                frm.LeaveEventClick += OnLeaveEvent;
                frm.GroupInfoSaved += OnGroupInfoSaved;
                frm.OnChannelink += OnChannelLinkClicked;
                _ShowFormInTheMainPanel(frm);
                clsUserLogging NewLog=new clsUserLogging();
                NewLog.UserID = clsGlobal.CurrentUser.UserID;
                NewLog.EntityID = e.EntityID;
                NewLog.LogOutDate = DateTime.Now;
                NewLog.IsGroup = true;
                NewLog.IsChannel = false;
                NewLog.Save();
            }
            else
            {
                frmShowChannelMessaging frm = new frmShowChannelMessaging(e.EntityID, e.EntityName, e.EntityType, e.EntityMembers);
                frm.LeaveEventClick += OnLeaveEvent;
                frm.DeletEventClick += OnDeleteChannelEvent;
                frm.ChannelInfoSaved += OnChannelInfoSaved;
                frm.RefreshEvent += OnRefresh;
                _ShowFormInTheMainPanel(frm);
                clsUserLogging NewLog = new clsUserLogging();
                NewLog.UserID = clsGlobal.CurrentUser.UserID;
                NewLog.EntityID = e.EntityID;
                NewLog.LogOutDate = DateTime.Now;
                NewLog.IsGroup = false;
                NewLog.IsChannel = true;
                NewLog.Save();
            }
            
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _LoginForm.Show();
            this.Close();
        }
        private void btnContacts_Click(object sender, EventArgs e)
        {
            frmContacts Contacts = new frmContacts();
            Contacts.ShowDialog();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings Settings = new FrmSettings();
            Settings.ShowDialog();
        }
        private void OnJoinEventClicked(object sender,frmSearchForPublicEntities.JoinEntityBag e )
        {
            if(e.IsGroup==true)
            {
                clsGroupMember NewMember = new clsGroupMember();
                NewMember.UserID = clsGlobal.CurrentUser.UserID;
                NewMember.GroupID = e.EntityID;
                NewMember.IsAdmin = false;
                NewMember.IsDeleted = false;
                if(!NewMember.Save())
                {
                    MessageBox.Show("Subscribtion Denied!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MainForm_Load(null, null);
                frmShowGroupMessaging frm = new frmShowGroupMessaging(e.EntityID, e.EntityName,true,
                    clsGroup.GetGroupMembersCount(e.EntityID));
                frm.DeletEventClick += OnDeleteEvent;
                frm.LeaveEventClick += OnLeaveEvent;
                frm.GroupInfoSaved += OnGroupInfoSaved;
                frm.OnChannelink += OnChannelLinkClicked;
                _ShowFormInTheMainPanel(frm);
                clsUserLogging NewLog = new clsUserLogging();
                NewLog.UserID = clsGlobal.CurrentUser.UserID;
                NewLog.EntityID = e.EntityID;
                NewLog.LogOutDate = DateTime.Now;
                NewLog.IsGroup = true;
                NewLog.IsChannel = false;
                NewLog.Save();
                pnlUserSilder.Visible = false;
                flowlayoutChannelsandGroups.Visible = true;
                MainForm_Load(null, null);

            }
            else if(e.IsChannel==true)
            {
                clsChannelSubscriber NewSubscriber = new clsChannelSubscriber();
                NewSubscriber.UserID = clsGlobal.CurrentUser.UserID;
                NewSubscriber.ChannelID = e.EntityID;
                NewSubscriber.IsAdmin = false;
                NewSubscriber.IsDeleted = false;
                if (!NewSubscriber.Save())
                {
                    MessageBox.Show("Subscribtion Denied!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MainForm_Load(null, null);
                frmShowChannelMessaging frm = new frmShowChannelMessaging(e.EntityID, e.EntityName, true,clsChannelSubscriber.GetChannelSubscribersCountByID(e.EntityID));
                frm.LeaveEventClick += OnLeaveEvent;
                frm.DeletEventClick += OnDeleteChannelEvent;
                frm.ChannelInfoSaved += OnChannelInfoSaved;
                frm.RefreshEvent += OnRefresh;
                _ShowFormInTheMainPanel(frm);
                clsUserLogging NewLog = new clsUserLogging();
                NewLog.UserID = clsGlobal.CurrentUser.UserID;
                NewLog.EntityID = e.EntityID;
                NewLog.LogOutDate = DateTime.Now;
                NewLog.IsGroup = false;
                NewLog.IsChannel = true;
                NewLog.Save();
                pnlUserSilder.Visible = false;
                flowlayoutChannelsandGroups.Visible = true;
                MainForm_Load(null, null);

            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchForPublicEntities frm = new frmSearchForPublicEntities();
            frm.JoinEventClicked += OnJoinEventClicked;
            frm.ShowDialog();
        }
        private void txtSearchForEnttiy_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchForEnttiy.Text!="")
            {
                _dtItems.DefaultView.RowFilter = "EntityName LIKE '%" + txtSearchForEnttiy.Text.Trim()+ "%'";
                _dtItems = _dtItems.DefaultView.ToTable();
            }
            else
                _dtItems = _dtUserGroupsAndChannels.DefaultView.ToTable(false, "EntityID", "EntityName", "EntityType", "EntityImagePath", "EntityMessagesCount", "EntityMembersCount", "IsGroup", "IsChannel");
            _FillFlowLayoutOfUserGroupsAndChannels();
        }
    }
}
