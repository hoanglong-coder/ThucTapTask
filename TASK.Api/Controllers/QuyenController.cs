using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MQuyen;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TASK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuyenController : ControllerBase
    {

        private readonly IQuyenService _quyenService;

        public QuyenController(IQuyenService quyenService)
        {
            _quyenService = quyenService;
        }
        // GET: api/<QuyenController>
        [HttpGet]
        public async Task<IEnumerable<QuyenResponse>> Get()
        {
            var listt = _quyenService.GetAll();
            await Task.Delay(1000);
            return (IEnumerable<QuyenResponse>)Ok(listt);
        }

        // GET api/<QuyenController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<QuyenController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<QuyenController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<QuyenController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
