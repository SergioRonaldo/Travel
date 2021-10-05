using System;

namespace Domain.Exceptions
{
    public class BookNotFoundException : Exception
    {
        public BookNotFoundException() : base("Book Not Found")
        {
        }
    }
}
