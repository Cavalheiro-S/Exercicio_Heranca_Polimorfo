using System;
using System.Collections.Generic;
using System.Text;

namespace Exec_Fixação_Herança_Polimorf.Entities
{
    class Product
    {
        public string name { get; set; }
        public double price { get; set; }

        public virtual string priceTag()
        {
            string Tag;
            Tag = $"{name} $ {price}";
            return Tag;
        }
    }
}
