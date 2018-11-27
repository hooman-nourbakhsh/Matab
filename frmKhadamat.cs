using ClearClass;
using Connection_Class;
using System;
using System.Windows.Forms;
using Stimulsoft.Report;

namespace Matab
{
    public partial class frmKhadamat : DevComponents.DotNetBar.OfficeForm
    {
        Connection_Query query = new Connection_Query();
        public frmKhadamat()
        {
            InitializeComponent();
        }
        void Display()
        {
            query.OpenConection();
            try
            {
                dgvKhadamt.DataSource = query.ShowData("select * from tblKhadamat");
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }

        private void frmKhadamat_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                if (txtName.Text == "" | txtTarefe.Text == "")
                {
                    errorProvider1.SetError(txtName, "نام خدمات یا تعرفه وارد نشده است");
                    txtName.Focus();
                }
                else
                {
                    query.ExecuteQueries(string.Format("insert into tblKhadamat values('{0}','{1}','{2}')", txtName.Text, txtTarefe.Text, txtTozihat.Text));
                    MessageBox.Show("عملیات با موفقیت انجام شد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls.ClearTextBoxes(this);
                    Display();
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
                int x = Convert.ToInt32(dgvKhadamt.SelectedCells[0].Value);
                query.ExecuteQueries("delete from tblKhadamat where ID=" + x);
                MessageBox.Show("عملیات با موفقیت انجام شد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls.ClearTextBoxes(this);
                Display();
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
                    query.ExecuteQueries("update tblKhadamat set NameKhadamat='" + txtName.Text + "',MablaghTarefe='" + txtTarefe.Text + "',Tozihat='" + txtTozihat.Text + "' where ID=" + txtCode.Text);
                    MessageBox.Show("عملیات با موفقیت انجام شد", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls.ClearTextBoxes(this);
                    Display();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }

        private void dgvKhadamt_MouseUp(object sender, MouseEventArgs e)
        {
            txtCode.Text = dgvKhadamt[0, dgvKhadamt.CurrentRow.Index].Value.ToString();
            txtName.Text = dgvKhadamt[1, dgvKhadamt.CurrentRow.Index].Value.ToString();
            txtTarefe.Text = dgvKhadamt[2, dgvKhadamt.CurrentRow.Index].Value.ToString();
            txtTozihat.Text = dgvKhadamt[3, dgvKhadamt.CurrentRow.Index].Value.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StiReport report = new StiReport();
                report.Load("Reports/rptKhadamat.mrt");
                report.Compile();
                report.ShowWithRibbonGUI();
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام گزارش گیری خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}