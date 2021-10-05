using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Architecture.Persistence.Entity
{
    /// <summary>
    /// Usuarios
    /// </summary>
    /// 
    [Table("Usuarios", Schema = "Travel")]
    public class Usuarios
    {
        /// <summary>
        /// Id
        /// </summary>
        /// 
        public int Id { get; set; }
        /// <summary>
        /// NombreUsuario
        /// </summary>
        public String NombreUsuario { get; set; }
        /// <summary>
        /// Contrasena
        /// </summary>
        public String Contrasena { get; set; }
        /// <summary>
        /// NombreCompleto
        /// </summary>
        public String NombreCompleto { get; set; }
    }
}
