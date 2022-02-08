using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInheritance
{
    public class Widget : Product
    {
        public string Size { get; set; } = "Medium";
        public string Color { get; set; } = "Black";

        public override string ToPrint()
        {
            string message = $"{base.ToPrint()}| {Size} | {Color}";
            return message;
        }

        public Widget(string code, decimal price, string size, string color) : base(code, price)
        {
            Size = size;
            Color = color;
        }
    }
}
