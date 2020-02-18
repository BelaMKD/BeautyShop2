using System;

namespace BeautyShop.Core
{
    public abstract class Membership
    {
        public int Id { get; set; }

        public abstract double DiscountService();
        public abstract string GetMembrshipType();
        public virtual double DiscountProduct()
        {
            return 0.1;
        }
    }
}
