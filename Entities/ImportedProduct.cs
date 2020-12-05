using System;
using System.Collections.Generic;
using System.Text;

namespace Exec_Fixação_Herança_Polimorf.Entities
{
    class ImportedProduct : Product
    {
        public double customsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            this.customsFee = customsFee;
        }

        public override string priceTag()
        {
            string tag;
            tag = base.priceTag() + $" (Customs fee: $ {customsFee})";
            return tag;
        }
        
        public double totalPrice()
        {
            double total = 0.0;

            total = price + customsFee;
            return total;
        }
    }
}
