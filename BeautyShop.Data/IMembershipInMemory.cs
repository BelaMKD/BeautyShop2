using BeautyShop.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop.Data
{
    public interface IMembershipInMemory
    {
        Membership GetMembershipbyID(int? id);
        List<Membership> GetMembrships();
    }
}
