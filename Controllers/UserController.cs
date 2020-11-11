using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetById(id);
            if(user == null) {
                return NotFound();
            }
            return Ok(user);
        }
    }
}