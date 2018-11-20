using System;
using System.Windows.Forms;
using Connection_Class;
using ClearClass;

namespace Matab
{
    public partial class frmUsers : DevComponents.DotNetBar.OfficeForm
    {
        Connection_Query query = new Connection_Query();
        public frmUsers()
        {
            InitializeComponent();
        }

        void Display()
        {
            query.OpenConection();
            try
            {
                dgvUsers.DataSource = query.ShowData("Select * from tblUsers");
            }
            catch (Exception)
            {
                MessageBox.Show("در اتصال به پایگاه داده خطایی رخ داده است ، لطفا مجددا تلاش کنید", "Blit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                query.ExecuteQueries(string.Format("insert into tblUsers values('{0}','{1}','{2}')", txtUserName.Text, txtPassword.Text, cmbAccess.Text));
                Display();
                MessageBox.Show("عملیات با موفقیت انجام شد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls.ClearTextBoxes(this);
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                int x = Convert.ToInt32(dgvUsers.SelectedCells[0].Value);
                query.ExecuteQueries("delete from tblUsers where ID=" + x);
                Display();
                MessageBox.Show("عملیات با موفقیت انجام شد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}