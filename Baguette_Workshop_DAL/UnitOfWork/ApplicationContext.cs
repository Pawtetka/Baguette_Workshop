using Baguette_Workshop_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_DAL.UnitOfWork
{
    public class ApplicationContext : DbContext
    {
        public DbSet<BaguetteModel> BaguetteModels { get; set; }
        public DbSet<MaterialModel> MaterialModels { get; set; }
        public DbSet<BaguetteMaterialModel> BaguetteMaterialModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Workshop;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
