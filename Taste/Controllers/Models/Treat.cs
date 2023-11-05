using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Taste.Models
{

    public class Treat
    {
        public int TreatId { get; set; }

        public string Name {get; set;}

        public string Description {get; set;}

        public Flavor flavor { get; set; }

        public virtual List<TreatFlavor> JoinEntities { get; set; }
    }

}