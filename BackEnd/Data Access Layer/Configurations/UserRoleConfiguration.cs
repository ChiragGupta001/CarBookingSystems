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
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
               new IdentityUserRole<string>
               {
                   UserId = "11055be5-ff3b-4c19-8716-6cf364c91528",
                   RoleId = "381ddd37-7ec9-46e6-ad76-3ba06106f305"
               },
               new IdentityUserRole<string>
               {
                   UserId = "aee5bb60-0f95-4414-b5ee-55dcf2a1f58d",
                   RoleId = "252c85f6-5e23-4b0d-af17-99971c36c43b"
               });
        }
    }
}