using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop.Core
{
    public class Visit
    {
        public int Id { get; set; }
        public Person Person { get; set; }
        public List<double> Products { get; set; }
        public List<double> Services { get; set; }
        public Visit()
        {
            Products = new List<double>();
            Services = new List<double>();
        }
        public void AddProduct(double price)
        {
            Products.Add(price);
        }
        public void AddService(double price)
        {
            Services.Add(price);
        }
        public double TotalPay()
        {
            var total = 0.0;
            foreach (var price in Products)
            {
                if (Person.IsMember)
                {
                    total += price * (1 - Person.Membership.DiscountProduct());
                }
                else
                {
                    total += price;
                }
            }
            foreach (var price in Services)
            {
                if (Person.IsMember)
                {
                    total += price * (1 - Person.Membership.DiscountService());
                }
                else
                {
                    total += price;
                }
            }
            return total;
        }
    }
}
