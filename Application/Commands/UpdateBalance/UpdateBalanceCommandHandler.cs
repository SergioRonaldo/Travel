using Application.DTO;
using Domain.Contract;
using Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class UpdateBalanceCommandHandler : IRequestHandler<UpdateBalanceCommand, CreateResponse>
    {

        private readonly IUpdateBalance _repository;
        private readonly IMediator _mediator;
        private const string message = "No se pudo actualizar el inventario";

        public UpdateBalanceCommandHandler(IUpdateBalance repository, IMediator mediator)
        {
            _repository = repository;
            _mediator = mediator;
        }

        public async Task<CreateResponse> Handle(UpdateBalanceCommand request, CancellationToken cancellationToken)
        {
            CreateResponse createResponse = new CreateResponse();
            try
            {
                Balance balance = new Balance
                {
                    Book_ISBN = request.Book_ISBN,
                    AmountEntered = request.AmountEntered
                };

                createResponse.Success = await _repository.UpdateBalance(balance, cancellationToken);
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
