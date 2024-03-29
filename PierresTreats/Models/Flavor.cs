using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }

    [Required(ErrorMessage = "Please enter a flavor name")]
    public string FlavorName { get; set; }

    public List<FlavorTreat> JoinEntities { get; }
    public ApplicationUser User { get; set; }
  }
}