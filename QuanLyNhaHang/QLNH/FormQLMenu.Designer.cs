namespace QLNH
{
    partial class FormQLMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbDanhMuc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNameMon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbIDMon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btntimmonan = new System.Windows.Forms.Button();
            this.txbSeach = new System.Windows.Forms.TextBox();
            this.lbMenu = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtgvMonAn = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonAn)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbDanhMuc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txbNameMon);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbIDMon);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btntimmonan);
            this.panel1.Controls.Add(this.txbSeach);
            this.panel1.Location = new System.Drawing.Point(461, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 459);
            this.panel1.TabIndex = 4;
            // 
            // cbbDanhMuc
            // 
            this.cbbDanhMuc.FormattingEnabled = true;
            this.cbbDanhMuc.Location = new System.Drawing.Point(110, 244);
            this.cbbDanhMuc.Margin = new System.Windows.Forms.Padding(2);
            this.cbbDanhMuc.Name = "cbbDanhMuc";
            this.cbbDanhMuc.Size = new System.Drawing.Size(164, 21);
            this.cbbDanhMuc.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 301);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Giá :";
            // 
            // txbPrice
            // 
            this.txbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrice.Location = new System.Drawing.Point(110, 298);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(164, 23);
            this.txbPrice.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Danh Mục :";
            // 
            // txbNameMon
            // 
            this.txbNameMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameMon.Location = new System.Drawing.Point(110, 194);
            this.txbNameMon.Margin = new System.Windows.Forms.Padding(2);
            this.txbNameMon.Name = "txbNameMon";
            this.txbNameMon.Size = new System.Drawing.Size(164, 23);
            this.txbNameMon.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tên Món :";
            // 
            // txbIDMon
            // 
            this.txbIDMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDMon.Location = new System.Drawing.Point(110, 145);
            this.txbIDMon.Margin = new System.Windows.Forms.Padding(2);
            this.txbIDMon.Name = "txbIDMon";
            this.txbIDMon.Size = new System.Drawing.Size(164, 23);
            this.txbIDMon.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID :";
            // 
            // btntimmonan
            // 
            this.btntimmonan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimmonan.Location = new System.Drawing.Point(206, 46);
            this.btntimmonan.Margin = new System.Windows.Forms.Padding(2);
            this.btntimmonan.Name = "btntimmonan";
            this.btntimmonan.Size = new System.Drawing.Size(84, 28);
            this.btntimmonan.TabIndex = 12;
            this.btntimmonan.Text = "Tìm Kiếm";
            this.btntimmonan.UseVisualStyleBackColor = true;
            this.btntimmonan.Click += new System.EventHandler(this.btntimmonan_Click);
            // 
            // txbSeach
            // 
            this.txbSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSeach.Location = new System.Drawing.Point(21, 50);
            this.txbSeach.Margin = new System.Windows.Forms.Padding(2);
            this.txbSeach.Name = "txbSeach";
            this.txbSeach.Size = new System.Drawing.Size(164, 23);
            this.txbSeach.TabIndex = 11;
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.Location = new System.Drawing.Point(576, 21);
            this.lbMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(98, 31);
            this.lbMenu.TabIndex = 8;
            this.lbMenu.Text = "MENU";
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Image = global::QLNH.Properties.Resources.bin;
            this.btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclear.Location = new System.Drawing.Point(206, 9);
            this.btnclear.Margin = new System.Windows.Forms.Padding(2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnclear.Size = new System.Drawing.Size(106, 62);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "Xóa";
            this.btnclear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnFix
            // 
            this.btnFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.Image = global::QLNH.Properties.Resources.holding_wrench;
            this.btnFix.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFix.Location = new System.Drawing.Point(317, 9);
            this.btnFix.Margin = new System.Windows.Forms.Padding(2);
            this.btnFix.Name = "btnFix";
            this.btnFix.Padding = new System.Windows.Forms.Padding(8, 0, 11, 0);
            this.btnFix.Size = new System.Drawing.Size(106, 62);
            this.btnFix.TabIndex = 14;
            this.btnFix.Text = "Sửa";
            this.btnFix.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::QLNH.Properties.Resources.add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(95, 9);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnAdd.Size = new System.Drawing.Size(106, 62);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtgvMonAn
            // 
            this.dtgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgvMonAn.Location = new System.Drawing.Point(10, 2);
            this.dtgvMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvMonAn.Name = "dtgvMonAn";
            this.dtgvMonAn.RowHeadersWidth = 51;
            this.dtgvMonAn.RowTemplate.Height = 24;
            this.dtgvMonAn.Size = new System.Drawing.Size(430, 442);
            this.dtgvMonAn.TabIndex = 0;
            this.dtgvMonAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMonAn_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvMonAn);
            this.panel2.Location = new System.Drawing.Point(9, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 447);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Các món ăn và đồ uống";
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
            this.Column3.DataPropertyName = "idCategory";
            this.Column3.HeaderText = "Mã loại thức ăn";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Price";
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.Name = "Column4";
            // 
            // FormQLMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(785, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormQLMenu";
            this.Text = "Quản lý menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonAn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNameMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbIDMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btntimmonan;
        private System.Windows.Forms.TextBox txbSeach;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgvMonAn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.ComboBox cbbDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}