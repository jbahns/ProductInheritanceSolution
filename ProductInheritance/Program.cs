using System;
using System.Collections.Generic;

namespace ProductInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            /*
            Service s1 = new Service("BASIC", 100, "Basic", 3);
            
            Widget w = new Widget("Widget", 543.21m, "Large", "MAX Red");
            
            Product p = new Product("Echo", 123.45m);

            products.Add(s1);
            products.Add(w);
            products.Add(p);
            */

            Product widget1 = new Widget("W1", 50, "Small", "Red");
            Product widget2 = new Widget("W2", 100, "Medium", "White");
            Product widget3 = new Widget("W3", 200, "Large", "Blue");
            Product service = new Service("SVC", 500, "Premium", 5);
            Product software = new Software("SFTW", 150, true);

            products.Add(widget1);
            products.Add(widget2);
            products.Add(widget3);
            products.Add(service);
            products.Add(software);

            decimal total = 0;

            foreach (Product prod in products)
            {
                if(prod is Widget)
                {
                    Widget w = prod as Widget;
                    Console.WriteLine($"{w.Code} {w.Price:c} {w.Size} {w.Color}");
                }
                else if(prod is Service)
                {
                    Service s = prod as Service;
                    Console.WriteLine($"{s.Code} {s.Price:c} {s.ServiceLevel} {s.NumberOfYears}");
                }
                else if(prod is Software)
                {
                    Software sftw = prod as Software;
                    Console.WriteLine($"{sftw.Code} {software.Price:c} {sftw.Book}");
                }
                else
                {
                    Console.WriteLine($"{prod.Code} {prod.Price:c}");
                }
                
                //Console.WriteLine(prod.ToPrint());
                total += prod.Price;
            }
            Console.WriteLine($"{total:c}");
        }
    }
}
