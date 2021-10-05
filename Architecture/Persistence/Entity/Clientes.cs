using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Architecture.Persistence.Entity
{
    /// <summary>
    /// Clientes
    /// </summary>
    /// 
    [Table("Clientes", Schema = "Travel")]
    public class Clientes
    {
        /// <summary>
        /// Id
        /// </summary>
        /// 
        public int Id { get; set; }
        /// <summary>
        /// TipoDocumentos_Id
        /// </summary>
        /// 
        public int TipoDocumentos_Id { get; set; }
        /// <summary>
        /// NumeroDocumento
        /// </summary>
        public String NumeroDocumento { get; set; }
        /// <summary>
        /// Nombres
        /// </summary>
        public String Nombres { get; set; }
        /// <summary>
        /// Apellidos
        /// </summary>
        public String Apellidos { get; set; }
    }
}
