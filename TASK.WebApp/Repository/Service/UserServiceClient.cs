using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TASK.Application.MUser;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Repository.Service
{
    public class UserServiceClient : IUserServiceClient
    {
        public HttpClient httpClient;

        public UserServiceClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<UserResponse>> GetAllByDuAn(int maduan)
        {
            var ListUser = await httpClient.GetFromJsonAsync<List<UserResponse>>($"/api/User/getallbyduan?maduan={ maduan }");

            return ListUser;
        }

        public async Task<int> GetQuyenDuAn(Guid idUser, int maduan)
        {
            var ListUser = await httpClient.GetFromJsonAsync<int>($"/api/User/GetQuyenDuAn?mauser={idUser}&maduan={maduan}");

            return ListUser;
        }

        public async Task<UserResponse> GetUser(Guid idUser)
        {
            var User = await httpClient.GetFromJsonAsync<UserResponse>($"/api/User/GetUser?MaUser={idUser}");

            return User;
        }
    }
}
