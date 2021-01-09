using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Paula_Iscu.Data;
using Proiect_Paula_Iscu.Models;

namespace Proiect_Paula_Iscu.Pages.Gadgets
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect_Paula_Iscu.Data.Proiect_Paula_IscuContext _context;

        public DeleteModel(Proiect_Paula_Iscu.Data.Proiect_Paula_IscuContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Gadget Gadget { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gadget = await _context.Gadget.FirstOrDefaultAsync(m => m.ID == id);

            if (Gadget == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gadget = await _context.Gadget.FindAsync(id);

            if (Gadget != null)
            {
                _context.Gadget.Remove(Gadget);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
