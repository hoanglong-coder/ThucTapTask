using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.Application.MUser;
using TASK.Data;

namespace TASK.Application.MLogin
{
    public class LoginService : ILoginService
    {
        private readonly TaskDbContext _taskDbContext;


        public LoginService(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }


        public LoginResponse Login(LoginRequest loginRequest)
        {
            string PasswordHashMD5 = new MD5Hash().HashMD5(loginRequest.Password);
            var User = _taskDbContext.Users.Where(t => t.UserName == loginRequest.UserName && t.Password == PasswordHashMD5).SingleOrDefault();
            var LoginResponse = new LoginResponse()
            {
                MaUser = User.MaUser,
                UserName = User.UserName,
                FullName = User.TenUser,
                MaQuyenHeThong = User.MaQuyenHeThong,
                Successful = true
            };
            return LoginResponse;
        }
        /// <summary>
        /// Kiểm tra login
        /// 1 - Có tài khoản
        /// 0 - Không có tài khoản
        /// </summary>
        /// <param name="loginRequest">loginRequest</param>
        /// <returns>Number</returns>
        public int CheckLogin(LoginRequest loginRequest)
        {
            string PasswordHashMD5 = new MD5Hash().HashMD5(loginRequest.Password);
            var lst = _taskDbContext.Users.Select(t => t);
            var User = _taskDbContext.Users.Where(t => t.UserName == loginRequest.UserName && t.Password == PasswordHashMD5).SingleOrDefault();

            if (User != null)
            {
                return 1;
            }
            return 0;
        }

    }
}
