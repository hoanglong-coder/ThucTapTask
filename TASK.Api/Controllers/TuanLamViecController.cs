using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MTuanLamViec;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TASK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TuanLamViecController : ControllerBase
    {

        private readonly ITuanLamViecService tuanLamViecService;

        public TuanLamViecController(ITuanLamViecService tuanLamViecService)
        {
            this.tuanLamViecService = tuanLamViecService;
        }

        // GET: api/<TuanLamViecController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TuanLamViecController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {

            var lstTuanLamViec = await tuanLamViecService.GetTuanLamViecByDuAn(id);

            await Task.Delay(1000);

            return Ok(lstTuanLamViec);

        }

        // POST api/<TuanLamViecController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TuanLamViecRequest tuanLamViec)
        {
            var MaTuanLamViec = await tuanLamViecService.InsertTuanLamViec(tuanLamViec);
            if (MaTuanLamViec == 0)
            {
                return BadRequest();
            }else
            {
                return Ok(MaTuanLamViec);
            }    
        }

        // PUT api/<TuanLamViecController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TuanLamViecController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
