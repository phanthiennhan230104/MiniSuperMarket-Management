namespace BaoCaoSoLuongHangTonKho
{
    partial class frm_Baocaotonkho
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_XemKetQua = new System.Windows.Forms.Button();
            this.txt_ChonNam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_TongLuongTon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHang,
            this.SoLuongNhap,
            this.SoLuongXuat,
            this.SoLuongTon});
            this.dataGridView1.Location = new System.Drawing.Point(8, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1314, 442);
            this.dataGridView1.TabIndex = 7;
            // 
            // btn_XemKetQua
            // 
            this.btn_XemKetQua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_XemKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemKetQua.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_XemKetQua.Location = new System.Drawing.Point(596, 133);
            this.btn_XemKetQua.Name = "btn_XemKetQua";
            this.btn_XemKetQua.Size = new System.Drawing.Size(185, 34);
            this.btn_XemKetQua.TabIndex = 6;
            this.btn_XemKetQua.Text = "Xem Kết Quả";
            this.btn_XemKetQua.UseVisualStyleBackColor = false;
            // 
            // txt_ChonNam
            // 
            this.txt_ChonNam.Location = new System.Drawing.Point(515, 68);
            this.txt_ChonNam.Multiline = true;
            this.txt_ChonNam.Name = "txt_ChonNam";
            this.txt_ChonNam.Size = new System.Drawing.Size(330, 37);
            this.txt_ChonNam.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(624, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn năm";
            // 
            // TenHang
            // 
            this.TenHang.HeaderText = "TÊN HÀNG";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            this.TenHang.Width = 125;
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.HeaderText = "SỐ LƯỢNG NHẬP";
            this.SoLuongNhap.MinimumWidth = 6;
            this.SoLuongNhap.Name = "SoLuongNhap";
            this.SoLuongNhap.Width = 125;
            // 
            // SoLuongXuat
            // 
            this.SoLuongXuat.HeaderText = "SỐ LƯỢNG XUẤT";
            this.SoLuongXuat.MinimumWidth = 6;
            this.SoLuongXuat.Name = "SoLuongXuat";
            this.SoLuongXuat.Width = 125;
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.HeaderText = "SỐ LƯỢNG TỒN";
            this.SoLuongTon.MinimumWidth = 6;
            this.SoLuongTon.Name = "SoLuongTon";
            this.SoLuongTon.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(901, 676);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tổng số lượng tồn";
            // 
            // btn_TongLuongTon
            // 
            this.btn_TongLuongTon.Location = new System.Drawing.Point(1125, 674);
            this.btn_TongLuongTon.Name = "btn_TongLuongTon";
            this.btn_TongLuongTon.Size = new System.Drawing.Size(127, 22);
            this.btn_TongLuongTon.TabIndex = 9;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1330, 717);
            this.Controls.Add(this.btn_TongLuongTon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_XemKetQua);
            this.Controls.Add(this.txt_ChonNam);
            this.Controls.Add(this.label1);
            this.Name = "form1";
            this.Text = "Báo cáo số lượng hàng tồn kho";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.Button btn_XemKetQua;
        private System.Windows.Forms.TextBox txt_ChonNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox btn_TongLuongTon;
    }
}

