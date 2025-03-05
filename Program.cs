using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaoCaoSoLuongHangTonKho;
using CMU_CS447_BrosHood;
using HoaDon2;
using MSM_Project;
using PhieuNhap;
using ThongTinPhieuNhap;
using TimKiemKhachHang;
using WindowsForms;

namespace CS464_BrosHood
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Danhmuc());
            //Application.Run(new frm_Dangnhap());
            //Application.Run(new frm_Dangky());
            //Application.Run(new frm_phanQuyen());
            //Application.Run(new frm_PhieuNhap());
            //Application.Run(new frm_Baocaobanhang());
            //Application.Run(new frm_HoaDon());
            //Application.Run(new frm_ThongTinPhieuNhap());
            //Application.Run(new frm_TimKiemKhachHang());
            //Application.Run(new frm_Trangchu());
            //Application.Run(new frm_Quanlyhanghoa());
            //Application.Run(new frm_Quanlykhachhang());
            //Application.Run(new frm_Quanlynhacungcap());
            //Application.Run(new frm_Quanlykhachhang());
            //Application.Run(new frm_Baocaotonkho());


        }
    }
}
