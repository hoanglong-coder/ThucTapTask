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
    }
}
