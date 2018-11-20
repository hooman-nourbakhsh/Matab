using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matab
{
    public partial class frmMain : DevComponents.DotNetBar.OfficeForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = clc_variable.strU;
            if (lblUser.Text == "کاربر عادی") 
            {
                btnUsers.Enabled = false;
                btnSetting.Enabled = false;
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            new frmUsers().ShowDialog();
        }
    }
}
