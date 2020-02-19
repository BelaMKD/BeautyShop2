using BeautyShop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeautyShop.Data
{
    public class VisitInMemory : IVisitInMemory
    {
        public List<Visit> Visits { get; set; }
        public VisitInMemory()
        {
            Visits = new List<Visit>();
        }
        public Visit AddVisit(Visit visit)
        {
            visit.Id = Visits.Any() ? Visits.Max(x => x.Id) + 1 : 1;
            Visits.Add(visit);
            return visit;
        }

        public Visit GetVisit(int id)
        {
            return Visits.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Visit> GetVisits()
        {
            return Visits;
        }

        public Visit Update(Visit visit)
        {
            throw new NotImplementedException();
        }
    }
}
