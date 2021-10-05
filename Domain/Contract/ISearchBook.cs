using Domain.Entities;

namespace Domain.Contract
{
    public interface ISearchBook
    {
        Book SearchBook(int ISBN);
    }
}
