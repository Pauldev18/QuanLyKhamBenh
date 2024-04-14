using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class NhanVienBLL
    {
        private static NhanVienBLL instance;

        public static NhanVienBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienBLL();
                return NhanVienBLL.instance;
            }
        }

        private NhanVienBLL() { }

        public bool CheckLogin(NhanVien nhanVien)
        {
            if (nhanVien.TenDangNhap == "")
                return false;
            if (nhanVien.MatKhau == "")
                return false;

            try
            {
                return NhanVienDAL.Instance.CheckLogin(nhanVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public NhanVien GetAccountByUserName(string tendangnhap)
        {
            DataTable table;
            try
            {
                table = NhanVienDAL.Instance.GetAccountByUserName(tendangnhap);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return new NhanVien(table.Rows[0]);
        }

        public bool ChangePassWord(string tenDangNhap, string matKhauCu, string matKhauMoi)
        {
            try
            {
                return NhanVienDAL.Instance.ChangePassWord(tenDangNhap, matKhauCu, matKhauMoi);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
