namespace QLNhaTro
{
    partial class FTinhTien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVThuePhong = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbSoPhong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMaPhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTienPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaKhach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaThue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.tbDichVu = new System.Windows.Forms.TextBox();
            this.tbTienNuoc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbTienDien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbSoDien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSoNuoc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVThuePhong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(370, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "LẬP HÓA ĐƠN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.dGVThuePhong);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng chưa lập hóa đơn";
            // 
            // dGVThuePhong
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dGVThuePhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVThuePhong.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGVThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVThuePhong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVThuePhong.Location = new System.Drawing.Point(3, 15);
            this.dGVThuePhong.Name = "dGVThuePhong";
            this.dGVThuePhong.RowHeadersWidth = 62;
            this.dGVThuePhong.RowTemplate.Height = 28;
            this.dGVThuePhong.Size = new System.Drawing.Size(859, 130);
            this.dGVThuePhong.TabIndex = 0;
            this.dGVThuePhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVThuePhong_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox2.Controls.Add(this.tbSoPhong);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbMaPhong);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbTienPhong);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbMaKhach);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbMaThue);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 184);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phòng thuê";
            // 
            // tbSoPhong
            // 
            this.tbSoPhong.Enabled = false;
            this.tbSoPhong.Location = new System.Drawing.Point(139, 80);
            this.tbSoPhong.Name = "tbSoPhong";
            this.tbSoPhong.Size = new System.Drawing.Size(191, 38);
            this.tbSoPhong.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(40, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 31);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số phòng:";
            // 
            // tbMaPhong
            // 
            this.tbMaPhong.Enabled = false;
            this.tbMaPhong.Location = new System.Drawing.Point(139, 51);
            this.tbMaPhong.Name = "tbMaPhong";
            this.tbMaPhong.Size = new System.Drawing.Size(191, 38);
            this.tbMaPhong.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(40, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã phòng:";
            // 
            // tbTienPhong
            // 
            this.tbTienPhong.Enabled = false;
            this.tbTienPhong.Location = new System.Drawing.Point(139, 140);
            this.tbTienPhong.Name = "tbTienPhong";
            this.tbTienPhong.Size = new System.Drawing.Size(191, 38);
            this.tbTienPhong.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(40, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tiền phòng";
            // 
            // tbMaKhach
            // 
            this.tbMaKhach.Enabled = false;
            this.tbMaKhach.Location = new System.Drawing.Point(139, 109);
            this.tbMaKhach.Name = "tbMaKhach";
            this.tbMaKhach.Size = new System.Drawing.Size(191, 38);
            this.tbMaKhach.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(40, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã khách:";
            // 
            // tbMaThue
            // 
            this.tbMaThue.Enabled = false;
            this.tbMaThue.Location = new System.Drawing.Point(139, 22);
            this.tbMaThue.Name = "tbMaThue";
            this.tbMaThue.Size = new System.Drawing.Size(191, 38);
            this.tbMaThue.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Thuê";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox3.Controls.Add(this.cbThang);
            this.groupBox3.Controls.Add(this.tbDichVu);
            this.groupBox3.Controls.Add(this.tbTienNuoc);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.tbTienDien);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.tbSoDien);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tbSoNuoc);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(456, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 184);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phí sử dụng";
            // 
            // cbThang
            // 
            this.cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(291, 13);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(121, 39);
            this.cbThang.TabIndex = 17;
            // 
            // tbDichVu
            // 
            this.tbDichVu.Enabled = false;
            this.tbDichVu.Location = new System.Drawing.Point(292, 145);
            this.tbDichVu.Name = "tbDichVu";
            this.tbDichVu.Size = new System.Drawing.Size(120, 38);
            this.tbDichVu.TabIndex = 16;
            this.tbDichVu.Text = "120000";
            // 
            // tbTienNuoc
            // 
            this.tbTienNuoc.Enabled = false;
            this.tbTienNuoc.Location = new System.Drawing.Point(292, 115);
            this.tbTienNuoc.Name = "tbTienNuoc";
            this.tbTienNuoc.Size = new System.Drawing.Size(120, 38);
            this.tbTienNuoc.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(191, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 31);
            this.label15.TabIndex = 14;
            this.label15.Text = "Thành tiền:";
            // 
            // tbTienDien
            // 
            this.tbTienDien.Enabled = false;
            this.tbTienDien.Location = new System.Drawing.Point(292, 55);
            this.tbTienDien.Name = "tbTienDien";
            this.tbTienDien.Size = new System.Drawing.Size(120, 38);
            this.tbTienDien.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(191, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tháng:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(191, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 31);
            this.label14.TabIndex = 12;
            this.label14.Text = "Thành tiền:";
            // 
            // tbSoDien
            // 
            this.tbSoDien.Location = new System.Drawing.Point(126, 55);
            this.tbSoDien.Name = "tbSoDien";
            this.tbSoDien.Size = new System.Drawing.Size(53, 38);
            this.tbSoDien.TabIndex = 11;
            this.tbSoDien.Text = "0";
            this.tbSoDien.TextChanged += new System.EventHandler(this.tbSoDien_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(28, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 31);
            this.label8.TabIndex = 10;
            this.label8.Text = "Số kí điện:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 31);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tiền điện:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(15, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(278, 31);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tiền rác+wifi+dịch vụ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(28, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 31);
            this.label11.TabIndex = 4;
            this.label11.Text = "Số kí nước:";
            // 
            // tbSoNuoc
            // 
            this.tbSoNuoc.Location = new System.Drawing.Point(126, 115);
            this.tbSoNuoc.Name = "tbSoNuoc";
            this.tbSoNuoc.Size = new System.Drawing.Size(53, 38);
            this.tbSoNuoc.TabIndex = 3;
            this.tbSoNuoc.Text = "0";
            this.tbSoNuoc.TextChanged += new System.EventHandler(this.tbSoNuoc_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(15, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 31);
            this.label12.TabIndex = 2;
            this.label12.Text = "Tiền nước:";
            // 
            // tbTongTien
            // 
            this.tbTongTien.Enabled = false;
            this.tbTongTien.Location = new System.Drawing.Point(573, 399);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(139, 38);
            this.tbTongTien.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(474, 402);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(135, 31);
            this.label17.TabIndex = 27;
            this.label17.Text = "Tổng tiền:";
            // 
            // btThanhToan
            // 
            this.btThanhToan.Location = new System.Drawing.Point(748, 394);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(123, 37);
            this.btThanhToan.TabIndex = 29;
            this.btThanhToan.Text = "Thanh Toán";
            this.btThanhToan.UseVisualStyleBackColor = true;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // FTinhTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(896, 434);
            this.Controls.Add(this.btThanhToan);
            this.Controls.Add(this.tbTongTien);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FTinhTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTinhTien";
            this.Load += new System.EventHandler(this.FTinhTien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVThuePhong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbSoPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMaPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTienPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaKhach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaThue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbSoDien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbSoNuoc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbDichVu;
        private System.Windows.Forms.TextBox tbTienNuoc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbTienDien;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.DataGridView dGVThuePhong;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label label4;
    }
}