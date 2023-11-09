
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;


namespace Taste.Models
{
  public class TreatFlavor
  {
    public int TreatFlavorId { get; set; }
    public int FlavorId { get; set; }
    public int TreatId { get; set; }
    public Flavor flavor { get; set; }
    public Treat treat { get; set; }
  }
}