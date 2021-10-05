using Application.DTO;
using Domain.Contract;
using Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, CreateResponse>
    {

        private readonly ICreateCustomer _repository;
        private readonly IMediator _mediator;
        private const string message = "No se pudo crear el cliente";

        public CreateCustomerCommandHandler(ICreateCustomer repository, IMediator mediator)
        {
            _repository = repository;
            _mediator = mediator;
        }

        public async Task<CreateResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            CreateResponse createResponse = new CreateResponse();
            try
            {
                Customer customer = new Customer
                {
                    TypeDocuments_Id = request.TypeDocuments_Id,
                    DocumentNumber = request.DocumentNumber,
                    Name = request.Name,
                    LastName = request.LastName
                };

                createResponse.Success = await _repository.CreateCustomer(customer, cancellationToken);
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
