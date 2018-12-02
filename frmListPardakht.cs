using Connection_Class;
using System;
using System.Windows.Forms;
using Stimulsoft.Report;

namespace Matab
{
    public partial class frmListPardakht : DevComponents.DotNetBar.OfficeForm
    {
        Connection_Query query = new Connection_Query();
        public frmListPardakht()
        {
            InitializeComponent();
        }
        void Display()
        {
            query.OpenConection();
            try
            {
                dgvListPardakht.DataSource = query.ShowData("select * from tblPardakht");
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }
        private void frmListPardakht_Load(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar P = new System.Globalization.PersianCalendar();
            mskTarikh.Text = P.GetYear(DateTime.Now).ToString() + P.GetMonth(DateTime.Now).ToString("0#") + P.GetDayOfMonth(DateTime.Now).ToString("0#");
            mskAzTarikh.Text = P.GetYear(DateTime.Now).ToString() + P.GetMonth(DateTime.Now).ToString("0#") + P.GetDayOfMonth(DateTime.Now).ToString("0#");
            mskTaTarikh.Text = P.GetYear(DateTime.Now).ToString() + P.GetMonth(DateTime.Now).ToString("0#") + P.GetDayOfMonth(DateTime.Now.AddDays(1)).ToString("0#");
            Display();
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            dgvListPardakht.DataSource = query.ShowData(string.Format("select * from tblPardakht where LName like '%' +'{0}'+ '%'", txtLName.Text));
        }

        private void mskTarikh_TextChanged(object sender, EventArgs e)
        {
            dgvListPardakht.DataSource = query.ShowData(string.Format("select * from tblPardakht where Tarikh like '%' +'{0}'+ '%'", mskTarikh.Text));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            report.Load("Reports/rptPardakht.mrt");
            report.Compile();
            report["strAzTarikh"] = mskAzTarikh.Text;
            report["strTaTarikh"] = mskTaTarikh.Text;
            report.ShowWithRibbonGUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                int x = Convert.ToInt32(dgvListPardakht.SelectedCells[0].Value);
                query.ExecuteQueries("delete from tblPardakht where ID=" + x);
                MessageBox.Show("عملیات با موفقیت انجام شد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Display();
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }
    }
}