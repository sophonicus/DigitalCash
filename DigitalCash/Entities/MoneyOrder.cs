using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigitalCash.Entities
{
    public class MoneyOrder
    {
        public Guid UniqueID { get; set; }
        public double Amount { get; set; }
        public string[] PayerIdentityStrings { get; set; }
        public string[] Payee { get; set; }
        public string BankSignature { get; set; }
    }
}