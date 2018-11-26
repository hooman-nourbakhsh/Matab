using Connection_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stimulsoft.Report;

namespace Matab
{
    public partial class frmListNobat : DevComponents.DotNetBar.OfficeForm
    {
        Connection_Query query = new Connection_Query();
        public frmListNobat()
        {
            InitializeComponent();
        }
        void Display()
        {
            query.OpenConection();
            try
            {
                dgvListNobat.DataSource = query.ShowData(string.Format("select * from tblNobat where Tarikh like '%' + '{0}' + '%' ", mskTarikh.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }

        private void frmListNobat_Load(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar P = new System.Globalization.PersianCalendar();
            mskTarikh.Text = P.GetYear(DateTime.Now).ToString() + P.GetMonth(DateTime.Now).ToString("0#") + P.GetDayOfMonth(DateTime.Now).ToString("0#");
            mskAzTarikh.Text = P.GetYear(DateTime.Now).ToString() + P.GetMonth(DateTime.Now).ToString("0#") + P.GetDayOfMonth(DateTime.Now).ToString("0#");
            mskTaTarikh.Text = P.GetYear(DateTime.Now).ToString() + P.GetMonth(DateTime.Now).ToString("0#") + P.GetDayOfMonth(DateTime.Now.AddDays(1)).ToString("0#");

            Display();
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            dgvListNobat.DataSource = query.ShowData(string.Format("select * from tblNobat where LNameBimar like '%' + '{0}' + '%' ", txtLName.Text));
        }

        private void txtNobat_TextChanged(object sender, EventArgs e)
        {
            dgvListNobat.DataSource = query.ShowData(string.Format("select * from tblNobat where Nobat like '%' + '{0}' + '%' ", txtNobat.Text));

        }

        private void mskTarikh_TextChanged(object sender, EventArgs e)
        {
            dgvListNobat.DataSource = query.ShowData(string.Format("select * from tblNobat where Tarikh like '%' + '{0}' + '%' ", mskTarikh.Text));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                int x = Convert.ToInt32(dgvListNobat.SelectedCells[0].Value);
                query.ExecuteQueries("delete from tblNobat where ID=" + x);
                MessageBox.Show("عملیات با موفقیت انجام شد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Display();
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StiReport report = new StiReport();
                report.Load("Reports/rptNobat.mrt");
                report.Compile();
                report["strAzTarikh"] = mskAzTarikh.Text;
                report["strTaTarikh"] = mskTaTarikh.Text;
                report.ShowWithRibbonGUI();
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام گزارش گیری خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}