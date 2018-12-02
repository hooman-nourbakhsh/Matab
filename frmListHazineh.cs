using Connection_Class;
using System;
using Stimulsoft.Report;

namespace Matab
{
    public partial class frmListHazineh : DevComponents.DotNetBar.OfficeForm
    {
        Connection_Query query = new Connection_Query();
        public frmListHazineh()
        {
            InitializeComponent();
        }
        void Display()
        {
            query.OpenConection();
            try
            {
                dgvListHazineh.DataSource = query.ShowData(string.Format("select * from tblHazineh where Tarikh between '{0}' and '{1}' ", mskAzTarikh.Text, mskTaTarikh.Text));
            }
            catch (Exception)
            {

                throw;
            }
            query.CloseConnection();
        }
        private void frmListHazineh_Load(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar P = new System.Globalization.PersianCalendar();
            mskAzTarikh.Text = P.GetYear(DateTime.Now).ToString() + P.GetMonth(DateTime.Now).ToString("0#") + P.GetDayOfMonth(DateTime.Now).ToString("0#");
            mskTaTarikh.Text = P.GetYear(DateTime.Now).ToString() + P.GetMonth(DateTime.Now).ToString("0#") + P.GetDayOfMonth(DateTime.Now.AddDays(1)).ToString("0#");
            Display();
        }

        private void mskAzTarikh_TextChanged(object sender, EventArgs e)
        {
            Display();
        }

        private void mskTaTarikh_TextChanged(object sender, EventArgs e)
        {
            Display();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StiReport report = new StiReport();
                report.Load("Reports/rptHazineh.mrt");
                report.Compile();
                report["strAzTarikh"] = mskAzTarikh.Text;
                report["strTaTarikh"] = mskTaTarikh.Text;
                report.ShowWithRibbonGUI();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}