using System;

namespace Application.DTO
{
    /// <summary>
    /// CreateAuthorResponse
    /// </summary>
    public class CreateAuthorResponse
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Author Name
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// Author LastName
        /// </summary>
        public String LastName { get; set; }
    }
}
