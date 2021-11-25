using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MLogin;
using TASK.Application.MUser;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TASK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly IUserService _userService;
        private readonly ILoginService _loginService;

        public LoginController(IUserService userService, ILoginService loginService)
        {
            _userService = userService;
            _loginService = loginService;
        }

        // GET: api/<LoginController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _userService.GetAll());
        }

        // GET api/<LoginController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoginController>
        [HttpPost]
        public IActionResult Post([FromBody] LoginRequest login)
        {
            if (_loginService.CheckLogin(login) != 1)
            {
                return BadRequest(new LoginResponse { Successful = false, Error = "Sai tài khoản hoặc mật khẩu" });
            }
            var User = _loginService.Login(login);
            return Ok(User);
        }

        // PUT api/<LoginController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
