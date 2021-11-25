using FinalArgentaBackend.Models;
using FinalArgentaBackend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FinalArgentaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoalController : RelatedController<Goal, Users>
    {
        public GoalController(IRelatedRepository<Goal, Users> repo) : base(repo)
        {
        }
    }
}
