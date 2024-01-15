using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class DAL_GiaiDoan: Connect
    {

        public DataTable LoadData()
        {
            string sql = "select * from GIAIDOAN_DA";
            return Load(sql);
        }

        public DataTable LoadData(string sql)
        {
            return Load(sql);
        }

        public DataTable LoadData(string sql, SqlParameter[] parameters)
        {
            return Load(sql, parameters);
        }

        public void Insert(GiaiDoanDA gd)
        {
            string sql = "insert into GIAIDOAN_DA values(@MaDA, @SoGD, @TenGD, @NgayBatDau, @NgayKetThuc)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaDA", gd.MaDA),
                new SqlParameter("@SoGD", gd.SoGD),
                new SqlParameter("@TenGD", gd.TenGD),
                new SqlParameter("@NgayBatDau", gd.NgayBatDau),
                new SqlParameter("@NgayKetThuc", gd.NgayKetThuc)
            };
            Execute(sql, parameters);
        }

        public void Update(GiaiDoanDA gd)
        {
            string sql = "update GIAIDOAN_DA set SOGDOAN = @SoGD, TEN_GD = @TenGD, NGAY_BD = @NgayBatDau, NGAY_KT = @NgayKetThuc where MA_DA = @MaDA";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaDA", gd.MaDA),
                new SqlParameter("@SoGD", gd.SoGD),
                new SqlParameter("@TenGD", gd.TenGD),
                new SqlParameter("@NgayBatDau", gd.NgayBatDau),
                new SqlParameter("@NgayKetThuc", gd.NgayKetThuc)
            };
            Execute(sql, parameters);
        }

        public void Delete(GiaiDoanDA gd)
        {
            string sql = "delete GIAIDOAN_DA where MA_DA = @MaDA";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaDA", gd.MaDA)
            };
            Execute(sql, parameters);
        }
    }
}
