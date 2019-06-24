using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnjoyStLouis.Data.Repositories;
using EnjoyStLouis.Models;
using Microsoft.AspNetCore.Mvc;


namespace EnjoyStLouis.ViewModels
{
    public class BuisnessListViewModel
    {
        public static List<BuisnessListViewModel> GetBuisness(Factory repositoryFactory)
        {
            return repositoryFactory.GetBuisnessRepository()
                .GetModels()
                .Select(m => new BuisnessListViewModel(m))
                .ToList();
        }

        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public BuisnessListViewModel (Buisness buisness)
        {
            this.Id = buisness.Id;
            this.Name = buisness.Name;
            this.Description = buisness.Description;
        }

    }
}
