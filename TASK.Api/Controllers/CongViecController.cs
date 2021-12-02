using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MCongViec;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TASK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CongViecController : ControllerBase
    {

        private readonly ICongViecService congViecService;

        public CongViecController(ICongViecService congViecService)
        {
            this.congViecService = congViecService;
        }

        // GET: api/<CongViecController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var lstcongviec = await congViecService.GetAll();

            return Ok(lstcongviec);
        }


        [HttpGet("getmoduel")]
        public async Task<IActionResult> GetAllModule()
        {
            var lstmodule = await congViecService.GetAllModule();

            return Ok(lstmodule);
        }

        // GET api/<CongViecController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CongViecController>
        [HttpPost("InsertCongViec")]
        public async Task<IActionResult> Post([FromBody] CongViecRequest congViecRequest)
        {
            int rs = await congViecService.InsertCongViec(congViecRequest);
            return Ok(rs);
        }

        // PUT api/<CongViecController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CongViecController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
