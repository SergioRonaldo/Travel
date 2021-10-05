namespace Domain.Entities
{
    /// <summary>
    /// DetailInvoice
    /// </summary>
    public class DetailInvoice
    {
        /// <summary>
        /// Id
        /// </summary>
        /// 
        public int Id { get; set; }
        /// <summary>
        /// Libros_ISBN
        /// </summary>
        public int Book_ISBN { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        public decimal Quantity { get; set; }
        /// <summary>
        /// Value
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        public decimal Total { get; set; }
    }
}
