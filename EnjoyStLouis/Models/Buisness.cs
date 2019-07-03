using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnjoyStLouis.Models
{
    public class Buisness : IModel

    { 
        public int Id { set; get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<RateReview> RatingAndReviews { get; set; }
        public Regions Region {get;set;}
        public virtual List<Category> Categories { get; set; }

    }
}
