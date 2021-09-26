namespace QLNhaTro
{
    partial class FCapNhatPhong
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
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.tbPhong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(343, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT PHÒNG";
            // 
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPhong.Location = new System.Drawing.Point(0, 239);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.Size = new System.Drawing.Size(959, 201);
            this.dgvPhong.TabIndex = 1;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phòng:";
            // 
            // tbMa
            // 
            this.tbMa.BackColor = System.Drawing.Color.White;
            this.tbMa.Location = new System.Drawing.Point(183, 69);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(215, 30);
            this.tbMa.TabIndex = 3;
            // 
            // tbPhong
            // 
            this.tbPhong.Location = new System.Drawing.Point(183, 104);
            this.tbPhong.Name = "tbPhong";
            this.tbPhong.Size = new System.Drawing.Size(215, 30);
            this.tbPhong.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loại phòng:";
            // 
            // tbGia
            // 
            this.tbGia.Location = new System.Drawing.Point(648, 68);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(215, 30);
            this.tbGia.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Giá:";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(471, 178);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(89, 37);
            this.btThem.TabIndex = 16;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(612, 178);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(89, 37);
            this.btSua.TabIndex = 17;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(751, 178);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(89, 37);
            this.btXoa.TabIndex = 18;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(648, 107);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(215, 33);
            this.cbLoaiPhong.TabIndex = 21;
            // 
            // FCapNhatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(959, 440);
            this.Controls.Add(this.cbLoaiPhong);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.tbGia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FCapNhatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhong";
            this.Load += new System.EventHandler(this.FCapNhatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.TextBox tbPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
    }
}