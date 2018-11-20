using ClearClass;
using Connection_Class;
using System;
using System.Windows.Forms;

namespace Matab
{
    public partial class frmSetting : DevComponents.DotNetBar.OfficeForm
    {
        Connection_Query query = new Connection_Query();
        public frmSetting()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                query.ExecuteQueries(string.Format("insert into tblSetting values ('{0}','{1}','{2}','{3}','{4}') ", txtNameMatab.Text, txtNameP.Text, txtTel.Text, txtMobile.Text, txtAddress.Text));
                MessageBox.Show("عملیات با موفقیت انجام شد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls.ClearTextBoxes(this);
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
                query.ExecuteQueries("delete from tblSetting where ID=" + txtID.Text);
                MessageBox.Show("عملیات با موفقیت انجام شد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls.ClearTextBoxes(this);
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
                query.ExecuteQueries("update tblSetting set NameMatab='" + txtNameMatab.Text + "',NamePezeshk='" + txtNameP.Text + "',Tel='" + txtTel.Text + "',Mobile='" + txtMobile.Text + "',Address='" + txtAddress.Text + "' where ID=" + txtID.Text);
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
                    var dr = query.DataReader("select * from tblSetting where ID=" + txtID.Text);
                    if (dr.Read())
                    {
                        txtID.Text = dr["ID"].ToString();
                        txtNameMatab.Text = dr["NameMatab"].ToString();
                        txtNameP.Text = dr["NamePezeshk"].ToString();
                        txtTel.Text = dr["Tel"].ToString();
                        txtMobile.Text = dr["Mobile"].ToString();
                        txtAddress.Text = dr["Address"].ToString();
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