using Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Contract
{
    public interface ICreateBook
    {
        Task<bool> CreateBook(Book book, CancellationToken cancellationToken);
    }
}
