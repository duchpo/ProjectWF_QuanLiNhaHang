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
    public partial class FormDanhMuc : Form
    {
        private DataConfig dataConfig;
        //SqlConnection connect;
        //string conn = "Data Source=LAPTOP-5RGHKJ2R\\SQLEXPRESS;Initial Catalog=TU_QLNH;Integrated Security=True";
        public FormDanhMuc()
        {
            InitializeComponent();
            //connect = new SqlConnection(conn);
            //connect.Open();
            dataConfig = new DataConfig();
            txbIDDM.Enabled = false;
            Load();
        }
        public event EventHandler FoodAdded;
        void Load()
        {
            string query = "select * from DMFood";
            //using (SqlConnection connection = new SqlConnection(conn))
            //{
                //dataConfig.GetConnection().Open();
                SqlCommand cmd = new SqlCommand(query, dataConfig.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.SelectCommand = cmd;

                DataTable data = new DataTable();
                adapter.Fill(data);
                dataConfig.GetConnection().Close();

                dtgvDSban.DataSource = data;
            //}
        }

        // Hàm kiểm tra xem tên món đã tồn tại trong cơ sở dữ liệu hay chưa
        private bool IsFoodTypeExists(string foodType)
        {
            // Mở kết nối đến cơ sở dữ liệu
            SqlConnection connection = dataConfig.GetConnection();
            connection.Open();

            string query = "SELECT COUNT(*) FROM DMFood WHERE FoodType = @FoodType";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@FoodType", foodType);
            int count = (int)cmd.ExecuteScalar();

            // Đóng kết nối đến cơ sở dữ liệu
            connection.Close();

            return count > 0;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem cả hai trường thông tin đã được nhập vào hay chưa
            if (string.IsNullOrWhiteSpace(txbNameDM.Text) || string.IsNullOrWhiteSpace(txbIDMon.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return; // Thoát khỏi phương thức nếu không nhập đủ thông tin
            }

            // Kiểm tra tên món
            if (!char.IsLetter(txbNameDM.Text[0]))
            {
                MessageBox.Show("Tên món phải bắt đầu bằng chữ cái!");
                return;
            }

            // Kiểm tra ID món
            int idMon;
            if (!int.TryParse(txbIDMon.Text, out idMon) || idMon <= 0)
            {
                MessageBox.Show("ID món phải là số nguyên dương!");
                return;
            }

            // Kiểm tra xem tên món đã tồn tại trong cơ sở dữ liệu hay chưa
            if (IsFoodTypeExists(txbNameDM.Text))
            {
                MessageBox.Show("Tên món đã tồn tại!");
                return;
            }

            // Mở kết nối đến cơ sở dữ liệu
            dataConfig.GetConnection().Open();

            // Chuỗi truy vấn thêm dữ liệu
            string add = "INSERT INTO DMFood(FoodType, idCategory) VALUES (@FoodType, @idCategory)";

            // Tạo và thiết lập các tham số cho SqlCommand
            SqlCommand cmd = new SqlCommand(add, dataConfig.GetConnection());
            cmd.Parameters.AddWithValue("@FoodType", txbNameDM.Text);
            cmd.Parameters.AddWithValue("@idCategory", idMon);

            // Thực thi truy vấn và kiểm tra số dòng bị ảnh hưởng
            int rowAffected = cmd.ExecuteNonQuery();

            // Đóng kết nối
            dataConfig.GetConnection().Close();

            // Kiểm tra số dòng bị ảnh hưởng để xác nhận việc thêm dữ liệu
            if (rowAffected > 0)
            {
                MessageBox.Show("Thêm danh mục thành công!");
                // Nạp lại dữ liệu (điều này phụ thuộc vào cách bạn cài đặt phương thức Load())
                Load();
            }
            else
            {
                MessageBox.Show("Thêm danh mục thất bại!");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            if (dtgvDSban.SelectedRows.Count > 0)
            {
                // Lấy tên cột từ thuộc tính DataPropertyName
                string columnName = "FoodType";

                // Lấy giá trị của cột FoodType từ dòng được chọn
                string foodType = dtgvDSban.SelectedRows[0].Cells[columnName].Value.ToString();

                // Mở kết nối đến cơ sở dữ liệu
                dataConfig.GetConnection().Open();

                // Chuỗi truy vấn xóa dữ liệu
                string clear = "DELETE FROM DMFood WHERE FoodType = @FoodType ";

                // Tạo và thiết lập tham số cho SqlCommand
                SqlCommand cmd = new SqlCommand(clear, dataConfig.GetConnection());
                cmd.Parameters.AddWithValue("@FoodType", foodType);

                // Thực thi truy vấn xóa và lấy số dòng bị ảnh hưởng
                int rowAffected = cmd.ExecuteNonQuery();

                // Kiểm tra số dòng bị ảnh hưởng để xác nhận việc xóa dữ liệu
                if (rowAffected > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    txbNameDM.Clear();
                    Load();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }

                // Đóng kết nối đến cơ sở dữ liệu
                dataConfig.GetConnection().Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một danh mục để xóa.");
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            //using (SqlConnection connection = new SqlConnection(conn))
            //{
                dataConfig.GetConnection().Open();
                string add = "UPDATE DMFood SET FoodType = @FoodType, idCategory = @idCategory  WHERE id = @id  ";
                SqlCommand cmd = new SqlCommand(add, dataConfig.GetConnection());
                cmd.Parameters.AddWithValue("@id", txbIDDM.Text);
                cmd.Parameters.AddWithValue("@FoodType", txbNameDM.Text);
                cmd.Parameters.AddWithValue("@idCategory", txbIDMon.Text);

                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    txbNameDM.Clear();
                    Load();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
                dataConfig.GetConnection().Close();
            //}
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            //using (SqlConnection connection = new SqlConnection(conn))
            //{
                dataConfig.GetConnection().Open();
                string tukhoa = txbSeach.Text;
                string checkDM = "select * from DMFood WHERE FoodType like N'%" + tukhoa.ToString() + "%' ";

                SqlDataAdapter adapter = new SqlDataAdapter(checkDM, dataConfig.GetConnection());

                adapter.Fill(ds, "DMFood1");
                dtgvDSban.DataSource = ds.Tables["DMFood1"];
                dataConfig.GetConnection().Close();
            //}
        }

        private void dtgvDSban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbIDDM.ReadOnly = true;
            int i;
            i = dtgvDSban.CurrentRow.Index;
            txbIDDM.Text = dtgvDSban.Rows[i].Cells[0].Value.ToString();
            txbNameDM.Text = dtgvDSban.Rows[i].Cells[1].Value.ToString();
        }

        private void btnDMmonan_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            //using (SqlConnection connection = new SqlConnection(conn))
            //{
                dataConfig.GetConnection().Open();
                string tukhoa = txbSeach.Text;
                string checkDM = "select * from DMFood WHERE FoodType like N'%" + tukhoa.ToString() + "%' ";

                SqlDataAdapter adapter = new SqlDataAdapter(checkDM, dataConfig.GetConnection());

                adapter.Fill(ds, "DMFood1");
                dtgvDSban.DataSource = ds.Tables["DMFood1"];
                dataConfig.GetConnection().Close();
            //}
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDanhMuc_Load(object sender, EventArgs e)
        {

        }

        private void FormDanhMuc_Load_1(object sender, EventArgs e)
        {

        }

        private void FormDanhMuc_Load_2(object sender, EventArgs e)
        {

        }
    }
 }
