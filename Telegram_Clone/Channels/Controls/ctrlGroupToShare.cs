using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram_Clone.Properties;

namespace Telegram_Clone.Channels.Controls
{
    public partial class ctrlGroupToShare : UserControl
    {
        private int _GroupID = -1;
        public ctrlGroupToShare()
        {
            InitializeComponent();
        }
        public delegate void DataBackShareGroup(object sender, int GroupID);
        public event DataBackShareGroup SharePostGroupEvent;
        public void LoadData(int GroupID,string GroupName,string GroupImagePath)
        {
            _GroupID = GroupID;
            lblGroupName.Text = GroupName;
            if (GroupImagePath != null & GroupImagePath != "")
                pbGroupImage.ImageLocation = GroupImagePath;
            else
                pbGroupImage.Image = Resources.icons8_chat_group_35;
            _GroupID = GroupID;
        }
        private void ctrlGroupToShare_Click(object sender, EventArgs e)
        {
            SharePostGroupEvent?.Invoke(this, _GroupID);
        }

        private void ctrlGroupToShare_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.SkyBlue;
            lblGroupName.BackColor = Color.SkyBlue;
            pbGroupImage.BackColor = Color.SkyBlue;
        }

        private void ctrlGroupToShare_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(38,40,66);
            lblGroupName.BackColor = Color.FromArgb(38, 40, 66);
            pbGroupImage.BackColor = Color.FromArgb(38, 40, 66);
        }
    }
}
