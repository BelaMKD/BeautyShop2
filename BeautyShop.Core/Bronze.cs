using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop.Core
{
    public class Bronze : Membership
    {
        public Bronze()
        {
            Id = 3;
        }
        public override double DiscountService()
        {
            return 0.05;
        }

        public override string GetMembrshipType()
        {
            return "Bronze";
        }
    }
}
