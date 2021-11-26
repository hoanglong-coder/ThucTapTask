using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.Data;

namespace TASK.Application.MChart
{
    public class ChartService : IChartService
    {
        private readonly TaskDbContext _taskDbContext;

        public ChartService(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }

        public async Task<List<ChartDashboard>> GetChartDashboards(Guid MaUser, int MaDuAn)
        {
            if (!KiemTraAdmin(MaUser))
            {
                ChartDashboard chartDashboard = new ChartDashboard();

                List<ChartDashboard> chartDashboards = chartDashboard.DataTemp();

                await Task.Delay(400);

                return chartDashboards;
            }
            else
            {
                ChartDashboard chartDashboard = new ChartDashboard();

                List<ChartDashboard> chartDashboards = chartDashboard.DataTemp();

                await Task.Delay(400);

                return chartDashboards;
            }
        }
        public bool KiemTraAdmin(Guid UserId)
        {
            var check = _taskDbContext.Users.Where(t => t.MaUser == UserId).SingleOrDefault();

            if (check.MaQuyenHeThong == 1)
            {
                return true;
            }
            return false;
        }
    }
}
