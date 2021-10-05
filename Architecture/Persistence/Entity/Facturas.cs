using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Persistence.Entity
{
    /// <summary>
    /// Facturas
    /// </summary>
    /// 
    [Table("Facturas", Schema = "Travel")]
    public class Facturas
    {
        public Facturas()
        {
            this.FacturaDetalle = new HashSet<FacturaDetalle>();
        }
        /// <summary>
        /// Id
        /// </summary>
        /// 
        public int Id { get; set; }
        /// <summary>
        /// Clientes_Id
        /// </summary>
        public int Clientes_Id { get; set; }
        /// <summary>
        /// NumeroFactura
        /// </summary>
        public String NumeroFactura { get; set; }
        /// <summary>
        /// FechaSalida
        /// </summary>
        public DateTime FechaSalida { get; set; }
        /// <summary>
        /// TotalFactura
        /// </summary>
        public decimal TotalFactura { get; set; }

        [ForeignKey("Clientes_Id")]
        public virtual Clientes Cliente { get; set; }

        public virtual ICollection<FacturaDetalle> FacturaDetalle { get; set; }
    }
}
