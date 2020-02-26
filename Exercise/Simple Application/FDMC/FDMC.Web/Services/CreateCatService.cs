using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDMC.Data;
using FDMC.Data.Models;
using FDMC.Web.Models;
using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace FDMC.Web.Services
{
    public class CreateCatService : ICreateCatService
    {
        private readonly CatDbContext db;

        public CreateCatService(CatDbContext db)
        {
            this.db = db;
        }

        public int CreateCat(string name, int age, string breed, string image)
        {
            var cat = new Cat
            {
                Name = name,
                Age = age,
                Breed = breed,
                Image = image
            };
            this.db.Cats.Add(cat);
            this.db.SaveChanges();

            return cat.Id;
        }
    }
}
