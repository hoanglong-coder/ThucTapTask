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
    }
}
