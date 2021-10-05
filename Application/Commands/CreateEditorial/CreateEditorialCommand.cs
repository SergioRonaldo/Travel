using Application.DTO;
using MediatR;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Application.Commands
{
    public class CreateEditorialCommand : IRequest<CreateResponse>
    {

        [JsonProperty("Name")]
        [Required]
        public String Name { get; set; }

        [JsonProperty("Branch")]
        [Required]
        public String Branch { get; set; }

        public CreateEditorialCommand()
        {
        }


        [JsonConstructor]
        public CreateEditorialCommand(String name, String branch)
        {
            this.Name = name;
            this.Branch = branch;
        }
    }
}
