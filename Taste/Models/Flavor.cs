using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Taste.Models
{

    public class Flavor
    {
        public int FlavorId { get; set; }
         [Required(ErrorMessage = "The flavor's description can't be empty!")]

        public string Description { get; set; }
        
        public string Name { get; set; }

        public virtual List<TreatFlavor> JoinEntities { get; set; }

        public ApplicationUser User { get; set; } 
    }
}

