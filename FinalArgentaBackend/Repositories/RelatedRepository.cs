using FinalArgentaBackend.Data;
using FinalArgentaBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalArgentaBackend.Repositories
{
    public class RelatedRepository<T, U> : IRelatedRepository<T, U>
        where T : RelatedEntity<U>
        where U : BaseEntity
    {
        private readonly ArgentaDbContext _con;

        private readonly DbSet<T> _set;

        public RelatedRepository(ArgentaDbContext con)
        {
            _con = con;
            _set = _con.Set<T>();
        }

        public void Create(T entity)
        {
            _set.Add(entity);
        }

        public void Delete(T entity)
        {
            _set.Remove(entity);
        }

        public async Task<IEnumerable<T>> ReadAsync(Guid baseId)
        {
            return await _set.Where(s => s.Base.Id == baseId).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _con.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _set.Update(entity);
        }
    }
}
