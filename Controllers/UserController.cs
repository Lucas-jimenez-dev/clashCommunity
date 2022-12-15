
using Microsoft.AspNetCore.Mvc;

namespace clashCommunity_api.Controllers
{
    [Route("api/v1/[Controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserAppRepository _userRepository;

        public UserController(UserAppRepository userRepository)
        {
            _userRepository = userRepository;
        }
    }
}
