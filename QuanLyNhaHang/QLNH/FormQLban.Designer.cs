namespace QLNH
{
    partial class FormQLban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLban));
            this.flpQLban = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txt_sdtKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.text_tenKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtOder = new System.Windows.Forms.DateTimePicker();
            this.btnOder = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Nametb = new System.Windows.Forms.TextBox();
            this.IbBan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbThucAn = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbDM = new System.Windows.Forms.ComboBox();
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_sumHD = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgvBillne = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbQLban = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillne)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpQLban
            // 
            this.flpQLban.AutoScroll = true;
            this.flpQLban.Location = new System.Drawing.Point(9, 80);
            this.flpQLban.Margin = new System.Windows.Forms.Padding(2);
            this.flpQLban.Name = "flpQLban";
            this.flpQLban.Size = new System.Drawing.Size(308, 464);
            this.flpQLban.TabIndex = 27;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_Xoa);
            this.panel6.Controls.Add(this.txt_sdtKH);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.text_tenKH);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.dtOder);
            this.panel6.Controls.Add(this.btnOder);
            this.panel6.Controls.Add(this.btnThanhToan);
            this.panel6.Location = new System.Drawing.Point(668, 80);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(151, 464);
            this.panel6.TabIndex = 26;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(11, 154);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 40);
            this.btn_Xoa.TabIndex = 36;
            this.btn_Xoa.Text = "Xóa Món";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // txt_sdtKH
            // 
            this.txt_sdtKH.Location = new System.Drawing.Point(12, 69);
            this.txt_sdtKH.Name = "txt_sdtKH";
            this.txt_sdtKH.Size = new System.Drawing.Size(100, 20);
            this.txt_sdtKH.TabIndex = 35;
            this.txt_sdtKH.TextChanged += new System.EventHandler(this.txt_sdtKH_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "SDT khách hàng :";
            // 
            // text_tenKH
            // 
            this.text_tenKH.Location = new System.Drawing.Point(12, 24);
            this.text_tenKH.Name = "text_tenKH";
            this.text_tenKH.Size = new System.Drawing.Size(100, 20);
            this.text_tenKH.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = " Tên khách hàng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ngày đặt món :";
            // 
            // dtOder
            // 
            this.dtOder.CustomFormat = "dd/MM/yyyy";
            this.dtOder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtOder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOder.Location = new System.Drawing.Point(15, 281);
            this.dtOder.Margin = new System.Windows.Forms.Padding(2);
            this.dtOder.Name = "dtOder";
            this.dtOder.Size = new System.Drawing.Size(112, 26);
            this.dtOder.TabIndex = 31;
            // 
            // btnOder
            // 
            this.btnOder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOder.Location = new System.Drawing.Point(11, 101);
            this.btnOder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOder.Name = "btnOder";
            this.btnOder.Size = new System.Drawing.Size(100, 40);
            this.btnOder.TabIndex = 30;
            this.btnOder.Text = "Gọi Món";
            this.btnOder.UseVisualStyleBackColor = true;
            this.btnOder.Click += new System.EventHandler(this.btnOder_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(11, 374);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(110, 50);
            this.btnThanhToan.TabIndex = 24;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Nametb);
            this.panel4.Controls.Add(this.IbBan);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.cbbThucAn);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cbbDM);
            this.panel4.Controls.Add(this.nmSoLuong);
            this.panel4.Location = new System.Drawing.Point(324, 80);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(340, 98);
            this.panel4.TabIndex = 25;
            // 
            // Nametb
            // 
            this.Nametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nametb.Location = new System.Drawing.Point(180, 25);
            this.Nametb.Margin = new System.Windows.Forms.Padding(2);
            this.Nametb.Name = "Nametb";
            this.Nametb.Size = new System.Drawing.Size(118, 23);
            this.Nametb.TabIndex = 8;
            // 
            // IbBan
            // 
            this.IbBan.AutoSize = true;
            this.IbBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbBan.Location = new System.Drawing.Point(178, 6);
            this.IbBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IbBan.Name = "IbBan";
            this.IbBan.Size = new System.Drawing.Size(68, 15);
            this.IbBan.TabIndex = 7;
            this.IbBan.Text = "Tên Bàn :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(178, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số Lượng :";
            // 
            // cbbThucAn
            // 
            this.cbbThucAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThucAn.FormattingEnabled = true;
            this.cbbThucAn.Location = new System.Drawing.Point(4, 72);
            this.cbbThucAn.Margin = new System.Windows.Forms.Padding(2);
            this.cbbThucAn.Name = "cbbThucAn";
            this.cbbThucAn.Size = new System.Drawing.Size(156, 25);
            this.cbbThucAn.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên Món Ăn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh Mục Thức Ăn :";
            // 
            // cbbDM
            // 
            this.cbbDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDM.FormattingEnabled = true;
            this.cbbDM.Location = new System.Drawing.Point(4, 25);
            this.cbbDM.Margin = new System.Windows.Forms.Padding(2);
            this.cbbDM.Name = "cbbDM";
            this.cbbDM.Size = new System.Drawing.Size(156, 25);
            this.cbbDM.TabIndex = 0;
            this.cbbDM.SelectedIndexChanged += new System.EventHandler(this.cbbDM_SelectedIndexChanged);
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmSoLuong.Location = new System.Drawing.Point(180, 72);
            this.nmSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.nmSoLuong.Name = "nmSoLuong";
            this.nmSoLuong.Size = new System.Drawing.Size(117, 23);
            this.nmSoLuong.TabIndex = 3;
            this.nmSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_sumHD);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtgvBillne);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(322, 180);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 364);
            this.panel2.TabIndex = 24;
            // 
            // lb_sumHD
            // 
            this.lb_sumHD.AutoSize = true;
            this.lb_sumHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sumHD.Location = new System.Drawing.Point(205, 304);
            this.lb_sumHD.Name = "lb_sumHD";
            this.lb_sumHD.Size = new System.Drawing.Size(0, 20);
            this.lb_sumHD.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tổng hóa đơn : ";
            // 
            // dtgvBillne
            // 
            this.dtgvBillne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBillne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dtgvBillne.Location = new System.Drawing.Point(2, 2);
            this.dtgvBillne.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvBillne.Name = "dtgvBillne";
            this.dtgvBillne.RowHeadersWidth = 51;
            this.dtgvBillne.RowTemplate.Height = 24;
            this.dtgvBillne.Size = new System.Drawing.Size(338, 288);
            this.dtgvBillne.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(358, -10);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 300);
            this.panel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbQLban);
            this.panel1.Location = new System.Drawing.Point(324, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 70);
            this.panel1.TabIndex = 28;
            // 
            // lbQLban
            // 
            this.lbQLban.AutoSize = true;
            this.lbQLban.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLban.Location = new System.Drawing.Point(59, 12);
            this.lbQLban.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQLban.Name = "lbQLban";
            this.lbQLban.Size = new System.Drawing.Size(118, 31);
            this.lbQLban.TabIndex = 1;
            this.lbQLban.Text = "ORDER";
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
            this.Column7.HeaderText = "Ngày ";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TenKH";
            this.Column8.HeaderText = "Tên khách hàng";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "SDT";
            this.Column9.HeaderText = "SĐT";
            this.Column9.Name = "Column9";
            // 
            // FormQLban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(828, 552);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpQLban);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormQLban";
            this.Text = "Order ";
            this.Load += new System.EventHandler(this.FormQLban_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillne)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpQLban;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nmSoLuong;
        private System.Windows.Forms.ComboBox cbbThucAn;
        private System.Windows.Forms.ComboBox cbbDM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbQLban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvBillne;
        private System.Windows.Forms.Button btnOder;
        private System.Windows.Forms.TextBox Nametb;
        private System.Windows.Forms.Label IbBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtOder;
        private System.Windows.Forms.Label lb_sumHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_tenKH;
        private System.Windows.Forms.TextBox txt_sdtKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Xoa;
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