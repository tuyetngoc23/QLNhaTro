namespace QLNhaTro
{
    partial class FThuePhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVPhong = new System.Windows.Forms.DataGridView();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.tbMaKhach = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGioiTinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dGVKhachHang = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbTienPhong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPhong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbMaPhong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMaThue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpNgayThue = new System.Windows.Forms.DateTimePicker();
            this.btThue = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.tbTienCoc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btSua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPhong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKhachHang)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(392, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "THUÊ PHÒNG";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.dGVPhong);
            this.groupBox1.Controls.Add(this.cbLoaiPhong);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng trống";
            // 
            // dGVPhong
            // 
            this.dGVPhong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGVPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVPhong.DefaultCellStyle = dataGridViewCellStyle5;
            this.dGVPhong.Location = new System.Drawing.Point(6, 74);
            this.dGVPhong.Name = "dGVPhong";
            this.dGVPhong.RowHeadersVisible = false;
            this.dGVPhong.RowHeadersWidth = 51;
            this.dGVPhong.RowTemplate.Height = 24;
            this.dGVPhong.Size = new System.Drawing.Size(262, 119);
            this.dGVPhong.TabIndex = 0;
            this.dGVPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVPhong_CellClick);
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(146, 29);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(121, 39);
            this.cbLoaiPhong.TabIndex = 2;
            this.cbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiPhong_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(8, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 31);
            this.label8.TabIndex = 1;
            this.label8.Text = "Loại phòng:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox2.Controls.Add(this.dtpNgaySinh);
            this.groupBox2.Controls.Add(this.tbMaKhach);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbDiaChi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbCMND);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbSdt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbGioiTinh);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbTen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(292, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 157);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách thuê";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(391, 54);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(191, 38);
            this.dtpNgaySinh.TabIndex = 26;
            // 
            // tbMaKhach
            // 
            this.tbMaKhach.Enabled = false;
            this.tbMaKhach.Location = new System.Drawing.Point(76, 22);
            this.tbMaKhach.Name = "tbMaKhach";
            this.tbMaKhach.Size = new System.Drawing.Size(191, 38);
            this.tbMaKhach.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 31);
            this.label9.TabIndex = 12;
            this.label9.Text = "Mã:";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(76, 118);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(191, 38);
            this.tbDiaChi.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 31);
            this.label7.TabIndex = 10;
            this.label7.Text = "Quê quán:";
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(76, 86);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(191, 38);
            this.tbCMND.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "CMND:";
            // 
            // tbSdt
            // 
            this.tbSdt.Location = new System.Drawing.Point(392, 86);
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(191, 38);
            this.tbSdt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(292, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(292, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            // 
            // tbGioiTinh
            // 
            this.tbGioiTinh.Location = new System.Drawing.Point(392, 22);
            this.tbGioiTinh.Name = "tbGioiTinh";
            this.tbGioiTinh.Size = new System.Drawing.Size(191, 38);
            this.tbGioiTinh.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(292, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính:";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(76, 54);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(191, 38);
            this.tbTen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox4.Controls.Add(this.dGVKhachHang);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(1, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(274, 157);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách khách hàng";
            // 
            // dGVKhachHang
            // 
            this.dGVKhachHang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGVKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVKhachHang.DefaultCellStyle = dataGridViewCellStyle6;
            this.dGVKhachHang.Location = new System.Drawing.Point(6, 23);
            this.dGVKhachHang.Name = "dGVKhachHang";
            this.dGVKhachHang.RowHeadersVisible = false;
            this.dGVKhachHang.RowHeadersWidth = 51;
            this.dGVKhachHang.RowTemplate.Height = 24;
            this.dGVKhachHang.Size = new System.Drawing.Size(262, 119);
            this.dGVKhachHang.TabIndex = 0;
            this.dGVKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVKhachHang_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox3.Controls.Add(this.tbTienPhong);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tbPhong);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tbMaPhong);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(292, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(595, 79);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin phòng";
            // 
            // tbTienPhong
            // 
            this.tbTienPhong.Enabled = false;
            this.tbTienPhong.Location = new System.Drawing.Point(466, 29);
            this.tbTienPhong.Name = "tbTienPhong";
            this.tbTienPhong.Size = new System.Drawing.Size(121, 38);
            this.tbTienPhong.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(388, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 31);
            this.label12.TabIndex = 20;
            this.label12.Text = "Giá tiền:";
            // 
            // tbPhong
            // 
            this.tbPhong.Enabled = false;
            this.tbPhong.Location = new System.Drawing.Point(267, 29);
            this.tbPhong.Name = "tbPhong";
            this.tbPhong.Size = new System.Drawing.Size(121, 38);
            this.tbPhong.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(174, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 31);
            this.label11.TabIndex = 18;
            this.label11.Text = "Số phòng";
            // 
            // tbMaPhong
            // 
            this.tbMaPhong.Enabled = false;
            this.tbMaPhong.Location = new System.Drawing.Point(49, 29);
            this.tbMaPhong.Name = "tbMaPhong";
            this.tbMaPhong.Size = new System.Drawing.Size(121, 38);
            this.tbMaPhong.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 31);
            this.label10.TabIndex = 16;
            this.label10.Text = "Mã:";
            // 
            // tbMaThue
            // 
            this.tbMaThue.Enabled = false;
            this.tbMaThue.Location = new System.Drawing.Point(418, 316);
            this.tbMaThue.Name = "tbMaThue";
            this.tbMaThue.Size = new System.Drawing.Size(163, 38);
            this.tbMaThue.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(290, 319);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(193, 31);
            this.label13.TabIndex = 22;
            this.label13.Text = "Mã thuê phòng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(290, 352);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(203, 31);
            this.label14.TabIndex = 24;
            this.label14.Text = "Ngày nhận cọc:";
            // 
            // dtpNgayThue
            // 
            this.dtpNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThue.Location = new System.Drawing.Point(418, 351);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(163, 38);
            this.dtpNgayThue.TabIndex = 25;
            // 
            // btThue
            // 
            this.btThue.Location = new System.Drawing.Point(757, 346);
            this.btThue.Name = "btThue";
            this.btThue.Size = new System.Drawing.Size(117, 37);
            this.btThue.TabIndex = 27;
            this.btThue.Text = "Thuê phòng";
            this.btThue.UseVisualStyleBackColor = true;
            this.btThue.Click += new System.EventHandler(this.btThue_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(757, 388);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(117, 37);
            this.btXoa.TabIndex = 28;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // tbTienCoc
            // 
            this.tbTienCoc.Location = new System.Drawing.Point(418, 386);
            this.tbTienCoc.Name = "tbTienCoc";
            this.tbTienCoc.Size = new System.Drawing.Size(163, 38);
            this.tbTienCoc.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(290, 389);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 31);
            this.label15.TabIndex = 29;
            this.label15.Text = "Tiền coc:";
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(757, 303);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(117, 37);
            this.btSua.TabIndex = 27;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // FThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(896, 439);
            this.Controls.Add(this.tbTienCoc);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThue);
            this.Controls.Add(this.dtpNgayThue);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbMaThue);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FThuePhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThuePhong";
            this.Load += new System.EventHandler(this.FThuePhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPhong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVKhachHang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGioiTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dGVKhachHang;
        private System.Windows.Forms.TextBox tbMaKhach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbTienPhong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPhong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbMaPhong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox tbMaThue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpNgayThue;
        private System.Windows.Forms.Button btThue;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.TextBox tbTienCoc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dGVPhong;
        private System.Windows.Forms.Button btSua;
    }
}