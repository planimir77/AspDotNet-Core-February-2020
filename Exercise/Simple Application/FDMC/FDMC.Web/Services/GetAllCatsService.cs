using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDMC.Data;
using FDMC.Web.Models.Home;

namespace FDMC.Web.Services
{
    public class GetAllCatsService : IGetAllCatsService
    {
        private readonly CatDbContext db;

        public GetAllCatsService(CatDbContext db)
        {
            this.db = db;
        }

        public IndexViewModel GetAllCats()
        {
            var  cats = this.db.Cats.Select(x=> new CatInfoViewModel
            {
                Id= x.Id,
                Name = x.Name
            }).ToList();
            
            var result = new IndexViewModel
            {
                CatInfo = cats
            };
            
            return result;
        }
    }
}
