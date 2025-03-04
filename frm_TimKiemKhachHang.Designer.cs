namespace TimKiemKhachHang
{
    partial class frm_TimKiemKhachHang
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
            this.txt_NhaptenKhachHang = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(566, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên khách hàng";
            // 
            // txt_NhaptenKhachHang
            // 
            this.txt_NhaptenKhachHang.Location = new System.Drawing.Point(515, 78);
            this.txt_NhaptenKhachHang.Multiline = true;
            this.txt_NhaptenKhachHang.Name = "txt_NhaptenKhachHang";
            this.txt_NhaptenKhachHang.Size = new System.Drawing.Size(330, 37);
            this.txt_NhaptenKhachHang.TabIndex = 1;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_TimKiem.Location = new System.Drawing.Point(611, 138);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(131, 34);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKhachHang,
            this.IDPhieu,
            this.NgayMua,
            this.TongTien});
            this.dataGridView1.Location = new System.Drawing.Point(8, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1314, 488);
            this.dataGridView1.TabIndex = 3;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.HeaderText = "TÊN KHÁCH HÀNG";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Width = 250;
            // 
            // IDPhieu
            // 
            this.IDPhieu.HeaderText = "ID PHIẾU";
            this.IDPhieu.MinimumWidth = 6;
            this.IDPhieu.Name = "IDPhieu";
            this.IDPhieu.Width = 250;
            // 
            // NgayMua
            // 
            this.NgayMua.HeaderText = "NGÀY MUA";
            this.NgayMua.MinimumWidth = 6;
            this.NgayMua.Name = "NgayMua";
            this.NgayMua.Width = 150;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "TỔNG TIỀN";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 150;
            // 
            // frm_TimKiemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1330, 717);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_NhaptenKhachHang);
            this.Controls.Add(this.label1);
            this.Name = "frm_TimKiemKhachHang";
            this.Text = "Tìm Kiếm Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NhaptenKhachHang;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}

