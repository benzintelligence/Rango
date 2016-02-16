using Rango.Domain.Contracts.Repositories.Base;
using Rango.Domain.Entities;

namespace Rango.Domain.Contracts.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User GetByEmail(string email);
    }
}