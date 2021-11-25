using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MDuAn;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TASK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DuAnController : ControllerBase
    {

        private readonly IDuAnService _duAnService;

        public DuAnController(IDuAnService duAnService)
        {
            _duAnService = duAnService;
        }

        // GET: api/<DuAnController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DuAnController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            await Task.Delay(2000);
            return Ok(await _duAnService.GetDuAnByUser(id));
        }

        // GET api/<DuAnController>/5
        [HttpGet("tenduan/{id}")]
        public IActionResult GetTenDuAn(int id)
        {
            
            return Ok(_duAnService.GetNameDuAn(id));
        }

        // POST api/<DuAnController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DuAnController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DuAnController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
