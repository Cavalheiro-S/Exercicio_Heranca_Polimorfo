using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exec_Fixação_Herança_Polimorf.Entities
{
    class Product
    {
        public string name { get; set; }
        public double price { get; set; }

        public Product() { }

        public Product(string name, double price) 
        {
            this.name = name;
            this.price = price;
        }

        public virtual string priceTag()
        {
            string Tag;
            Tag = $"{name} $ {price.ToString("F2", CultureInfo.InvariantCulture)}";
            return Tag;
        }
    }
}
