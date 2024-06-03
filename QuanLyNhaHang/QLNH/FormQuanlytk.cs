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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLNH
{
    public partial class FormQuanlytk : Form
    {
        private DataConfig dataConfig;
        public FormQuanlytk()
        {

            InitializeComponent();
            //connect = new SqlConnection(conn);
            //connect.Open();
            dataConfig = new DataConfig();
            Load();
        }
        void Load()
        {
            string query = "select * from Account";
            //using (SqlConnection connection = new SqlConnection(conn))
            //{
            //dataConfig.GetConnection().Open();
            SqlCommand cmd = new SqlCommand(query, dataConfig.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = cmd;

            DataTable data = new DataTable();
            adapter.Fill(data);
            dataConfig.GetConnection().Close();

            dtgvDSAcc.DataSource = data;
            //}
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tên món đã tồn tại trong cơ sở dữ liệu chưa
            if (IsFoodNameExists(txtUsername.Text))
            {
                MessageBox.Show("Tài khoản đã tồn tại!");
                return;
            }
            if (!decimal.TryParse(txtSdt.Text, out decimal sdt))
            {
                MessageBox.Show("Số điện thoại khách hàng không hợp lệ!");
                return;
            }
            // Kiểm tra xem cả hai trường thông tin đã được nhập vào hay chưa
            if (string.IsNullOrWhiteSpace(txtDisplayname.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(cboType.Text) || string.IsNullOrWhiteSpace(txtGioitinh.Text) || string.IsNullOrWhiteSpace(txtQuequan.Text) || string.IsNullOrWhiteSpace(txtSdt.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return; // Thoát khỏi phương thức nếu không nhập đủ thông tin
            }

            // Mở kết nối đến cơ sở dữ liệu
            dataConfig.GetConnection().Open();

            // Chuỗi truy vấn thêm dữ liệu
            string add = "INSERT INTO Account(Displayname, UserName,PassWord,Type,GioiTinh,QueQuan,SDT) VALUES (@Displayname, @UserName,@PassWord,@Type,@GioiTinh,@QueQuan,@SDT)";

            // Tạo và thiết lập các tham số cho SqlCommand
            SqlCommand cmd = new SqlCommand(add, dataConfig.GetConnection());
            cmd.Parameters.AddWithValue("@Displayname", txtDisplayname.Text);
            cmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
            cmd.Parameters.AddWithValue("@PassWord", txtPassword.Text);
            cmd.Parameters.AddWithValue("@Type", cboType.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", txtGioitinh.Text);
            cmd.Parameters.AddWithValue("@QueQuan", txtQuequan.Text);
            cmd.Parameters.AddWithValue("@SDT", txtSdt.Text);

            // Thực thi truy vấn và kiểm tra số dòng bị ảnh hưởng
            int rowAffected = cmd.ExecuteNonQuery();

            // Đóng kết nối
            dataConfig.GetConnection().Close();

            // Kiểm tra số dòng bị ảnh hưởng để xác nhận việc thêm dữ liệu
            if (rowAffected > 0)
            {
                MessageBox.Show("Thêm tài khoản thành công!");
                // Nạp lại dữ liệu (điều này phụ thuộc vào cách bạn cài đặt phương thức Load())
                Load();
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại!");
            }
        }
        private bool IsFoodNameExists(string foodName)
        {
            // Mở kết nối đến cơ sở dữ liệu
            SqlConnection connection = dataConfig.GetConnection();
            connection.Open();

            string query = "SELECT COUNT(*) from  Account  WHERE UserName = @UserName";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserName", foodName);
            int count = (int)cmd.ExecuteScalar();

            // Đóng kết nối đến cơ sở dữ liệu
            connection.Close();

            return count > 0;
        }
        private void txtDisplayname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem userName có giá trị hợp lệ không
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng để xóa.");
                return;
            }

            // Mở kết nối đến cơ sở dữ liệu
            dataConfig.GetConnection().Open();

            // Chuỗi truy vấn xóa dữ liệu
            string delete = "DELETE FROM Account WHERE UserName = @UserName";

            // Tạo và thiết lập tham số cho SqlCommand
            SqlCommand cmd = new SqlCommand(delete, dataConfig.GetConnection());
            cmd.Parameters.AddWithValue("@UserName", txtUsername.Text);

            try
            {
                // Thực thi truy vấn và kiểm tra số dòng bị ảnh hưởng
                int rowAffected = cmd.ExecuteNonQuery();

                // Đóng kết nối
                dataConfig.GetConnection().Close();

                // Kiểm tra số dòng bị ảnh hưởng để xác nhận việc xóa dữ liệu
                if (rowAffected > 0)
                {
                    MessageBox.Show("Xóa tài khoản thành công!");
                    // Nạp lại dữ liệu (điều này phụ thuộc vào cách bạn cài đặt phương thức Load())
                    Load();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản để xóa!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi xóa tài khoản: " + ex.Message);
            }
            finally
            {
                // Đảm bảo đóng kết nối dù có lỗi xảy ra hay không
                if (dataConfig.GetConnection().State != ConnectionState.Closed)
                {
                    dataConfig.GetConnection().Close();
                }
            }
        }

        private void dtgvDSAcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.ReadOnly = true;
            int i;
            i = dtgvDSAcc.CurrentRow.Index;
            txtId.Text = dtgvDSAcc.Rows[i].Cells[0].Value.ToString();
            txtDisplayname.Text = dtgvDSAcc.Rows[i].Cells[1].Value.ToString();
            txtUsername.Text = dtgvDSAcc.Rows[i].Cells[2].Value.ToString();
            txtPassword.Text = dtgvDSAcc.Rows[i].Cells[3].Value.ToString();
            cboType.Text = dtgvDSAcc.Rows[i].Cells[4].Value.ToString();
            txtGioitinh.Text = dtgvDSAcc.Rows[i].Cells[5].Value.ToString();
            txtQuequan.Text = dtgvDSAcc.Rows[i].Cells[6].Value.ToString();
            txtSdt.Text = dtgvDSAcc.Rows[i].Cells[7].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtSdt.Text, out decimal sdt))
            {
                MessageBox.Show("Số điện thoại khách hàng không hợp lệ!");
                return;
            }
            // Kiểm tra xem userName có giá trị hợp lệ không
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản để sửa.");
                return;
            }

            // Kiểm tra xem tất cả các trường thông tin có được nhập vào không
            if (string.IsNullOrWhiteSpace(txtDisplayname.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(cboType.Text) || string.IsNullOrWhiteSpace(txtGioitinh.Text) || string.IsNullOrWhiteSpace(txtQuequan.Text) || string.IsNullOrWhiteSpace(txtSdt.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return; // Thoát khỏi phương thức nếu không nhập đủ thông tin
            }

            // Mở kết nối đến cơ sở dữ liệu
            dataConfig.GetConnection().Open();

            // Chuỗi truy vấn sửa dữ liệu
            string update = "UPDATE Account SET Displayname = @DisplayName, PassWord = @PassWord, Type = @Type, GioiTinh = @GioiTinh, QueQuan = @QueQuan, SDT = @SDT WHERE UserName = @UserName";

            // Tạo và thiết lập tham số cho SqlCommand
            SqlCommand cmd = new SqlCommand(update, dataConfig.GetConnection());
            cmd.Parameters.AddWithValue("@Displayname", txtDisplayname.Text);
            cmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
            cmd.Parameters.AddWithValue("@PassWord", txtPassword.Text);
            cmd.Parameters.AddWithValue("@Type", cboType.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", txtGioitinh.Text);
            cmd.Parameters.AddWithValue("@QueQuan", txtQuequan.Text);
            cmd.Parameters.AddWithValue("@SDT", txtSdt.Text);

            try
            {
                // Thực thi truy vấn và kiểm tra số dòng bị ảnh hưởng
                int rowAffected = cmd.ExecuteNonQuery();

                // Đóng kết nối
                dataConfig.GetConnection().Close();

                // Kiểm tra số dòng bị ảnh hưởng để xác nhận việc sửa dữ liệu
                if (rowAffected > 0)
                {
                    MessageBox.Show("Sửa thông tin tài khoản thành công!");
                    // Nạp lại dữ liệu (điều này phụ thuộc vào cách bạn cài đặt phương thức Load())
                    Load();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản để sửa!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi sửa thông tin tài khoản: " + ex.Message);
            }
            finally
            {
                // Đảm bảo đóng kết nối dù có lỗi xảy ra hay không
                if (dataConfig.GetConnection().State != ConnectionState.Closed)
                {
                    dataConfig.GetConnection().Close();
                }
            }
        }


    }
}
