using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QLNH
{
    public partial class FormQLban : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        private DataConfig dataConfig;
        string nameban = "";

        public FormQLban()
        {
            InitializeComponent();
            dataConfig = new DataConfig();
            LoadBill();
            LoadDMFood();
        }

        private void cbbDM_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataConfig.GetConnection().Close();
            dataConfig.GetConnection().Open();
            if (cbbDM.SelectedItem != null)
            {
                string select = "SELECT idCategory FROM DMFood WHERE FoodType = @NDM ";
                SqlCommand cmd = new SqlCommand(select, dataConfig.GetConnection());
                cmd.Parameters.AddWithValue("@NDM", cbbDM.SelectedItem);
                SqlDataReader doc = cmd.ExecuteReader();
                if (doc.Read())
                {
                    int nguoidoc = doc.GetInt32(0);
                    doc.Close();

                    string select1 = "SELECT FoodName FROM Food WHERE idCategory = @CategoryId";
                    SqlCommand cmd1 = new SqlCommand(select1, dataConfig.GetConnection());
                    cmd1.Parameters.AddWithValue("@CategoryId", nguoidoc);
                    SqlDataReader doc1 = cmd1.ExecuteReader();
                    cbbThucAn.Items.Clear();
                    while (doc1.Read())
                    {
                        string foodName = doc1.GetString(0);
                        cbbThucAn.Items.Add(foodName);
                    }
                    doc1.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
                dataConfig.GetConnection().Close();
            }
        }

        void LoadBill()
        {
            string displaybill = "SELECT * FROM Billinfo WHERE Name = @Name ORDER BY Name";
            dataConfig.GetConnection().Close();
            dataConfig.GetConnection().Open();
            SqlCommand Billne = new SqlCommand(displaybill, dataConfig.GetConnection());
            Billne.Parameters.AddWithValue("@Name", Nametb.Text);
            SqlDataAdapter adtne = new SqlDataAdapter();
            adtne.SelectCommand = Billne;

            DataTable datane = new DataTable();
            adtne.Fill(datane);

            // Tính tổng số tiền của hóa đơn
            totalBillAmount = 0;
            foreach (DataRow row in datane.Rows)
            {
                totalBillAmount += Convert.ToSingle(row["SumPrice"]);
            }

            dataConfig.GetConnection().Close();

            dtgvBillne.DataSource = datane;
        }
        void LoadDMFood()
        {
            string query = "select FoodType from DMFood"; // Chọn chỉ cột idCategory
            SqlCommand cmd = new SqlCommand(query, dataConfig.GetConnection());

            try
            {
                dataConfig.GetConnection().Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Đọc giá trị từ cột idCategory
                        string FoodType = reader.GetString(0); // Lấy giá trị từ cột đầu tiên (index 0)

                        // Thêm giá trị vào ComboBox
                        cbbDM.Items.Add(FoodType);
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
        private void LoadData()
        {
            lb_sumHD.Text = totalBillAmount.ToString();
            string query = "SELECT * FROM DSTable ";

            // Mở kết nối trước khi thực thi truy vấn
            dataConfig.GetConnection().Open();

            SqlCommand cmd = new SqlCommand(query, dataConfig.GetConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string tableName = reader["Name"].ToString();
                string tableStatus = reader["Status"].ToString();

                Button tableBtn = new Button();
                tableBtn.Text = tableName + Environment.NewLine + tableStatus;

                tableBtn.Width = 90;
                tableBtn.Height = 90;

                if (tableStatus == "Có người")
                {
                    tableBtn.BackColor = Color.LightPink;
                }
                else
                {
                    tableBtn.BackColor = Color.LightGreen;
                }

                tableBtn.Click += (s, evt) =>
                {
                    // Xử lý sự kiện khi nhấn vào nút bàn ở đây
                    // Ví dụ: Hiển thị thông tin của bàn, các món đã đặt, v.v.
                    nameban = tableName;
                    Nametb.Text = nameban;
                    LoadBill();
                    LoadKH(); // Gọi LoadKH() để hiển thị tên khách hàng cho bàn đó
                };

                flpQLban.Controls.Add(tableBtn);
            }
            reader.Close();
            // Đóng kết nối sau khi sử dụng
            dataConfig.GetConnection().Close();
        }

        private void LoadKH()
        {
            // Mở kết nối trước khi thực thi truy vấn
            dataConfig.GetConnection().Open();

            string query = "SELECT * FROM Billinfo WHERE Name = @tableName";
            SqlCommand cmd = new SqlCommand(query, dataConfig.GetConnection());
            cmd.Parameters.AddWithValue("@tableName", nameban); // Sử dụng biến nameban để lấy thông tin cho bàn tương ứng
            SqlDataReader reader = cmd.ExecuteReader();

            // Kiểm tra xem có dữ liệu để đọc không
            if (reader.Read())
            {
                string Namekh = reader["tenKH"].ToString();
                text_tenKH.Text = Namekh.ToString();
                string Sdtkh = reader["SDT"].ToString();
                txt_sdtKH.Text = Sdtkh.ToString();
            }


            // Đóng SqlDataReader
            reader.Close();
            // Đóng kết nối sau khi sử dụng
            dataConfig.GetConnection().Close();
        }

        private void FormQLban_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }

        private void UpdateFoodCategoryList()
        {
            dataConfig.GetConnection().Open();
            string select = "select FoodType from DMFood";
            SqlCommand cmd = new SqlCommand(select, dataConfig.GetConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            cbbDM.Items.Clear();
            while (reader.Read())
            {
                string foodType = reader["FoodType"].ToString();
                cbbDM.Items.Add(foodType);
            }
            reader.Close();
            dataConfig.GetConnection().Close();
        }
        private void FormDanhMuc_FoodAdded(object sender, EventArgs e)
        {
            UpdateFoodCategoryList();
        }

        public float SumMoney;
        float totalBillAmount;
        private void btnOder_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txt_sdtKH.Text, out decimal sdt))
                {
                    MessageBox.Show("Số điện thoại khách hàng không hợp lệ!");
                    return;
                }

                if (!decimal.TryParse(nmSoLuong.Text, out decimal sl ) || sl <= 0)
                {
                    MessageBox.Show("Số lượng món  không hợp lệ!");
                    return;
                }
                dataConfig.GetConnection().Open();
                float gia = 0;
                //float totalBillAmount = 0; // Biến tính tổng hóa đơn
                string laygia = "SELECT Price FROM Food WHERE FoodName = @FoodName";
                SqlCommand laygiane = new SqlCommand(laygia, dataConfig.GetConnection());
                laygiane.Parameters.AddWithValue("@FoodName", cbbThucAn.SelectedItem.ToString());
                SqlDataReader giane = laygiane.ExecuteReader();
                if (giane.Read())
                {
                    gia = (float)giane.GetDouble(0);
                    giane.Close();

                    SumMoney = (float)nmSoLuong.Value * gia;

                    // Tính tổng số tiền cho hóa đơn
                    totalBillAmount += SumMoney;

                    // Thêm dữ liệu vào cả hai bảng Billinfo và BillHistory
                    string insertQuery = "INSERT INTO Billinfo(FoodName, Soluong, Price, SumPrice, Name, DateOder,TenKH,SDT) " +
                                         "VALUES(@FoodName, @Soluong, @Price, @SumPrice, @Name, @DateOder, @TenKH, @SDT);" +
                                         "INSERT INTO BillHistory(FoodName, Soluong, Price, SumPrice, Name, DateOder,TenKH,SDT) " +
                                         "VALUES(@FoodName, @Soluong, @Price, @SumPrice, @Name, @DateOder, @TenKH,@SDT)";
                    SqlCommand cmd = new SqlCommand(insertQuery, dataConfig.GetConnection());
                    cmd.Parameters.AddWithValue("@FoodName", cbbThucAn.SelectedItem);
                    cmd.Parameters.AddWithValue("@Soluong", nmSoLuong.Value);
                    cmd.Parameters.AddWithValue("@Price", gia);
                    cmd.Parameters.AddWithValue("@SumPrice", SumMoney);
                    cmd.Parameters.AddWithValue("@Name", Nametb.Text);
                    cmd.Parameters.AddWithValue("@DateOder", dtOder.Value);
                    cmd.Parameters.AddWithValue("@TenKH", text_tenKH.Text);
                    cmd.Parameters.AddWithValue("@SDT", txt_sdtKH.Text);

                    int rowAffected = cmd.ExecuteNonQuery();
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Gọi món thành công! " );
                        LoadBill();
                        flpQLban.Controls.Clear();
                        UpdateTableStatus1("Có người");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Gọi món không thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                dataConfig.GetConnection().Close();
            }
        }

        private void ClearBill()
        {
            dataConfig.GetConnection().Open();
            string deleteQuery = "DELETE FROM Billinfo WHERE Name = @Name";
            SqlCommand deleteCmd = new SqlCommand(deleteQuery, dataConfig.GetConnection());
            deleteCmd.Parameters.AddWithValue("@Name", Nametb.Text);
            deleteCmd.ExecuteNonQuery();
            dataConfig.GetConnection().Close();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nametb.Text))
            {
                MessageBox.Show("Không có bàn được chọn.");
                return;
            }

            if (totalBillAmount <= 0)
            {
                MessageBox.Show("Chưa có đơn hàng nào được thanh toán.");
                return;
            }

            /*MessageBox.Show("Tổng tiền của Bàn '" + Nametb.Text + "' là: " + totalBillAmount);*/

            // Xóa hóa đơn của bàn
            inHD();
            ClearBill();

            // Cập nhật trạng thái của bàn thành "Trống"
            UpdateTableStatus("Trống");
            LoadBill();
            flpQLban.Controls.Clear();
            LoadData();
            
        }
        void inHD()
        {
                string updateQuery = "SELECT id, FoodName, Soluong, Price, SumPrice, Name, DateOder, TenKH,SDT FROM Billinfo WHERE Name = @Name";
                SqlCommand cmd = new SqlCommand(updateQuery, dataConfig.GetConnection());
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Name", Nametb.Text);
                da.SelectCommand = cmd;
                DataTable dt = new DataTable("hoadon");
                da.Fill(dt);

                // Thêm một cột mới vào DataTable để lưu giá trị của SumMoney
                dt.Columns.Add("SumMoney", typeof(decimal));

                // Gán giá trị của SumMoney cho mỗi hàng trong DataTable
                float sumMoneyValue = totalBillAmount;
                totalBillAmount = 0;
            foreach (DataRow row in dt.Rows)
                {
                    row["SumMoney"] = (decimal)sumMoneyValue;
                }
                thanhtoan reportHD = new thanhtoan();
                reportHD.SetDataSource(dt);

                FormThanhToan f = new FormThanhToan();
                f.crystalReportViewer1.ReportSource = reportHD;
                f.ShowDialog();


        }
        private void UpdateTableStatus(string status)
        {
            try
            {
                dataConfig.GetConnection().Open();
                string updateQuery = "UPDATE DSTable SET Status = @TrangThai WHERE Name = @Name";
                SqlCommand cmd = new SqlCommand(updateQuery, dataConfig.GetConnection());
                cmd.Parameters.AddWithValue("@TrangThai", status);
                cmd.Parameters.AddWithValue("@Name", Nametb.Text);
                int rowAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                dataConfig.GetConnection().Close();
            }
        }
        private void UpdateTableStatus1(string status)
        {
            try
            {
                dataConfig.GetConnection().Open();
                string updateQuery = "UPDATE DSTable SET Status = @TrangThai WHERE Name = @Name";
                SqlCommand cmd = new SqlCommand(updateQuery, dataConfig.GetConnection());
                cmd.Parameters.AddWithValue("@TrangThai", status);
                cmd.Parameters.AddWithValue("@Name", Nametb.Text);
                int rowAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                dataConfig.GetConnection().Close();
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_sdtKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                dataConfig.GetConnection().Open();

                // Kiểm tra xem có món ăn nào được chọn từ DataGridView không
                if (dtgvBillne.SelectedRows.Count > 0)
                {
                    // Lấy chỉ mục của hàng được chọn
                    int selectedIndex = dtgvBillne.SelectedRows[0].Index;

                    // Lấy giá trị của cột "FoodName" từ hàng được chọn
                    string selectedFood = dtgvBillne.Rows[selectedIndex].Cells["FoodName"].Value.ToString();

                    // Thực hiện xóa dữ liệu của món ăn được chọn từ cơ sở dữ liệu
                    string deleteQuery = "DELETE FROM Billinfo WHERE FoodName = @FoodName;" +
                                         "DELETE FROM BillHistory WHERE FoodName = @FoodName;";
                    SqlCommand cmd = new SqlCommand(deleteQuery, dataConfig.GetConnection());
                    cmd.Parameters.AddWithValue("@FoodName", selectedFood);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa món thành công!");

                        // Tải lại hóa đơn và các thông tin khác nếu cần
                        LoadBill();
                        flpQLban.Controls.Clear();
                        UpdateTableStatus1("Có người");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy món để xóa hoặc xóa không thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một món để xóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                dataConfig.GetConnection().Close();
            }
        }
    
    }
}
