using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDMC.Data;
using FDMC.Web.Models.Cats;
using FDMC.Web.Models.Home;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace FDMC.Web.Services
{
    public class CatDetailsServices : ICatDetailsServices
    {
        private readonly CatDbContext _db;

        public CatDetailsServices(CatDbContext db)
        {
            _db = db;
        }
        public CatDetailsViewModel CatInfo(string catId)
        {
            CatDetailsViewModel result = _db.Cats.Where(cat => cat.Id == int.Parse(catId)).Select(cat => new CatDetailsViewModel
            {
                Name = cat.Name,
                Image = cat.Image,
                Age = cat.Age,
                Breed = cat.Breed
            })
                .FirstOrDefault();

            return result;
        }
    }
}
