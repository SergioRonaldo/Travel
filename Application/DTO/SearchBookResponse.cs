using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Application.DTO
{
    /// <summary>
    /// class SearchBookResponse
    /// </summary>
    public class SearchBookResponse
    {
        public SearchBookResponse()
        {

        }
        /// <summary>
        /// ISBN
        /// </summary>
        public int ISBN { get; set; }
        /// <summary>
        /// Editorial
        /// </summary>
        public int Editorial { get; set; }
        /// <summary>
        /// Title
        /// </summary>
        public String Title { get; set; }
        /// <summary>
        /// Synopsis
        /// </summary>
        public String Synopsis { get; set; }
        /// <summary>
        /// N_Pages
        /// </summary>
        public int N_Pages { get; set; }
        /// <summary>
        /// Authors
        /// </summary>
        public List<Author> Authors { get; set; }
        /// <summary>
        /// AmountEntered
        /// </summary>
        public decimal AmountEntered { get; set; }
        /// <summary>
        /// OutputQuantity
        /// </summary>
        public decimal OutputQuantity { get; set; }
        /// <summary>
        /// QuantityAvailable
        /// </summary>
        public decimal QuantityAvailable { get; set; }
    }
}
