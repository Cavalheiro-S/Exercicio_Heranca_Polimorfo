using System;
using System.Collections.Generic;
using System.Text;

namespace Exec_Fixação_Herança_Polimorf.Entities
{
    class UserProduct : Product
    {
        public DateTime manufactureDate { get; set; }

        public override string priceTag()
        {
            string tag;
            tag = $"{name} (used) $ {price} (Manufacture date: {manufactureDate.ToString("dd/mm/yyyy")})";
            return tag;
        }
    }
}
