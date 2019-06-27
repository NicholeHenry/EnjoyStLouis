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
        private string ratings = "12345";

        private readonly Factory repositoryFactory;

        public int Id { set; get; }
        public string BuisnessName { get; set; }
        public string Review { get; set; }
        public int Rating { get; set; }
        public int BuisnessId { get; set; }

        public SelectList Ratings { get { return GetRatings(); } }

        public RateReviewCreateViewModel(Factory repositoryFactory)
        {
            this.repositoryFactory = repositoryFactory;
        }
       
       private SelectList GetRatings()
        {
            var rateSelectedItem = ratings.Select(r => new SelectListItem(r.ToString(), r.ToString()));
            return new SelectList(rateSelectedItem);
        }

       

        internal void Persist()
        {
            Models.RateReview rateReview = new Models.RateReview
            {

                BuisnessId = this.BuisnessId,
                Rating = this.Rating,
                Review = this.Review,
                BuisnessName = this.BuisnessName
            };

            repositoryFactory.GetRateReviewRepository().Save(rateReview);
        }

    }
}
 