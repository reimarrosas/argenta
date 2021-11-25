using FinalArgentaBackend.Data;
using FinalArgentaBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalArgentaBackend.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ArgentaDbContext _con;

        public UserRepository(ArgentaDbContext con)
        {
            _con = con;
        }

        public void AppendUser(Users user)
        {
            _con.Users.Add(user);
        }

        public async Task<Users?> FetchUserById(Guid id)
        {
            return await _con.Users.Where(u => u.Id == id).FirstOrDefaultAsync();
        }

        public async Task SaveAsync()
        {
            await _con.SaveChangesAsync();
        }
    }
}
