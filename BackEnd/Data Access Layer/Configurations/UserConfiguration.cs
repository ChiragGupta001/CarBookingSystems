using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
            new User()
            {
                Id = "11055be5-ff3b-4c19-8716-6cf364c91528",
                Name = "Admin",
                UserName = "Admin",
                Email = "Admin@gmail.com",
                Password = "Admin@123",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Admin@123"),
                EmailConfirmed = true,
                PhoneNumber= "9632587415",
                PhoneNumberConfirmed = true,
                NormalizedUserName = "ADMIN",
                NormalizedEmail="ADMIN@GMAIL.COM",
                Profile=""
            },
            new User()
            {
                Id = "aee5bb60-0f95-4414-b5ee-55dcf2a1f58d",
                Name = "User",
                UserName = "User",
                Email = "User@gmail.com",
                Password = "User@123",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "User@123"),
                EmailConfirmed = true,
                PhoneNumber = "9632586547",
                PhoneNumberConfirmed = true,
                NormalizedUserName = "USER",
                NormalizedEmail = "USER@GMAIL.COM",
                Profile = ""
            });
        }
    }
}
