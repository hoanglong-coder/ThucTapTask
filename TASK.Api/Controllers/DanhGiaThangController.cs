using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MDanhGiaNhanSu;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TASK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhGiaThangController : ControllerBase
    {
        private readonly IDanhGiaThangService danhGiaThangService;

        private readonly IDanhGiaTuanService danhGiaTuanService;

        public DanhGiaThangController(IDanhGiaThangService danhGiaThangService, IDanhGiaTuanService danhGiaTuanService)
        {
            this.danhGiaThangService = danhGiaThangService;
            this.danhGiaTuanService = danhGiaTuanService;
        }

        // GET: api/<DanhGiaThangController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DanhGiaThangController>/5
        [HttpGet("GetDanhGiaThang")]
        public async Task<IActionResult> GetDanhGiaThang(int MaThangLamViec, Guid MaUser)
        {
            var DanhGiaThang = await danhGiaThangService.GetDanhGiaThang(MaThangLamViec, MaUser);

            return Ok(DanhGiaThang);
        }

        // GET api/<DanhGiaThangController>/5
        [HttpGet("GetDanhGiatuan")]
        public async Task<IActionResult> GetDanhGiaTuan(int MaDanhGiaThang, Guid MaUser)
        {
            var DanhGiaTuan = await danhGiaTuanService.GetDanhGiaTuanByDanhGiaThang(MaDanhGiaThang,MaUser);

            return Ok(DanhGiaTuan);
        }

        // POST api/<DanhGiaThangController>
        [HttpPost("UpdateDanhGiaThang")]
        public async Task<IActionResult> Post([FromBody] DanhGiaThangResponse danhGiaThangResponse)
        {

            var check = await danhGiaThangService.UpdateDanhGiaThang(danhGiaThangResponse);

            return Ok(check);
        }

        [HttpPost("UpdateDanhGiaTuan")]
        public async Task<IActionResult> UpdateDanhGiaTuan([FromBody] List<DanhGiaTuanResponse> danhGiaTuanResponses)
        {

            var check = await danhGiaTuanService.UpdateDanhGiaTuan(danhGiaTuanResponses);

            return Ok(check);
        }



        // PUT api/<DanhGiaThangController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DanhGiaThangController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
