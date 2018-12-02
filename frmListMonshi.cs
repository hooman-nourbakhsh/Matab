using Connection_Class;
using System;
using System.Windows.Forms;

namespace Matab
{
    public partial class frmListMonshi : DevComponents.DotNetBar.OfficeForm
    {
        Connection_Query query = new Connection_Query();
        public frmListMonshi()
        {
            InitializeComponent();
        }
        void Display()
        {
            query.OpenConection();
            try
            {
                dgvListMonshi.DataSource = query.ShowData("select * from tblMonshi");
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }

        private void frmListMonshi_Load(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar P = new System.Globalization.PersianCalendar();
            mskTarikh.Text = P.GetYear(DateTime.Now).ToString() + P.GetMonth(DateTime.Now).ToString("0#") + P.GetDayOfMonth(DateTime.Now).ToString("0#");
            Display();
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            dgvListMonshi.DataSource = query.ShowData(string.Format("select * from tblMonshi where LName like '%' +'{0}'+ '%'", txtLName.Text));
        }

        private void mskTarikh_TextChanged(object sender, EventArgs e)
        {
            dgvListMonshi.DataSource = query.ShowData(string.Format("select * from tblMonshi where Tarikh like '%' +'{0}'+ '%'", mskTarikh.Text));
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                query.ExecuteQueries(string.Format("insert into tblPardakht values ('{0}','{1}','{2}','{3}','{4}')", dgvListMonshi.CurrentRow.Cells[0].Value, dgvListMonshi.CurrentRow.Cells[2].Value, dgvListMonshi.CurrentRow.Cells[4].Value, dgvListMonshi.CurrentRow.Cells[5].Value, dgvListMonshi.CurrentRow.Cells[6].Value));
                MessageBox.Show("پرداخت حقوق منشی با موفقیت انجام شد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }
    }
}