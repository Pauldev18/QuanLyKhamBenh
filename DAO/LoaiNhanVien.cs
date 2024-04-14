using System.Data;

namespace DTO
{
    public class LoaiNhanVien
    {
        public int MaLoaiNV { get; set; }
        public string TenLoaiNV { get; set; }

        public LoaiNhanVien() { }

        public LoaiNhanVien(int MaLoaiNV, string TenLoaiNV)
        {
            this.MaLoaiNV = MaLoaiNV;
            this.TenLoaiNV = TenLoaiNV;
        }

        public LoaiNhanVien(DataRow row)
        {
            this.MaLoaiNV = (int)row["MaLoaiNV"];
            this.TenLoaiNV = row["TenLoaiNV"].ToString();
        }
    }
}
