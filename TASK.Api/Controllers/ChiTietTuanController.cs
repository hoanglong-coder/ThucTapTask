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

        // DELETE api/<ChiTietTuanController>/5
        [HttpPost("DeleteChitiet")]
        public async Task<IActionResult> DeleteChitiettuan([FromBody] List<ChiTietTuanRequest> chiTietTuans)
        {
            var check = await chiTietTuanService.DeleteChiTietTuan(chiTietTuans);

            if (check != 1)
            {
                return Ok(2);
            }
            return Ok(check);
        }

        // DELETE api/<ChiTietTuanController>/5
        [HttpDelete("DeleteChitietAll/{id}")]
        public async Task<IActionResult> DeleteAll(int id)
        {
            var check = await chiTietTuanService.DeleteChiTietTuanAll(id);

            if (check != 1)
            {
                return BadRequest();
            }
            return Ok(check);
        }
    }
}
