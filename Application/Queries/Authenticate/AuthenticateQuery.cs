using MediatR;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Application.Queries.Authenticate
{
    public class AuthenticateQuery : IRequest<bool>
    {
        [JsonProperty("userName")]
        [Required]
        [MaxLength(255)]
        public String UserName { get; set; }

        [JsonProperty("password")]
        [Required]
        [MaxLength(255)]
        public String Password { get; set; }

        public AuthenticateQuery()
        {

        }

        [JsonConstructor]
        public AuthenticateQuery(String userName, String password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
