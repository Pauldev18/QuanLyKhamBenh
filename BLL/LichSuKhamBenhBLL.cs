using System;
using System.Data;
using System.Collections.Generic;
using DTO;
using DAL;

namespace BLL
{
    public class LichSuKhamBenhBLL
    {
        private static LichSuKhamBenhBLL instance;
        public static LichSuKhamBenhBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new LichSuKhamBenhBLL();
                return instance;
            }
        }
        private LichSuKhamBenhBLL() { }

        public DataTable LayDSChoKham()
        {
            try
            {
                return LichSuKhamBenhDAL.Instance.LayDSChoKham();
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
                return LichSuKhamBenhDAL.Instance.LayDSGoiKham();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool XoaSoCho(int stt)
        {
            try
            {
                return LichSuKhamBenhDAL.Instance.XoaSoCho(stt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int LaySoChoLonNhatTrongNgay()
        {
            try
            {
                return LichSuKhamBenhDAL.Instance.LaySoChoLonNhatTrongNgay();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Insert(LichSuKhamBenh lskb, NhanVien taikhoan)
        {
            try
            {
                return LichSuKhamBenhDAL.Instance.Insert(lskb,taikhoan);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool GoiKham(int maKhamBenh)
        {
            try
            {
                return LichSuKhamBenhDAL.Instance.GoiKham(maKhamBenh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
