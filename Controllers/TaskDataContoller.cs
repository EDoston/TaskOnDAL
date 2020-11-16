using Microsoft.AspNetCore.Mvc;
using ParsedData.Services;

namespace ParsedData.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskDataContoller : ControllerBase
    {
        private readonly TaskService _taskService;
        public TaskDataContoller(TaskService _taskService)
        {
            this._taskService = _taskService;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _taskService.GetTask(id);
            if(result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("{page}/{size}")]
        public IActionResult GetTaskDirectors(int page, int size)
        {
            var result = _taskService.GetTaskManagers(page, size);
            if(result == null)
            {
                return NotFound();
            }
            
            return Ok(result);
        }

        [HttpGet("{page}/{size}")]
        public IActionResult GetTaskExecutors(int page, int size)
        {
            var result = _taskService.GetTaskExecutors(page, size);
            if(result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("{page}/{size}")]
        public IActionResult Update(ParsedData.Models.TaskData taskData)
        {
            var result = _taskService.Update(taskData);
            if(result == false)
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpGet("{id}/{stateId}")]
        public IActionResult UpdateTaskState(int id, int stateId)
        {
            var result = _taskService.UpdateTaskState(id, stateId);
            if(result == false)
            {
                return NotFound();
            }

            return Ok();
        }

    }
}