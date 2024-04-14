using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
    public class PhieuKhamBenhDAL
    {
        private static PhieuKhamBenhDAL instance;

        public static PhieuKhamBenhDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuKhamBenhDAL();
                return PhieuKhamBenhDAL.instance;
            }
        }

        private PhieuKhamBenhDAL() { }


        public bool Insert(PhieuKhamBenh pkb)
        {
            string query = string.Format("Proc_ThemPhieuKhamBenh @maKhamBenh , @maBacSi , @TienSuBenh , @TrieuChung , @chandoan , @ghichu , @keHoachDieuTri , @thoiGianDieuTri ");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { pkb.MaKhamBenh,pkb.MaBacSi,pkb.TienSuBenh,pkb.TrieuChung,
                        pkb.ChanDoan,pkb.GhiChu,pkb.KeHoachDieuTri,pkb.ThoiGianDieuTri });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

       
    }
}
