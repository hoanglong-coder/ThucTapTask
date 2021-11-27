using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MToDoList
{
    public class ToDoListResponse
    {
        public int Count { get; set; }

        public List<ToDoListDTO> ListToDo { get; set; }
    }
}
