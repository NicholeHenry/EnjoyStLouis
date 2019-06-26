using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnjoyStLouis.Models
{
    public class RateReview : IModel
    {
        
        
        public int Id { get; set; }
        public string BuisnessName { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public int BuisnessId { get; set; }
    }
}
