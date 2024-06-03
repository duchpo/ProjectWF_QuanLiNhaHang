namespace QLNH
{
    partial class FormDanhMuc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDanhMuc));
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbDM = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIDMon = new System.Windows.Forms.TextBox();
            this.btnDMmonan = new System.Windows.Forms.Button();
            this.txbNameDM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbIDDM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSeach = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvDSban = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSban)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbDM);
            this.panel4.Location = new System.Drawing.Point(461, 11);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(302, 67);
            this.panel4.TabIndex = 10;
            // 
            // lbDM
            // 
            this.lbDM.AutoSize = true;
            this.lbDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDM.Location = new System.Drawing.Point(10, 15);
            this.lbDM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDM.Name = "lbDM";
            this.lbDM.Size = new System.Drawing.Size(303, 31);
            this.lbDM.TabIndex = 0;
            this.lbDM.Text = "QUẢN LÝ DANH MỤC";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txbIDMon);
            this.panel3.Controls.Add(this.btnDMmonan);
            this.panel3.Controls.Add(this.txbNameDM);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txbIDDM);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txbSeach);
            this.panel3.Location = new System.Drawing.Point(461, 83);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 460);
            this.panel3.TabIndex = 9;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 294);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID món ăn :";
            // 
            // txbIDMon
            // 
            this.txbIDMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDMon.Location = new System.Drawing.Point(130, 288);
            this.txbIDMon.Margin = new System.Windows.Forms.Padding(2);
            this.txbIDMon.Name = "txbIDMon";
            this.txbIDMon.Size = new System.Drawing.Size(164, 23);
            this.txbIDMon.TabIndex = 18;
            // 
            // btnDMmonan
            // 
            this.btnDMmonan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDMmonan.Location = new System.Drawing.Point(198, 60);
            this.btnDMmonan.Margin = new System.Windows.Forms.Padding(2);
            this.btnDMmonan.Name = "btnDMmonan";
            this.btnDMmonan.Size = new System.Drawing.Size(84, 28);
            this.btnDMmonan.TabIndex = 17;
            this.btnDMmonan.Text = "Tìm Kiếm";
            this.btnDMmonan.UseVisualStyleBackColor = true;
            this.btnDMmonan.Click += new System.EventHandler(this.btnDMmonan_Click);
            // 
            // txbNameDM
            // 
            this.txbNameDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameDM.Location = new System.Drawing.Point(130, 240);
            this.txbNameDM.Margin = new System.Windows.Forms.Padding(2);
            this.txbNameDM.Name = "txbNameDM";
            this.txbNameDM.Size = new System.Drawing.Size(164, 23);
            this.txbNameDM.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tên danh mục :";
            // 
            // txbIDDM
            // 
            this.txbIDDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDDM.Location = new System.Drawing.Point(130, 188);
            this.txbIDDM.Margin = new System.Windows.Forms.Padding(2);
            this.txbIDDM.Name = "txbIDDM";
            this.txbIDDM.Size = new System.Drawing.Size(164, 23);
            this.txbIDDM.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID :";
            // 
            // txbSeach
            // 
            this.txbSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSeach.Location = new System.Drawing.Point(16, 64);
            this.txbSeach.Margin = new System.Windows.Forms.Padding(2);
            this.txbSeach.Name = "txbSeach";
            this.txbSeach.Size = new System.Drawing.Size(164, 23);
            this.txbSeach.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnclear);
            this.panel2.Controls.Add(this.btnFix);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(9, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 68);
            this.panel2.TabIndex = 8;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Image = global::QLNH.Properties.Resources.bin;
            this.btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclear.Location = new System.Drawing.Point(174, 1);
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
            this.btnFix.Location = new System.Drawing.Point(285, 1);
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
            this.btnAdd.Location = new System.Drawing.Point(63, 1);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvDSban);
            this.panel1.Location = new System.Drawing.Point(9, 83);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 460);
            this.panel1.TabIndex = 7;
            // 
            // dtgvDSban
            // 
            this.dtgvDSban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDSban.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDSban.Location = new System.Drawing.Point(4, 2);
            this.dtgvDSban.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvDSban.Name = "dtgvDSban";
            this.dtgvDSban.RowHeadersWidth = 51;
            this.dtgvDSban.RowTemplate.Height = 24;
            this.dtgvDSban.Size = new System.Drawing.Size(442, 457);
            this.dtgvDSban.TabIndex = 0;
            this.dtgvDSban.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSban_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FoodType";
            this.Column2.HeaderText = "Loại thức ăn";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "idCategory";
            this.Column3.HeaderText = "Mã thức ăn";
            this.Column3.Name = "Column3";
            // 
            // FormDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(777, 552);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDanhMuc";
            this.Text = "Quản lý danh mục";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbDM;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbNameDM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbIDDM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSeach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvDSban;
        private System.Windows.Forms.Button btnDMmonan;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIDMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}