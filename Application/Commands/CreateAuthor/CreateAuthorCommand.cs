using Application.DTO;
using MediatR;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Application.Commands
{
    public class CreateAuthorCommand : IRequest<CreateResponse>
    {

        [JsonProperty("Name")]
        [Required]
        public String Name { get; set; }

        [JsonProperty("LastName")]
        [Required]
        public String LastName { get; set; }

        public CreateAuthorCommand()
        {
        }


        [JsonConstructor]
        public CreateAuthorCommand(String name, String lastName)
        {
            this.Name = name;
            this.LastName = lastName;
        }
    }
}
