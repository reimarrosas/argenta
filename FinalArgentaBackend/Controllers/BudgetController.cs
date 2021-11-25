using FinalArgentaBackend.Models;
using FinalArgentaBackend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FinalArgentaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetController : RelatedController<Budget, Users>
    {
        public BudgetController(IRelatedRepository<Budget, Users> repo)
            : base(repo)
        { }
    }
}
