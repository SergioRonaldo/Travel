using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Customer
    {
        /// <summary>
        /// Id
        /// </summary>
        /// 
        public int Id { get; set; }
        /// <summary>
        /// TypeDocuments_Id
        /// </summary>
        /// 
        public int TypeDocuments_Id { get; set; }
        /// <summary>
        /// DocumentNumber
        /// </summary>
        public String DocumentNumber { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// LastName
        /// </summary>
        public String LastName { get; set; }
    }
}
