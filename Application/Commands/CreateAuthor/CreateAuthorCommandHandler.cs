using Application.DTO;
using Domain.Contract;
using Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand, CreateResponse>
    {

        private readonly ICreateAuthor _repository;
        private readonly IMediator _mediator;
        private const string message = "No se pudo crear el autor";

        public CreateAuthorCommandHandler(ICreateAuthor repository, IMediator mediator)
        {
            _repository = repository;
            _mediator = mediator;
        }

        public async Task<CreateResponse> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            CreateResponse createResponse = new CreateResponse();
            try
            {
                Author author = new Author
                {
                    Name = request.Name,
                    LastName = request.LastName
                };

                createResponse.Success = await _repository.CreateAuthor(author, cancellationToken);
                if (!createResponse.Success)
                {
                    createResponse.Message = message;
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
