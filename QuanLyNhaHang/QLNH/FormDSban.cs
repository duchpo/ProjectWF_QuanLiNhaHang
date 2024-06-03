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
    public partial class FormDSban : Form
    {
        private DataConfig dataConfig;
        //SqlConnection connect;
        //string conn = "Data Source=LAPTOP-5RGHKJ2R\\SQLEXPRESS;Initial Catalog=TU_QLNH;Integrated Security=True";
        public FormDSban()
        {
            InitializeComponent();
            //connect = new SqlConnection(conn);
            //connect.Open();
            dataConfig = new DataConfig();
            txbIDban.Enabled = false;
            Load();
        }
        void Load()
        {
            string query = "select * from DSTable";
            //using (SqlConnection connection = new SqlConnection(conn))
            //{
            //    connection.Open();
            //    SqlCommand cmd = new SqlCommand(query, connection);
            //    SqlDataAdapter adapter = new SqlDataAdapter();

            //    adapter.SelectCommand = cmd;

            //    DataTable data = new DataTable();
            //    adapter.Fill(data);

            //    connection.Close();

            dtgvDSban.DataSource = dataConfig.ExecuteQuery(query);


        //}
        }





        private void btnclear_Click(object sender, EventArgs e)
        {
            //using (SqlConnection connection = new SqlConnection(conn))
            //{
                dataConfig.GetConnection().Open();
                string clear = "DELETE FROM DSTable WHERE Name = @Name ";
                SqlCommand cmd = new SqlCommand(clear, dataConfig.GetConnection());
                cmd.Parameters.AddWithValue("@Name", txbNameTable.Text);
                cmd.Parameters.AddWithValue("@Status", cbbStatus.Text);

                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    txbNameTable.Clear();
                    Load();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
                dataConfig.GetConnection().Close();
            //}
        }

        private void btntimban_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            //using (SqlConnection connection = new SqlConnection(conn))
            //{
                dataConfig.GetConnection().Open();
                string tukhoa = txbSeach.Text;
                string checkban = " select * from DSTable where Status like N'%"+tukhoa.ToString()+"%' or Name like N'%"+tukhoa.ToString()+"%'";
              
                    SqlDataAdapter adapter = new SqlDataAdapter(checkban, dataConfig.GetConnection());
                    
                    adapter.Fill(ds, "DSTable1");
                    dtgvDSban.DataSource = ds.Tables["DSTable1"];
                dataConfig.GetConnection().Close ();
                
            //}
        }

        private void btnFix_Click(object sender, EventArgs e)
        {

            //using (SqlConnection connection = new SqlConnection(conn))
            //{
            dataConfig.GetConnection().Open();
                string add = "UPDATE DSTable SET Name = @Name , Status = @TrangThai WHERE id = @id";
                SqlCommand cmd = new SqlCommand(add, dataConfig.GetConnection());
                cmd.Parameters.AddWithValue("@Name", txbNameTable.Text);
                cmd.Parameters.AddWithValue("@id", txbIDban.Text);
                cmd.Parameters.AddWithValue("@TrangThai", cbbStatus.Text);

                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    txbNameTable.Clear();
                    Load();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
                dataConfig.GetConnection().Close();
            //}
        }

        private void dtgvDSban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                txbIDban.ReadOnly = true;
                int i;
                i = dtgvDSban.CurrentRow.Index;
                txbIDban.Text = dtgvDSban.Rows[i].Cells[0].Value.ToString();
                txbNameTable.Text = dtgvDSban.Rows[i].Cells[1].Value.ToString();
                cbbStatus.Text = dtgvDSban.Rows[i].Cells[2].Value.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tên món đã tồn tại trong cơ sở dữ liệu chưa
            if (IsFoodNameExists(txbNameTable.Text))
            {
                MessageBox.Show("Tên bàn  đã tồn tại!");
                return;
            }

            //using (SqlConnection connection = new SqlConnection(conn))
            //{
            dataConfig.GetConnection().Open();
            string add = "insert into DSTable( Name, Status)" + "values( @name, @status)";
            SqlCommand cmd = new SqlCommand(add, dataConfig.GetConnection());
            cmd.Parameters.AddWithValue("@name", txbNameTable.Text);
            cmd.Parameters.AddWithValue("@status", cbbStatus.Text);
            int rowAffected = cmd.ExecuteNonQuery();
            if (rowAffected > 0)
            {
                MessageBox.Show("Thêm bàn mới thành công !");
                DataSet ds = new DataSet();
                ds.Clear();
                Load();
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại!");
            }
            dataConfig.GetConnection().Close();



            //}
        }
        private bool IsFoodNameExists(string foodName)
        {
            // Mở kết nối đến cơ sở dữ liệu
            SqlConnection connection = dataConfig.GetConnection();
            connection.Open();

            string query = "SELECT COUNT(*) FROM DSTable WHERE Name = @Name";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Name", foodName);
            int count = (int)cmd.ExecuteScalar();

            // Đóng kết nối đến cơ sở dữ liệu
            connection.Close();

            return count > 0;
        }

        

        private void btnSeach_Click(object sender, EventArgs e)
        {

        }

        private void FormDSban_Load(object sender, EventArgs e)
        {

        }

        private void FormDSban_Load_1(object sender, EventArgs e)
        {

        }
    }
}
