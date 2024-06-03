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
    public partial class FormQLMenu : Form
    {
        private DataConfig dataConfig;
        //SqlConnection connect;
        //string conn = "Data Source=LAPTOP-5RGHKJ2R\\SQLEXPRESS;Initial Catalog=TU_QLNH;Integrated Security=True";
        public FormQLMenu()
        {
            InitializeComponent();
            //connect = new SqlConnection(conn);
            //connect.Open();
            dataConfig = new DataConfig();
            txbIDMon.Enabled = false;
            Load();
            LoadData();
        }
        void LoadData()
        {
            string query = "select idCategory from DMFood"; // Chọn chỉ cột idCategory
            SqlCommand cmd = new SqlCommand(query, dataConfig.GetConnection());

            try
            {
                dataConfig.GetConnection().Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Đọc giá trị từ cột idCategory
                        int idCategory = reader.GetInt32(0); // Lấy giá trị từ cột đầu tiên (index 0)

                        // Thêm giá trị vào ComboBox
                        cbbDanhMuc.Items.Add(idCategory);
                    }
                }
            }
            catch (SqlException ex)
            {
                // Xử lý ngoại lệ nếu có
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                dataConfig.GetConnection().Close();
            }
        }

        void Load()
        {
            string query = "select * from Food";
            //using (SqlConnection connection = new SqlConnection(conn))
            //{
                //dataConfig.GetConnection().Open();
                SqlCommand cmd = new SqlCommand(query, dataConfig.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.SelectCommand = cmd;

                DataTable data = new DataTable();
                adapter.Fill(data);
                dataConfig.GetConnection().Close();

                dtgvMonAn.DataSource = data;
            //}
        }

        // Hàm kiểm tra xem tên món đã tồn tại trong cơ sở dữ liệu hay chưa
        private bool IsFoodNameExists(string foodName)
        {
            // Mở kết nối đến cơ sở dữ liệu
            SqlConnection connection = dataConfig.GetConnection();
            connection.Open();

            string query = "SELECT COUNT(*) FROM Food WHERE FoodName = @FoodName";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@FoodName", foodName);
            int count = (int)cmd.ExecuteScalar();

            // Đóng kết nối đến cơ sở dữ liệu
            connection.Close();

            return count > 0;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các trường thông tin có được nhập hay không
            if (string.IsNullOrWhiteSpace(txbNameMon.Text) ||
                string.IsNullOrWhiteSpace(cbbDanhMuc.Text) ||
                string.IsNullOrWhiteSpace(txbPrice.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            // Kiểm tra kí tự đầu tiên của tên món
            if (!char.IsLetter(txbNameMon.Text[0]))
            {
                MessageBox.Show("Tên món ăn phải bắt đầu bằng một chữ cái!");
                return;
            }

            // Kiểm tra giá trị giá
            if (!decimal.TryParse(txbPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Giá tiền không hợp lệ!");
                return;
            }

            // Kiểm tra xem tên món đã tồn tại trong cơ sở dữ liệu chưa
            if (IsFoodNameExists(txbNameMon.Text))
            {
                MessageBox.Show("Tên món ăn đã tồn tại!");
                return;
            }

            // Mở kết nối đến cơ sở dữ liệu
            dataConfig.GetConnection().Open();

            // Tạo câu lệnh SQL để thêm món ăn
            string add = "INSERT INTO Food (FoodName, idCategory, Price) VALUES (@FoodName, @idCategory, @Price)";
            SqlCommand cmd = new SqlCommand(add, dataConfig.GetConnection());

            // Đưa các giá trị vào các tham số
            cmd.Parameters.AddWithValue("@FoodName", txbNameMon.Text);
            cmd.Parameters.AddWithValue("@idCategory", cbbDanhMuc.Text);
            cmd.Parameters.AddWithValue("@Price", price);

            // Thực thi câu lệnh SQL và lấy số dòng bị ảnh hưởng
            int rowAffected = cmd.ExecuteNonQuery();

            // Kiểm tra xem có món ăn nào được thêm thành công không
            if (rowAffected > 0)
            {
                MessageBox.Show("Thêm món thành công !");
                // Nạp lại dữ liệu
                Load();
            }
            else
            {
                MessageBox.Show("Thêm món ăn thất bại!");
            }

            // Đóng kết nối đến cơ sở dữ liệu
            dataConfig.GetConnection().Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //using (SqlConnection connection = new SqlConnection(conn))
            //{
                dataConfig.GetConnection().Open();
                string clear = "DELETE FROM Food WHERE FoodName = @FoodName";

                SqlCommand cmd = new SqlCommand(clear, dataConfig.GetConnection());
                cmd.Parameters.AddWithValue("@FoodName", txbNameMon.Text);
                cmd.Parameters.AddWithValue("@idCategory", cbbDanhMuc.Text);
                cmd.Parameters.AddWithValue("@Price", txbPrice.Text);
                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    txbNameMon.Clear();

                    Load();

                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
                dataConfig.GetConnection().Close();
            //}
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các trường thông tin có được nhập hay không
            if (string.IsNullOrWhiteSpace(txbNameMon.Text) ||
                string.IsNullOrWhiteSpace(cbbDanhMuc.Text) ||
                string.IsNullOrWhiteSpace(txbPrice.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            // Kiểm tra kí tự đầu tiên của tên món
            if (!char.IsLetter(txbNameMon.Text[0]))
            {
                MessageBox.Show("Tên món ăn phải bắt đầu bằng một chữ cái!");
                return;
            }

            // Kiểm tra giá trị giá
            if (!decimal.TryParse(txbPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Giá tiền không hợp lệ!");
                return;
            }
            //using (SqlConnection connection = new SqlConnection(conn))
            //{
            dataConfig.GetConnection().Open();
                string add = "update Food SET FoodName = @FoodName , idCategory = @idCategory, price = @Price WHERE id = @id";
                SqlCommand cmd = new SqlCommand(add, dataConfig.GetConnection());
                cmd.Parameters.AddWithValue("@FoodName", txbNameMon.Text);
                cmd.Parameters.AddWithValue("@idCategory", cbbDanhMuc.Text);
                cmd.Parameters.AddWithValue("@Price", txbPrice.Text);
                cmd.Parameters.AddWithValue("@id", txbIDMon.Text);

                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    txbNameMon.Clear();
                    Load();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
                dataConfig.GetConnection().Close();
            //}
        }



        private void dtgvMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbIDMon.ReadOnly = true;
            int i;
            i = dtgvMonAn.CurrentRow.Index;
            txbIDMon.Text = dtgvMonAn.Rows[i].Cells[0].Value.ToString();
            txbNameMon.Text = dtgvMonAn.Rows[i].Cells[1].Value.ToString();
            cbbDanhMuc.Text = dtgvMonAn.Rows[i].Cells[2].Value.ToString();
            txbPrice.Text = dtgvMonAn.Rows[i].Cells[3].Value.ToString();

        }

        private void cbbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormQLMenu_Load(object sender, EventArgs e)
        {

        }

        private void FormQLMenu_Load_1(object sender, EventArgs e)
        {

        }

        private void FormQLMenu_Load_2(object sender, EventArgs e)
        {

        }

        private void FormQLMenu_Load_3(object sender, EventArgs e)
        {

        }

        private void btntimmonan_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            //using (SqlConnection connection = new SqlConnection(conn))
            //{
            dataConfig.GetConnection().Open();
            string tukhoa = txbSeach.Text;
            string checkmon = "select * from Food WHERE FoodName like '%" + tukhoa.ToString() + "%' or idCategory like '%" + tukhoa.ToString() + "%' ";

            SqlDataAdapter adapter = new SqlDataAdapter(checkmon, dataConfig.GetConnection());

            adapter.Fill(ds, "food");
            dtgvMonAn.DataSource = ds.Tables["food"];
            dataConfig.GetConnection().Close();
            //}
        }

        private void FormQLMenu_Load_4(object sender, EventArgs e)
        {

        }
    }
}
