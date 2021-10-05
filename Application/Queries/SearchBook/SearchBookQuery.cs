using Application.DTO;
using MediatR;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Application.Queries
{
    public class SearchBookQuery : IRequest<SearchBookResponse>
    {
        [JsonProperty("ISBN")]
        [Required]
        [MaxLength(255)]
        public int ISBN { get; set; }


        public SearchBookQuery()
        {

        }

        [JsonConstructor]
        public SearchBookQuery(int ISBN)
        {
            this.ISBN = ISBN;
        }
    }
}
