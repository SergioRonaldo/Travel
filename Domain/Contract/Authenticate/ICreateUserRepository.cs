using Domain.Entities.Authenticate;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Contract.Authenticate
{
    public interface ICreateUserRepository
    {
        Task<bool> CreateUser(User user, CancellationToken cancellationToken);
    }
}
