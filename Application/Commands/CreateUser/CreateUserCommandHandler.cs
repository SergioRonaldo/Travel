using Application.DTO;
using Domain.Contract.Authenticate;
using Domain.Entities.Authenticate;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateResponse>
    {

        private readonly ICreateUserRepository _repository;
        private readonly IMediator _mediator;
        private const string message = "No se pudo crear el usuario";


        public CreateUserCommandHandler(ICreateUserRepository repository, IMediator mediator)
        {
            _repository = repository;
            _mediator = mediator;
        }

        public async Task<CreateResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            CreateResponse createResponse = new CreateResponse();
            try
            {
                User user = new User
                {
                    UserName = request.UserName,
                    Password = request.Password,
                    FullName = request.FullName
                };

                 createResponse.Success = await _repository.CreateUser(user, cancellationToken);
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
