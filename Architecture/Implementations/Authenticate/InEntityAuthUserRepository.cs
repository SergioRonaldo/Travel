using Architecture.Persistence.Entity.Data;
using Domain.Contract.Authenticate;
using Domain.Entities.Authenticate;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Architecture.Implementations.Authenticate
{
    public class InEntityAuthUserRepository : IAuthUserRepository
    {
        private readonly DataContext _context;

        public InEntityAuthUserRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<bool> SearchAsync(User user)
        {
            var result = await _context.Usuarios
                  .FirstOrDefaultAsync(s => s.NombreUsuario == user.UserName && s.Contrasena == user.Password);

            return result != null;

        }
    }
}
