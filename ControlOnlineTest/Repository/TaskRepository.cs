using ControlOnlineTest.Class;
using ControlOnlineTest.DB;
using ControlOnlineTest.Repository.Interfaces;

namespace ControlOnlineTest.Repository
{
    public class TaskRepository :ITaskRepository
    {
        private readonly AppDBContext _context;

        public TaskRepository(AppDBContext context) 
        {
            _context = context;
        }
        public List<Tasks> tareaPorEstado() 
        {
            var listaTareas = _context.Tasks.ToList();

            return listaTareas; 
        }


        public List<Tasks> ListaTareas()
        {
            var listaTareas = _context.Tasks.ToList();

            return listaTareas;
        }
    }
}
