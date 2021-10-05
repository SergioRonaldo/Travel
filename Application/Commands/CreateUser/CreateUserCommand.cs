using Application.DTO;
using MediatR;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Application.Commands
{
    public class CreateUserCommand : IRequest<CreateResponse>
    {

        [JsonProperty("UserName")]
        [Required]
        public String UserName { get; set; }

        [JsonProperty("Password")]
        [Required]
        public String Password { get; set; }

        [JsonProperty("FullName")]
        [Required]
        public String FullName { get; set; }

        public CreateUserCommand()
        {
        }


        [JsonConstructor]
        public CreateUserCommand(String userName, String password, String fullName)
        {
            this.UserName = userName;
            this.Password = password;
            this.FullName = fullName;
        }
    }
}
