using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PierresTreats.Models
{
    public class Treat
    {
        public int TreatId { get; set; }

        [Required(ErrorMessage = "Please enter a treat name")]
        public string TreatName { get; set; }
        public List<FlavorTreat> JoinEntities { get; }
        public ApplicationUser User { get; set; }
    }
}