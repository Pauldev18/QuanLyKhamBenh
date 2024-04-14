using System.Data;
using System;

namespace DTO
{
    public class PhieuKhamBenh
    {
        public int MaKhamBenh { get; set; }
        public int MaHoaDon { get; set; }
        public DateTime ThoiGian { get; set; }
        public string MaBacSi { get; set; }
        public string TienSuBenh { get; set; }
        public string TrieuChung { get; set; }
        public string ChanDoan { get; set; }
        public string GhiChu { get; set; }
        public string KeHoachDieuTri { get; set; }
        public string ThoiGianDieuTri { get; set; }


        public PhieuKhamBenh(DataRow row)
        {
            this.MaKhamBenh = (int)row["MaKhamBenh"];
            this.ThoiGian = (DateTime)row["ThoiGian"];

            this.MaHoaDon = (int)row["MaHoaDon"];
            this.MaBacSi = row["MaBacSi"].ToString();
            this.TienSuBenh = row["TienSuBenh"].ToString();
            this.TrieuChung = row["TrieuChung"].ToString();
            this.ChanDoan = row["ChanDoan"].ToString();
            this.GhiChu = row["GhiChu"].ToString();
        }

     

        public PhieuKhamBenh(int maKhamBenh, string maBacSi, string tienSuBenh, string trieuChung, string chanDoan, 
            string ghiChu, string keHoachDieuTri, string thoiGianDieuTri)
        {
            MaKhamBenh = maKhamBenh;
         
            MaBacSi = maBacSi;
            TienSuBenh = tienSuBenh;
            TrieuChung = trieuChung;
            ChanDoan = chanDoan;
            GhiChu = ghiChu;
            KeHoachDieuTri = keHoachDieuTri;
            ThoiGianDieuTri = thoiGianDieuTri;
        }
    }
}
