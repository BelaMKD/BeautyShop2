using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop.Core
{
    public class Gold : Membership
    {
        public Gold()
        {
            Id = 1;
        }
        public override double DiscountService()
        {
            return 0.15;
        }

        public override string GetMembrshipType()
        {
            return "Gold";
        }
    }
}
