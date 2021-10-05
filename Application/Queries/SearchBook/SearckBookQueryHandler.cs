using Application.DTO;
using Domain.Contract;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Queries
{
    public class SearckBookQueryHandler : IRequestHandler<SearchBookQuery, SearchBookResponse>
    {
        private readonly ISearchBook _repository;

        public SearckBookQueryHandler(ISearchBook repository)
        {
            _repository = repository;
        }

        public Task<SearchBookResponse> Handle(SearchBookQuery request, CancellationToken cancellationToken)
        {
            var result = _repository.SearchBook(request.ISBN);

            var tales = new SearchBookResponse()
            {
                ISBN = result.ISBN,
                Editorial = result.Editoriales_Id,
                Title = result.Title,
                Synopsis = result.Synopsis,
                N_Pages = result.N_Pages,
                Authors = result?.AuthorList,
                AmountEntered = result.AmountEntered,
                OutputQuantity = result.OutputQuantity,
                QuantityAvailable = result.QuantityAvailable
            };

            return Task.FromResult<SearchBookResponse>(tales);
        }
    }
}
