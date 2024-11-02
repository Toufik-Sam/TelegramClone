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
    public partial class frmSearchForPublicEntities : Form
    {
        private static DataTable _dtEntities;
        public frmSearchForPublicEntities()
        {
            InitializeComponent();
        }
        public class JoinEntityBag:EventArgs
        {
            public int EntityID { get; }
            public string EntityName { get; }
            public bool IsGroup { get; }
            public bool IsChannel { get; }
            public JoinEntityBag(int EntityID,string EntityName,bool IsGroup,bool IsChannel)
            {
                this.EntityID = EntityID;
                this.EntityName = EntityName;
                this.IsGroup = IsGroup;
                this.IsChannel = IsChannel;
            }
        }
        public delegate void JoinEntityEventHandler(object sender,JoinEntityBag e);
        public event EventHandler<JoinEntityBag>JoinEventClicked;
        public void RaiseOnJoinEventClicked(int EntityID,string EntityName,bool IsGroup,bool IsChannel)
        {
            RaiseOnJoinEventClicked(new JoinEntityBag(EntityID,EntityName,IsGroup, IsChannel));
        }
        protected virtual void RaiseOnJoinEventClicked(JoinEntityBag e)
        {
            JoinEventClicked?.Invoke(this, e);
        }
        private void OnJoinClicked(object sender,ctrlEntity.clsJoinEventBag e)
        {
            RaiseOnJoinEventClicked(e.EntityID,e.EntityName, e.IsGroup, e.IsChannel);
            this.Close();
        }
        public void _FillEntitiesLayout()
        {
            flyEntities.Controls.Clear();
            foreach(DataRow row in _dtEntities.Rows)
            {
                ctrlEntity Entity = new ctrlEntity();
                Entity.JoinEvent += OnJoinClicked;
                if (row["EntityImagePath"]!=System.DBNull.Value)
                    Entity.LoadData((int)row["EntityID"], (string)row["EntityName"], (string)row["EntityImagePath"],
                        (bool)row["IsGroup"], (bool)row["IsChannel"]);
                else
                    Entity.LoadData((int)row["EntityID"], (string)row["EntityName"],"",(bool)row["IsGroup"], 
                        (bool)row["IsChannel"]);

                flyEntities.Controls.Add(Entity);
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _dtEntities = clsUser.SearchForPublicEntities(clsGlobal.CurrentUser.UserID, txtSearch.Text.Trim());
            _FillEntitiesLayout();
        }
    }
}
