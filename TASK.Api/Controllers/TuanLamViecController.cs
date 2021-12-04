using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MChiTietTuan;
using TASK.Application.MTuanLamViec;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TASK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TuanLamViecController : ControllerBase
    {

        private readonly ITuanLamViecService tuanLamViecService;

        private readonly IChiTietTuanService chiTietTuanService;

        public TuanLamViecController(ITuanLamViecService tuanLamViecService, IChiTietTuanService chiTietTuanService)
        {
            this.tuanLamViecService = tuanLamViecService;
            this.chiTietTuanService = chiTietTuanService;
        }

        [HttpGet("gettonggio1thang")]
        public async Task<IActionResult> gettonggio1thang(int mathanglamviec)
        {
            var lstChitiettuan = await tuanLamViecService.GetTongGio1Thang(mathanglamviec);

            return Ok(lstChitiettuan);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {

            var lstTuanLamViec = await tuanLamViecService.GetTuanLamViecByDuAn(id);

            return Ok(lstTuanLamViec);

        }

        [HttpGet("gettuanlamviecpaging")]
        public async Task<IActionResult> Gettuanlamviecpaging(int id,int skip,int take)
        {

            var lstTuanLamViec = await tuanLamViecService.GetTuanLamViecByDuAnPageing(id,skip,take);

            return Ok(lstTuanLamViec);

        }

        [HttpGet("Getchitiettuanlamviec")]
        public async Task<IActionResult> GetTuanLamViecByMaThang(int id)
        {

            var TuanLamViec = await tuanLamViecService.GetTuanLamViecByMaThangLamViec(id);

            return Ok(TuanLamViec);

        }
        [HttpPost("Updatetuanlamviec")]
        public async Task<IActionResult> UpdateTuanLamViec([FromBody] TuanLamViecRequest tuanLamViec)
        {
            var check = await tuanLamViecService.UpdateTuanLamViec(tuanLamViec);

            return Ok(check);

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
        [HttpPost("DeleteTuanLamViec")]
        public async Task<IActionResult> PostTuanLamViec([FromBody] List<TuanLamViecRequest> tuanLamViecs)
        {
            //xóa chi tiết trước
            foreach (var item in tuanLamViecs)
            {
               await chiTietTuanService.DeleteChiTietTuanAll(item.MaThangLamViec);
            }

            var check = await tuanLamViecService.DeleteTuanLamViec(tuanLamViecs);

            if (check != 1)
            {
                return Ok(2);
            }
            return Ok(check);
        }

    }
}
