using ClearClass;
using Connection_Class;
using System;
using System.Windows.Forms;

namespace Matab
{
    public partial class frmVizit : DevComponents.DotNetBar.OfficeForm
    {
        Connection_Query query = new Connection_Query();
        public frmVizit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                if (txtCodeVisit.Text == "" | txtLName.Text == "")
                {
                    errorProvider1.SetError(txtCodeVisit, "شماره ویزیت وارد نشده است");
                    txtCodeVisit.Focus();
                    errorProvider1.SetError(txtLName, "نام خانوادگی بیمار وارد نشده است");
                }
                else
                {
                    query.ExecuteQueries(string.Format("insert into tblVisit values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", txtCodeVisit.Text, mskTarikh.Text, txtFName.Text, txtLName.Text, txtNameBime.Text, txtTarefeBime.Text, txtNameKhadamat.Text, txtTarefeKhadamat.Text, txtMablaghKol.Text, txtNoskhe.Text));
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
                if (txtCodeVisit.Text == "")
                {
                    errorProvider1.SetError(txtCodeVisit, "شماره ویزیت وارد نشده است");
                    txtCodeVisit.Focus();
                }
                else
                {
                    query.ExecuteQueries("update tblVisit set Tarikh='" + mskTarikh.Text + "',FNameBimar='" + txtFName.Text + "',LNameBimar='" + txtLName.Text + "',NameBimeh='" + txtNameBime.Text + "',TarefeBimeh='" + txtTarefeBime.Text + "',NameKhadamat='" + txtNameKhadamat.Text + "',TarefeKhadamat='" + txtTarefeKhadamat.Text + "',MablaghKol='" + txtMablaghKol.Text + "',NoskhePezeshk='" + txtNoskhe.Text + "' where ID_Visit= " + txtCodeVisit.Text);
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

        private void btnSearchVisit_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                if (txtCodeVisit.Text != "")
                {
                    var dr = query.DataReader("select * from tblVisit where ID_Visit=" + txtCodeVisit.Text);
                    if (dr.Read())
                    {
                        txtCodeVisit.Text = dr["ID_Visit"].ToString();
                        mskTarikh.Text = dr["Tarikh"].ToString();
                        txtFName.Text = dr["FNameBimar"].ToString();
                        txtLName.Text = dr["LNameBimar"].ToString();
                        txtNameBime.Text = dr["NameBimeh"].ToString();
                        txtTarefeBime.Text = dr["TarefeBimeh"].ToString();
                        txtNameKhadamat.Text = dr["NameKhadamat"].ToString();
                        txtTarefeKhadamat.Text = dr["TarefeKhadamat"].ToString();
                        txtMablaghKol.Text = dr["MablaghKol"].ToString();
                        txtNoskhe.Text = dr["NoskhePezeshk"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("ویزیتی با این کد وجود ندارد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCodeVisit.Focus();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }

        private void btnSearchBime_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                if (txtCodeBime.Text != "")
                {
                    var dr = query.DataReader("select * from tblBimeh where ID=" + txtCodeBime.Text);
                    if (dr.Read())
                    {
                        txtNameBime.Text = dr["NameBimeh"].ToString();
                        txtTarefeBime.Text = dr["TarefeBimeh"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("بیمه ای با این کد وجود ندارد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCodeVisit.Focus();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }

        private void btnSearchKhadamat_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                if (txtCodeKhadamat.Text != "")
                {
                    var dr = query.DataReader("select * from tblKhadamat where ID=" + txtCodeKhadamat.Text);
                    if (dr.Read())
                    {
                        txtNameKhadamat.Text = dr["NameKhadamat"].ToString();
                        txtTarefeKhadamat.Text = dr["MablaghTarefe"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("خدماتی با این کد وجود ندارد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCodeVisit.Focus();
                    }
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
                if (txtCodeVisit.Text != "")
                {
                    var dr = query.DataReader("select * from tblKhadamat where ID=" + txtCodeKhadamat.Text);
                    if (dr.Read())
                    {
                        txtNameKhadamat.Text = dr["NameKhadamat"].ToString();
                        txtTarefeKhadamat.Text = dr["MablaghTarefe"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("خدماتی با این کد وجود ندارد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCodeVisit.Focus();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }

        private void frmVizit_Load(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar P = new System.Globalization.PersianCalendar();
            mskTarikh.Text = P.GetYear(DateTime.Now).ToString() + P.GetMonth(DateTime.Now).ToString("0#") + P.GetDayOfMonth(DateTime.Now).ToString("0#");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTarefeBime.Text == "")
                {
                    errorProvider1.SetError(txtTarefeBime, "تعرفه بیمه وارد نشده است");
                    txtTarefeBime.Focus();
                }
                else if (txtTarefeKhadamat.Text == "")
                {
                    errorProvider1.SetError(txtTarefeKhadamat, "تعرفه خدمات وارد نشده است");
                    txtTarefeKhadamat.Focus();
                }
                else
                {
                    int bimeh, khadamat, sum = 0;
                    bimeh = Convert.ToInt32(txtTarefeBime.Text);
                    khadamat = Convert.ToInt32(txtTarefeKhadamat.Text);
                    sum = bimeh + khadamat;
                    txtMablaghKol.Text = sum.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام محاسبه مبلغ نهایی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}