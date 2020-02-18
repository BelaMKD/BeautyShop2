using BeautyShop.Core;
using System.Collections.Generic;

namespace BeautyShop.Data
{
    public interface IVisitInMemory
    {
        Visit GetVisit(int id);
        IEnumerable<Visit> GetVisits();
        Visit AddVisit(Visit visit);
        Visit Update(Visit visit);
    }
}
