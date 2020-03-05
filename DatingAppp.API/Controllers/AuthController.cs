using System.Threading.Tasks;
using DatingAppp.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace DatingAppp.API.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase {
        private readonly IAuthRepository _repo;
        public AuthController (IAuthRepository repo) {

            _repo = repo;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(string username, string password){
            // validate request....
            username = username.ToLower();
            if (await _repo.UserExists(username))
                return BadRequest("username already exists");
            var userToCreate = new User
            {
                username = username
            };

            var createdUser = await _repo.Register(userToCreate, password);
            return StatusCode(201);
        }
    }
}