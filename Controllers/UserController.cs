using Microsoft.AspNetCore.Mvc;
using ParsedData.Dtos;
using ParsedData.Services;

namespace ParsedData.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserServiсe _userService;
        public UserController(IUserServiсe _userService)
        {
            this._userService = _userService;
        }
        [HttpGet("{page}")]
        [HttpGet("{page}/{size}")]
        public IActionResult GetAll(int page = 1, int size = 10)
        {
            var users = _userService.GetAll(page, size);
            if(users == null) {
                return NotFound();
            }
            return Ok(users);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetById(id);
            if(user == null) {
                return NotFound();
            }
            return Ok(user);
        }
        public IActionResult Update(UpdateUserDto user)
        {
            var result = _userService.Update(user);
            if(result == false) {
                return NotFound();
            }

            return Ok();
        }
        [HttpGet("{DirectorId}/{ExecutorId}")]
        public IActionResult SetTaskExcutor(int DirectorId, int ExecutorId) 
        {
            var result = _userService.SetTaskExcutor(DirectorId, ExecutorId);
            if(result == false)
            {
                return NotFound();
            }
            
            return Ok();
        }
    }
}