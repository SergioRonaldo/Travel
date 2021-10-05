using Application.DTO;
using Domain.Contract;
using Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class CreateInvoiceCommandHandler : IRequestHandler<CreateInvoiceCommand, CreateResponse>
    {

        private readonly ICreateInvoice _repository;
        private readonly IMediator _mediator;
        private const string message = "No se pudo crear la factura";
        private const string messageBook = "No seencontró un libro";

        public CreateInvoiceCommandHandler(ICreateInvoice repository, IMediator mediator)
        {
            _repository = repository;
            _mediator = mediator;
        }

        public async Task<CreateResponse> Handle(CreateInvoiceCommand request, CancellationToken cancellationToken)
        {
            CreateResponse createResponse = new CreateResponse();
            if (request?.DetailInvoiceList?.Count <= 0)
            {
                createResponse.Success = false;
                createResponse.Message = messageBook;
                return createResponse;

            }
            try
            {
                Invoice invoice = new Invoice
                {
                    Customer_Id = request.Customer_Id,
                    DetailInvoiceList = request.DetailInvoiceList
                };

                createResponse.Success = await _repository.CreateInvoice(invoice, cancellationToken);
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
