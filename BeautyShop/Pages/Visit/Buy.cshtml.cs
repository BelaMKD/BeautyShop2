using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeautyShop.Core;
using BeautyShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BeautyShop
{
    public class BuyModel : PageModel
    {
        private readonly IVisitInMemory visitInMemory;
        private readonly IPersonInMemory personInMemory;

        public List<SelectListItem> CustomerNames { get; set; }
        [BindProperty]
        public Visit Visit { get; set; }
        public BuyModel(IVisitInMemory visitInMemory,IPersonInMemory personInMemory)
        {
            this.visitInMemory = visitInMemory;
            this.personInMemory = personInMemory;
        }
        public void OnGet()
        {
            Visit = new Visit();
            CustomerNames = personInMemory.GetPeople().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();
        }

        //public IActionResult OnPost()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var person = personInMemory.GetPerson(Visit.Person.Id);
        //        Visit.Person = person;
        //        Visit = visitInMemory.AddVisit(Visit);
        //        TempData["Message"] = "Thank you for your purchase!";
        //    }
        //}

        public IActionResult OnPostBuy(double product)
        {
            if (product>0)
            {
                Visit.Products.Add(product);
            }
            return Page();
        }
    }
}