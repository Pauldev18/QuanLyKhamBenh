using System;
using System.Data;
namespace DTO
{
    public class LichSuKhamBenh
    {
        public int MaKhamBenh { get; set; }
        public int MaBN { get; set; }
       
        public DateTime ThoiGian { get; set; }
        public int SoThuTu { get; set; }
        public string TrangThai { get; set; }
        public string HoTen { get; set; }

        public LichSuKhamBenh() { }
        public LichSuKhamBenh(int maKhamBenh, int maBN,  DateTime thoiGian, int soThuTu, string trangThai)
        {
            MaKhamBenh = maKhamBenh;
            MaBN = maBN;
            ThoiGian = thoiGian;
            SoThuTu = soThuTu;
            TrangThai = trangThai;
        }

        public LichSuKhamBenh(int maKhamBenh, int maBN, DateTime thoiGian, int soThuTu, string trangThai,string hoTen)
        {
            MaKhamBenh = maKhamBenh;
            MaBN = maBN;
            ThoiGian = thoiGian;
            SoThuTu = soThuTu;
            TrangThai = trangThai;
            HoTen = hoTen;
        }


        public LichSuKhamBenh(int maBN, int soThuTu)
        {
            MaBN = maBN;
            SoThuTu = soThuTu;
        }

        public LichSuKhamBenh(DataRow row)
        {
            this.MaKhamBenh = (int)row["MaKhamBenh"];
            this.MaBN = (int)row["MaBN"];
            this.ThoiGian = (DateTime)row["ThoiGian"];
            this.SoThuTu = (int)row["SoThuTu"];
            this.TrangThai = row["TrangThai"].ToString();
        }
    }
}
