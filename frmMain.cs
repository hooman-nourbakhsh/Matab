using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matab
{
    public partial class frmMain : DevComponents.DotNetBar.OfficeForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

            lblUser.Text = clc_variable.strU;
            if (lblUser.Text == "کاربر عادی")
            {
                btnUsers.Enabled = false;
                btnSetting.Enabled = false;
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
    }
}