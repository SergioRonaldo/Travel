using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Architecture.Persistence.Entity
{
    /// <summary>
    /// Editoriales
    /// </summary>
    /// 
    [Table("Editoriales", Schema = "Travel")]
    public class Editoriales
    {
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
        /// Sede
        /// </summary>
        public String Sede { get; set; }
    }
}
