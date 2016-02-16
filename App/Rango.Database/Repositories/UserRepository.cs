using Rango.Database.Repositories.Base;
using Rango.Domain.Contracts.Repositories;
using Rango.Domain.Entities;

namespace Rango.Database.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public User GetByEmail(string email)
        {
            throw new System.NotImplementedException();
        }
    }
}