using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeautyShop.Core;
using BeautyShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BeautyShop.Pages
{
    public class MembrshipsModel : PageModel
    {
        private readonly IMembershipInMemory membrshipInMemory;
        public List<Membership> Membrships { get; set; }
        public MembrshipsModel(IMembershipInMemory membrshipInMemory)
        {
            this.membrshipInMemory = membrshipInMemory;
        }
        public void OnGet()
        {
            Membrships = membrshipInMemory.GetMembrships();
        }
    }
}