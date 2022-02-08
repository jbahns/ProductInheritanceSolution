using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInheritance
{
    public class Software : Product
    {
        public bool Book { get; set; } = true;

        public override string ToPrint()
        {
            string message = $"{base.ToPrint()}| {(Book ? "Yes" : "No")}";
            return message;
        }

        public Software(string code, decimal price, bool book) : base(code, price)
        {
            Book = book;
        }
        public Software()
        {

        }
    }
}
