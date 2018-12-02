using Connection_Class;
using System;
using System.Windows.Forms;

namespace Matab
{
    public partial class frmMain : DevComponents.DotNetBar.OfficeForm
    {
        Connection_Query query = new Connection_Query();
        public frmMain()
        {
            InitializeComponent();
            this.dgvListNobat.BackgroundColor = System.Drawing.Color.White;
        }
        void Display()
        {
            query.OpenConection();
            try
            {
                dgvListNobat.DataSource = query.ShowData("select * from tblNobat");
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            new frmLogin().ShowDialog();
            Display();
            lblUser.Text = clc_variable.strU;
            if (lblUser.Text == "منشی")
            {
                btnUsers.Enabled = false;
                btnSetting.Enabled = false;
                btnMonshi.Enabled = false;
                btnHoghogh.Enabled = false;
                btnListPardakht.Enabled = false;
                btnAmalKard.Enabled = false;
                btnDataBase.Enabled = false;
            }

            //***********************************************************************
            System.Globalization.PersianCalendar P = new System.Globalization.PersianCalendar();
            lblDate.Text = P.GetYear(DateTime.Now).ToString() + "/" + P.GetMonth(DateTime.Now).ToString("0#") + "/" + P.GetDayOfMonth(DateTime.Now).ToString("0#");

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    lblDay.Text = "یکشنبه";
                    break;
                case DayOfWeek.Monday:
                    lblDay.Text = "دوشنبه";
                    break;
                case DayOfWeek.Tuesday:
                    lblDay.Text = "سه شنبه";
                    break;
                case DayOfWeek.Wednesday:
                    lblDay.Text = "چهارشنبه";
                    break;
                case DayOfWeek.Thursday:
                    lblDay.Text = "پنج شنبه";
                    break;
                case DayOfWeek.Friday:
                    lblDay.Text = "جمعه";
                    break;
                case DayOfWeek.Saturday:
                    lblDay.Text = "شنبه";
                    break;
                default:
                    break;
            }

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            new frmUsers().ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            new frmSetting().ShowDialog();
        }

        private void btnMonshi_Click(object sender, EventArgs e)
        {
            new frmMonshi().ShowDialog();
        }

        private void btnHoghogh_Click(object sender, EventArgs e)
        {
            new frmListMonshi().ShowDialog();
        }

        private void btnListPardakht_Click(object sender, EventArgs e)
        {
            new frmListPardakht().ShowDialog();
        }

        private void btnNobat_Click(object sender, EventArgs e)
        {
            new frmNobat().ShowDialog();
        }

        private void btnListNobat_Click(object sender, EventArgs e)
        {
            new frmListNobat().ShowDialog();
        }

        private void btnKhadamat_Click(object sender, EventArgs e)
        {
            new frmKhadamat().ShowDialog();
        }

        private void btnBimeh_Click(object sender, EventArgs e)
        {
            new frmBimeh().ShowDialog();
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            new frmVizit().ShowDialog();
        }

        private void btnListVisit_Click(object sender, EventArgs e)
        {
            new frmListVisit().ShowDialog();
        }

        private void btnParvandeh_Click(object sender, EventArgs e)
        {
            new frmParvandeh().ShowDialog();
        }

        private void btnListParvandeh_Click(object sender, EventArgs e)
        {
            new frmListParvandeh().ShowDialog();
        }

        private void btnAmalKard_Click(object sender, EventArgs e)
        {
            new frmAmalKard().ShowDialog();
        }

        private void btnGavahi_Click(object sender, EventArgs e)
        {
            new frmGavahi().ShowDialog();
        }

        private void btnHazineh_Click(object sender, EventArgs e)
        {
            new frmHazineh().ShowDialog();
        }

        private void btnListHazineh_Click(object sender, EventArgs e)
        {
            new frmListHazineh().ShowDialog();
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            dgvListNobat.DataSource = query.ShowData(string.Format("select * from tblNobat where LNameBimar like '%' + '{0}' + '%' ", txtLName.Text));
        }

        private void txtNobat_TextChanged(object sender, EventArgs e)
        {
            dgvListNobat.DataSource = query.ShowData(string.Format("select * from tblNobat where Nobat like '%' + '{0}' + '%' ", txtNobat.Text));
        }

        private void btnDataBase_Click(object sender, EventArgs e)
        {
            new frmDataBase().ShowDialog();
        }
    }
}