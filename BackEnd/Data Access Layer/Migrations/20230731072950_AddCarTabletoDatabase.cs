using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Access_Layer.Migrations
{
    public partial class AddCarTabletoDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceperHour = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "252c85f6-5e23-4b0d-af17-99971c36c43b",
                column: "ConcurrencyStamp",
                value: "cde42539-35f4-47dd-beb8-d4422bb1e9a9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "381ddd37-7ec9-46e6-ad76-3ba06106f305",
                column: "ConcurrencyStamp",
                value: "4b0399e1-162f-48fb-a2f6-4423c9cb7dc4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11055be5-ff3b-4c19-8716-6cf364c91528",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cab9da9-da37-4376-b016-6dd4929b3453", "AQAAAAEAACcQAAAAECRgHWpg6HB5oxcqzYLCkzWLUCHwZpJAaWj6Z++YTA1JR078BXB0i011K0O9PkkkBA==", "af96bcd3-f1f5-4851-a318-ece9a68343a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aee5bb60-0f95-4414-b5ee-55dcf2a1f58d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "388b5216-a154-4d27-b110-9abb6fc197f3", "AQAAAAEAACcQAAAAECyEqZL0xuGIjQUTvt1zlPOI+AX65Aop8A51kFyl/k4o5Khv3l8dcGneXIYtS5HnlA==", "3497df96-f1ba-4fd2-be5b-4680fb76b37a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "252c85f6-5e23-4b0d-af17-99971c36c43b",
                column: "ConcurrencyStamp",
                value: "29bb307a-fbb2-43e0-8451-dbe3d3d2a8fe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "381ddd37-7ec9-46e6-ad76-3ba06106f305",
                column: "ConcurrencyStamp",
                value: "e2042cff-de20-44c5-9f71-ada5a5675609");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11055be5-ff3b-4c19-8716-6cf364c91528",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4efc5435-8889-4963-934f-4e565b95a4ae", "AQAAAAEAACcQAAAAEKBvaQlTTC4B3kNM2l2R9zk2a5MfY9rGMYUmfMAGaWgDPWL/JZ4fAi5eI7q3i8QXJw==", "168d8d61-a7b2-428f-bc65-ac6a645a9ff4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aee5bb60-0f95-4414-b5ee-55dcf2a1f58d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "625d7f0d-cf74-4ed5-9bec-68d2b742de8b", "AQAAAAEAACcQAAAAELQVL4CrUsLNTEM6sKmrQBCpCSwQzZ8zLzYDLN3vcusCBOmTwZ4v/aUdSTG9pdflSA==", "67261718-2709-411c-b148-2a170d0fc299" });
        }
    }
}
