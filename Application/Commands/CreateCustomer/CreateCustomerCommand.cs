using Application.DTO;
using MediatR;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Application.Commands
{
    public class CreateCustomerCommand : IRequest<CreateResponse>
    {

        [JsonProperty("TypeDocuments_Id")]
        [Required]
        public int TypeDocuments_Id { get; set; }

        [JsonProperty("DocumentNumber")]
        [Required]
        public String DocumentNumber { get; set; }

        [JsonProperty("Name")]
        [Required]
        public String Name { get; set; }

        [JsonProperty("LastName")]
        [Required]
        public String LastName { get; set; }

        public CreateCustomerCommand()
        {
        }


        [JsonConstructor]
        public CreateCustomerCommand(int TypeDocuments_Id, String DocumentNumber, String Name, String LastName)
        {
            this.TypeDocuments_Id = TypeDocuments_Id;
            this.DocumentNumber = DocumentNumber;
            this.Name = Name;
            this.LastName = LastName;
        }
    }
}
