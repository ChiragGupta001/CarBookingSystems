using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Access_Layer.Migrations
{
    public partial class AddBookCarTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCar_AspNetUsers_UserId",
                table: "BookCar");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCar_Cars_CarId",
                table: "BookCar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCar",
                table: "BookCar");

            migrationBuilder.RenameTable(
                name: "BookCar",
                newName: "BookCars");

            migrationBuilder.RenameIndex(
                name: "IX_BookCar_UserId",
                table: "BookCars",
                newName: "IX_BookCars_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BookCar_CarId",
                table: "BookCars",
                newName: "IX_BookCars_CarId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "BookCars",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<double>(
                name: "TotalRent",
                table: "BookCars",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCars",
                table: "BookCars",
                column: "BookCarId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "252c85f6-5e23-4b0d-af17-99971c36c43b",
                column: "ConcurrencyStamp",
                value: "79c69b71-f1f8-4bd5-922c-c7becdeb46b3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "381ddd37-7ec9-46e6-ad76-3ba06106f305",
                column: "ConcurrencyStamp",
                value: "6d7ae49d-dcb9-4235-b509-4f55d8694ccb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11055be5-ff3b-4c19-8716-6cf364c91528",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c213e924-f57e-4b10-94ad-c0247fce60ea", "AQAAAAEAACcQAAAAEHKU051yKtV2Iu7ZEZ3GbBwEFqar2NscxGcR9CPmDacgZaIAEzVpKBrqejZgVG9jFw==", "95c826ba-e1ba-47cf-8da0-244da051ce68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aee5bb60-0f95-4414-b5ee-55dcf2a1f58d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b2508f2-67a4-43a1-aa32-c0e1138a9597", "AQAAAAEAACcQAAAAEK4NqSNYzvkY0mFm7JrwWKt8lPsz3hoyiNY0H0pEfJOdZCVKJks0wwbwb1nyAMQbBg==", "80f1ee08-104f-4d27-b0f4-9741ea206412" });

            migrationBuilder.AddForeignKey(
                name: "FK_BookCars_AspNetUsers_UserId",
                table: "BookCars",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCars_Cars_CarId",
                table: "BookCars",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCars_AspNetUsers_UserId",
                table: "BookCars");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCars_Cars_CarId",
                table: "BookCars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCars",
                table: "BookCars");

            migrationBuilder.DropColumn(
                name: "TotalRent",
                table: "BookCars");

            migrationBuilder.RenameTable(
                name: "BookCars",
                newName: "BookCar");

            migrationBuilder.RenameIndex(
                name: "IX_BookCars_UserId",
                table: "BookCar",
                newName: "IX_BookCar_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BookCars_CarId",
                table: "BookCar",
                newName: "IX_BookCar_CarId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "BookCar",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCar",
                table: "BookCar",
                column: "BookCarId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "252c85f6-5e23-4b0d-af17-99971c36c43b",
                column: "ConcurrencyStamp",
                value: "36754c2c-1c5d-4c75-9d4b-7116ef82c833");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "381ddd37-7ec9-46e6-ad76-3ba06106f305",
                column: "ConcurrencyStamp",
                value: "b52dc9b8-01e4-4358-9cb4-b0404f5e8cbb");

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

            migrationBuilder.AddForeignKey(
                name: "FK_BookCar_AspNetUsers_UserId",
                table: "BookCar",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCar_Cars_CarId",
                table: "BookCar",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
