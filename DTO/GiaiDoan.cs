using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaiDoanDA
    {
        public string MaDA { get; set; }
        public int SoGD { get; set; }
        public string TenGD { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }

        public GiaiDoanDA()
        {
        }

        public GiaiDoanDA(string maDA, int soGD, string tenGD, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            MaDA = maDA;
            SoGD = soGD;
            TenGD = tenGD;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
        }
    }
}
