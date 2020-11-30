using System.Threading.Tasks;
using Api.Data;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repository;
        public AuthController(IAuthRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(string username, string password)
        {
            username = username.ToLower();

            if (await _repository.UserExists(username))
                return BadRequest("Użytkownik o takiej nazwie już istnieje!");

            var userToCreate = new User
            {
                Username = username
            }

            var createdUser = await _repository.Register(userToCreate, password);

            return StatusCode(201);
        }
    }
}