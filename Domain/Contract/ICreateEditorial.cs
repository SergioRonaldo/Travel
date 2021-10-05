using Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Contract
{
    public interface ICreateEditorial
    {
        Task<bool> CreateEditorial(Editorial editorial, CancellationToken cancellationToken);
    }
}
