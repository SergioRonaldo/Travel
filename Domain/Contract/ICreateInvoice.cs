using Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Contract
{
    public interface ICreateInvoice
    {
        Task<bool> CreateInvoice(Invoice invoice, CancellationToken cancellationToken);
    }
}
