using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MChart
{
    public interface IChartService
    {
        Task<List<ChartDashboard>> GetChartDashboards(Guid MaUser, int MaDuAn);

        Task<List<ChartBaoCaoHieuSuatSoGioLam>> GetChartSoGioLam(int MaDuAn,int MaThangLamViec);

        Task<List<ChartBaoCaoHieuSuatTrungbinhthang>> GetChartTrungBinhThang(int MaDuAn, int MaThangLamViec);

        Task<List<NhanXet>> getnhanxet(int MaDuAn, int MaThangLamViec);

        Task<List<ChitietNhanXet>> getchitietnhanxet(int MaDuAn, int MaThangLamViec);
    }
}
