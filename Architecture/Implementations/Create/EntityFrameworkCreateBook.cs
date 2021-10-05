using Architecture.Persistence.Entity.Data;
using Domain.Contract;
using Domain.Entities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Architecture.Implementations
{
    public class EntityFrameworkCreateBook : ICreateBook
    {
        private readonly DataContext _context;

        public EntityFrameworkCreateBook(DataContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateBook(Book book, CancellationToken cancellationToken)
        {
            using (_context)
            {
                Persistence.Entity.Libros libro = new Persistence.Entity.Libros
                {
                    ISBN = book.ISBN,
                    Editoriales_Id = book.Editoriales_Id,
                    Titulo = book.Title,
                    Sinopsis = book.Synopsis,
                    N_Paginas = book.N_Pages

                };

                Persistence.Entity.Autores autores = new Persistence.Entity.Autores();

                foreach (var author in book.AuthorList)
                {

                    //Se obtiene el producto
                    autores = _context.Autores.FirstOrDefault(a => a.Id == author.Id);

                    Persistence.Entity.Autores_has_Libros autores_has_Libros = new Persistence.Entity.Autores_has_Libros
                    {
                        Autores_Id = autores.Id,
                        Libros_ISBN = book.ISBN

                    };

                    autores_has_Libros.autor = autores;
                    autores_has_Libros.libro = libro;
                    libro.Autores_has_Libros.Add(autores_has_Libros);
                    autores.Autores_has_Libros.Add(autores_has_Libros);
                    _context.Autores_has_Libros.Add(autores_has_Libros);

                }


                _context.Libros.Add(libro);
                var result = await _context.SaveChangesAsync(cancellationToken);

                return result > 0;
            }
        }
    }
}

