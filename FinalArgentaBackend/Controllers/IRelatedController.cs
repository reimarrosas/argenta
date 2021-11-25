using FinalArgentaBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalArgentaBackend.Controllers
{
    public interface IRelatedController<T, U>
        where T: RelatedEntity<U>
        where U : BaseEntity
    {
        public Task<IActionResult> Create(T t);

        public Task<ActionResult<IEnumerable<T>>> GetAll(Guid guid);

        public Task<IActionResult> Update(T t);

        public Task<IActionResult> Delete(T t);
    }
}
