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
    public partial class FormAccount : Form
    {
        public string hi;
        private DataConfig dataConfig;
        //SqlConnection connect;
        //string conn = "Data Source=LAPTOP-5RGHKJ2R\\SQLEXPRESS;Initial Catalog=TU_QLNH;Integrated Security=True";
        public FormAccount()
        {
            InitializeComponent();
            dataConfig = new DataConfig();
            //connect = new SqlConnection(conn);
            //connect.Open();

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            FormChangePass f = new FormChangePass();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


        private void FormAccount_Load(object sender, EventArgs e)
        {
            //using (SqlConnection connection = new SqlConnection(conn))
            //{

                string query = "select Displayname, SDT, GioiTinh, QueQuan from Account where UserName = '"+hi+"'  ";


                dataConfig.GetConnection().Open();
                SqlCommand cmd = new SqlCommand(query, dataConfig.GetConnection());
                SqlDataReader r = cmd.ExecuteReader();

                if (r.Read())
                {
                    if (!r.IsDBNull(0))
                    {
                        lbMyName.Text = r.GetString(0);
                    }
                    lbUN.Text=hi;

                    if (!r.IsDBNull(1))
                    {
                        lbSdt.Text = r.GetString(1);
                    }

                    if (!r.IsDBNull(2))
                    {
                        lbGt.Text = r.GetString(2);
                    }

                    if (!r.IsDBNull(3))
                    {
                        lbQq.Text = r.GetString(3);
                    }

                }




                dataConfig.GetConnection().Close();
            //}
        }
    }
}
