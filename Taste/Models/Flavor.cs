using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Taste.Models
{

    public class Flavor
    {
        public int FlavorId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "You must add your item to a category. Have you created a category yet?")]

        public int TreatId { get; set; }
        public Treat treat { get; set; }

        public virtual List<TreatFlavor> JoinEntities { get; set; }

        public ApplicationUser User { get; set; } 
    }
}

