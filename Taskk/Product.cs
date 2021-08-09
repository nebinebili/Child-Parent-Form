using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskk
{
    public class Product
    {
        public Product(string name, string country, double cost)
        {
            Name = name;
            Country = country;
            Cost = cost;
        }

        public string Name { get; set; }
        public string Country { get; set; }
        public double Cost { get; set; }

        public override string ToString()
        {
            return $"{Name}   \tCountry:{Country}    \tCost:{Cost}";
        }
    }
}
