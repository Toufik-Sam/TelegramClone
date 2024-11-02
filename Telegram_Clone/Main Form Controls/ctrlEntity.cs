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

namespace Telegram_Clone.Main_Form_Controls
{
    public partial class ctrlEntity : UserControl
    {
        private int _EntityID = -1;
        private bool _IsGroup = false, _IsChannel = false;
        private string _EntityName = "";
        public ctrlEntity()
        {
            InitializeComponent();
        }
        public class clsJoinEventBag:EventArgs
        {
            public int EntityID { get; }
            public string EntityName { get; }
            public bool IsGroup { get; }
            public bool IsChannel { get; }
            public clsJoinEventBag(int EntityID,string EntityName,bool IsGroup,bool IsChannel)
            {
                this.EntityID = EntityID;
                this.EntityName = EntityName;
                this.IsGroup = IsGroup;
                this.IsChannel = IsChannel;
            }
        }
        public delegate void JoinEventHandler(object sender,clsJoinEventBag e);
        public event EventHandler<clsJoinEventBag>JoinEvent;
        public void RaiseOnJoinEvent(int EntityID,string EntityName,bool IsGroup,bool IsChannel)
        {
            RaiseOnJoinEvent(new clsJoinEventBag(EntityID,EntityName,IsGroup, IsChannel));
        }
        protected virtual void RaiseOnJoinEvent(clsJoinEventBag e)
        {
            JoinEvent?.Invoke(this, e);
        }
        private void btnJoinGroup_Click(object sender, EventArgs e)
        {
            RaiseOnJoinEvent(_EntityID,_EntityName,_IsGroup, _IsChannel);
        }
        private void ctrlEntity_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.SkyBlue;
            lblEntityName.BackColor = Color.SkyBlue;
            pbEntityImage.BackColor = Color.SkyBlue;
            btnJoinGroup.BackColor = Color.SkyBlue;
        }
        private void ctrlEntity_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(38,40,66);
            lblEntityName.BackColor = Color.FromArgb(38, 40, 66);
            pbEntityImage.BackColor = Color.FromArgb(38, 40, 66);
            btnJoinGroup.BackColor = Color.FromArgb(38, 40, 66);
        }
        public void LoadData(int EntityID,string EntityName,string EntityImagePath,bool IsGroup,bool IsChannel)
        {
            _EntityID = EntityID;
            _EntityName = EntityName;
            lblEntityName.Text = EntityName;
            if (EntityImagePath != null && EntityImagePath != "")
                pbEntityImage.ImageLocation = EntityImagePath;
            else
                pbEntityImage.Image = Resources.icons8_chat_group_35;
            _IsChannel = IsChannel;
            _IsGroup = IsGroup;
        }
    }
}
