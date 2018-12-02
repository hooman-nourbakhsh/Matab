using Connection_Class;
using System;
using System.Windows.Forms;
using Stimulsoft.Report;

namespace Matab
{
    public partial class frmListVisit : DevComponents.DotNetBar.OfficeForm
    {
        Connection_Query query = new Connection_Query();
        public frmListVisit()
        {
            InitializeComponent();
        }
        void Display()
        {
            query.OpenConection();
            try
            {
                dgvListVisit.DataSource = query.ShowData("select * from tblVisit");
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }
        void Search()
        {
            query.OpenConection();
            try
            {
                dgvListVisit.DataSource = query.ShowData(string.Format("select * from tblVisit where Tarikh Between '{0}' and '{1}' ", mskAzTarikh.Text, mskTaTarikh.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }

        private void frmListVisit_Load(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar P = new System.Globalization.PersianCalendar();
            mskAzTarikh.Text = P.GetYear(DateTime.Now).ToString() + P.GetMonth(DateTime.Now).ToString("0#") + P.GetDayOfMonth(DateTime.Now).ToString("0#");
            mskTaTarikh.Text = P.GetYear(DateTime.Now).ToString() + P.GetMonth(DateTime.Now).ToString("0#") + P.GetDayOfMonth(DateTime.Now.AddDays(1)).ToString("0#");
        }

        private void mskAzTarikh_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void mskTaTarikh_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                dgvListVisit.DataSource = query.ShowData(string.Format("select * from tblVisit where LNameBimar like '%' + '{0}' + '%' ", txtLName.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {

            try
            {
                Search();
                int sum = 0;
                for (int i = 0; i < dgvListVisit.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(dgvListVisit.Rows[i].Cells[9].Value);
                    lblDaramad.Text = sum.ToString("N0");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام محاسبه مبلغ درآمد خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblDaramad.Text== "000000")
                {
                    MessageBox.Show("ابتدا بروی دکمه محاسبه درآمد کلیک کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    StiReport report = new StiReport();
                    report.Load("Reports/rptDaramad.mrt");
                    report.Compile();
                    report["strAzTarikh"] = mskAzTarikh.Text;
                    report["strTaTarikh"] = mskTaTarikh.Text;
                    report["Daramad"] = lblDaramad.Text;
                    report.ShowWithRibbonGUI();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام گزارش گیری خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                int x = Convert.ToInt32(dgvListVisit.SelectedCells[0].Value);
                query.ExecuteQueries("delete from tblVisit where ID=" + x);
                MessageBox.Show("عملیات با موفقیت انجام شد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Search();
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
            
        }
    }
}