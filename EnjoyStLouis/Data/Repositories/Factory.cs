using EnjoyStLouis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnjoyStLouis.Data.Repositories
{
    public class Factory
    {

        private ApplicationDbContext context;

        public Factory(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IRepository<Buisness> GetBuisnessRepository()
        {
            return new BaseRepository<Buisness>(context);
        }
    }
}
