using Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Contract
{
    public interface ICreateAuthor
    {
        Task<bool> CreateAuthor(Author author, CancellationToken cancellationToken);
    }
}
