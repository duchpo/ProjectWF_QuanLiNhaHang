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
    public partial class FormMoney : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        private DataConfig dataConfig;
        //SqlConnection connect;
        //string conn = "Data Source=LAPTOP-5RGHKJ2R\\SQLEXPRESS;Initial Catalog=TU_QLNH;Integrated Security=True";
        public FormMoney()
        {
            InitializeComponent();
            //connect = new SqlConnection(conn);
            //connect.Open();
            dataConfig = new DataConfig();
        }

        private void FormMoney_Load(object sender, EventArgs e)
        {

        }
        decimal totalRevenue = 0;
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string check = "select * from BillHistory where DateOder like '" + dtThongKe.Text + "'  ";

            try
            {
                dataConfig.GetConnection().Open();
                SqlCommand cmd = new SqlCommand(check, dataConfig.GetConnection());
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand = cmd;

                DataTable data = new DataTable();
                adt.Fill(data);

                // Tính tổng doanh thu
                
                foreach (DataRow row in data.Rows)
                {
                    totalRevenue += Convert.ToDecimal(row["SumPrice"]);
                }

                // Hiển thị tổng doanh thu trong TextBox
                txt_TongDT.Text = totalRevenue.ToString();

                dataConfig.GetConnection().Close();

                // Hiển thị dữ liệu trong DataGridView
                dtgvDoanhThu.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            string updateQuery = "SELECT id, FoodName, Soluong, Price, SumPrice, Name, DateOder, TenKH,SDT FROM BillHistory WHERE DateOder like '" + dtThongKe.Text + "'  ";
            SqlCommand cmd = new SqlCommand(updateQuery, dataConfig.GetConnection());
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateOder", dtThongKe.Text);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable("doanhthu");
            da.Fill(dt);
            // Thêm một cột mới vào DataTable để lưu giá trị của SumMoney
            dt.Columns.Add("SumMoney", typeof(decimal));




            // Gán giá trị của SumMoney cho mỗi hàng trong DataTable
            float sumMoneyValue = Convert.ToSingle(totalRevenue);
            //totalRevenue = 0;
            foreach (DataRow row in dt.Rows)
            {
                row["SumMoney"] = Convert.ToSingle(sumMoneyValue);
            }

            BaoCao reportBC = new BaoCao();
            reportBC.SetDataSource(dt);

            FormBaoCao f = new FormBaoCao();
            f.crystalReportViewer2.ReportSource = reportBC;
            f.ShowDialog();

        }
    }
    
}
