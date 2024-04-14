using DAL;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CapCuuBLL
    {
        private static CapCuuBLL instance;
        public static CapCuuBLL Instance
        {
            get
            {
                if(instance == null)
                    instance = new CapCuuBLL();
                return instance;
            }
        }
        public CapCuuBLL() { }
        public bool Insert(BenhNhanCapCuu benhNhanCC)
        {
            try
            {
                return CapCuuDAL.Instance.InsertBenhNhanCapCuu(benhNhanCC);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
