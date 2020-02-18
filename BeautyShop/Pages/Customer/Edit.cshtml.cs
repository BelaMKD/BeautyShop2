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
    public class EditModel : PageModel
    {
        private readonly IPersonInMemory personInMemory;
        private readonly IMembershipInMemory membrshipInMemory;
        public List<SelectListItem> MembershipTypes { get; set; }
        [BindProperty]
        public Person Person { get; set; }

        public EditModel(IPersonInMemory personInMemory, IMembershipInMemory membrshipInMemory)
        {
            this.personInMemory = personInMemory;
            this.membrshipInMemory = membrshipInMemory;
        }
        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
            {
                Person = personInMemory.GetPerson(id.Value);
                if (Person==null)
                {
                    return RedirectToPage("./List");
                }
            }
            else
            {
                Person = new Person();
            }
            MembershipTypes = membrshipInMemory.GetMembrships().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.GetMembrshipType()
            }).ToList();
            return Page();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var membership = membrshipInMemory.GetMembershipbyID(Person.MembershipId);
                Person.Membership = membership;
                if (Person.Id==0)
                {
                    personInMemory.AddPerson(Person);
                    TempData["Message"] = "The Customer is created!";
                }
                else
                {
                    personInMemory.UpdatePerson(Person);
                    TempData["Message"] = "The Customer is updated!";
                }
                return RedirectToPage("./List");
            }
            MembershipTypes = membrshipInMemory.GetMembrships().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.GetMembrshipType()
            }).ToList();
            return Page();
        }
    }
}