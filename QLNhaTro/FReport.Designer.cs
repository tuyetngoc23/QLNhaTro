namespace QLNhaTro
{
    partial class FReport
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
            this.cRVDoanhThu = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cReport1 = new QLNhaTro.Report.cReport();
            this.SuspendLayout();
            // 
            // cRVDoanhThu
            // 
            this.cRVDoanhThu.ActiveViewIndex = -1;
            this.cRVDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cRVDoanhThu.Cursor = System.Windows.Forms.Cursors.Default;
            this.cRVDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cRVDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.cRVDoanhThu.Name = "cRVDoanhThu";
            this.cRVDoanhThu.Size = new System.Drawing.Size(1102, 611);
            this.cRVDoanhThu.TabIndex = 0;
            // 
            // FReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 611);
            this.Controls.Add(this.cRVDoanhThu);
            this.Name = "FReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FReport";
            this.ResumeLayout(false);

        }

        #endregion
        private Report.cReport cReport1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer cRVDoanhThu;
    }
}