using ClearClass;
using Connection_Class;
using System;
using System.Windows.Forms;

namespace Matab
{
    public partial class frmHazineh : DevComponents.DotNetBar.OfficeForm
    {
        Connection_Query query = new Connection_Query();
        public frmHazineh()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                if (txtHazine.Text == "")
                {
                    errorProvider1.SetError(txtHazine, "مبلغ وارد نشده است");
                    txtHazine.Focus();
                }
                else
                {
                    query.ExecuteQueries(string.Format("insert into tblHazineh values ('{0}','{1}','{2}','{3}','{4}') ", txtSharhHazine.Text, txtHazine.Text, mskTarikh.Text, txtNameMonshi.Text, txtTozihat.Text));
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

        private void frmHazineh_Load(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar P = new System.Globalization.PersianCalendar();
            mskTarikh.Text = P.GetYear(DateTime.Now).ToString() + P.GetMonth(DateTime.Now).ToString("0#") + P.GetDayOfMonth(DateTime.Now).ToString("0#");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                if (txtCode.Text == "")
                {
                    errorProvider1.SetError(txtCode, "کد وارد نشده است");
                    txtCode.Focus();
                }
                else
                {
                    query.ExecuteQueries("delete from tblHazineh where ID=" + txtCode.Text);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                if (txtCode.Text == "")
                {
                    errorProvider1.SetError(txtCode, "کد وارد نشده است");
                    txtCode.Focus();
                }
                else
                {
                    query.ExecuteQueries("update tblHazineh set SharhHazineh='" + txtSharhHazine.Text + "',Mablagh='" + txtHazine.Text + "',Tarikh='" + mskTarikh.Text + "',NameMonshi='" + txtNameMonshi.Text + "',Tozihat='" + txtTozihat.Text + "' where ID=" + txtCode.Text);
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
                if (txtCode.Text != "")
                {

                    var dr = query.DataReader("select * from tblHazineh where ID=" + txtCode.Text);
                    if (dr.Read())
                    {
                        txtCode.Text = dr["ID"].ToString();
                        txtSharhHazine.Text = dr["SharhHazineh"].ToString();
                        txtHazine.Text = dr["Mablagh"].ToString();
                        mskTarikh.Text = dr["Tarikh"].ToString();
                        txtNameMonshi.Text = dr["NameMonshi"].ToString();
                        txtTozihat.Text = dr["Tozihat"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("هزینه ای با این کد ثبت نشده است", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    errorProvider1.SetError(txtCode, "لطفا کد هزینه را وارد کنید");
                    txtCode.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }
    }
}