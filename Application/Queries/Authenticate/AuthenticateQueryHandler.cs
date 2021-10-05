using Domain.Contract.Authenticate;
using Domain.Entities.Authenticate;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Queries.Authenticate
{
    public class AuthenticateQueryHandler : IRequestHandler<AuthenticateQuery, bool>
    {
        private readonly IAuthUserRepository _repository;

        public AuthenticateQueryHandler(IAuthUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(AuthenticateQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var user = new User
                {
                    UserName = request.UserName,
                    Password = request.Password
                };

                return await _repository.SearchAsync(user);
            }
            catch (System.Exception)
            {

                return false;
            }

        }
    }
}
