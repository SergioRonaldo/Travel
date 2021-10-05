using Application.DTO;
using Domain.Entities;
using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Application.Commands
{
    public class CreateBookCommand : IRequest<CreateResponse>
    {

        [JsonProperty("ISBN")]
        [Required]
        public int ISBN { get; set; }

        [JsonProperty("Editoriales_Id")]
        [Required]
        public int Editoriales_Id { get; set; }


        [JsonProperty("Authors")]
        [Required]
        public List<Author> AuthorsList { get; set; }

        [JsonProperty("Title")]
        [Required]
        public String Title { get; set; }

        [JsonProperty("Synopsis")]
        [Required]
        public String Synopsis { get; set; }

        [JsonProperty("N_Pages")]
        [Required]
        public int N_Pages { get; set; }

        [JsonConstructor]
        public CreateBookCommand()
        {
        }


        [JsonConstructor]
        public CreateBookCommand(int ISBN, int Editoriales_Id, List<Author> Authors, String Title, String Synopsis, int N_Pages)
        {
            this.ISBN = ISBN;
            this.Editoriales_Id = Editoriales_Id;
            this.AuthorsList = Authors;
            this.Title = Title;
            this.Synopsis = Synopsis;
            this.N_Pages = N_Pages;
        }
    }
}
