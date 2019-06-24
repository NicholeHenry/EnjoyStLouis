using EnjoyStLouis.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnjoyStLouis.ViewModels
{
    public class BuisnessCreateViewModel
    {
        private Factory repositoryFactory;

        public string Name { get; set; }
        public string Description { get; set; }

        public BuisnessCreateViewModel() { }

        public BuisnessCreateViewModel(Factory repositoryFactory)
        {
            this.repositoryFactory = repositoryFactory;
        }

        public void Persist(Factory repositoryFactory)
        {
            Models.Buisness buisness = new Models.Buisness
            {
                Name = this.Name,
                Description = this.Description
            };
            repositoryFactory.GetBuisnessRepository().Save(buisness);
        }
    }
}
