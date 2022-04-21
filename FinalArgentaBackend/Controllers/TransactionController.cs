using FinalArgentaBackend.Models;
using FinalArgentaBackend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FinalArgentaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : RelatedController<Transaction, Users>
    {
        public TransactionController(IRelatedRepository<Transaction, Users> repo) : base(repo)
        {
        }
    }
}
