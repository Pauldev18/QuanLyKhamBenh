using System.Data;

namespace DTO
{
    public class BenhNhan
    {
        public int MaBN { get; set; }
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }

        public string Email { get; set; }
        public string Sdt { get; set; }
        public BenhNhan()
        {

        }

        public BenhNhan(int maBN, string hoTen, int namSinh, string gioiTinh, string diaChi, string email, string sdt)
        {
            MaBN = maBN;
            HoTen = hoTen;
            NamSinh = namSinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            Email = email;
            Sdt = sdt;
        }

        public BenhNhan( string hoTen, int namSinh, string gioiTinh, string diaChi, string email, string sdt)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            Email = email;
            Sdt = sdt;
        }

        public BenhNhan(DataRow row)
        {
            this.MaBN = (int)row["MaBN"];
            this.HoTen = row["HoTen"].ToString();
            this.NamSinh = (int)row["NamSinh"];
            this.GioiTinh = row["GioiTinh"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.Email = row["Email"].ToString();
            this.Sdt = row["SDT"].ToString();
        }
    }
}
