using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.CodeAnalysis;
using FDMC.Data.Models;
using Microsoft.Extensions.Configuration;

namespace FDMC.Data
{
    public class CatDbContext : DbContext
    {
        public CatDbContext()
        {
        }

        public CatDbContext([NotNull] DbContextOptions options) 
            : base(options)
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
