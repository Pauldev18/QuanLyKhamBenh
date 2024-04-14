using System;
using System.Collections.Generic;
using System.Data;

using DTO;

namespace DAL
{
    public class BenhNhanDAL
    {
        private static BenhNhanDAL instance;
        public static BenhNhanDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new BenhNhanDAL();
                return instance;
            }
        }

        private BenhNhanDAL() { }

        //lay danh sach tat ca cac ban
        public DataTable LayTatCaDSBenhNhan()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("Proc_LayTatCaDSBenhNhan");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable LayDSLichSuKhamBenh(int mabn)
        {
            string query = "Proc_LayDSLichSuKhamBenh @mabn";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { mabn });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool KiemTraDangKyKham(int mabn)
        {
            string query = "Proc_KiemTraDangKyKham @mabn";
            DataTable result = new DataTable();
            try
            {
                result = DataProvider.Instance.ExecuteQuery(query, new object[] { mabn});
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result.Rows.Count > 0;
        }


        public bool Insert(BenhNhan benhNhan)
        {
            string query = string.Format("Proc_ThemBenhNhan @hoTen , @namSinh , @gioiTinh , @diaChi , @sdt , @email");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { benhNhan.HoTen, benhNhan.NamSinh, benhNhan.GioiTinh,
                        benhNhan.DiaChi, benhNhan.Sdt,benhNhan.Email });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool Update(BenhNhan benhNhan)
        {
            string query = string.Format("Proc_SuaBenhNhan @mabn , @hoTen , @namSinh , @gioiTinh , @diaChi , @sdt , @email");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { benhNhan.MaBN,benhNhan.HoTen,benhNhan.NamSinh,benhNhan.GioiTinh,
                        benhNhan.DiaChi,benhNhan.Sdt,benhNhan.Email });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

  

    }
}
