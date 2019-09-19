using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime GetDateTime { get; set; }
        public string Type { get; set; }
        public double Amount { get; set; }

    }
}
