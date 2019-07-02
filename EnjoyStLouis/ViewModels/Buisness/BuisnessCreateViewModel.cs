using EnjoyStLouis.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EnjoyStLouis.ViewModels
{
    public class BuisnessCreateViewModel
    {
        private Factory repositoryFactory;
        [Required(ErrorMessage="Name must be included")]
        public string Name { get; set; }
        [Required(ErrorMessage="Description must be included")]
        [StringLength(2-200)]
        public string Description { get; set; }
        public List<string> Region { get;  set; }
        public List<string> Categories { get; set; }

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
