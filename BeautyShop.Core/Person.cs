using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BeautyShop.Core
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool IsMember 
        {
            get 
            {
                return Membership != null;
            }
            
        }
        [Display(Name = "Membership Type")]
        public int? MembershipId { get; set; }
        public Membership Membership { get; set; }
    }
}
