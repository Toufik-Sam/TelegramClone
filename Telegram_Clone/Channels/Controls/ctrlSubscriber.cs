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

namespace Telegram_Clone.Channels.Controls
{
    public partial class ctrlSubscriber : UserControl
    {
        private int _SubscriberID = -1;
        public ctrlSubscriber()
        {
            InitializeComponent();
        }
        public delegate void DeleteSubscriberEvenetHandler(object sender, int MemberID);
        public event DeleteSubscriberEvenetHandler DeleteSubscriberEvent;
        public void LoadData(int SubscriberID,string FullName,string ImagePath,bool ShowDeleteIconToAdmin)
        {
            if (ShowDeleteIconToAdmin == false)
                btnDeleteSubscriber.Visible = false;
            _SubscriberID = SubscriberID;
            lblSubscriberName.Text = FullName;
            if (ImagePath != null && ImagePath != "")
                pbSubscriberImage.ImageLocation = ImagePath;
            else
                pbSubscriberImage.Image = Resources.man_512;
        }

        private void btnDeleteSubscriber_Click(object sender, EventArgs e)
        {
            DeleteSubscriberEvent?.Invoke(this, _SubscriberID);
        }
    }
}
