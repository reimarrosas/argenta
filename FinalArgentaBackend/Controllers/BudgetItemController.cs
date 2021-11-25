using FinalArgentaBackend.Models;
using FinalArgentaBackend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FinalArgentaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetItemController : RelatedController<BudgetItem, Budget>
    {
        public BudgetItemController(IRelatedRepository<BudgetItem, Budget> repo) : base(repo)
        {
        }
    }
}
