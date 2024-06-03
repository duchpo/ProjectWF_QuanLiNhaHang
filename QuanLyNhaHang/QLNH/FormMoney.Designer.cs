namespace QLNH
{
    partial class FormMoney
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMoney));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_TongDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_BaoCao = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtThongKe = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbDT = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoanhThu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_TongDT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtgvDoanhThu);
            this.panel1.Location = new System.Drawing.Point(9, 145);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 396);
            this.panel1.TabIndex = 0;
            // 
            // txt_TongDT
            // 
            this.txt_TongDT.Location = new System.Drawing.Point(377, 363);
            this.txt_TongDT.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TongDT.Name = "txt_TongDT";
            this.txt_TongDT.Size = new System.Drawing.Size(127, 20);
            this.txt_TongDT.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 363);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tổng doanh thu : ";
            // 
            // dtgvDoanhThu
            // 
            this.dtgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dtgvDoanhThu.Location = new System.Drawing.Point(2, 2);
            this.dtgvDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvDoanhThu.Name = "dtgvDoanhThu";
            this.dtgvDoanhThu.RowHeadersWidth = 51;
            this.dtgvDoanhThu.RowTemplate.Height = 24;
            this.dtgvDoanhThu.Size = new System.Drawing.Size(768, 342);
            this.dtgvDoanhThu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_BaoCao);
            this.panel2.Controls.Add(this.btnThongKe);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtThongKe);
            this.panel2.Location = new System.Drawing.Point(9, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 65);
            this.panel2.TabIndex = 1;
            // 
            // btn_BaoCao
            // 
            this.btn_BaoCao.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_BaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BaoCao.Location = new System.Drawing.Point(626, 6);
            this.btn_BaoCao.Margin = new System.Windows.Forms.Padding(2);
            this.btn_BaoCao.Name = "btn_BaoCao";
            this.btn_BaoCao.Size = new System.Drawing.Size(95, 50);
            this.btn_BaoCao.TabIndex = 5;
            this.btn_BaoCao.Text = "Báo Cáo";
            this.btn_BaoCao.UseVisualStyleBackColor = false;
            this.btn_BaoCao.Click += new System.EventHandler(this.btn_BaoCao_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.LightSalmon;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(503, 6);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(95, 50);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn thời gian muốn xem doanh thu :";
            // 
            // dtThongKe
            // 
            this.dtThongKe.CustomFormat = "yyyy-MM-dd";
            this.dtThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtThongKe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThongKe.Location = new System.Drawing.Point(327, 16);
            this.dtThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.dtThongKe.Name = "dtThongKe";
            this.dtThongKe.Size = new System.Drawing.Size(137, 26);
            this.dtThongKe.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbDT);
            this.panel3.Location = new System.Drawing.Point(9, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 60);
            this.panel3.TabIndex = 2;
            // 
            // lbDT
            // 
            this.lbDT.AutoSize = true;
            this.lbDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDT.Location = new System.Drawing.Point(219, 9);
            this.lbDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDT.Name = "lbDT";
            this.lbDT.Size = new System.Drawing.Size(320, 31);
            this.lbDT.TabIndex = 1;
            this.lbDT.Text = "QUẢN LÝ DOANH THU";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FoodName";
            this.Column2.HeaderText = "Tên món";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Soluong";
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Price";
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SumPrice";
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Name";
            this.Column6.HeaderText = "Bàn";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DateOder";
            this.Column7.HeaderText = "Ngày";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TenKH";
            this.Column8.HeaderText = "Tên KH";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "SDT";
            this.Column9.HeaderText = "SĐT";
            this.Column9.Name = "Column9";
            // 
            // FormMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(788, 550);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMoney";
            this.Text = "Quản lý doanh thu";
            this.Load += new System.EventHandler(this.FormMoney_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoanhThu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbDT;
        private System.Windows.Forms.DateTimePicker dtThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDoanhThu;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.TextBox txt_TongDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}