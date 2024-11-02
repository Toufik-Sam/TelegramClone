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
    public partial class ctrlMember : UserControl
    {
        private int _MemberID = -1;
        public ctrlMember()
        {
            InitializeComponent();
        }
        public delegate void DeleteMemberEvenetHandler(object sender, int MemberID);
        public event DeleteMemberEvenetHandler DeleteMemberEvent;
        public void LoadData(int MemberID,string FullName,string ImagePath,bool ShowDeleteIconToAdmin)
        {
            if (ShowDeleteIconToAdmin == false)
                btnDeleteMember.Visible = false;
            _MemberID = MemberID;
            lblMemberName.Text = FullName;
            if (ImagePath != null && ImagePath != "")
                pbMemberImage.ImageLocation = ImagePath;
            else
                pbMemberImage.Image = Resources.man_512;
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            DeleteMemberEvent?.Invoke(this, _MemberID);
        }
    }
}
