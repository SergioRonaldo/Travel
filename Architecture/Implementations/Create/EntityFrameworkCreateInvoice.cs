using Architecture.Persistence.Entity;
using Architecture.Persistence.Entity.Data;
using Domain.Contract;
using Domain.Entities;
using Domain.Exceptions;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Architecture.Implementations
{
    public class EntityFrameworkCreateInvoice : ICreateInvoice
    {
        private readonly DataContext _context;

        public EntityFrameworkCreateInvoice(DataContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateInvoice(Invoice invoice, CancellationToken cancellationToken)
        {

            using (_context)
            {
                decimal total = 0;
                Facturas fac = new Facturas
                {
                    Clientes_Id = invoice.Customer_Id,
                    FechaSalida = DateTime.Now,
                    NumeroFactura = $"FAC{DateTime.Now.ToString("yyyyMMddHHmmssffff")}",

                };

                foreach (var item in invoice?.DetailInvoiceList)
                {
                    FacturaDetalle detalle = new FacturaDetalle
                    {
                        Factura = fac,
                        Cantidad = item.Quantity,
                        ValorUnitario = item.Value,
                        Libros_ISBN = item.Book_ISBN

                    };

                    //Se obtiene el libro
                    var book = _context.Libros.FirstOrDefault(l => l.ISBN == item.Book_ISBN);
                    if (book == null)
                    {
                        throw new BookNotFoundException();
                    }

                    //Modificar cantidad disponible
                    var balance = _context.Inventario
                           .FirstOrDefault(i => i.Libros_ISBN == item.Book_ISBN);

                    if (balance == null)
                    {
                        throw new BalanceNotFoundException();
                    }

                    balance.CantidadSalida += item.Quantity;
                    //Se agrega el producto al detalle
                    detalle.Libro = book;

                    fac.FacturaDetalle.Add(detalle);
                    total = total + (detalle.Cantidad * detalle.ValorUnitario);
                }
                fac.TotalFactura = total;
                _context.Facturas.Add(fac);
                var result = await _context.SaveChangesAsync(cancellationToken);
                return result > 0;

            }
        }
    }
}


