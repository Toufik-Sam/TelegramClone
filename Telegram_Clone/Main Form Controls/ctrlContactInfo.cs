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
    public partial class ctrlContactInfo : UserControl
    {
        private int _UserContactID = -1;
        public ctrlContactInfo()
        {
            InitializeComponent();
        }
        public delegate void DeleteDataBackEventHandler(object sender, int UserContactID);
        public event DeleteDataBackEventHandler DeleteDataBack;
        public void LoadData(int UserContactID,string FullName,string ImagePath)
        {
            lblContactName.Text = FullName;
            if (ImagePath != null && ImagePath != "")
                pbContactImage.ImageLocation = ImagePath;
            else
                pbContactImage.Image = Resources.man_512;
            _UserContactID = UserContactID;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DeleteDataBack?.Invoke(this, _UserContactID);
        }

        private void ctrlContactInfo_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.SkyBlue;
            pbContactImage.BackColor= Color.SkyBlue;
            lblContactName.BackColor= Color.SkyBlue; ;
            btnRemove.BackColor= Color.SkyBlue;
        }

        private void ctrlContactInfo_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(38, 40, 66);
            pbContactImage.BackColor = Color.FromArgb(38, 40, 66);
            lblContactName.BackColor = Color.FromArgb(38, 40, 66); ;
            btnRemove.BackColor = Color.FromArgb(38, 40, 66);
        }
    }
}
