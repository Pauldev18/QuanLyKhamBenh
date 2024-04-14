using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class PhieuKhamBenhBLL
    {
        private static PhieuKhamBenhBLL instance;

        public static PhieuKhamBenhBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuKhamBenhBLL();
                return PhieuKhamBenhBLL.instance;
            }
        }

        private PhieuKhamBenhBLL() { }

      
        public bool Insert(PhieuKhamBenh pkb)
        {
            try
            {
                return PhieuKhamBenhDAL.Instance.Insert(pkb);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


      
    }
}
