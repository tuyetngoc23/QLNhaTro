namespace QLNhaTro
{
    partial class FCapNhatKH
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.tbQueQuan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSdt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btCSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.tbGioiTinh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(293, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN KHÁCH THUÊ";
            // 
            // dgvKH
            // 
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKH.Location = new System.Drawing.Point(0, 270);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(1072, 170);
            this.dgvKH.TabIndex = 1;
            this.dgvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "CMND:";
            // 
            // tbMa
            // 
            this.tbMa.BackColor = System.Drawing.Color.White;
            this.tbMa.Enabled = false;
            this.tbMa.Location = new System.Drawing.Point(172, 69);
            this.tbMa.Name = "tbMa";
            this.tbMa.ReadOnly = true;
            this.tbMa.Size = new System.Drawing.Size(202, 30);
            this.tbMa.TabIndex = 5;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(172, 105);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(202, 30);
            this.tbTen.TabIndex = 6;
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(172, 141);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(202, 30);
            this.tbCMND.TabIndex = 7;
            // 
            // tbQueQuan
            // 
            this.tbQueQuan.Location = new System.Drawing.Point(172, 177);
            this.tbQueQuan.Name = "tbQueQuan";
            this.tbQueQuan.Size = new System.Drawing.Size(202, 30);
            this.tbQueQuan.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quê quán:";
            // 
            // tbSdt
            // 
            this.tbSdt.Location = new System.Drawing.Point(648, 108);
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(202, 30);
            this.tbSdt.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(515, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số điện thoại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(515, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ngày sinh:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(515, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Giới tính:";
            // 
            // btCSua
            // 
            this.btCSua.Location = new System.Drawing.Point(646, 212);
            this.btCSua.Name = "btCSua";
            this.btCSua.Size = new System.Drawing.Size(89, 37);
            this.btCSua.TabIndex = 19;
            this.btCSua.Text = "Sửa";
            this.btCSua.UseVisualStyleBackColor = true;
            this.btCSua.Click += new System.EventHandler(this.btCSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(764, 212);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(89, 37);
            this.btXoa.TabIndex = 20;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(648, 72);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(200, 30);
            this.dtpNgay.TabIndex = 21;
            // 
            // tbGioiTinh
            // 
            this.tbGioiTinh.Location = new System.Drawing.Point(648, 144);
            this.tbGioiTinh.Name = "tbGioiTinh";
            this.tbGioiTinh.Size = new System.Drawing.Size(202, 30);
            this.tbGioiTinh.TabIndex = 23;
            // 
            // FCapNhatKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1072, 440);
            this.Controls.Add(this.tbGioiTinh);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btCSua);
            this.Controls.Add(this.tbSdt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbQueQuan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCMND);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvKH);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FCapNhatKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCapNhatKH";
            this.Load += new System.EventHandler(this.FCapNhatKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.TextBox tbQueQuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSdt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btCSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.TextBox tbGioiTinh;
    }
}