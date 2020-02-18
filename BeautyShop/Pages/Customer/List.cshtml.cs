using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeautyShop.Core;
using BeautyShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BeautyShop
{
    public class ListModel : PageModel
    {
        private readonly IPersonInMemory personInMemory;
        [BindProperty (SupportsGet = true)]
        public string SearchName { get; set; }
        [TempData]
        public string Message { get; set; }
        public IEnumerable<Person> People { get; set; }
        public ListModel(IPersonInMemory personInMemory)
        {
            this.personInMemory = personInMemory;
        }
        public void OnGet()
        {
            People = personInMemory.GetPeople(SearchName);
        }
    }
}