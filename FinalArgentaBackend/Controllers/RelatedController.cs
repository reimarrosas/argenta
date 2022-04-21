using FinalArgentaBackend.Models;
using FinalArgentaBackend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FinalArgentaBackend.Controllers
{
    public class RelatedController<T, U> : ControllerBase, IRelatedController<T, U>
        where T : RelatedEntity<U>
        where U : BaseEntity
    {
        private readonly IRelatedRepository<T, U> _repo;

        public RelatedController(IRelatedRepository<T, U> repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] T t)
        {
            try
            {
                _repo.Create(t);
                await _repo.SaveAsync();
            } catch (Exception)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody]T t)
        {
            try
            {
                _repo.Delete(t);
                await _repo.SaveAsync();
            } catch (Exception)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<T>>> GetAll([FromQuery(Name = "baseId")] Guid baseId)
        {
            return Ok(await _repo.ReadAsync(baseId));
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] T t)
        {
            try
            {
                _repo.Update(t);
                await _repo.SaveAsync();
            } catch (Exception)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
