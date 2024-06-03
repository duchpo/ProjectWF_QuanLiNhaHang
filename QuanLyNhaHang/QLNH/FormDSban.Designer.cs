namespace QLNH
{
    partial class FormDSban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDSban));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvDSban = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btntimban = new System.Windows.Forms.Button();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNameTable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbIDban = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSeach = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbDSban = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSban)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvDSban);
            this.panel1.Location = new System.Drawing.Point(9, 83);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 460);
            this.panel1.TabIndex = 0;
            // 
            // dtgvDSban
            // 
            this.dtgvDSban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgvDSban.Location = new System.Drawing.Point(4, 2);
            this.dtgvDSban.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvDSban.Name = "dtgvDSban";
            this.dtgvDSban.RowHeadersWidth = 51;
            this.dtgvDSban.RowTemplate.Height = 24;
            this.dtgvDSban.Size = new System.Drawing.Size(440, 457);
            this.dtgvDSban.TabIndex = 0;
            this.dtgvDSban.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSban_CellContentClick);
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
            this.panel2.TabIndex = 1;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Image = global::QLNH.Properties.Resources.bin;
            this.btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclear.Location = new System.Drawing.Point(167, 4);
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
            this.btnFix.Location = new System.Drawing.Point(278, 4);
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
            this.btnAdd.Location = new System.Drawing.Point(56, 4);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btntimban);
            this.panel3.Controls.Add(this.cbbStatus);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txbNameTable);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txbIDban);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txbSeach);
            this.panel3.Location = new System.Drawing.Point(459, 85);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 460);
            this.panel3.TabIndex = 5;
            // 
            // btntimban
            // 
            this.btntimban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimban.Location = new System.Drawing.Point(202, 59);
            this.btntimban.Margin = new System.Windows.Forms.Padding(2);
            this.btntimban.Name = "btntimban";
            this.btntimban.Size = new System.Drawing.Size(84, 28);
            this.btntimban.TabIndex = 20;
            this.btntimban.Text = "Tìm Kiếm";
            this.btntimban.UseVisualStyleBackColor = true;
            this.btntimban.Click += new System.EventHandler(this.btntimban_Click);
            // 
            // cbbStatus
            // 
            this.cbbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "Trống",
            "Có người"});
            this.cbbStatus.Location = new System.Drawing.Point(108, 291);
            this.cbbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(164, 25);
            this.cbbStatus.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 293);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Trạng Thái :";
            // 
            // txbNameTable
            // 
            this.txbNameTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameTable.Location = new System.Drawing.Point(108, 240);
            this.txbNameTable.Margin = new System.Windows.Forms.Padding(2);
            this.txbNameTable.Name = "txbNameTable";
            this.txbNameTable.Size = new System.Drawing.Size(164, 23);
            this.txbNameTable.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tên bàn :";
            // 
            // txbIDban
            // 
            this.txbIDban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDban.Location = new System.Drawing.Point(108, 190);
            this.txbIDban.Margin = new System.Windows.Forms.Padding(2);
            this.txbIDban.Name = "txbIDban";
            this.txbIDban.Size = new System.Drawing.Size(164, 23);
            this.txbIDban.TabIndex = 14;
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
            this.txbSeach.Location = new System.Drawing.Point(24, 63);
            this.txbSeach.Margin = new System.Windows.Forms.Padding(2);
            this.txbSeach.Name = "txbSeach";
            this.txbSeach.Size = new System.Drawing.Size(164, 23);
            this.txbSeach.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbDSban);
            this.panel4.Location = new System.Drawing.Point(461, 11);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(302, 67);
            this.panel4.TabIndex = 6;
            // 
            // lbDSban
            // 
            this.lbDSban.AutoSize = true;
            this.lbDSban.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSban.Location = new System.Drawing.Point(36, 15);
            this.lbDSban.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDSban.Name = "lbDSban";
            this.lbDSban.Size = new System.Drawing.Size(251, 31);
            this.lbDSban.TabIndex = 0;
            this.lbDSban.Text = "DANH SÁCH BÀN";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Tên bàn";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Status";
            this.Column3.HeaderText = "Trạng thái";
            this.Column3.Name = "Column3";
            // 
            // FormDSban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(772, 552);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDSban";
            this.Text = "Quản lý bàn ";
            //this.Load += new System.EventHandler(this.FormDSban_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSban)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNameTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbIDban;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSeach;
        private System.Windows.Forms.DataGridView dtgvDSban;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbDSban;
        private System.Windows.Forms.Button btntimban;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}