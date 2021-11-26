using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TASK.Application.MToDoList;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Repository.Service
{
    public class ToDoServiceClient : IToDoServiceClient
    {
        public HttpClient httpClient;

        public ToDoServiceClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<ToDoListResponse>> GetToDoByDuAn(int MaDuAn, Guid MaUser)
        {
            var lsttodo = await httpClient.GetFromJsonAsync<List<ToDoListResponse>>($"/api/ToDo/GetToDoByDuAn?MaDuAn={MaDuAn}&MaUser={MaUser}");

            return lsttodo;
        }
    }
}
