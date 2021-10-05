using Architecture.Persistence.Entity;
using Architecture.Persistence.Entity.Data;
using Domain.Contract;
using Domain.Entities;
using Domain.Exceptions;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Architecture.Implementations
{
    public class EntityFrameworkUpdateBalance : IUpdateBalance
    {
        private readonly DataContext _context;

        public EntityFrameworkUpdateBalance(DataContext context)
        {
            _context = context;
        }
        public async Task<bool> UpdateBalance(Balance balance, CancellationToken cancellationToken)
        {

            using (_context)
            {
                Inventario inventario = new Inventario();
                //Obtener inventario
                inventario = _context.Inventario
                      .FirstOrDefault(i => i.Libros_ISBN == balance.Book_ISBN);

                if (inventario == null)
                {
                    inventario = new Inventario
                    {
                        Libros_ISBN = balance.Book_ISBN,
                        CantidadIngresada = balance.AmountEntered

                    };

                    //Se obtiene el libro
                    var book = _context.Libros.FirstOrDefault(l => l.ISBN == balance.Book_ISBN);
                    if (book == null)
                    {
                        throw new BookNotFoundException();
                    }

                    //Se agrega el producto al detalle
                    inventario.Libro = book;

                    book.Inventario.Add(inventario);
                    _context.Inventario.Add(inventario);

                }
                else
                {
                    inventario.CantidadIngresada += balance.AmountEntered;
                    _context.Inventario.Update(inventario);

                }

                var result = await _context.SaveChangesAsync(cancellationToken);

                return result > 0;

            }
        }
    }
}


