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
    public class DetailsModel : PageModel
    {
        private readonly Proiect_Paula_Iscu.Data.Proiect_Paula_IscuContext _context;

        public DetailsModel(Proiect_Paula_Iscu.Data.Proiect_Paula_IscuContext context)
        {
            _context = context;
        }

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
    }
}
