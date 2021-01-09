using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_Paula_Iscu.Models
{
    public class Gadget
    {
        public int ID { get; set; }
        [Display(Name = "Gadget")]
        public string Name { get; set; }
        public string Brand { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public string Color { get; set; }

    }
}
