using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MChart
{
    public class ChartBaoCaoHieuSuatSoGioLam
    {
        public Guid MaUser { get; set; }

        public string TenUser { get; set; }

        public int SoGiolam { get; set; }

    }

    public class ChartBaoCaoHieuSuatTrungbinhthang
    {
        public Guid MaUser { get; set; }

        public string TenUser { get; set; }

        public int PhanTramLamViec { get; set; }
    }
}
