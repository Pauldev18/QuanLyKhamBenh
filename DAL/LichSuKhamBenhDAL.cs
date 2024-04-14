using System;
using System.Data;
using System.Collections.Generic;
using DTO;

namespace DAL
{
    public class LichSuKhamBenhDAL
    {
        private static LichSuKhamBenhDAL instance;

        public static LichSuKhamBenhDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new LichSuKhamBenhDAL();
                return LichSuKhamBenhDAL.instance;
            }
        }

        public DataTable GetAllAccount()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("Proc_LayTatCaDSTaiKhoan");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public DataTable LayDSChoKham()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("Proc_LayDSChoKham");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable LayDSGoiKham()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("Proc_LayDSGoiKham");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public bool XoaSoCho(int stt)
        {
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery("Proc_XoaSoCho @stt", new object[] { stt });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public int LaySoChoLonNhatTrongNgay()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("Proc_LaySoChoLonNhatTrongNgay");
            }
            catch
            {
                return 1;
            }
        }

        public bool Insert(LichSuKhamBenh lskb, NhanVien taikhoan)
        {
            string query = string.Format("Proc_ThemLSKB @mabn , @stt , @manhanvien");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { lskb.MaBN,lskb.SoThuTu, taikhoan.MaNhanVien });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool GoiKham(int maKhamBenh)
        {
            string query = string.Format("Proc_GoiKham @maKhamBenh");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { maKhamBenh });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }



    }
}
