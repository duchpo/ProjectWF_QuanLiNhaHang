using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH
{
    public partial class FormMain : Form
    {

        private int userType;

        public FormMain(int userType)
        {
            InitializeComponent();
            this.userType = userType;
            CheckUserType(); // Kiểm tra loại người dùng và cài đặt quyền truy cập
        }

        private void CheckUserType()
        {
            // Nếu là nhân viên (Type = 0), ẩn các nút không cần thiết
            if (userType == 0)
            {
                btnMenu.Enabled = false;
                btnDMMonAn.Enabled = false;
                btnDThu.Enabled = false;
                btnQLTK.Enabled = false;
            }
        }
        public string tk;
        public FormMain()
        {
            InitializeComponent();
        }
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (childForm != null)
            {
                if (currentFormChild != null)
                {
                    currentFormChild.Close();
                }


                currentFormChild = childForm;
                if (currentFormChild != null)
                {
                    childForm.TopLevel = false;
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Fill;
                    pnBody.Controls.Add(childForm);
                    pnBody.Tag = childForm;
                    childForm.BringToFront();
                    childForm.Show();
                }
            }

        }

        private void btnQLban_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FormQLban());
            FormQLban fr = new FormQLban();
            fr.StartPosition = FormStartPosition.CenterParent; // Đặt form con xuất hiện ở giữa form cha
            fr.ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FormQLMenu());
            FormQLMenu fr = new FormQLMenu();
            fr.StartPosition = FormStartPosition.CenterParent; // Đặt form con xuất hiện ở giữa form cha
            fr.ShowDialog();
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void btnDSban_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FormDSban());
            FormDSban fr = new FormDSban();
            fr.StartPosition = FormStartPosition.CenterParent; // Đặt form con xuất hiện ở giữa form cha
            fr.ShowDialog();
        }

        private void btnDMMonAn_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FormDanhMuc());
            FormDanhMuc fr = new FormDanhMuc();
            fr.StartPosition = FormStartPosition.CenterParent; // Đặt form con xuất hiện ở giữa form cha
            fr.ShowDialog();
        }

        private void btnDThu_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FormMoney());
            FormMoney fr = new FormMoney();
            fr.StartPosition = FormStartPosition.CenterParent; // Đặt form con xuất hiện ở giữa form cha
            fr.ShowDialog();
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            FormAccount n = new FormAccount();
            n.hi = tk;
            n.Show();




        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void pbTrangchu_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormQuanlytk k = new FormQuanlytk();
            k.StartPosition = FormStartPosition.CenterParent; // Đặt form con xuất hiện ở giữa form cha
            k.ShowDialog();
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}