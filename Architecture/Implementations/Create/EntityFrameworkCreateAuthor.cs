using Architecture.Persistence.Entity.Data;
using Domain.Contract;
using Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Architecture.Implementations
{
    public class EntityFrameworkCreateAuthor : ICreateAuthor
    {
        private readonly DataContext _context;

        public EntityFrameworkCreateAuthor(DataContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateAuthor(Author author, CancellationToken cancellationToken)
        {
            Persistence.Entity.Autores autores = new Persistence.Entity.Autores
            {
                Nombre = author.Name,
                Apellidos = author.LastName

            };
            using (_context)
            {
                _context.Autores.Add(autores);
                var result = await _context.SaveChangesAsync(cancellationToken);

                return result > 0;
            }
        }
    }
}
