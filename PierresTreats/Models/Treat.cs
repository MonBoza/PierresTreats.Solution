using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresTreats.Models
{
    public class Treat
    {
        public int TreatId { get; set; }

        [Required(ErrorMessage = "Please enter a treat name")]
        public string TreatName { get; set; }
        public List<FlavorTreat> JoinEntities { get; }
    }
}