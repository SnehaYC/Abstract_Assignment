﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApp_Assignment.IRepository;
using WebApp_Assignment.Model;

namespace WebApp_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskRepository _tasksRepository;

        public TasksController(ITaskRepository tasksRepository)
        {
            _tasksRepository = tasksRepository;
        }

        [HttpGet("{id}")]
        public ActionResult<Tasks> GetTasksById(int id)
        {
            var task = _tasksRepository.GetTasksById(id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Tasks>> GetAllTasks()
        {
            var tasks = _tasksRepository.GetAllTasks();
            return Ok(tasks);
        }

        [HttpPost]
        public ActionResult<Tasks> AddTasks(Tasks task)
        {
            _tasksRepository.AddTasks(task);
            return CreatedAtAction(nameof(GetTasksById), new { id = task.Id }, task);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTasks(int id, Tasks task)
        {
            if (id != task.Id)
            {
                return BadRequest();
            }

            _tasksRepository.UpdateTasks(task);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTasks(int id)
        {
            _tasksRepository.DeleteTasks(id);
            return NoContent();
        }
    }
}
