using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    /// <summary>
    /// Invoice
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// Id
        /// </summary>
        /// 
        public int Id { get; set; }
        /// <summary>
        /// Customer_Id
        /// </summary>
        public int Customer_Id { get; set; }
        /// <summary>
        /// InvoceNumber
        /// </summary>
        public String InvoceNumber { get; set; }
        /// <summary>
        /// InvoiceDate
        /// </summary>
        public decimal InvoiceDate { get; set; }
        /// <summary>
        /// Total
        /// </summary>
        public decimal Total { get; set; }
        /// <summary>
        /// DetailInvoiceList
        /// </summary>
        public List<DetailInvoice> DetailInvoiceList = new List<DetailInvoice>();
    }
}
