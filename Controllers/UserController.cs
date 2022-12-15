
using Microsoft.AspNetCore.Mvc;

namespace clashCommunity_api.Controllers
{
    [Route("api/v1/[Controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserRepository _userRepository;

        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userRepository.Test());
        }
    }
}
