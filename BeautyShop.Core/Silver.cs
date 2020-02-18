using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop.Core
{
    public class Silver : Membership
    {
        public Silver()
        {
            Id = 2;
        }
        public override double DiscountService()
        {
            return 0.1;
        }

        public override string GetMembrshipType()
        {
            return "Silver";
        }
    }
}
