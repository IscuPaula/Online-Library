using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_Paula_Iscu.Data;
using Proiect_Paula_Iscu.Models;

namespace Proiect_Paula_Iscu.Pages.Gadgets
{
    public class CreateModel : PageModel
    {
        private readonly Proiect_Paula_Iscu.Data.Proiect_Paula_IscuContext _context;

        public CreateModel(Proiect_Paula_Iscu.Data.Proiect_Paula_IscuContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Gadget Gadget { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Gadget.Add(Gadget);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
