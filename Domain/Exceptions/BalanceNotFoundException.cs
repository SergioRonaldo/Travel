using System;

namespace Domain.Exceptions
{
    public class BalanceNotFoundException : Exception
    {
        public BalanceNotFoundException() : base("Balance Not Found")
        {
        }
    }
}
