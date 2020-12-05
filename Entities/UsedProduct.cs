using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

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
            tag = $"{name} (used) $ {price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {manufactureDate})";
            return tag;
        }
    }
}
