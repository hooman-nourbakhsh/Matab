using ClearClass;
using Connection_Class;
using System;
using System.Windows.Forms;
using Stimulsoft.Report;

namespace Matab
{
    public partial class frmBimeh : DevComponents.DotNetBar.OfficeForm
    {
        Connection_Query query = new Connection_Query();
        public frmBimeh()
        {
            InitializeComponent();
        }
        void Display()
        {
            query.OpenConection();
            try
            {
                dgvBime.DataSource = query.ShowData("select * from tblBimeh");
            }
            catch (Exception)
            {
                MessageBox.Show("در هنگام اتصال به بانک اطلاعاتی خطایی رخ داده است ، مجددا تلاش کنید", "Matab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            query.CloseConnection();
        }

        private void frmBimeh_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                if (txtNameBimeh.Text == "" | txtTarefe.Text == "")
                {
                    errorProvider1.SetError(txtNameBimeh, "نام بیمه وارد نشده است");
                    errorProvider1.SetError(txtTarefe, "تعرفه بیمه وارد نشده است");
                }
                else
                {
                    query.ExecuteQueries(string.Format("insert into tblBimeh values ('{0}','{1}','{2}')", txtNameBimeh.Text, txtTarefe.Text, txtTozihat.Text));
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
                if (txtCode.Text == "" )
                {
                    errorProvider1.SetError(txtNameBimeh, "کد بیمه وارد نشده است");
               }
                else
                {
                    int x = Convert.ToInt32(dgvBime.SelectedCells[0].Value);
                    query.ExecuteQueries("delete from tblBimeh where ID=" + x);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            query.OpenConection();
            try
            {
                if (txtCode.Text == "")
                {
                    errorProvider1.SetError(txtNameBimeh, "کد بیمه وارد نشده است");
                }
                else
                {
                    query.ExecuteQueries("update tblBimeh set NameBimeh='" + txtNameBimeh.Text + "',TarefeBimeh='" + txtTarefe.Text + "',Tozihat='" + txtTozihat.Text + "' where ID= " + txtCode.Text);
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

        private void dgvBime_MouseUp(object sender, MouseEventArgs e)
        {
            txtCode.Text = dgvBime[0, dgvBime.CurrentRow.Index].Value.ToString();
            txtNameBimeh.Text = dgvBime[1, dgvBime.CurrentRow.Index].Value.ToString();
            txtTarefe.Text = dgvBime[2, dgvBime.CurrentRow.Index].Value.ToString();
            txtTozihat.Text = dgvBime[3, dgvBime.CurrentRow.Index].Value.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StiReport report = new StiReport();
                report.Load("Reports/rptBimeh.mrt");
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