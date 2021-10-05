using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Architecture.Persistence.Entity
{
    /// <summary>
    /// Libros
    /// </summary>
    /// 
    [Table("Libros", Schema = "Travel")]
    public class Libros
    {
        public Libros()
        {
            this.Autores_has_Libros = new List<Autores_has_Libros>();
            this.FacturaDetalle = new List<FacturaDetalle>();
            this.Inventario = new List<Inventario>();
        }
        /// <summary>
        /// ISBN
        /// </summary>
        /// 
        [Key]
        public int ISBN { get; set; }
        /// <summary>
        /// Editoriales_Id
        /// </summary>
        public int Editoriales_Id { get; set; }
        /// <summary>
        /// Titulo
        /// </summary>
        public String Titulo { get; set; }

        /// <summary>
        /// Sinopsis
        /// </summary>
        public String Sinopsis { get; set; }

        /// <summary>
        /// N_Paginas
        /// </summary>
        public int N_Paginas { get; set; }

        /// <summary>
        /// Autores_has_Libros
        /// </summary>
        /// 
        public virtual List<Autores_has_Libros> Autores_has_Libros { get; set; }

        /// <summary>
        /// Inventario
        /// </summary>
        /// 
        public virtual List<Inventario> Inventario { get; set; }

        /// <summary>
        /// FacturaDetalle
        /// </summary>
        /// 
        public virtual List<FacturaDetalle> FacturaDetalle { get; set; }
    }
}
