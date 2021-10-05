namespace Domain.Entities
{
    /// <summary>
    /// Balance
    /// </summary>
    public class Balance
    {
        /// <summary>
        /// Id
        /// </summary>
        /// 
        public int Id { get; set; }
        /// <summary>
        /// Book_ISBN
        /// </summary>
        public int Book_ISBN { get; set; }
        /// <summary>
        /// Amount Entered
        /// </summary>
        public decimal AmountEntered { get; set; }
        /// <summary>
        /// Output Quantity
        /// </summary>
        public decimal OutputQuantity { get; set; }
    }
}
