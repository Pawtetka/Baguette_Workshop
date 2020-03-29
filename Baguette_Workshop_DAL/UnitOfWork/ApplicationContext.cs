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
        /*public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }*/
        public DbSet<BaguetteModel> BaguetteModels { get; set; }
        public DbSet<MaterialModel> MaterialModels { get; set; }
        public DbSet<BaguetteMaterialModel> BaguetteMaterialModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=(localdb)\MSSQLLocalDB;Initial catalog=Workshop;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
