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
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
