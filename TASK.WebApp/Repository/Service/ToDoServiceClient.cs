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

        public async Task<int> DeleteTodo(IList<ToDoListDTO> MaToDo)
        {
            var check = await httpClient.PostAsJsonAsync("/api/ToDo/Delete", MaToDo);

            var content = await check.Content.ReadAsStringAsync();

            return int.Parse(content);
        }

        public async Task<ToDoListResponse> GetAllToDoByDuAn(int MaDuAn, Guid MaUser)
        {
            var lsttodo = await httpClient.GetFromJsonAsync<ToDoListResponse>($"/api/ToDo/GetAllToDoByDuAn?MaDuAn={MaDuAn}&MaUser={MaUser}");

            return lsttodo;
        }

        public async Task<ToDoListResponse> GetToDoByDuAn(int MaDuAn, Guid MaUser, int skip, int take, bool trangthai)
        {
            var lsttodo = await httpClient.GetFromJsonAsync<ToDoListResponse>($"/api/ToDo/GetToDoByDuAn?MaDuAn={MaDuAn}&MaUser={MaUser}&skip={skip}&take={take}&trangthai={trangthai}");

            return lsttodo;
        }

        public async Task<ToDoListDTO> GetTodoById(int MaToDo)
        {
            var todo = await httpClient.GetFromJsonAsync<ToDoListDTO>($"/api/ToDo/GetToDoByID?id={MaToDo}");

            return todo;
        }

        public async Task<int> InsertToDo(ToDoListRequest toDoListRequest)
        {
            var check = await httpClient.PostAsJsonAsync("/api/ToDo/Inserttodo", toDoListRequest);

            var content = await check.Content.ReadAsStringAsync();

            return int.Parse(content);
        }

        public async Task<int> UpdateToDo(ToDoListRequest toDoListRequest)
        {
            var check = await httpClient.PostAsJsonAsync("/api/ToDo/Update", toDoListRequest);

            var content = await check.Content.ReadAsStringAsync();

            return int.Parse(content);
        }

        public async Task<int> XacNhanXongToDo(int MaToDo)
        {
            var todo = await httpClient.GetFromJsonAsync<int>($"/api/ToDo/XacNhanXongTodo?matodo={MaToDo}");

            return todo;
        }
    }
}
