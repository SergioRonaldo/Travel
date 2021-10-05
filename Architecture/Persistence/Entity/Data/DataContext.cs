using Domain.Contract.Persistence.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Architecture.Persistence.Entity.Data
{
    public class DataContext : DbContext, IDataContext
    {
        public IConfiguration Configuration { get; }
        public DataContext(DbContextOptions<DataContext> options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Autores> Autores { get; set; }
        public DbSet<Editoriales> Editoriales { get; set; }
        public DbSet<Libros> Libros { get; set; }
        public DbSet<Autores_has_Libros> Autores_has_Libros { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Inventario> Inventario { get; set; }
        public DbSet<Facturas> Facturas { get; set; }
        public DbSet<FacturaDetalle> FacturaDetalle { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Autores_has_Libros>()
                .HasKey(c => new { c.Autores_Id, c.Libros_ISBN });

            modelBuilder.Entity<Autores_has_Libros>()
                .HasOne(a => a.autor)
                .WithMany(b => b.Autores_has_Libros)
                .HasForeignKey(a => a.Autores_Id);

            modelBuilder.Entity<Autores_has_Libros>()
                .HasOne(a => a.libro)
                .WithMany(b => b.Autores_has_Libros)
                .HasForeignKey(a => a.Libros_ISBN);

        }
    }
}
