using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKeDAL
    {
        private static ThongKeDAL instance;

        public static ThongKeDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongKeDAL();
                return ThongKeDAL.instance;
            }
        }
        public DataTable thongke(string nam)
        {
            string query = "SELECT MONTH(ThoiGian) AS Thang, SUM(ChiPhi) AS DoanhThu " +
                            "FROM PHIEUTHU " +
                            "WHERE YEAR(ThoiGian) = @Year " +
                            "GROUP BY MONTH(ThoiGian)";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { nam });
            return dt;
        }
    }
}
