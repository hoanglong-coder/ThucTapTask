using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MChiTietTuan;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TASK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChiTietTuanController : ControllerBase
    {

        private readonly IChiTietTuanService chiTietTuanService;

        public ChiTietTuanController(IChiTietTuanService chiTietTuanService)
        {
            this.chiTietTuanService = chiTietTuanService;
        }

        // GET: api/<ChiTietTuanController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ChiTietTuanController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var lstChitiettuan = await chiTietTuanService.GetChiTietTuanByTuanLamViec(id);

            return Ok(lstChitiettuan);
        }

        // POST api/<ChiTietTuanController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] List<ChiTietTuanRequest> chiTietTuans)
        {
            if (!await chiTietTuanService.InsertListChiTietTuan(chiTietTuans))
            {
                return BadRequest();
            }else
            {
                return Ok(1);
            }    
        }

        // PUT api/<ChiTietTuanController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ChiTietTuanController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
