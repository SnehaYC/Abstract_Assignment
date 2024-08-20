using System.Threading.Tasks;
using WebApp_Assignment.Model;

namespace WebApp_Assignment.IRepository
{
    public interface ITaskRepository
    {
        Tasks GetTasksById(int id);
        IEnumerable<Tasks> GetAllTasks();
        void AddTasks(Tasks task);
        void UpdateTasks(Tasks task);
        void DeleteTasks(int id);

        // SubTask-related methods
        SubTask AddSubTask(SubTask subTask);
        IEnumerable<SubTask> GetSubTasksByTaskId(int taskId);
    }
}
