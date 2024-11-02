using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using Telegram_Clone.Properties;

namespace Telegram_Clone.Main_Form_Controls
{
    public partial class ctrlGroupChannel : UserControl
    {

        public class ReturnEntityInformationBag : EventArgs
        {
            public int EntityID { get; }
            public string EntityName { get; }
            public bool EntityType { get; }
            public bool isGroup { get; }
            public bool isChannel { get; }
            public int EntityMembers { get; }
            public ReturnEntityInformationBag(int EntityID,string EntityName,bool EntityType, bool isGroup, bool isChannel,int EntityMembers)
            {
                this.EntityID = EntityID;
                this.EntityMembers = EntityMembers;
                this.EntityName = EntityName;
                this.EntityType = EntityType;
                this.isGroup = isGroup;
                this.isChannel = isChannel;
            }
        }
        public delegate void OnReturnEntityInformationEventHandler(object sender, ReturnEntityInformationBag e);
        public event EventHandler<ReturnEntityInformationBag> OnReturnEntityInformation;
        private int _EntityID = -1;
        private int _EntityMembers = -1;
        private string _EntityName = "";
        private bool _EntityType = false;
        private bool _isGroup = false;
        private bool _isChannel = false;
        public ctrlGroupChannel()
        {
            InitializeComponent();
        }
        
        public void LoadData(DataRow Row)
        {
            _EntityID = (int)Row["EntityID"];
            _EntityName = (string)Row["EntityName"];
            _EntityType = (bool)Row["EntityType"];
            _isGroup = (bool)Row["IsGroup"];
            _isChannel = (bool)Row["IsChannel"];
            _EntityMembers = (int)Row["EntityMembersCount"];
            int Count = (int)Row["EntityMessagesCount"];
            lblEntityName.Text = (string)Row["EntityName"];
            if (Count > 0)
                lblMessagesCount.Text = Count.ToString();
            else
                lblMessagesCount.Visible = false;
            object var = Row["EntityImagePath"];
            if (var != DBNull.Value)
                pbEntityImage.ImageLocation = (string)Row["EntityImagePath"];
            else
                pbEntityImage.Image = Resources.icons8_chat_group_35;
        }
        private void ctrlGroupChannel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(38, 40, 66);
        }
        private void ctrlGroupChannel_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(52, 62, 88);
        }
        private void lblEntityName_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(52, 62, 88);

        }
        private void lblEntityName_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(38, 40, 66);

        }
        private void lblMessagesCount_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(52, 62, 88);

        }
        private void lblMessagesCount_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(38, 40, 66);
        }
        private void pbEntityImage_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(52, 62, 88);
        }
        private void pbEntityImage_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(38, 40, 66);
        }
        private void ctrlGroupChannel_Click(object sender, EventArgs e)
        {
            lblMessagesCount.Visible = false;
            OnReturnEntityInformation?.Invoke(this, new ReturnEntityInformationBag(_EntityID,_EntityName,_EntityType, _isGroup, _isChannel,_EntityMembers));
        }
    }
}
