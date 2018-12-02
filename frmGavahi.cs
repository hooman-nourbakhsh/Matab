using Connection_Class;
using System;
using System.Windows.Forms;
using Stimulsoft.Report;

namespace Matab
{
    public partial class frmGavahi : DevComponents.DotNetBar.OfficeForm
    {
        Connection_Query query = new Connection_Query();
        string address;
        public frmGavahi()
        {
            InitializeComponent();
        }
        void Display()
        {
            query.OpenConection();
            try
            {
                var dr = query.DataReader("select * from tblSetting");
                if (dr.Read())
                {
                    lblName.Text = dr["NameMatab"].ToString();
                    lblTel.Text = dr["Tel"].ToString();
                    address = dr["Address"].ToString();
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
        private void frmGavahi_Load(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar P = new System.Globalization.PersianCalendar();
            mskAzTarikh.Text = P.GetYear(DateTime.Now).ToString() + P.GetMonth(DateTime.Now).ToString("0#") + P.GetDayOfMonth(DateTime.Now).ToString("0#");
            Display();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StiReport report = new StiReport();
                report.Load("Reports/rptGavahi.mrt");
                report.Compile();
                report["strAzTarikh"] = mskAzTarikh.Text;
                report["NameBimar"] = txtName.Text;
                report["Bimari"] = txtBimari.Text;
                report["Tedad"] = txtTedad.Text;
                report["Makan"] = txtMakan.Text;
                report["NameMatab"] = lblName.Text;
                report["Tel"] = lblTel.Text;
                report["Address"] = address;
                report.ShowWithRibbonGUI();
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام گزارش گیری خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}