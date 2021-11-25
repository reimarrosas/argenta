using FinalArgentaBackend.Models;

namespace FinalArgentaBackend.Repositories
{
    public interface IRelatedRepository<T, U>
        where T : RelatedEntity<U>
        where U : BaseEntity
    {
        public void Create(T entity);

        public Task<IEnumerable<T>> ReadAsync(Guid userId);

        public void Update(T entity);

        public void Delete(T entity);

        public Task SaveAsync();
    }
}
