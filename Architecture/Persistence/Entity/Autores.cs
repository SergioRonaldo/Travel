using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Architecture.Persistence.Entity
{
    /// <summary>
    /// Autores
    /// </summary>
    /// 
    [Table("Autores", Schema = "Travel")]
    public class Autores
    {
        public Autores()
        {
            this.Autores_has_Libros = new List<Autores_has_Libros>();
        }

        /// <summary>
        /// Id
        /// </summary>
        /// 
        public int Id { get; set; }
        /// <summary>
        /// Nombre
        /// </summary>
        public String Nombre { get; set; }
        /// <summary>
        /// Apellidos
        /// </summary>
        public String Apellidos { get; set; }

        /// <summary>
        /// Autores_has_Libros
        /// </summary>
        /// 
        public virtual List<Autores_has_Libros> Autores_has_Libros { get; set; }

    }
}
