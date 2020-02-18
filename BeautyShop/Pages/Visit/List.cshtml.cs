using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeautyShop.Core;
using BeautyShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BeautyShop.Pages.Visit
{
    public class ListModel : PageModel
    {
        private readonly IVisitInMemory visitInMemory;
        private readonly IPersonInMemory personInMemory;

        public IEnumerable<Core.Visit> Visits { get; set; }
        public IEnumerable<Person> People { get; set; }
        public ListModel(IVisitInMemory visitInMemory, IPersonInMemory personInMemory)
        {
            this.visitInMemory = visitInMemory;
            this.personInMemory = personInMemory;
        }
        public void OnGet()
        {
            Visits = visitInMemory.GetVisits();
            People = personInMemory.GetPeople();
        }
    }
}