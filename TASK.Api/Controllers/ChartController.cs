using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MChart;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TASK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartController : ControllerBase
    {
        private readonly IChartService chartService;

        public ChartController(IChartService chartService)
        {
            this.chartService = chartService;
        }

        // GET api/<ChartController>/5
        [HttpGet("chartDashboard")]
        public async Task<IActionResult> GetChartDashboard(int maduan, Guid mauser)
        {
            var chart = await chartService.GetChartDashboards(mauser,maduan);
            return Ok(chart);
        }

        [HttpGet("GetXepLoai")]
        public async Task<IActionResult> GetXepLoai(int MaDuAn, int MaThangLamViec)
        {
            var chart = await chartService.getnhanxet(MaDuAn, MaThangLamViec);
            return Ok(chart);
        }

        [HttpGet("GetSoGioLam")]
        public async Task<IActionResult>  GetSoGioLam(int MaDuAn, int MaThangLamViec)
        {
            var chart = await chartService.GetChartSoGioLam(MaDuAn, MaThangLamViec);
            return Ok(chart);
        }
        [HttpGet("GetTBPhanTram")]
        public async Task<IActionResult> GetTBPhanTram(int MaDuAn, int MaThangLamViec)
        {
            var chart = await chartService.GetChartTrungBinhThang(MaDuAn, MaThangLamViec);
            return Ok(chart);
        }
    }
}
