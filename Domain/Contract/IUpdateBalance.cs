using Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Contract
{
    public interface IUpdateBalance
    {
        Task<bool> UpdateBalance(Balance balance, CancellationToken cancellationToken);
    }
}
