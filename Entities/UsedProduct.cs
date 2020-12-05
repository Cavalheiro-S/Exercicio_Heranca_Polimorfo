using System;
using System.Collections.Generic;
using System.Text;

namespace Exec_Fixação_Herança_Polimorf.Entities
{
    class UsedProduct : Product
    {
        public DateTime manufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price,DateTime manufactureDate): base(name, price)
        {
            this.manufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            string tag;
            tag = $"{name} (used) $ {price} (Manufacture date: {manufactureDate.ToString("dd/mm/yyyy")})";
            return tag;
        }
    }
}
