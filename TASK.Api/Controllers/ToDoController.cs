﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MToDoList;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TASK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {

        private readonly IToDoListService toDoListService;

        public ToDoController(IToDoListService toDoListService)
        {
            this.toDoListService = toDoListService;
        }

        // GET: api/<ToDoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ToDoController>/5
        [HttpGet("GetToDoByDuAn")]
        public async Task<IActionResult> Get(int MaDuAn,Guid MaUser)
        {
            var lstToDo = await toDoListService.GetToDoByDuAn(MaDuAn, MaUser);

            if (lstToDo == null)
            {
                return BadRequest();
            }

            return Ok(lstToDo);
        }

        // POST api/<ToDoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ToDoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ToDoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
