using System;
using System.Collections.Generic;
using System.Linq;
using BeautyShop.Core;

namespace BeautyShop.Data
{
    public class MembershipInMemory : IMembershipInMemory
    {
        public List<Membership> Memberships { get; set; }
        public MembershipInMemory()
        {
            Memberships = new List<Membership>
            {
                new Gold(),
                new Silver(),
                new Bronze()
            };
        }
        public List<Membership> GetMembrships()
        {
            return Memberships;
        }

        public Membership GetMembershipbyID(int? id)
        {
            return Memberships.SingleOrDefault(x => x.Id == id);
        }
    }
}
