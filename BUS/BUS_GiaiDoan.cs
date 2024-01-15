using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_GiaiDoan
    {
        private readonly DAL_GiaiDoan dal_gd = new DAL_GiaiDoan();

        public DataTable LoadGD()
        {
            return dal_gd.LoadData();
        }

        public DataTable LoadGD(string sql)
        {
            return dal_gd.LoadData(sql);
        }

        public DataTable LoadGD(string sql, SqlParameter[] parameters) { 
            return dal_gd.LoadData(sql, parameters);
        }

        public void Insert(GiaiDoanDA gd)
        {
            dal_gd.Insert(gd);
        }

        public void Update(GiaiDoanDA gd)
        {
            dal_gd.Update(gd);
        }

        public void Delete(GiaiDoanDA gd)
        {
            dal_gd.Delete(gd);
        }
    }
}
