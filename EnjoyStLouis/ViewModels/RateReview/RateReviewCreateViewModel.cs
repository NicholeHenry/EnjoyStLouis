using EnjoyStLouis.Data.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnjoyStLouis.Data;
using EnjoyStLouis.Models;

namespace EnjoyStLouis.ViewModels.RateReview
{
    public class RateReviewCreateViewModel
    {
       

        private readonly Factory repositoryFactory;

        public int Id { set; get; }
        
        public string Review { get; set; }
        public int Rating { get; set; }
        public int BuisnessId { get; set; }
       

        public RateReviewCreateViewModel(Factory repositoryFactory)
        {
            this.repositoryFactory = repositoryFactory;
        }

        


        internal void Persist()
        {
            Models.RateReview rateReview = new Models.RateReview
            {

                BuisnessId = this.BuisnessId,
                Rating = this.Rating,
                Review = this.Review,
               
            };

            repositoryFactory.GetRateReviewRepository().Save(rateReview);
        }

    }
}
 