using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    /// <summary>
    /// Class Book
    /// </summary>
    public class Book
    {
        /// <summary>
        /// ISBN
        /// </summary>
        /// 
        public int ISBN { get; set; }
        /// <summary>
        /// Editoriales_Id
        /// </summary>
        public int Editoriales_Id { get; set; }

        /// <summary>
        /// AuthorList
        /// </summary>
        public List<Author> AuthorList = new List<Author>();
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
