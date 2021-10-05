using Application.DTO;
using MediatR;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Application.Commands
{
    public class UpdateBalanceCommand : IRequest<CreateResponse>
    {

        [JsonProperty("Book_ISBN")]
        [Required]
        public int Book_ISBN { get; set; }

        [JsonProperty("AmountEntered")]
        [Required]
        public decimal AmountEntered { get; set; }

        public UpdateBalanceCommand()
        {
        }


        [JsonConstructor]
        public UpdateBalanceCommand(int Book_ISBN, decimal AmountEntered)
        {
            this.Book_ISBN = Book_ISBN;
            this.AmountEntered = AmountEntered;
        }
    }
}
