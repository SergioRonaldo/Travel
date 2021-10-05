using Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Contract
{
    public interface ICreateCustomer
    {
        Task<bool> CreateCustomer(Customer author, CancellationToken cancellationToken);
    }
}
