using Connection_Class;
using System;
using System.Windows.Forms;

namespace Matab
{
    public partial class frmDataBase : DevComponents.DotNetBar.OfficeForm
    {
        Connection_Query query = new Connection_Query();
        public frmDataBase()
        {
            InitializeComponent();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            try
            {
                query.BackUp_DB("Matab");
                MessageBox.Show("عملیات پشتیبان گیری با موفقیت انجام شد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("خطایی رخ داده است، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                query.CloseConnection();
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                query.Restore_DB("Matab");
                MessageBox.Show("عملیات بازیابی با موفقیت انجام شد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("خطایی رخ داده است، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                query.CloseConnection();
            }
        }
    }
}