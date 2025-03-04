namespace WindowsForms
{
    partial class frm_Quanlyhanghoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Quanlyhanghoa));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnTennhomhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDonvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnThanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ts_Quanly = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_Nhapkho = new System.Windows.Forms.ToolStripButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_xemtatca = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.txt_donvitinh = new System.Windows.Forms.TextBox();
            this.txt_tenhang = new System.Windows.Forms.TextBox();
            this.txt_mahang = new System.Windows.Forms.TextBox();
            this.cb_thũeuat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_chitietmoi = new System.Windows.Forms.Button();
            this.cb_nhomhang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel8.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTennhomhang,
            this.ColumnMahang,
            this.ColumnTenhang,
            this.ColumnDonvitinh,
            this.ColumnDongia,
            this.ColumnVAT,
            this.ColumnThanhtien});
            this.dataGridView1.Location = new System.Drawing.Point(1, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1329, 460);
            this.dataGridView1.TabIndex = 9;
            // 
            // ColumnTennhomhang
            // 
            this.ColumnTennhomhang.HeaderText = "TÊN NHÓM HÀNG";
            this.ColumnTennhomhang.MinimumWidth = 6;
            this.ColumnTennhomhang.Name = "ColumnTennhomhang";
            this.ColumnTennhomhang.Width = 185;
            // 
            // ColumnMahang
            // 
            this.ColumnMahang.HeaderText = "MÃ HÀNG";
            this.ColumnMahang.MinimumWidth = 6;
            this.ColumnMahang.Name = "ColumnMahang";
            this.ColumnMahang.Width = 185;
            // 
            // ColumnTenhang
            // 
            this.ColumnTenhang.HeaderText = "TÊN HÀNG";
            this.ColumnTenhang.MinimumWidth = 6;
            this.ColumnTenhang.Name = "ColumnTenhang";
            this.ColumnTenhang.Width = 185;
            // 
            // ColumnDonvitinh
            // 
            this.ColumnDonvitinh.HeaderText = "ĐƠN VỊ TÍNH";
            this.ColumnDonvitinh.MinimumWidth = 6;
            this.ColumnDonvitinh.Name = "ColumnDonvitinh";
            this.ColumnDonvitinh.Width = 185;
            // 
            // ColumnDongia
            // 
            this.ColumnDongia.HeaderText = "ĐƠN GIÁ";
            this.ColumnDongia.MinimumWidth = 6;
            this.ColumnDongia.Name = "ColumnDongia";
            this.ColumnDongia.Width = 185;
            // 
            // ColumnVAT
            // 
            this.ColumnVAT.HeaderText = "VAT";
            this.ColumnVAT.MinimumWidth = 6;
            this.ColumnVAT.Name = "ColumnVAT";
            this.ColumnVAT.Width = 185;
            // 
            // ColumnThanhtien
            // 
            this.ColumnThanhtien.HeaderText = "THANHTIEN";
            this.ColumnThanhtien.MinimumWidth = 6;
            this.ColumnThanhtien.Name = "ColumnThanhtien";
            this.ColumnThanhtien.Width = 185;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel8.Controls.Add(this.toolStrip2);
            this.panel8.Location = new System.Drawing.Point(1, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1329, 33);
            this.panel8.TabIndex = 8;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Quanly,
            this.toolStripSeparator1,
            this.ts_Nhapkho});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(3);
            this.toolStrip2.Size = new System.Drawing.Size(1329, 38);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // ts_Quanly
            // 
            this.ts_Quanly.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_Quanly.Image = ((System.Drawing.Image)(resources.GetObject("ts_Quanly.Image")));
            this.ts_Quanly.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Quanly.Name = "ts_Quanly";
            this.ts_Quanly.Size = new System.Drawing.Size(221, 29);
            this.ts_Quanly.Text = "Thông tin nhóm hàng";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // ts_Nhapkho
            // 
            this.ts_Nhapkho.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_Nhapkho.Image = ((System.Drawing.Image)(resources.GetObject("ts_Nhapkho.Image")));
            this.ts_Nhapkho.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Nhapkho.Name = "ts_Nhapkho";
            this.ts_Nhapkho.Size = new System.Drawing.Size(204, 29);
            this.ts_Nhapkho.Text = "Thông tin hàng hóa";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btn_xemtatca);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.txt_thanhtien);
            this.panel7.Controls.Add(this.txt_dongia);
            this.panel7.Controls.Add(this.txt_donvitinh);
            this.panel7.Controls.Add(this.txt_tenhang);
            this.panel7.Controls.Add(this.txt_mahang);
            this.panel7.Controls.Add(this.cb_thũeuat);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.btn_xoa);
            this.panel7.Controls.Add(this.btn_sua);
            this.panel7.Controls.Add(this.btn_them);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(243, 41);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1087, 204);
            this.panel7.TabIndex = 7;
            // 
            // btn_xemtatca
            // 
            this.btn_xemtatca.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_xemtatca.Location = new System.Drawing.Point(715, 138);
            this.btn_xemtatca.Name = "btn_xemtatca";
            this.btn_xemtatca.Size = new System.Drawing.Size(101, 33);
            this.btn_xemtatca.TabIndex = 23;
            this.btn_xemtatca.Text = "Xem tất cả";
            this.btn_xemtatca.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(824, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "%";
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Location = new System.Drawing.Point(773, 86);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(152, 22);
            this.txt_thanhtien.TabIndex = 40;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(434, 86);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(161, 22);
            this.txt_dongia.TabIndex = 39;
            // 
            // txt_donvitinh
            // 
            this.txt_donvitinh.Location = new System.Drawing.Point(434, 19);
            this.txt_donvitinh.Name = "txt_donvitinh";
            this.txt_donvitinh.Size = new System.Drawing.Size(161, 22);
            this.txt_donvitinh.TabIndex = 38;
            // 
            // txt_tenhang
            // 
            this.txt_tenhang.Location = new System.Drawing.Point(131, 88);
            this.txt_tenhang.Name = "txt_tenhang";
            this.txt_tenhang.Size = new System.Drawing.Size(160, 22);
            this.txt_tenhang.TabIndex = 37;
            // 
            // txt_mahang
            // 
            this.txt_mahang.Location = new System.Drawing.Point(131, 21);
            this.txt_mahang.Name = "txt_mahang";
            this.txt_mahang.Size = new System.Drawing.Size(160, 22);
            this.txt_mahang.TabIndex = 36;
            // 
            // cb_thũeuat
            // 
            this.cb_thũeuat.FormattingEnabled = true;
            this.cb_thũeuat.Location = new System.Drawing.Point(762, 17);
            this.cb_thũeuat.Name = "cb_thũeuat";
            this.cb_thũeuat.Size = new System.Drawing.Size(54, 24);
            this.cb_thũeuat.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(658, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Thuế xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(658, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Thành tiền";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Red;
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(521, 136);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(123, 35);
            this.btn_xoa.TabIndex = 31;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_sua.Location = new System.Drawing.Point(333, 136);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(123, 35);
            this.btn_sua.TabIndex = 30;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_them.Location = new System.Drawing.Point(124, 136);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(123, 35);
            this.btn_them.TabIndex = 29;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(340, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tên hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Đơn vị tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã hàng";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btn_lammoi);
            this.panel4.Controls.Add(this.btn_chitietmoi);
            this.panel4.Controls.Add(this.cb_nhomhang);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(1, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(244, 204);
            this.panel4.TabIndex = 6;
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_lammoi.Location = new System.Drawing.Point(135, 116);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(101, 33);
            this.btn_lammoi.TabIndex = 22;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            // 
            // btn_chitietmoi
            // 
            this.btn_chitietmoi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_chitietmoi.Location = new System.Drawing.Point(3, 116);
            this.btn_chitietmoi.Name = "btn_chitietmoi";
            this.btn_chitietmoi.Size = new System.Drawing.Size(101, 33);
            this.btn_chitietmoi.TabIndex = 21;
            this.btn_chitietmoi.Text = "Chi tiết mới";
            this.btn_chitietmoi.UseVisualStyleBackColor = true;
            // 
            // cb_nhomhang
            // 
            this.cb_nhomhang.FormattingEnabled = true;
            this.cb_nhomhang.Location = new System.Drawing.Point(153, 49);
            this.cb_nhomhang.Name = "cb_nhomhang";
            this.cb_nhomhang.Size = new System.Drawing.Size(83, 24);
            this.cb_nhomhang.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Chọn nhóm hàng";
            // 
            // frm_Quanlyhanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 717);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Name = "frm_Quanlyhanghoa";
            this.Text = "Quản lý hàng hóa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTennhomhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDonvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnThanhtien;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton ts_Quanly;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ts_Nhapkho;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_xemtatca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.TextBox txt_donvitinh;
        private System.Windows.Forms.TextBox txt_tenhang;
        private System.Windows.Forms.TextBox txt_mahang;
        private System.Windows.Forms.ComboBox cb_thũeuat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_chitietmoi;
        private System.Windows.Forms.ComboBox cb_nhomhang;
        private System.Windows.Forms.Label label3;
    }
}

