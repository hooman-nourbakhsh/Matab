using Connection_Class;
using System;
using System.Windows.Forms;

namespace Matab
{
    public partial class frmLogin : DevComponents.DotNetBar.OfficeForm
    {
        Connection_Query query = new Connection_Query();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string struser;

            query.OpenConection();
            try
            {
                if (cmbAccess.SelectedItem == "مدیر")
                {
                    struser = "admin";
                    clc_variable.strU = "مدیر";
                }
                else
                {
                    clc_variable.strU = "کاربر عادی";
                    struser = "user";
                }
                int i = 0;//check kardane mojod bodan Username
                var q = query.ExecuteScaler("Select Count(*) from tblUsers where Access='" + struser + "' and UserName='" + txtUserName.Text + "' and Password='" + txtPassword.Text + "'  ");
                i = (int)q.ExecuteScalar();//chon dar database taghiri eijad nemishe
                if (i > 0)
                {
                    new frmMain().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("کاربری با این مشخصات وجود ندارد", "Blit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Blit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}