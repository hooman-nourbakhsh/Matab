using ClearClass;
using Connection_Class;
using System;
using System.Windows.Forms;

namespace Matab
{
    public partial class frmMonshi : DevComponents.DotNetBar.OfficeForm
    {
        Connection_Query query = new Connection_Query();
        public frmMonshi()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                if (txtHoghogh.Text == "")
                {
                    errorProvider1.SetError(txtHoghogh, "مبلغ حقوق وارد نشده است");
                }
                else
                {
                    query.ExecuteQueries(string.Format("insert into tblMonshi values ('{0}','{1}','{2}','{3}','{4}','{5}') ", txtFName.Text, txtLName.Text, txtTel.Text, txtHoghogh.Text, mskTarikh.Text, txtTozihat.Text));
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
                if (txtID.Text == "")
                {
                    errorProvider1.SetError(txtID, "کد وارد نشده است");
                }
                else
                {
                    query.ExecuteQueries("delete from tblMonshi where ID=" + txtID.Text);
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
                query.ExecuteQueries("update tblMonshi set FName='" + txtFName.Text + "',LName='" + txtLName.Text + "',Tel='" + txtTel.Text + "',Hoghogh='" + txtHoghogh.Text + "',Tarikh='" + mskTarikh.Text + "',Tozihat='" + txtTozihat.Text + "' where ID=" + txtID.Text);
                MessageBox.Show("عملیات با موفقیت انجام شد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls.ClearTextBoxes(this);
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
                if (txtID.Text != "")
                {
                    var dr = query.DataReader("select * from tblMonshi where ID=" + txtID.Text);
                    if (dr.Read())
                    {
                        txtID.Text = dr["ID"].ToString();
                        txtFName.Text = dr["FName"].ToString();
                        txtLName.Text = dr["LName"].ToString();
                        txtTel.Text = dr["Tel"].ToString();
                        txtHoghogh.Text = dr["Hoghogh"].ToString();
                        mskTarikh.Text = dr["Tarikh"].ToString();
                        txtTozihat.Text = dr["Tozihat"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("اطلاعاتی برای این کد پیدا نشد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtID.Focus();
                        ClearControls.ClearTextBoxes(this);
                    }
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