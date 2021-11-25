using FinalArgentaBackend.Models;

namespace FinalArgentaBackend.Repositories
{
    public interface IUserRepository
    {
        public Task<Users?> FetchUserById(Guid id);

        public void AppendUser(Users user);

        public Task SaveAsync();
    }
}
