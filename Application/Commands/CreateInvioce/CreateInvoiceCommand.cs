using Application.DTO;
using Domain.Entities;
using MediatR;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Application.Commands
{
    public class CreateInvoiceCommand : IRequest<CreateResponse>
    {

        [JsonProperty("Customer_Id")]
        [Required]
        public int Customer_Id { get; set; }

        [JsonProperty("DetailInvoiceList")]
        [Required]
        public List<DetailInvoice> DetailInvoiceList { get; set; }


        public CreateInvoiceCommand()
        {
        }


        [JsonConstructor]
        public CreateInvoiceCommand(int Customer_Id, List<DetailInvoice> DetailInvoiceList)
        {
            this.Customer_Id = Customer_Id;
            this.DetailInvoiceList = DetailInvoiceList;
        }
    }
}
