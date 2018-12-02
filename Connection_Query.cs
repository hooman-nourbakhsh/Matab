using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Connection_Class
{
    /// <summary>
    ///This is a class called "Connection_Class" that is for SQL insert(Update Delete Search), and displaying data in DataGridView and 
    ///using commands (Scaler, DataReader).
    ///It also performs database backup and recovery operations.
    /// می باشد و (Scaler , DataReader) نمایش دیتا در دیتا گرید ویو و استفاده از دستورات (Insert, Update Delete Search) SQL است که برای دستورات پایه "Connection_Class" این یک کلاس با نام 
    ///همچنین عملیات بکاپ گیری از دیتابیس و بازیابی آن را هم انجام می دهد
    /// (Signature (HooMaN))
    /// </summary>

    public class Connection_Query
    {
        //string ConnectionString = @"Data Source=.;AttachDbFilename=|DataDirectory|DataBase\Blit.mdf;Integrated Security=True";//method 1
        string ConnectionString = "server=.;database=Matab;trusted_connection=true";//method 2
        SqlConnection con;

        public void OpenConection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }

        public void CloseConnection()
        {
            con.Close();
        }

        /// <summary>
        /// نمونه کد
        /// q.ExecuteQueries("Insert into tblUsers(Uname, Pass) values('" + txtName.Text + "','" + txtTel.Text + "')"); //mehtod 1
        /// q.ExecuteQueries(string.Format("insert into tblusers values('{0}','{1}')", txtName.Text, txtTel.Text)); //method 2
        /// </summary>

        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.Parameters.Clear();
            cmd.ExecuteNonQuery();
        }

        public SqlCommand ExecuteScaler(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.Parameters.Clear();
            cmd.ExecuteScalar();
            return cmd;
        }
        /// <summary>
        /// نمونه کد
        /// SqlDataReader dr = ClassObject.DataReader("Select * From Student");  
        /// dr.Read();  
        /// textBox1.Text = dr["Stdnt_Name"].tostring();
        /// </summary>

        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        /// <summary>
        /// نمونه کد
        /// dataGridView1.datasource = ClassObject.ShowDataInGridView("Select * From Student")
        /// </summary>

        public object ShowData(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }

        /// <summary>
        /// نمونه کد
        /// "اسم دیتابیس"
        /// </summary>

        public void BackUp_DB(string Name_DataBase)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.OverwritePrompt = true;
            sfd.Filter = @"SQL BackUp FIles ALL Files (*.*) |*.*| (*.Bak)|*.Bak";
            sfd.DefaultExt = "Bak";
            sfd.FilterIndex = 1;
            sfd.FileName = DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss");
            sfd.Title = "BackUp SQL Files";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                OpenConection();
                ExecuteQueries(@"BACKUP DATABASE [" + Name_DataBase + "] TO  DISK='" + sfd.FileName + "'");
                CloseConnection();
            }
        }
        /// <summary>
        /// نمونه کد
        /// "اسم دیتابیس"
        /// </summary>
        public void Restore_DB(string Name_DataBase)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = @"SQL BackUp FIles ALL Files (*.*) |*.*| (*.Bak)|*.Bak";
            ofd.FilterIndex = 1;
            ofd.Title = "BackUp SQL Files";
            ofd.FileName = DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss");

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                OpenConection();
                ExecuteQueries(@"Alter DATABASE [" + Name_DataBase + "] SET SINGLE_USER with ROLLBACK IMMEDIATE " + "USE master " + " RESTORE DATABASE [" + Name_DataBase + "] FROM DISK =N'" + ofd.FileName + "' with RECOVERY,REPLACE");
                CloseConnection();
            }
        }
    }
}