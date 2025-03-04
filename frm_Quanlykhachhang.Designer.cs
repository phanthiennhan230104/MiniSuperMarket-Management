namespace WindowsForms
{
    partial class frm_Quanlykhachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Quanlykhachhang));
            this.cb_Nu = new System.Windows.Forms.CheckBox();
            this.cb_Nam = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_sotaikhoan = new System.Windows.Forms.TextBox();
            this.txt_socmnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ColumnTennhomhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ColumnMahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDonvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_masothue = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_tenkhachhang = new System.Windows.Forms.TextBox();
            this.txt_makhachhang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.ColumnMasothue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ColumnThanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_Quanly = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel7.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Nu
            // 
            this.cb_Nu.AutoSize = true;
            this.cb_Nu.Location = new System.Drawing.Point(314, 145);
            this.cb_Nu.Name = "cb_Nu";
            this.cb_Nu.Size = new System.Drawing.Size(46, 20);
            this.cb_Nu.TabIndex = 48;
            this.cb_Nu.Text = "Nữ";
            this.cb_Nu.UseVisualStyleBackColor = true;
            // 
            // cb_Nam
            // 
            this.cb_Nam.AutoSize = true;
            this.cb_Nam.Location = new System.Drawing.Point(196, 142);
            this.cb_Nam.Name = "cb_Nam";
            this.cb_Nam.Size = new System.Drawing.Size(58, 20);
            this.cb_Nam.TabIndex = 47;
            this.cb_Nam.Text = "Nam";
            this.cb_Nam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Giới tính";
            // 
            // txt_sotaikhoan
            // 
            this.txt_sotaikhoan.Location = new System.Drawing.Point(983, 21);
            this.txt_sotaikhoan.Name = "txt_sotaikhoan";
            this.txt_sotaikhoan.Size = new System.Drawing.Size(152, 22);
            this.txt_sotaikhoan.TabIndex = 45;
            // 
            // txt_socmnd
            // 
            this.txt_socmnd.Location = new System.Drawing.Point(603, 144);
            this.txt_socmnd.Name = "txt_socmnd";
            this.txt_socmnd.Size = new System.Drawing.Size(161, 22);
            this.txt_socmnd.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Số CMND";
            // 
            // ColumnTennhomhang
            // 
            this.ColumnTennhomhang.HeaderText = "MÃ KHÁCH HÀNG";
            this.ColumnTennhomhang.MinimumWidth = 6;
            this.ColumnTennhomhang.Name = "ColumnTennhomhang";
            this.ColumnTennhomhang.Width = 160;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_sua.Location = new System.Drawing.Point(493, 207);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(123, 35);
            this.btn_sua.TabIndex = 30;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_them.Location = new System.Drawing.Point(231, 207);
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
            this.label5.Location = new System.Drawing.Point(500, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "SDT";
            // 
            // ColumnMahang
            // 
            this.ColumnMahang.HeaderText = "TÊN KHÁCH HÀNG";
            this.ColumnMahang.MinimumWidth = 6;
            this.ColumnMahang.Name = "ColumnMahang";
            this.ColumnMahang.Width = 160;
            // 
            // ColumnTenhang
            // 
            this.ColumnTenhang.HeaderText = "GIỚI TÍNH";
            this.ColumnTenhang.MinimumWidth = 6;
            this.ColumnTenhang.Name = "ColumnTenhang";
            this.ColumnTenhang.Width = 160;
            // 
            // ColumnDonvitinh
            // 
            this.ColumnDonvitinh.HeaderText = "ĐỊA CHỈ";
            this.ColumnDonvitinh.MinimumWidth = 6;
            this.ColumnDonvitinh.Name = "ColumnDonvitinh";
            this.ColumnDonvitinh.Width = 160;
            // 
            // ColumnDongia
            // 
            this.ColumnDongia.HeaderText = "SỐ ĐIỆN THOẠI";
            this.ColumnDongia.MinimumWidth = 6;
            this.ColumnDongia.Name = "ColumnDongia";
            this.ColumnDongia.Width = 160;
            // 
            // ColumnVAT
            // 
            this.ColumnVAT.HeaderText = "SỐ CMND";
            this.ColumnVAT.MinimumWidth = 6;
            this.ColumnVAT.Name = "ColumnVAT";
            this.ColumnVAT.Width = 160;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(854, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Số Tài Khoản";
            // 
            // txt_masothue
            // 
            this.txt_masothue.Location = new System.Drawing.Point(983, 86);
            this.txt_masothue.Name = "txt_masothue";
            this.txt_masothue.Size = new System.Drawing.Size(152, 22);
            this.txt_masothue.TabIndex = 40;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(603, 86);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(161, 22);
            this.txt_sdt.TabIndex = 39;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(603, 19);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(161, 22);
            this.txt_diachi.TabIndex = 38;
            // 
            // txt_tenkhachhang
            // 
            this.txt_tenkhachhang.Location = new System.Drawing.Point(196, 84);
            this.txt_tenkhachhang.Name = "txt_tenkhachhang";
            this.txt_tenkhachhang.Size = new System.Drawing.Size(160, 22);
            this.txt_tenkhachhang.TabIndex = 37;
            // 
            // txt_makhachhang
            // 
            this.txt_makhachhang.Location = new System.Drawing.Point(196, 21);
            this.txt_makhachhang.Name = "txt_makhachhang";
            this.txt_makhachhang.Size = new System.Drawing.Size(160, 22);
            this.txt_makhachhang.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(854, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Mã Số Thuế";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Red;
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(754, 207);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(123, 35);
            this.btn_xoa.TabIndex = 31;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // ColumnMasothue
            // 
            this.ColumnMasothue.HeaderText = "MÃ SỐ THUẾ";
            this.ColumnMasothue.MinimumWidth = 6;
            this.ColumnMasothue.Name = "ColumnMasothue";
            this.ColumnMasothue.Width = 163;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Địa chỉ";
            // 
            // ColumnThanhtien
            // 
            this.ColumnThanhtien.HeaderText = "SỐ TÀI KHOẢN";
            this.ColumnThanhtien.MinimumWidth = 6;
            this.ColumnThanhtien.Name = "ColumnThanhtien";
            this.ColumnThanhtien.Width = 160;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.cb_Nu);
            this.panel7.Controls.Add(this.cb_Nam);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.txt_sotaikhoan);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.txt_socmnd);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.txt_masothue);
            this.panel7.Controls.Add(this.txt_sdt);
            this.panel7.Controls.Add(this.txt_diachi);
            this.panel7.Controls.Add(this.txt_tenkhachhang);
            this.panel7.Controls.Add(this.txt_makhachhang);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.btn_xoa);
            this.panel7.Controls.Add(this.btn_sua);
            this.panel7.Controls.Add(this.btn_them);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(1, 47);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1329, 260);
            this.panel7.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã khách hàng";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
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
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Quanly,
            this.toolStripSeparator1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(3);
            this.toolStrip2.Size = new System.Drawing.Size(1329, 38);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel8.Controls.Add(this.toolStrip2);
            this.panel8.Location = new System.Drawing.Point(1, 8);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1329, 33);
            this.panel8.TabIndex = 11;
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
            this.ColumnThanhtien,
            this.ColumnMasothue});
            this.dataGridView1.Location = new System.Drawing.Point(1, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1329, 396);
            this.dataGridView1.TabIndex = 12;
            // 
            // frm_Quanlykhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 717);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_Quanlykhachhang";
            this.Text = "Quản lý khách hàng";
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_Nu;
        private System.Windows.Forms.CheckBox cb_Nam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_sotaikhoan;
        private System.Windows.Forms.TextBox txt_socmnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTennhomhang;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDonvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVAT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_masothue;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_tenkhachhang;
        private System.Windows.Forms.TextBox txt_makhachhang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMasothue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnThanhtien;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ts_Quanly;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}