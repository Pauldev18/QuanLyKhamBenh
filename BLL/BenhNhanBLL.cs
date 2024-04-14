using System;
using System.Collections.Generic;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class BenhNhanBLL
    {
        private static BenhNhanBLL instance;

        public static BenhNhanBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new BenhNhanBLL();
                return BenhNhanBLL.instance;
            }
        }
        //lấy ds bệnh nhân trả về kiểu datatable
        public DataTable LayTatCaDSBenhNhan()
        {
            try
            {
                return BenhNhanDAL.Instance.LayTatCaDSBenhNhan();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable LayDSLichSuKhamBenh(int mabn)
        {
            try
            {
                return BenhNhanDAL.Instance.LayDSLichSuKhamBenh(mabn);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool KiemTraDangKyKham(int mabn)
        {
            try
            {
                return BenhNhanDAL.Instance.KiemTraDangKyKham(mabn);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //thêm bệnh nhân
        public bool Insert(BenhNhan benhNhan)
        {
            try
            {
                return BenhNhanDAL.Instance.Insert(benhNhan);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //sửa bệnh nhân
        public bool Update(BenhNhan benhNhan)
        {
            try
            {
                return BenhNhanDAL.Instance.Update(benhNhan);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
