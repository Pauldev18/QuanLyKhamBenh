using System;
using System.Collections.Generic;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class LoaiNhanVienBLL
    {
        private static LoaiNhanVienBLL instance;

        public static LoaiNhanVienBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiNhanVienBLL();
                return LoaiNhanVienBLL.instance;
            }
        }
        public DataTable GetAllAccountType()
        {
            try
            {
                return LoaiNhanVienDAL.Instance.GetAllAccountType();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
