using Domain.Entities.Authenticate;
using System.Threading.Tasks;

namespace Domain.Contract.Authenticate
{
    public interface IAuthUserRepository
    {
        public Task<bool> SearchAsync(User user);
    }
}
