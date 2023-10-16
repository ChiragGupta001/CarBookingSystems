using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Access_Layer.Migrations
{
    public partial class UpdateCarTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cars",
                newName: "CarId");

            migrationBuilder.AddColumn<bool>(
                name: "IsBook",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "BookCar",
                columns: table => new
                {
                    BookCarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    To = table.Column<DateTime>(type: "datetime2", nullable: false),
                    From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCar", x => x.BookCarId);
                    table.ForeignKey(
                        name: "FK_BookCar_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCar_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "252c85f6-5e23-4b0d-af17-99971c36c43b",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "36754c2c-1c5d-4c75-9d4b-7116ef82c833", "User" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "381ddd37-7ec9-46e6-ad76-3ba06106f305",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "b52dc9b8-01e4-4358-9cb4-b0404f5e8cbb", "Admin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11055be5-ff3b-4c19-8716-6cf364c91528",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f7501ce-019a-4b8d-aedb-d43538cde1f1", "AQAAAAEAACcQAAAAEFIZCZlzvmiWjT0dDqzVlgW2T+Km/x2HbWMS/1GNw6HEe7LWGeV6NpTgSt+DEzbsNg==", "43cc3f7f-8aa2-4d9e-ba86-543ab410e93c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aee5bb60-0f95-4414-b5ee-55dcf2a1f58d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "748b5f9c-dd27-4a1d-93ca-1db0da600890", "AQAAAAEAACcQAAAAEPMvcRFXHFRBPoA5zSXJv2insLWMrzgbL9zpiLgFDN0WUbbNZD+XDygsgmQWV3mN5g==", "53ee9831-5872-4d30-9f37-7cdd574296e8" });

            migrationBuilder.CreateIndex(
                name: "IX_BookCar_CarId",
                table: "BookCar",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCar_UserId",
                table: "BookCar",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCar");

            migrationBuilder.DropColumn(
                name: "IsBook",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "Cars",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "252c85f6-5e23-4b0d-af17-99971c36c43b",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "cde42539-35f4-47dd-beb8-d4422bb1e9a9", "user" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "381ddd37-7ec9-46e6-ad76-3ba06106f305",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "4b0399e1-162f-48fb-a2f6-4423c9cb7dc4", "admin" });

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
    }
}
