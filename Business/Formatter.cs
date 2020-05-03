using System;

namespace Business
{
    public class Formatter
    {
        public string PrintReceipt(decimal amount, DateTime date)
        {
            return $"The price on {date:d} is {amount:C}";
        }
    }
}