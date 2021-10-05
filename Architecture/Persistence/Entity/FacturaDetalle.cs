using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Architecture.Persistence.Entity
{
    /// <summary>
    /// FacturaDetalle
    /// </summary>
    /// 
    [Table("FacturaDetalle", Schema = "Travel")]
    public class FacturaDetalle
    {
        /// <summary>
        /// Id
        /// </summary>
        /// 
        public int Id { get; set; }
        /// <summary>
        /// Facturas_Id
        /// </summary>
        public int Facturas_Id { get; set; }
        /// <summary>
        /// Libros_ISBN
        /// </summary>
        public int Libros_ISBN { get; set; }
        /// <summary>
        /// Cantidad
        /// </summary>
        public decimal Cantidad { get; set; }
        /// <summary>
        /// ValorUnitario
        /// </summary>
        public decimal ValorUnitario { get; set; }

        [ForeignKey("Facturas_Id")]
        public virtual Facturas Factura { get; set; }
        [ForeignKey("Libros_ISBN")]
        public virtual Libros Libro { get; set; }
    }
}
