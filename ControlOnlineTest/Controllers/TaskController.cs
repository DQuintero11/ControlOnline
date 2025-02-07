using ControlOnlineTest.Class;
using ControlOnlineTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace ControlOnlineTest.Controllers
{
    public class TaskController : Controller
    {
        private readonly TaskService _TaskService;

       public TaskController(TaskService taskService)
        {
            _TaskService = taskService;
        }

        [HttpGet("ListarTareas")]
        public IEnumerable<Tasks> ListarTareas() 
        {
            return _TaskService.ListarTareas();
        }
    }
}
