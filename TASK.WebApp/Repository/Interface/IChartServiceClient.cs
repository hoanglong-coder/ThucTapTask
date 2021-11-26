using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MChart;

namespace TASK.WebApp.Repository.Interface
{
    public interface IChartServiceClient
    {
        Task<List<ChartDashboard>> GetChartDashboards(Guid MaUser, int MaDuAn);
    }
}
