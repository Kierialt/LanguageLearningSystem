using Microsoft.AspNetCore.Mvc;
using LanguageLearningSystem1.Services;
using LanguageLearningSystem1.Models;


namespace LanguageLearningSystem1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
       

       

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            _userService.AddUser(user);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _userService.GetUser(id);
            return user != null ? Ok(user) : NotFound();
        }

        [HttpPut]
        public IActionResult UpdateUser(User user)
        {
            _userService.UpdateUser(user);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            _userService.DeleteUser(id);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(_userService.GetAllUsers());
        }
    }
}
