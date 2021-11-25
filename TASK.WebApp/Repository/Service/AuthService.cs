using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using TASK.Application.MLogin;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Repository.Service
{
    public class AuthService:IAuthService
    {
        public HttpClient httpClient;

      
        public AuthService(HttpClient httpClient)
        {
            this.httpClient = httpClient;

        }

        public async Task<LoginResponse> Login(LoginRequest login)
        {
            Console.WriteLine("Gửi request");
            var loginresponse = await httpClient.PostAsJsonAsync("/api/Login",login);

            var content = await loginresponse.Content.ReadAsStringAsync();

            var loginResponse = JsonSerializer.Deserialize<LoginResponse>(content,
                new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
           
            return loginResponse;
        }
    }
}
