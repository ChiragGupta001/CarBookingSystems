using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Access_Layer.Migrations
{
    public partial class AddRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "252c85f6-5e23-4b0d-af17-99971c36c43b", "9f45a717-c26a-4f6c-afac-43cb63ed9692", "user", "USER" },
                    { "381ddd37-7ec9-46e6-ad76-3ba06106f305", "581e0369-b5a1-4323-a3ff-56b3acf22e9d", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Profile", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "11055be5-ff3b-4c19-8716-6cf364c91528", 0, "fa08b170-7f61-49a0-a097-38d5a04d4bd4", "Admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN", "Admin@123", "AQAAAAEAACcQAAAAEJhOo2xyLjf+SlaxA6zzvd6ypoDmgC0/REOwGYFZTx3fmIaf+cVXxL2b7V5GI+X99A==", "9632587415", true, "", "f7af6a8f-4064-4d64-bdb5-9cfe9285e0a4", false, "Admin" },
                    { "aee5bb60-0f95-4414-b5ee-55dcf2a1f58d", 0, "75e1f4f0-8f65-412e-ab7c-1c7eac0d0c08", "User@gmail.com", true, false, null, "USER@GMAIL.COM", "USER", "User@123", "AQAAAAEAACcQAAAAEJhqrI0lGiT9vNDSXm/WDoBM6pGfxwO5/MwVX2uWDi3f9Hfp8P6iiANj9zd8IGtryw==", "9632586547", true, "", "51ffc052-ad8f-42b8-955f-d8b2fd902cfe", false, "User" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "381ddd37-7ec9-46e6-ad76-3ba06106f305", "11055be5-ff3b-4c19-8716-6cf364c91528" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "252c85f6-5e23-4b0d-af17-99971c36c43b", "aee5bb60-0f95-4414-b5ee-55dcf2a1f58d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "381ddd37-7ec9-46e6-ad76-3ba06106f305", "11055be5-ff3b-4c19-8716-6cf364c91528" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "252c85f6-5e23-4b0d-af17-99971c36c43b", "aee5bb60-0f95-4414-b5ee-55dcf2a1f58d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "252c85f6-5e23-4b0d-af17-99971c36c43b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "381ddd37-7ec9-46e6-ad76-3ba06106f305");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11055be5-ff3b-4c19-8716-6cf364c91528");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aee5bb60-0f95-4414-b5ee-55dcf2a1f58d");
        }
    }
}
