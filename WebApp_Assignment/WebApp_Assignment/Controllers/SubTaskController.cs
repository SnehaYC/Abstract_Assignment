using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp_Assignment.IRepository;
using WebApp_Assignment.Model;

namespace WebApp_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubTaskController : ControllerBase
    {
        private readonly ITaskRepository _tasksRepository;

        public SubTaskController(ITaskRepository tasksRepository)
        {
            _tasksRepository = tasksRepository;
        }

        [HttpPost]
        public ActionResult<SubTask> AddSubTask(SubTask subTask)
        {
            var addedSubTask = _tasksRepository.AddSubTask(subTask);
            return CreatedAtAction(nameof(GetSubTasksByTaskId), new { id = subTask.TaskId }, addedSubTask);
        }

        [HttpGet("tasks/{taskId}")]
        public ActionResult<IEnumerable<SubTask>> GetSubTasksByTaskId(int taskId)
        {
            var subTasks = _tasksRepository.GetSubTasksByTaskId(taskId);
            return Ok(subTasks);
        }
    }
}
