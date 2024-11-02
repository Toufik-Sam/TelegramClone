using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telegram_Clone.Groups
{
    public partial class frmDropDowMenu : Form
    {
        public frmDropDowMenu()
        {
            InitializeComponent();
        }
        public delegate void DeleteDataBack(object sender);
        public event DeleteDataBack DetailGroupInfo;
        public event DeleteDataBack DeletEvent;
        public event DeleteDataBack LeaveEvent;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeletEvent?.Invoke(this);
            this.Close();
        }
        private void btnLeave_Click(object sender, EventArgs e)
        {
            LeaveEvent?.Invoke(this);
            this.Close();
        }
        private void btnShowGroupInfo_Click(object sender, EventArgs e)
        {
            DetailGroupInfo?.Invoke(this);
            this.Close();
        }
    }
}
