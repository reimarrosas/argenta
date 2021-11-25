using FinalArgentaBackend.Models;
using FinalArgentaBackend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FinalArgentaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _repo;

        public UsersController(IUserRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<Users?>> GetUser([FromQuery(Name = "userId")]Guid userId)
        {
            return Ok(await _repo.FetchUserById(userId));
        }

        [HttpPost]
        public async Task<IActionResult> AppendUser([FromBody] Users user)
        {
            try
            {
                _repo.AppendUser(user);
                await _repo.SaveAsync();
            } catch (Exception)
            {
                return BadRequest();
            }

            return Ok(user);
        }
    }
}
