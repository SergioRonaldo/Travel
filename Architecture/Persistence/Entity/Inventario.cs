using System.ComponentModel.DataAnnotations.Schema;

namespace Architecture.Persistence.Entity
{
    /// <summary>
    /// Inventario
    /// </summary>
    /// 
    [Table("Inventario", Schema = "Travel")]
    public class Inventario
    {
        /// <summary>
        /// Id
        /// </summary>
        /// 
        public int Id { get; set; }
        /// <summary>
        /// Libros_ISBN
        /// </summary>
        public int Libros_ISBN { get; set; }
        /// <summary>
        /// CantidadIngresada
        /// </summary>
        public decimal CantidadIngresada { get; set; }
        /// <summary>
        /// CantidadSalida
        /// </summary>
        public decimal CantidadSalida { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        [ForeignKey("Libros_ISBN")]
        public virtual Libros Libro { get; set; }
    }
}
