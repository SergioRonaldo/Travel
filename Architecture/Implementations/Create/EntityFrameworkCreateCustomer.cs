using Architecture.Persistence.Entity.Data;
using Domain.Contract;
using Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Architecture.Implementations
{
    public class EntityFrameworkCreateCustomer : ICreateCustomer
    {
        private readonly DataContext _context;

        public EntityFrameworkCreateCustomer(DataContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateCustomer(Customer customer, CancellationToken cancellationToken)
        {
            Persistence.Entity.Clientes autores = new Persistence.Entity.Clientes
            {
                Nombres = customer.Name,
                Apellidos = customer.LastName,
                TipoDocumentos_Id = customer.TypeDocuments_Id,
                NumeroDocumento = customer.DocumentNumber

            };
            _context.Clientes.Add(autores);
            var result = await _context.SaveChangesAsync(cancellationToken);

            return result > 0;
        }
    }
}
