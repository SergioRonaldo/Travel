using System;

namespace Application.DTO.Authenticate
{
    /// <summary>
    /// AuthResponse
    /// </summary>
    public class AuthResponse
    {
        /// <summary>
        /// Id
        /// </summary>
        public String Id { get; set; }
        /// <summary>
        /// UserName
        /// </summary>
        public String UserName { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        public String Password { get; set; }
        /// <summary>
        /// FullName
        /// </summary>
        public String FullName { get; set; }
    }
}
