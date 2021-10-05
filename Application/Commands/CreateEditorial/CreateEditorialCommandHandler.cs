using Application.DTO;
using Domain.Contract;
using Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class CreateEditorialCommandHandler : IRequestHandler<CreateEditorialCommand, CreateResponse>
    {

        private readonly ICreateEditorial _repository;
        private readonly IMediator _mediator;
        private const string message = "No se pudo crear el autor";

        public CreateEditorialCommandHandler(ICreateEditorial repository, IMediator mediator)
        {
            _repository = repository;
            _mediator = mediator;
        }

        public async Task<CreateResponse> Handle(CreateEditorialCommand request, CancellationToken cancellationToken)
        {
            CreateResponse createResponse = new CreateResponse();
            try
            {
                Editorial editorial = new Editorial
                {
                    Name = request.Name,
                    Branch = request.Branch
                };

                createResponse.Success = await _repository.CreateEditorial(editorial, cancellationToken);
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
