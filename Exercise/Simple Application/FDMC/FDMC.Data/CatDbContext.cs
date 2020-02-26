using Microsoft.EntityFrameworkCore;
using System;
using FDMC.Data.Models;

namespace FDMC.Data
{
    public class CatDbContext : DbContext
    {
        public CatDbContext()
        {
        }

        public DbSet<Cat> Cats { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Cats;Trusted_Connection=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
