using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_Paula_Iscu.Models;

namespace Proiect_Paula_Iscu.Data
{
    public class Proiect_Paula_IscuContext : DbContext
    {
        public Proiect_Paula_IscuContext (DbContextOptions<Proiect_Paula_IscuContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_Paula_Iscu.Models.Gadget> Gadget { get; set; }
    }
}
