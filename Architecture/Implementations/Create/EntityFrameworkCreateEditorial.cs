using Architecture.Persistence.Entity.Data;
using Domain.Contract;
using Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Architecture.Implementations
{
    public class EntityFrameworkCreateEditorial : ICreateEditorial
    {
        private readonly DataContext _context;

        public EntityFrameworkCreateEditorial(DataContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateEditorial(Editorial _editorial, CancellationToken cancellationToken)
        {
            Persistence.Entity.Editoriales editorial = new Persistence.Entity.Editoriales
            {
                Nombre = _editorial.Name,
                Sede = _editorial.Branch

            };
            using (_context)
            {
                _context.Editoriales.Add(editorial);
                var result = await _context.SaveChangesAsync(cancellationToken);

                return result > 0;
            }
        }
    }
}

