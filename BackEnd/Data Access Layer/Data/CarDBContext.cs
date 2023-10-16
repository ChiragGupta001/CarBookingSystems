using Data_Access_Layer.Configurations;
using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Data
{
    public class CarDBContext : IdentityDbContext<User>
    {
        public CarDBContext()
        {
        }

        public CarDBContext(DbContextOptions<CarDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<BookCar> BookCars { get; set; }

    }
}
