using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH
{
    public partial class FormLogin : Form
    {
        private DataConfig dataConfig;
        //SqlConnection connetion;
        //string conn = "Data Source=LAPTOP-5RGHKJ2R\\SQLEXPRESS;Initial Catalog=TU_QLNH;Integrated Security=True";
        public FormLogin()
        {
            InitializeComponent();
            dataConfig = new DataConfig();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "select * from Account where UserName=@tdn and PassWord=@mk";

            dataConfig.GetConnection().Open();
            SqlCommand check = new SqlCommand(query, dataConfig.GetConnection());
            check.Parameters.AddWithValue("@tdn", txbUN.Text);
            check.Parameters.AddWithValue("@mk", txbPW.Text);
            SqlDataReader reader = check.ExecuteReader();

            if (reader.Read())
            {
                int userType = Convert.ToInt32(reader["Type"]); // Lấy giá trị của trường Type
                FormMain f = new FormMain(userType); // Truyền giá trị Type vào FormMain
                f.tk = txbUN.Text;
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
            dataConfig.GetConnection().Close();
        }




        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel= true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked) 
            {
                txbPW.UseSystemPasswordChar = false;
            }
            else
            {
                txbPW.UseSystemPasswordChar = true;
            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
