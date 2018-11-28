using ClearClass;
using Connection_Class;
using System;
using System.Windows.Forms;

namespace Matab
{
    public partial class frmParvandeh : DevComponents.DotNetBar.OfficeForm
    {
        Connection_Query query = new Connection_Query();
        public frmParvandeh()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                if (txtCodeParvandeh.Text == "")
                {
                    errorProvider1.SetError(txtCodeParvandeh, "شماره پرونده وارد نشده است");
                    txtCodeParvandeh.Focus();
                }
                else
                {
                    query.ExecuteQueries(string.Format("insert into tblParvandeh values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')", txtCodeParvandeh.Text, mskTarikh.Text, txtFName.Text, txtLName.Text, mskTarikhTavalod.Text, cmbGender.Text, mskT_Feeli.Text, mskT_Baadi.Text, cmbNameBimeh.Text, txtTarefe.Text, txtBimari_Ghabli.Text, txtBimari_Feeli.Text, txtNoskhe.Text));
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {

                if (txtCodeParvandeh.Text == "")
                {
                    errorProvider1.SetError(txtCodeParvandeh, "شماره پرونده وارد نشده است");
                    txtCodeParvandeh.Focus();
                }
                else
                {
                    query.ExecuteQueries("delete from tblParvandeh where Code_Parvandeh=" + txtCodeParvandeh.Text);
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
                if (txtCodeParvandeh.Text == "")
                {
                    errorProvider1.SetError(txtCodeParvandeh, "شماره پرونده وارد نشده است");
                    txtCodeParvandeh.Focus();
                }
                else
                {
                    query.ExecuteQueries("update tblParvandeh set Tarikh='" + mskTarikh.Text + "',FName='" + txtFName.Text + "',LName='" + txtLName.Text + "',T_Tavalod='" + mskTarikhTavalod.Text + "',Gender='" + cmbGender.Text + "',T_FEeli='" + mskT_Feeli.Text + "',T_Baadi='" + mskT_Baadi.Text + "', NameBimeh='" + cmbNameBimeh.Text + "',TarefeBimeh='" + txtTarefe.Text + "',Bimari_Ghabli='" + txtBimari_Ghabli.Text + "',Bimari_Feeli='" + txtBimari_Feeli.Text + "',Noskhe='" + txtNoskhe.Text + "' where Code_Parvandeh=" + txtCodeParvandeh.Text);
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

        private void frmParvandeh_Load(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar P = new System.Globalization.PersianCalendar();
            mskTarikh.Text = P.GetYear(DateTime.Now).ToString() + P.GetMonth(DateTime.Now).ToString("0#") + P.GetDayOfMonth(DateTime.Now).ToString("0#");
            mskT_Feeli.Text = P.GetYear(DateTime.Now).ToString() + P.GetMonth(DateTime.Now).ToString("0#") + P.GetDayOfMonth(DateTime.Now).ToString("0#");
            mskT_Baadi.Text = P.GetYear(DateTime.Now).ToString() + P.GetMonth(DateTime.Now).ToString("0#") + P.GetDayOfMonth(DateTime.Now.AddDays(1)).ToString("0#");

            cmbNameBimeh.DataSource = query.ShowData("select NameBimeh from tblBimeh");
            cmbNameBimeh.DisplayMember = "NameBimeh";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                var dr = query.DataReader("select * from tblParvandeh where Code_Parvandeh=" + txtCodeParvandeh.Text);
                if (dr.Read())
                {
                    txtCodeParvandeh.Text = dr["Code_Parvandeh"].ToString();
                    mskTarikh.Text = dr["Tarikh"].ToString();
                    txtFName.Text = dr["FName"].ToString();
                    txtLName.Text = dr["LName"].ToString();
                    mskTarikhTavalod.Text = dr["T_Tavalod"].ToString();
                    cmbGender.Text = dr["Gender"].ToString();
                    mskT_Feeli.Text = dr["T_Feeli"].ToString();
                    mskT_Baadi.Text = dr["T_Baadi"].ToString();
                    cmbNameBimeh.Text = dr["NameBimeh"].ToString();
                    txtTarefe.Text = dr["TarefeBimeh"].ToString();
                    txtBimari_Ghabli.Text = dr["Bimari_Ghabli"].ToString();
                    txtBimari_Feeli.Text = dr["Bimari_Feeli"].ToString();
                    txtNoskhe.Text = dr["Noskhe"].ToString();
                }
                else
                {
                    txtCodeParvandeh.Text = "";
                    MessageBox.Show("پرونده ای با این شماره وجود ندارد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodeParvandeh.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }

        private void cmbNameBimeh_SelectedIndexChanged(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                var dr = query.DataReader("select TarefeBimeh from tblBimeh where NameBimeh='" + cmbNameBimeh.Text + "'");
                if (dr.Read())
                {
                    txtTarefe.Text = dr["TarefeBimeh"].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام دریافت اطلاعات بیمه خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }
    }
}