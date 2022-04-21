using FinalArgentaBackend.Models;
using FinalArgentaBackend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FinalArgentaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoalUpdateController : RelatedController<GoalUpdate, Goal>
    {
        public GoalUpdateController(IRelatedRepository<GoalUpdate, Goal> repo) : base(repo)
        {
        }
    }
}
