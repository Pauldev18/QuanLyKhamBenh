using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class LoaiNhanVienDAL
    {
        private static LoaiNhanVienDAL instance;

        public static LoaiNhanVienDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiNhanVienDAL();
                return LoaiNhanVienDAL.instance;
            }
        }
        public DataTable GetAllAccountType()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("Proc_LayTatCaDSLoaiNhanVien");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
