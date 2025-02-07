using ControlOnlineTest.Class;

namespace ControlOnlineTest.Repository.Interfaces
{
    public interface ITaskRepository
    {
        List<Tasks> tareaPorEstado();

        List<Tasks> ListaTareas();
    }
}
