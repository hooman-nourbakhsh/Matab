using Connection_Class;
using System;
using System.Windows.Forms;
using Stimulsoft.Report;

namespace Matab
{
    public partial class frmAmalKard : DevComponents.DotNetBar.OfficeForm
    {
        Connection_Query query = new Connection_Query();
        public frmAmalKard()
        {
            InitializeComponent();
        }
        void Display()
        {
            lblDaramadBimeh.Text = "000000000000";
            query.OpenConection();
            try
            {
                var q = query.ExecuteScaler(string.Format("select count(*) from tblVisit where Tarikh between '{0}' and '{1}'", mskAzTarikh.Text, mskTaTarikh.Text));
                lblTedadVizit.Text = Convert.ToString((int)q.ExecuteScalar());
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام محاسبه تعداد ویزیت ها خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
            //*********************************************************************************************************
            query.OpenConection();
            try
            {
                var q = query.ExecuteScaler(string.Format("select sum(TarefeBimeh) from tblVisit where Tarikh between '{0}' and '{1}'", mskAzTarikh.Text, mskTaTarikh.Text));
                lblDaramadBimeh.Text = q.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام محاسبه مجموع بیمه ها خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
            //*********************************************************************************************************
            query.OpenConection();
            try
            {
                var q = query.ExecuteScaler(string.Format("select sum(TarefeKhadamat) from tblVisit where Tarikh between '{0}' and '{1}'", mskAzTarikh.Text, mskTaTarikh.Text));
                lblDaramadKhadamat.Text = q.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام محاسبه مجموع خدمات خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
            //*********************************************************************************************************
            query.OpenConection();
            try
            {
                var q = query.ExecuteScaler(string.Format("select sum(MablaghKol) from tblVisit where Tarikh between '{0}' and '{1}'", mskAzTarikh.Text, mskTaTarikh.Text));
                lblKoleDaramad.Text = q.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام محاسبه مبلغ کل خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }
        private void frmAmalKard_Load(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar P = new System.Globalization.PersianCalendar();
            mskAzTarikh.Text = P.GetYear(DateTime.Now).ToString() + P.GetMonth(DateTime.Now).ToString("0#") + P.GetDayOfMonth(DateTime.Now).ToString("0#");
            mskTaTarikh.Text = P.GetYear(DateTime.Now).ToString() + P.GetMonth(DateTime.Now).ToString("0#") + P.GetDayOfMonth(DateTime.Now.AddDays(1)).ToString("0#");
            Display();
            //*********************************************************************************************************
            query.OpenConection();
            try
            {
                var dr = query.DataReader("select NameMatab,Tel from tblSetting");
                if (dr.Read())
                {
                    lblName.Text = dr["NameMatab"].ToString();
                    lblTel.Text = dr["Tel"].ToString();
                }
                else
                {
                    MessageBox.Show("در بخش تنظیمات نرم افزار اطلاعاتی ثبت نشده است", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();

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
                report.Load("Reports/rptAmalKard.mrt");
                report.Compile();
                report["strAzTarikh"] = mskAzTarikh.Text;
                report["strTaTarikh"] = mskTaTarikh.Text;
                report["Visit"] = lblTedadVizit.Text;
                report["Bimeh"] = lblDaramadBimeh.Text;
                report["Khadamat"] = lblDaramadKhadamat.Text;
                report["KolDaramad"] = lblKoleDaramad.Text;
                report["NameMatab"] = lblName.Text;
                report["Tel"] = lblTel.Text;
                report.ShowWithRibbonGUI();
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام گزارش گیری خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}