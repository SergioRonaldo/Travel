using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Architecture.Persistence.Entity
{
    /// <summary>
    /// Autores_has_Libros
    /// </summary>
    /// 
    [Table("Autores_has_Libros", Schema = "Travel")]
    public class Autores_has_Libros
    {

        /// <summary>
        /// Autores_Id
        /// </summary>
        /// 
        public int Autores_Id { get; set; }
        /// <summary>
        /// Libros_ISBN
        /// </summary>
        /// 
        public int Libros_ISBN { get; set; }

        [ForeignKey("Autores_Id")]
        public virtual Autores autor { get; set; }
        [ForeignKey("Libros_ISBN")]
        public virtual Libros libro { get; set; }
    }
}
