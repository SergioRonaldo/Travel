using Application.DTO;
using Domain.Contract;
using Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class CreateBookrCommandHandler : IRequestHandler<CreateBookCommand, CreateResponse>
    {

        private readonly ICreateBook _repository;
        private readonly IMediator _mediator;
        private const string messageCreate = "No se pudo crear el libro";
        private const string messageAuthor = "No se enontraron autores";

        public CreateBookrCommandHandler(ICreateBook repository, IMediator mediator)
        {
            _repository = repository;
            _mediator = mediator;
        }

        public async Task<CreateResponse> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            CreateResponse createResponse = new CreateResponse();
            if (request?.AuthorsList?.Count <= 0)
            {
                createResponse.Success = false;
                createResponse.Message = messageAuthor;
                return createResponse;

            }
            try
            {
                Book book = new Book
                {
                    ISBN = request.ISBN,
                    Editoriales_Id = request.Editoriales_Id,
                    AuthorList = request.AuthorsList,
                    Title = request.Title,
                    Synopsis = request.Synopsis,
                    N_Pages = request.N_Pages
                };

                createResponse.Success = await _repository.CreateBook(book, cancellationToken);
                if (!createResponse.Success)
                {
                    createResponse.Message = messageCreate;
                }
            }
            catch (Exception ex)
            {

                createResponse.Success = false;
                createResponse.Message = $"{ ex.Message  },Inner : {ex?.InnerException}";
            }

            return createResponse;
        }
    }
}
