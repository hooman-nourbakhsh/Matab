using ClearClass;
using Connection_Class;
using System;
using System.Windows.Forms;

namespace Matab
{
    public partial class frmNobat : DevComponents.DotNetBar.OfficeForm
    {
        Connection_Query query = new Connection_Query();
        public frmNobat()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                if (txtNobat.Text == "")
                {
                    errorProvider1.SetError(txtNobat, "شماره نوبت وارد نشده است");
                    txtNobat.Focus();
                }
                else if (txtLName.Text == "")
                {
                    errorProvider1.SetError(txtLName, "نام خانوادگی وارد نشده است");
                    txtLName.Focus();
                }
                else if (mskTarikh.Text == "")
                {
                    errorProvider1.SetError(mskTarikh, "تریخ وارد وارد نشده است");
                    mskTarikh.Focus();
                }
                else
                {
                    query.ExecuteQueries(string.Format("insert into tblNobat values('{0}','{1}','{2}','{3}','{4}','{5}')", txtNobat.Text, mskTarikh.Text, txtFName.Text, txtLName.Text, txtTel.Text, txtTozihat.Text));
                    var q = query.ExecuteScaler("SELECT MAX(Nobat) FROM tblNobat");
                    string max = ((int)q.ExecuteScalar()).ToString();
                    MessageBox.Show("شماره نوبت " + max + " برای این بیمار ثبت شد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls.ClearTextBoxes(this);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                if (txtNobat.Text == "")
                {
                    errorProvider1.SetError(txtNobat, "شماره نوبت وارد نشده است");
                }
                else
                {
                    query.ExecuteQueries("update tblNobat set Tarikh='" + mskTarikh.Text + "',FNameBimar='" + txtFName.Text + "',LNameBimar='" + txtLName.Text + "',Tel='" + txtTel.Text + "',Tozihat='" + txtTozihat.Text + "' where Nobat=" + txtNobat.Text);
                    MessageBox.Show("عملیات با موفقیت انجام شد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls.ClearTextBoxes(this);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                if (txtNobat.Text != "")
                {
                    var dr = query.DataReader("select * from tblNobat where Nobat=" + txtNobat.Text);
                    if (dr.Read())
                    {
                        txtNobat.Text = dr["Nobat"].ToString();
                        mskTarikh.Text = dr["Tarikh"].ToString();
                        txtFName.Text = dr["FNameBimar"].ToString();
                        txtLName.Text = dr["LNameBimar"].ToString();
                        txtTel.Text = dr["Tel"].ToString();
                        txtTozihat.Text = dr["Tozihat"].ToString();
                    }
                    else
                    {
                        txtNobat.Text = "";
                        txtNobat.Focus();
                        MessageBox.Show("نوبت با این شماره وجود ندارد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }

        private void frmNobat_Load(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar P = new System.Globalization.PersianCalendar();
            mskTarikh.Text = P.GetYear(DateTime.Now).ToString() + P.GetMonth(DateTime.Now).ToString("0#") + P.GetDayOfMonth(DateTime.Now).ToString("0#");
        }
    }
}