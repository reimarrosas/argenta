using FinalArgentaBackend.Models;
using FinalArgentaBackend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FinalArgentaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestmentEntryController : RelatedController<InvestmentEntry, Investment>
    {
        public InvestmentEntryController(IRelatedRepository<InvestmentEntry, Investment> repo) : base(repo)
        {
        }
    }
}
