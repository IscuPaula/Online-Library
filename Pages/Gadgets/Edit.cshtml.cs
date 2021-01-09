using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect_Paula_Iscu.Data;
using Proiect_Paula_Iscu.Models;

namespace Proiect_Paula_Iscu.Pages.Gadgets
{
    public class EditModel : PageModel
    {
        private readonly Proiect_Paula_Iscu.Data.Proiect_Paula_IscuContext _context;

        public EditModel(Proiect_Paula_Iscu.Data.Proiect_Paula_IscuContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Gadget).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GadgetExists(Gadget.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GadgetExists(int id)
        {
            return _context.Gadget.Any(e => e.ID == id);
        }
    }
}
