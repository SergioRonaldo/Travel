using Architecture.Persistence.Entity.Data;
using Domain.Contract.Authenticate;
using Domain.Entities.Authenticate;
using System.Threading;
using System.Threading.Tasks;

namespace Architecture.Implementations
{
    public class InEntityCreateUserRepository : ICreateUserRepository
    {
        private readonly DataContext _context;

        public InEntityCreateUserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateUser(User user, CancellationToken cancellationToken)
        {
            Architecture.Persistence.Entity.Usuarios usuario = new Architecture.Persistence.Entity.Usuarios
            {
                NombreUsuario = user.UserName,
                Contrasena = user.Password,
                NombreCompleto = user.FullName

            };
            _context.Usuarios.Add(usuario);
            var result = await _context.SaveChangesAsync(cancellationToken);

            return result > 0;
        }
    }
}
