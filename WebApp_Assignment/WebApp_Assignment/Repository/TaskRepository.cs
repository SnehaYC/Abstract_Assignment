using WebApp_Assignment.Context;
using WebApp_Assignment.IRepository;
using WebApp_Assignment.Model;

namespace WebApp_Assignment.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskDbContext _context;

        public TaskRepository(TaskDbContext context)
        {
            _context = context;
        }
        public SubTask AddSubTask(SubTask subTask)
        {
            _context.SubTasks.Add(subTask);
            _context.SaveChanges();
            return subTask;
        }

        public void AddTasks(Tasks task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public void DeleteTasks(int id)
        {
            var task = _context.Tasks.Find(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Tasks> GetAllTasks()
        {
            return _context.Tasks.ToList();
        }

        public IEnumerable<SubTask> GetSubTasksByTaskId(int taskId)
        {
            return _context.SubTasks.Where(st => st.TaskId == taskId).ToList();
        }

        public Tasks GetTasksById(int id)
        {
            return _context.Tasks.Find(id);
        }

        public void UpdateTasks(Tasks task)
        {
            _context.Tasks.Update(task);
            _context.SaveChanges();
        }
    }
}
