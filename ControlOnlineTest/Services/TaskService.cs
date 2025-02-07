using ControlOnlineTest.Class;
using ControlOnlineTest.Repository.Interfaces;

namespace ControlOnlineTest.Services
{
    public class TaskService
    {
        //public bool crearTarea();

        //public bool actualizarTarea();

        //public bool eliminarTarea();

        //public List<Task> tareaPorEstado();

        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository) 
        {
            _taskRepository= taskRepository;    
        }

        public List<Tasks> ListarTareas()
        { 
         var listado = _taskRepository.ListaTareas();   

            return listado;
        }
    }
}
