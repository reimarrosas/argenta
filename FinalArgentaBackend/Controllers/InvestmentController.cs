using FinalArgentaBackend.Models;
using FinalArgentaBackend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FinalArgentaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestmentController : RelatedController<Investment, Users>
    {
        public InvestmentController(IRelatedRepository<Investment, Users> repo) : base(repo)
        {
        }
    }
}
