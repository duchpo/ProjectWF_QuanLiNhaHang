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
    public partial class FormChangePass : Form
    {
        private DataConfig dataConfig;
        //SqlConnection connect;
        //string conn = "Data Source=LAPTOP-5RGHKJ2R\\SQLEXPRESS;Initial Catalog=TU_QLNH;Integrated Security=True";
        public FormChangePass()
        {
            InitializeComponent();
            dataConfig = new DataConfig();
            //connect = new SqlConnection(conn);
            //connect.Open();
        }

        private void btnUD_Click(object sender, EventArgs e)
        {
            //using (SqlConnection connection = new SqlConnection(conn))
            //{
                dataConfig.GetConnection().Open();
                string checkpass = "SELECT COUNT(*) FROM Account WHERE UserName = @UserName AND PassWord = @Password";
                SqlCommand checkne = new SqlCommand(checkpass, dataConfig.GetConnection());
                checkne.Parameters.AddWithValue("@UserName", txbUN.Text);
                checkne.Parameters.AddWithValue("@Password", txbPW.Text);

                int kiemtra = (int)checkne.ExecuteScalar();

                if(kiemtra > 0)
                {
                    if (txbNPW.Text == txbRNPW.Text)
                    {
                        string add = "UPDATE Account SET Displayname = @Displayname, PassWord = @PassWord   WHERE UserName like N'%"+txbUN.Text+"%'  ";
                        SqlCommand cmd = new SqlCommand(add, dataConfig.GetConnection());

                        cmd.Parameters.AddWithValue("@PassWord", txbNPW.Text);
                        cmd.Parameters.AddWithValue("@Displayname", txbhienthi.Text);
                        int rowAffected = cmd.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thành công!");
                            txbPW.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại!");
                        }
                    }
                    else
                        MessageBox.Show("Nhập lại mật khẩu không đúng");

                }
                else
                {
                    MessageBox.Show("Thông tin tên đăng nhập hoặc mật khẩu không chính xác!");
                }


                dataConfig.GetConnection().Close();
            //}
        }








    }
}
