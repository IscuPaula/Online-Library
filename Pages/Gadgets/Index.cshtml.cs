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
    public class IndexModel : PageModel
    {
        private readonly Proiect_Paula_Iscu.Data.Proiect_Paula_IscuContext _context;

        public IndexModel(Proiect_Paula_Iscu.Data.Proiect_Paula_IscuContext context)
        {
            _context = context;
        }

        public IList<Gadget> Gadget { get;set; }

        public async Task OnGetAsync()
        {
            Gadget = await _context.Gadget.ToListAsync();
        }
    }
}
