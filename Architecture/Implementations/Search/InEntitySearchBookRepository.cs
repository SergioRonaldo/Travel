using Architecture.Persistence.Entity.Data;
using Domain.Contract;
using Domain.Entities;
using System.Linq;

namespace Architecture.Implementations
{
    public class InEntitySearchBookRepository : ISearchBook
    {
        private readonly DataContext _context;

        public InEntitySearchBookRepository(DataContext context)
        {
            _context = context;
        }
        public Book SearchBook(int ISBN)
        {
            var result = _context.Libros.Select(o => new
            {
                ISBN = o.ISBN,
                Editoriales_Id = o.Editoriales_Id,
                Title = o.Titulo,
                Synopsis = o.Sinopsis,
                N_Pages = o.N_Paginas,
                AuthorList = o.Autores_has_Libros.Select(ot => ot.autor).ToList(),
                AmountEntered = o.Inventario.FirstOrDefault().CantidadIngresada,
                OutputQuantity = o.Inventario.FirstOrDefault().CantidadSalida
            }).FirstOrDefault();


            var book = new Book
            {
                ISBN = result.ISBN,
                Editoriales_Id = result.Editoriales_Id,
                Title = result.Title,
                Synopsis = result.Synopsis,
                N_Pages = result.N_Pages,
                AmountEntered = result.AmountEntered,
                OutputQuantity = result.OutputQuantity,
                QuantityAvailable = result.AmountEntered - result.OutputQuantity
            };

            foreach (var item in result.AuthorList)
            {
                book.AuthorList.Add(new Author
                {
                    Id = item.Id,
                    Name = item.Nombre,
                    LastName = item.Apellidos
                });
            }

            return book;
        }
    }
}
