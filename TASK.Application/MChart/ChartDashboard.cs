using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MChart
{
    public class ChartDashboard
    {
        public Guid MaChart { get; set; }

        public string NameUser { get; set; }

        public int MucDoHoanThanh { get; set; }


        public List<ChartDashboard> DataTemp()
        {
            List<ChartDashboard> chartDashboards = new List<ChartDashboard>();

            for (int i = 0; i < 7; i++)
            {
                ChartDashboard chartDashboard = new ChartDashboard();

                chartDashboard.MaChart = Guid.NewGuid();
                chartDashboard.NameUser = "Nhân viên " + i+1;
                chartDashboard.MucDoHoanThanh = new Random().Next(50, 100);
                chartDashboards.Add(chartDashboard);
            }
            return chartDashboards;
        }




    }
}
