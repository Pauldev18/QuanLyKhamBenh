using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongKeBLL
    {
        private static ThongKeBLL instance;

        public static ThongKeBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongKeBLL();
                return instance;
            }
        }
        public ThongKeBLL()
        {

        }
        public DataTable thongke(string nam)
        {
            try
            {
                return ThongKeDAL.Instance.thongke(nam);
            }catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
