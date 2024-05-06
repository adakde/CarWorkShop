using Microsoft.EntityFrameworkCore;
using Projekt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Infrastructure.CarWorkShopDB
{
    public class CarWorkShopDBContext : DbContext
    {
        public CarWorkShopDBContext(DbContextOptions<CarWorkShopDBContext> options) : base(options)
        {
            
        }
        public DbSet<CarWorkShop> CarWorkShops { get; set; }

/*        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CarWorkShopDb;Trusted_Connection=True;");
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarWorkShop>()
                .OwnsOne(c => c.ContactDetails);
        }
    }
}