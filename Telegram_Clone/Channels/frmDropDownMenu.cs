using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telegram_Clone.Channels
{
    public partial class frmDropDownMenu : Form
    {
        public frmDropDownMenu()
        {
            InitializeComponent();
        }
        public delegate void DataBackEventHandler(object sender);
        public event DataBackEventHandler DetailGroupInfo;
        public event DataBackEventHandler leaveEvent;
        public event DataBackEventHandler DeleteEvent;

        private void btnShowChannelInfo_Click(object sender, EventArgs e)
        {
            DetailGroupInfo?.Invoke(this);
            this.Close();
        }
        private void btnLeave_Click(object sender, EventArgs e)
        {
            leaveEvent?.Invoke(this);
            this.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteEvent?.Invoke(this);
            this.Close();
        }
    }
}
