using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class NhanVienDAL
    {
        private static NhanVienDAL instance;

        public static NhanVienDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAL();
                return NhanVienDAL.instance;
            }
        }

        private NhanVienDAL() { }
        public bool CheckLogin(NhanVien nhanVien)
        {
            string query = "Proc_DangNhap @TenDangNhap , @MatKhau";
            DataTable result = new DataTable();
            try
            {
                result = DataProvider.Instance.ExecuteQuery(query, new object[] { nhanVien.TenDangNhap, nhanVien.MatKhau });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result.Rows.Count > 0;
        }
        public DataTable GetAccountByUserName(string tendangnhap)
        {
            string query = "Proc_LayNhanVienTheoTenDangNhap @TenDangNhap";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { tendangnhap });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ChangePassWord(string tenDangNhap, string matKhauCu, string matKhauMoi)
        {
            string query = "Proc_DoiMatKhau @tenDangNhap , @matKhauCu , @matKhauMoi";
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { tenDangNhap, matKhauCu, matKhauMoi });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }



    }
}
