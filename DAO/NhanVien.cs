using System;
using System.Data;
namespace DTO
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string TenDangNhap { get; set; }

        public string MatKhau { get; set; }
        public int MaLoaiNV { get; set; }

        public NhanVien() { }

        public NhanVien(string maNhanVien, string hoTen, DateTime ngaySinh, string gioiTinh, string tenDangNhap, string matKhau, int maLoaiNV)
        {
            MaNhanVien = maNhanVien;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            MaLoaiNV = maLoaiNV;
        }
        public NhanVien(string tenDangNhap, string matKhau)
        {
            this.TenDangNhap = tenDangNhap;
            this.MatKhau = matKhau;
        }
        public NhanVien(DataRow row)
        {
            this.TenDangNhap = row["TenDangNhap"].ToString();
            this.MaNhanVien = row["MaNhanVien"].ToString();
            this.MaLoaiNV = (int)row["MaLoaiNV"];
            this.MatKhau = row["MatKhau"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.NgaySinh = (DateTime) row["NgaySinh"];
        }
    }
}
